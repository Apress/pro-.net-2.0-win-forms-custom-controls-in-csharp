using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultithreadingWorker
{
	public delegate void ReportWorkerProgressEventHandler(object sender, ReportWorkerProgressEventArgs e);
	public delegate void WorkerCompletedEventHandler(object sender, WorkerCompletedEventArgs e);

	// Inherit from component for design-time use.
	public class TaskManager : System.ComponentModel.Component
	{
		private int maxThreads = 2;
		public int MaxThreads
		{
			get { return maxThreads; }
			set { maxThreads = value; }
		}

		// Track ongoing workers.
		List<ThreadWrapperBase> workers = new List<ThreadWrapperBase>();

		// Track queued requests.
		List<ThreadWrapperBase> workersQueued = new List<ThreadWrapperBase>();

		// Task completed requests.
		List<ThreadWrapperBase> workersCompleted = new List<ThreadWrapperBase>();

		public ThreadWrapperBase[] CompletedTasks
		{
			get
			{
				// To avoid synchronization issues, make a copy of this
				// information.
				ThreadWrapperBase[] taskArray;
				lock (workersCompleted)
				{
					taskArray = new ThreadWrapperBase[workersCompleted.Count];
					workersCompleted.CopyTo(taskArray);
				}
				return taskArray;
			}
		}

		public void EnqueueTask(ThreadWrapperBase task)
		{
			lock (workersQueued)
			{
				workersQueued.Add(task);
			}
		}



		private Thread allocateWork;
		private bool working = false;
		private Control invokeContext;
		public void StartAllocatingWork(Control invokeContext)
		{
			if (working == false)
			{
				this.invokeContext = invokeContext;
				allocateWork = new Thread(new ThreadStart(AllocateWork));
				allocateWork.IsBackground = true;
				//allocateWork.Priority = ThreadPriority.BelowNormal;
				working = true;
				allocateWork.Start();
			}

		}

		public event ReportWorkerProgressEventHandler ReportWorkerProgress;
		private void OnReportWorkerProgress(object sender, ReportWorkerProgressEventArgs e)
		{
			if (ReportWorkerProgress != null)
				ReportWorkerProgress(sender, e);
		}

		public event WorkerCompletedEventHandler WorkerCompleted;
		private void OnWorkerCompleted(object sender, WorkerCompletedEventArgs e)
		{
			if (WorkerCompleted != null)
				WorkerCompleted(sender, e);
		}

		private void AllocateWork()
		{
			while (true)
			{
				// Remove completed tasks.
				// Because we are not using foreach, the collection
				// doesn't need to be locked. It could grow while this
				// method is working, but that would only result in a
				// slot being missed until the next pass, which is acceptable.
				// It can't shrink, because no other methods remove work.
				// We count in reverse order so a single pass can 
				// remove multiple entries without rearranging the items
				// that haven't been scanned.
				// Deferring the locking improves performance.
                 for (int i = workers.Count-1; i >= 0; i--)
				 {
					 if (workers[i].Status == StatusState.Completed)
					 {
						 ThreadWrapperBase worker = workers[i];
						 lock (workersCompleted)
						 {
							 workersCompleted.Add(worker);
						 }
						 lock (workers)
						 {
							 workers.Remove(worker);
						 }
						 // Fire notification event.
						 invokeContext.Invoke(new WorkerCompletedEventHandler(OnWorkerCompleted),
							 new object[] { this, new WorkerCompletedEventArgs((EratosthenesTask)worker)});
					 }
				 }

				// Allocate new work while threads are available.
				while (workersQueued.Count > 0 && 
					workers.Count < maxThreads)
				{
					ThreadWrapperBase task = workersQueued[0];

					// Some exception handling code here would be useful
					// to prevent performing one part of this sequence
					// (starting the task), without the other (removing it
					// from the queue).
					lock (workers)
					{
						workers.Add(task);
					}
					lock (workersQueued)
					{
						workersQueued.RemoveAt(0);
					}
					task.Start();			
				}

				// Report progress.
				for (int i = workers.Count - 1; i >= 0; i--)
				{
					ThreadWrapperBase worker = workers[i];
					if (worker.Status == StatusState.InProgress)
					{
						// Fire notification event.
                        if (invokeContext.Created)
                        {
                            invokeContext.Invoke(new ReportWorkerProgressEventHandler(OnReportWorkerProgress),
                                new object[]{this, 
								new ReportWorkerProgressEventArgs(worker.ID, worker.Progress)});
                        }
					}
				}

				// Pause 2 seconds before the next pass.
				// You could make this variable configurable.
				Thread.Sleep(TimeSpan.FromSeconds(2));
			}
		}

		
		public void StopAllTasks()
		{
			// Stop the work allocator.
			allocateWork.Abort();
			// Make sure it's finished.
			allocateWork.Join();

			// Stop the tasks.
			foreach (ThreadWrapperBase worker in workers)
			{
				worker.StopTask();
			}
		}
	}


	public class ReportWorkerProgressEventArgs : EventArgs
	{
		private int progress;
		public int Progress
		{
			get { return progress; }
			set { progress = value; }
		}
		private Guid taskID;
		public Guid TaskID
		{
			get { return taskID; }
			set { taskID = value; }
		}

		public ReportWorkerProgressEventArgs(Guid taskID, int progress)
		{
			Progress = progress;
			TaskID = taskID;
		}
	}


	public class WorkerCompletedEventArgs : EventArgs
	{
		private string primeList;
			public string PrimeList
			{
				get { return primeList; }
				set { primeList = value; }
			}

			private Guid id;
			public Guid ID
			{
				get { return id; }
				set { id = value; }
			}
			public WorkerCompletedEventArgs(EratosthenesTask task)
			{
				PrimeList = task.GetResultOfLastTask();
				id = task.ID;
			}
		
	
	}
}
