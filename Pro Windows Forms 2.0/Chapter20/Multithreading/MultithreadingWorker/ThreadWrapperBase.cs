#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
#endregion

namespace MultithreadingWorker
{
    public enum StatusState
	{
		Unstarted, InProgress, Completed
	}

	public abstract class ThreadWrapperBase
	{
		// This is the thread where the task is carried out.
		private Thread thread;

		// Track the status of the task.
		private StatusState status = StatusState.Unstarted;
		public StatusState Status
		{
			get { return status; }
		}

		// Use a unique ID to track the task later, if needed.
		private Guid id = Guid.NewGuid();
		public Guid ID
		{
			get { return id; }
		}

		// Start the new operation.
		public void Start()
		{
			if (status == StatusState.InProgress)
			{
				throw new InvalidOperationException("Already in progress.");
			}
			else
			{
				// Initialize the new task.
				status = StatusState.InProgress;

				// Create the thread and run it in the background,
				// so it will terminate automatically if the application ends.
				thread = new Thread(StartTaskAsync);
				thread.IsBackground = true;

				// Start the thread.
				thread.Start();
			}
		}

		private void StartTaskAsync()
		{
			DoTask();
			status = StatusState.Completed;
			OnCompleted();
		}

		// Override this class to supply the task logic.
		protected abstract void DoTask();

		// Override this class to supply the callback logic.
		protected abstract void OnCompleted();

		// Flag that indicates a stop is requested.
		private bool requestCancel = false;
		protected bool RequestCancel
		{
			get { return requestCancel; }
		}

		// How long the thread will wait (in total)
		// before aborting a thread that hasn't responded to
		// the cancellation message.
		// TimeSpan.Zero means polite stops are not enabled.
		private TimeSpan cancelWaitTime = TimeSpan.Zero;
		protected TimeSpan CancelWaitTime
		{
			get { return cancelWaitTime; }
			set { cancelWaitTime = value; }
		}

		// How often the thread checks to see if a cancellation
		// message has been heeded.
		private int cancelCheckInterval = 5;
		protected int CancelCheckInterval
		{
			get { return cancelCheckInterval; }
			set { cancelCheckInterval = value; }
		}

		public void StopTask()
		{
			// Perform no operation if task isn't running.
			if (status != StatusState.InProgress) return;

			// Try the polite approach.
			if (cancelWaitTime != TimeSpan.Zero)
			{
				DateTime startTime = DateTime.Now;
				while (DateTime.Now.Subtract(startTime).TotalSeconds > 0)
				{
					// Still waiting for the time limit to pass.
					// Allow other threads to do some work.
					Thread.Sleep(TimeSpan.FromSeconds(cancelCheckInterval));
				}
			}

			// Use the forced approach.
			thread.Abort();
		}

		// Add Pause and Resume methods here.

		private bool supportsProgress = false;
		protected bool SupportsProgress
		{
			get { return supportsProgress; }
			set { supportsProgress = value; }
		}

		protected int progress;
		public int Progress
		{
			get
			{
				if (!supportsProgress)
					throw new InvalidOperationException("This worker does not report progess.");
				else
					return progress;
			}
		}
	}
			
}
