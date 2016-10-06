using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewVirtualization
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            dataGridView1.Columns.Clear();
			dataGridView1.RowCount = NorthwindDB.GetOrdersCount();
            
			// Suspending automatic refreshes as items are added/removed.
            dataGridView1.SuspendLayout();

			// Add column headers for Details view.
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns.Add("ShippedDate", "ShippedDate");
            dataGridView1.Columns[1].Width = 125;
            			
			// Re-enable the display.
			dataGridView1.ResumeLayout();
		}

		private DataTable dtCachedItems;
		
        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            // Check if the item is in the local cache.
            DataRow match = null;           
            if (dtCachedItems != null)
                match = dtCachedItems.Rows.Find(e.RowIndex + 1);

            if (match == null)
            {
                // The item isn't in memory.
                // Get a new range of 100 records.
                int from, to;
                if (e.RowIndex < 50)
                    from = 0;
                else
                    from = (e.RowIndex - 50);

                to = from + 100;
                dtCachedItems = NorthwindDB.GetOrders(from, to);

                // Don't use the MessageBox to show this information.
                // Hiding any part of the ListView can retrigger this event.
                lblStatus.Text = String.Format(
                    "Fetched rows from {0} to {1} at {2}.",
                    from.ToString(), to.ToString(),
                    DateTime.Now.ToLongTimeString());

                match = dtCachedItems.Rows.Find(e.RowIndex + 1);
            }

            switch (e.ColumnIndex)
            {
                case 0:
                    e.Value = match["OrderID"];
                    break;
                case 1:
                    e.Value = match["ShippedDate"];
                    break;
            }           

        }

	}
}