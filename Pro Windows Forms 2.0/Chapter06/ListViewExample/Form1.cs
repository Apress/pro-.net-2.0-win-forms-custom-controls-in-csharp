using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewExample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdFillList_Click(object sender, EventArgs e)
		{
			FillList();
		}

		private void FillList()
		{
			listView.Items.Clear();

			// Create groups if needed. They only
			// appear is ShowGroups is true.
			if (listView.Groups.Count == 0)
			{
				DataTable dtGroups = StoreDB.GetCategories();
				foreach (DataRow dr in dtGroups.Rows)
				{
					listView.Groups.Add(dr["CategoryID"].ToString(),
						dr["CategoryName"].ToString());
				}
			}
			// Turn groups on or off.
			listView.ShowGroups = chkGroups.Checked;

			DataTable dtProducts = StoreDB.GetProducts();

			// Suspending automatic refreshes as items are added/removed.
			listView.BeginUpdate();

			listView.SmallImageList = imagesSmall;
			listView.LargeImageList = imagesLarge;
			foreach (DataRow dr in dtProducts.Rows)
			{
				ListViewItem listItem = new ListViewItem(dr["ModelName"].ToString());
				listItem.ImageIndex = 0;

				// Put it in the appropriate group.
				// (Only has an effect if ShowGroups is true.)
				listItem.Group = listView.Groups[dr["CategoryID"].ToString()];

				// Add sub-items for Details view.
				listItem.SubItems.Add(dr["ProductID"].ToString());
				listItem.SubItems.Add(dr["Description"].ToString());

				listView.Items.Add(listItem);
			}

			// Add column headers for Details view
			// if they haven't been added before.
			if (listView.Columns.Count == 0)
			{
				listView.Columns.Add("Product", 100, HorizontalAlignment.Left);
				listView.Columns.Add("ID", 100, HorizontalAlignment.Left);
				listView.Columns.Add("Description", 100, HorizontalAlignment.Left);
			}

			// Re-enable the display.
			listView.EndUpdate();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listView.View = View.Tile;
			listView.TileSize = new Size(300, 50);
			optLargeIcon.Tag = View.LargeIcon;
			optSmallIcon.Tag = View.SmallIcon;
			optDetails.Tag = View.Details;
			optList.Tag = View.List;
			optTile.Tag = View.Tile;
			FillList();
		}

		private void NewView(object sender, System.EventArgs e)
		{
			// Set the current view mode based on the number in the tag value of the
			// selected radio button.

			listView.View = (View)(((Control)sender).Tag);

			// Display the current view style.
			this.Text = "Using View: " + listView.View.ToString();
		}

		private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			// Check the current sort.
			ListViewItemComparer sorter = listView.ListViewItemSorter as ListViewItemComparer;

			// Specify an alphabetic sort based on the column that was clicked.
			if (sorter == null)
			{
				sorter = new ListViewItemComparer(e.Column);
				listView.ListViewItemSorter = sorter;
			}
			else
			{
				if (sorter.Column == e.Column && !sorter.Descending)
				{
					// The list is already sorted on this column.
					// Time to flip the sort.
					sorter.Descending = true;
					// Keep the ListView.Sorting property 
					// synchronized, just for tidiness.
					listView.Sorting = SortOrder.Descending;				
				}
				else
				{
					listView.Sorting = SortOrder.Ascending;
					sorter.Descending = false;
					sorter.Column = e.Column;
				}
			}	
			
			// Perform the sort.
			listView.Sort();
		}

		private void cmdResizeColumns_Click(object sender, EventArgs e)
		{
			listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}


		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView.SelectedItems.Count > 0)
				txtSelected.Text = listView.SelectedItems[0].SubItems[2].Text;
		}

		private void chkGroups_CheckedChanged(object sender, EventArgs e)
		{
			FillList();
		}

		
	}
}