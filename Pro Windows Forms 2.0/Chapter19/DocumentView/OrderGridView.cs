using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
	public partial class OrderGridView : UserControl
	{
		public OrderGridView()
		{
			InitializeComponent();
		}

		private Order document;
		public Order Document
		{
			set
			{
				// Store a reference to the document, attach the event handler,
				// and refresh the display.
				document = value;
				document.DocumentChanged += new EventHandler(RefreshList);
				RefreshList();
			}
			get { return document; }
		}


		public OrderGridView(Order document)
			: this()
		{
			// Store a reference to the document, attach the event handler,
			// and refresh the display.
			Document = document;
		}

		private void RefreshList(object sender, System.EventArgs e)
		{
			RefreshList();
		}

		private void RefreshList()
		{
			// Update the ListView control with the new document contents.
			if (list != null)
			{
				// For best performance, disable refreshes while updating the list.
				list.SuspendLayout();

				list.Items.Clear();

				// Step through the list of items in the document.
				Product itemProduct;
				ListViewItem itemDisplay;
				foreach (OrderItem item in this.Document)
				{
					itemDisplay = list.Items.Add(item.ID.ToString());
					itemProduct = PriceList.GetItem(item.ID);
					itemDisplay.SubItems.Add(itemProduct.Name);
					itemDisplay.SubItems.Add(itemProduct.Price.ToString());
					itemDisplay.SubItems.Add(itemProduct.Description);
				}

				list.ResumeLayout();
			}
		}

		// Triggered when the Add button is clicked.
		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			// Add a random item.
			Random randomItem = new Random();
			Document.Add(new OrderItem(randomItem.Next(1, 4)));
		}

		// Triggered when the Remove button is clicked.
		private void cmdRemove_Click(object sender, System.EventArgs e)
		{
			// Remove the current item.
			// The ListView Is configured for single-selection only.
			if (list.SelectedIndices.Count == 1)
			Document.Remove(list.SelectedIndices[0]);
		}
	}
}
