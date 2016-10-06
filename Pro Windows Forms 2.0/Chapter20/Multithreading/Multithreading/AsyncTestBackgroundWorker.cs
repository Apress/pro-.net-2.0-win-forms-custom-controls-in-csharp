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
    partial class AsyncTestBackgroundWorker : Form
    {
        public AsyncTestBackgroundWorker()
        {
            InitializeComponent();
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
            FindPrimesInput input = new FindPrimesInput(from, to);
            backgroundWorker.RunWorkerAsync(input);
        }

        private void statusStrip1_DoubleClick(object sender, EventArgs e)
        {
            if (statusPanel.Text != "")
            {
                txtResults.Text = primeList;
                primeList = "";
                statusPanel.Text = "";
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the input values.
            FindPrimesInput input = (FindPrimesInput)e.Argument;

            // Start the search for primes and wait.
            int[] primes = MultithreadingWorker.Worker.FindPrimes(input.From, input.To, backgroundWorker);

            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            // Paste the list of primes together into one long string.
            StringBuilder sb = new StringBuilder();
            foreach (int prime in primes)
            {
                sb.Append(prime.ToString());
                sb.Append("  ");
            }

            // Return the result.
            e.Result = sb.ToString();
        }

        string primeList;
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            primeList = "";
            statusPanel.Text = "";

            if (e.Cancelled)
            {
                MessageBox.Show("Search cancelled.");
            }
            else if (e.Error != null)
            {
                // An error was thrown by the DoWork event handler.
                MessageBox.Show(e.Error.Message, "An Error Occurred");
            }
            else
            {
                primeList = (string)e.Result;
                statusPanel.Text = "Double-click panel to see new prime list.";
            }
            cmdFind.Enabled = true;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressPanel.Value = e.ProgressPercentage;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

    }

    public class FindPrimesInput
    {
        private int to;
        public int To
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        }

        private int from;
        public int From
        {
            get
            {
                return from;
            }
            set
            {
                from = value;
            }
        }

        public FindPrimesInput(int from, int to)
        {
            To = to;
            From = from;
        }

    }
}