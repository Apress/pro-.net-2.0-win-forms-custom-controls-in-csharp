#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

#endregion

namespace MultithreadingClient
{
    partial class AsyncTestLocking : Form
    {
        public AsyncTestLocking()
        {
            InitializeComponent();
        }

        private delegate void CallAsyncWorkerDelegate(int from, int to);


        // Shared data.
        string primeList = "";

        private void CallAsyncWorker(int from, int to)
        {
            try
            {
                // Start the search for primes and wait.
                int[] primes = MultithreadingWorker.Worker.FindPrimes(from, to);

                // Paste the list of primes together into one long string.
                StringBuilder sb = new StringBuilder();
                foreach (int prime in primes)
                {
                    sb.Append(prime.ToString());
                    sb.Append("  ");
                }

                // Store the list of primes for later use.
                lock (primeList)
                {
                    primeList = sb.ToString();
                }

                // Indicate that the prime list is available.
                this.Invoke(new MethodInvoker(NotifyComplete));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

		private bool dataAvailable = false;
        private void NotifyComplete()
        {
			dataAvailable = true;
            statusPanel.Text = "Double-click panel to see new prime list.";
            cmdFind.Enabled = true;
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            // Disable the button.
            cmdFind.Enabled = false;

            
            statusPanel.Text = "";

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

            // Start the search for primes on another thread.
            CallAsyncWorkerDelegate doWork = new CallAsyncWorkerDelegate(CallAsyncWorker);
            doWork.BeginInvoke(from, to, null, null);
        }

        private void statusStrip1_DoubleClick(object sender, EventArgs e)
        {
            if (dataAvailable)
            {
                txtResults.Text = primeList;
                primeList = "";
                statusPanel.Text = "";
				dataAvailable = false;
            }
        }

    }
}