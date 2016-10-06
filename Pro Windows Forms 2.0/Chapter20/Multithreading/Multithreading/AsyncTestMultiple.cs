#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MultithreadingWorker;

#endregion

namespace MultithreadingClient
{
    partial class AsyncTestMultiple : Form
    {
        public AsyncTestMultiple()
        {
            InitializeComponent();
        }


        // Track ongoing threads.
        List<EratosthenesTask> workers = new List<EratosthenesTask>();
        
        private void cmdNewSearch_Click(object sender, EventArgs e)
        {
            AsyncTestQuery search = new AsyncTestQuery();
            if (search.ShowDialog() == DialogResult.OK)
            {
                // Start the new search.
				EratosthenesTask worker = new EratosthenesTask(search.From, search.To);
				worker.Completed += new FindPrimesCompletedEventHandler(WorkerCompleted);
                lock (workers)
                {
                    workers.Add(worker);
                    statusPanel.Text = String.Format("Currently running {0} tasks.", workers.Count);
                }
                worker.Start();
            }
            search.Dispose();
        }

        private void WorkerCompleted(object sender, FindPrimesCompletedEventArgs e)
        {
            // Stop tracking the worker.
            lock (workers)
            {
                workers.Remove((EratosthenesTask)sender);
            }

            // Show the results (on the user interface thread).
            this.Invoke(new FindPrimesCompletedEventHandler(ShowResults),
                new object[] {sender, e} );           
        }

 		private void ShowResults(object sender, FindPrimesCompletedEventArgs e)
        {
            AsyncTestResult result = new AsyncTestResult();
			result.Text = String.Format("Primes From {0} To {1}",
				new object[] { e.From, e.To });
            result.ShowList(e.PrimeList);
            result.MdiParent = this;
            result.Show();

            lock (workers)
            {
                statusPanel.Text = String.Format("Currently running {0} tasks.", workers.Count);
            }
        }

        private void AsyncTestMultiple_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This would be a good place to loop through the workes and
            // terminate each one.
            // As it stands, they are background threads, so they will
            // be aborted by the CLR when the application ends.
        }

    }
}