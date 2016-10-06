using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MultithreadingWorker;

namespace MultithreadingClient
{
	public partial class TaskManagerClient : Form
	{
		public TaskManagerClient()
		{
			InitializeComponent();
		}

		private void taskManager_ReportWorkerProgress(object sender, MultithreadingWorker.ReportWorkerProgressEventArgs e)
		{
			// Find the matching item.
			foreach (ListViewItem item in listTasks.Items)
			{
				if (item.Text == e.TaskID.ToString())
				{
					item.SubItems[2].Text = e.Progress.ToString() + "% completed";
					break;
				}
			}
		}

		private void taskManager_WorkerCompleted(object sender, MultithreadingWorker.WorkerCompletedEventArgs e)
		{
			// Find the matching item.
			foreach (ListViewItem item in listTasks.Items)
			{
				if (item.Text == e.ID.ToString())
				{
					item.SubItems[2].Text = "Completed";

					// Store the results for later use.
					// Could use a custom ListView here, but the
					// Tag is a messier shortcut.
					item.Tag = e.PrimeList;
					break;
				}
			}
		}

		private void cmdFind_Click(object sender, EventArgs e)
		{
			// Get the search range.
			int from, to;
            if (!Int32.TryParse(txtFrom.Text, out from))
            {
                MessageBox.Show("Invalid From value.");
                return;
            }
            if (!Int32.TryParse(txtTo.Text, out to))
            {
                MessageBox.Show("Invalid To value.");
                return;
            }

			// Create the task.
			EratosthenesTask task = new EratosthenesTask(from, to);

			// Add the task to the grid.
			ListViewItem item = new ListViewItem(task.ID.ToString());
			item.SubItems.Add(from.ToString() + " to " + to.ToString());
			item.SubItems.Add("Queued");
			listTasks.Items.Add(item);

			// Enqueue the task.
			taskManager.EnqueueTask(task);
		}

		private void TaskManagerClient_Load(object sender, EventArgs e)
		{
			taskManager.StartAllocatingWork(this);
		}

        private void listTasks_DoubleClick(object sender, EventArgs e)
        {
            // Check for item click.
            if (listTasks.SelectedItems[0] != null)
            {
                // Check item is completed.
                if (listTasks.SelectedItems[0].Tag != null)
                {
                    AsyncTestResult result = new AsyncTestResult();
                    result.ShowList((string)listTasks.SelectedItems[0].Tag);
                    result.ShowDialog();
                    result.Dispose();
                }
            }
            
        }
	}
}