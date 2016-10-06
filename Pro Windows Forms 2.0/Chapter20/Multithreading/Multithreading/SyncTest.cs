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
    partial class SyncTest : Form
    {
        public SyncTest()
        {
            InitializeComponent();
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;

            txtResults.Text = "";
            lblTimeTaken.Text = "";

            try
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

                // Start the search for primes and wait.
                DateTime startTime = DateTime.Now;
                int[] primes = MultithreadingWorker.Worker.FindPrimes(from, to);

                // Display the time for the call to complete.
                lblTimeTaken.Text = DateTime.Now.Subtract(startTime).TotalSeconds.ToString();


                // Paste the list of primes together into one long string.
                StringBuilder sb = new StringBuilder();
                foreach (int prime in primes)
                {
                    sb.Append(prime.ToString());
                    sb.Append("  ");
                }
                txtResults.Text = sb.ToString();
            }
            catch (Exception err)
            {
                 MessageBox.Show(err.Message);
            }

            this.UseWaitCursor = false;
         }


    }
}