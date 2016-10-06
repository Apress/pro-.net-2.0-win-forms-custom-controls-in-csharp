using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewVirtualization
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listView.View = View.Details;
			listView.VirtualMode = true;
			listView.VirtualListSize = NorthwindDB.GetOrdersCount();

			// Suspending automatic refreshes as items are added/removed.
			listView.BeginUpdate();

			listView.SmallImageList = imagesSmall;
			listView.LargeImageList = imagesLarge;

			// Add column headers for Details view.
			listView.Columns.Add("ID", 100, HorizontalAlignment.Left);
			listView.Columns.Add("ShippedDate", 100, HorizontalAlignment.Left);

			// Re-enable the display.
			listView.EndUpdate();
		}

		private DataTable dtCachedItems;
		private void listView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			// Check if the item is in the local cache.
			DataRow match = null;
			if (dtCachedItems != null)
				match = dtCachedItems.Rows.Find(e.ItemIndex + 1);

			if (match == null)
			{
				// The item isn't in memory.
				// Get a new range of 100 records.
				int from, to;
				if (e.ItemIndex < 50)
					from = 0;
				else
					from = (e.ItemIndex - 50);

				to = from + 100;
				dtCachedItems = NorthwindDB.GetOrders(from, to);

				// Don't use the MessageBox to show this information.
				// Hiding any part of the ListView can retrigger this event.
				lblStatus.Text = String.Format(
					"Fetched rows from {0} to {1}.",
					from.ToString(), to.ToString());

				match = dtCachedItems.Rows.Find(e.ItemIndex + 1);
			}

			// Create the ListViewItem for the matching record.
			e.Item = new ListViewItem(match["OrderID"].ToString());
			e.Item.SubItems.Add(match["ShippedDate"].ToString());
		}

	}
}