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
    partial class AsyncTest : Form
    {
        public AsyncTest()
        {
            InitializeComponent();
        }

        private delegate void CallAsyncWorkerDelegate(int from, int to);

        private void CallAsyncWorker(int from, int to)
        {
            try
            {
                // Start the search for primes and wait.
                DateTime startTime = DateTime.Now;
                int[] primes = MultithreadingWorker.Worker.FindPrimes(from, to);

                // Calculate the time for the call to complete.
                TimeSpan timeTaken = DateTime.Now.Subtract(startTime);

                // Paste the list of primes together into one long string.
                StringBuilder sb = new StringBuilder();
                foreach (int prime in primes)
                {
                    sb.Append(prime.ToString());
                    sb.Append("  ");
                }

                // Use the Control.Invoke() method of the current form,
                // which is on the same thread as the rest of the controls.
                this.Invoke(new UpdateFormDelegate(UpdateForm), 
                  new object[] {timeTaken, sb.ToString()} );

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private delegate void UpdateFormDelegate(TimeSpan timeTaken, string primeList);
        private void UpdateForm(TimeSpan timeTaken, string primeList)
        {
            lblTimeTaken.Text = timeTaken.TotalSeconds.ToString();
            txtResults.Text = primeList;

            cmdFind.Enabled = true;
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            // Disable the button.
            cmdFind.Enabled = false;

            txtResults.Text = "";
            lblTimeTaken.Text = "";

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

    }
}