using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeViewDataBinding
{
	public partial class TreeViewForm : Form
	{
		public TreeViewForm()
		{
			InitializeComponent();
		}

		private void TreeViewForm_Load(object sender, EventArgs e)
		{
			TreeNode nodeParent;
			foreach (DataRow row in Program.StoreDB.GetCategories().Rows)
			{
				// Add the category node.
				nodeParent =
				  treeDB.Nodes.Add(row[StoreDB.CategoryField.Name].ToString());
				nodeParent.ImageIndex = 0;

				// Store the disconnected category information.
				nodeParent.Tag = row;

				// Add a "dummy" node.
				nodeParent.Nodes.Add("*");
			}

		}

		private void treeDB_AfterSelect(object sender, TreeViewEventArgs e)
		{
			lblInfo.Text = Program.StoreDB.GetDisplayText((DataRow)e.Node.Tag);
		}

		private void treeDB_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			TreeNode nodeSelected, nodeChild;
			nodeSelected = e.Node;

			if (nodeSelected.Nodes[0].Text == "*")
			{
				// This is a dummy node.
				nodeSelected.Nodes.Clear();

				foreach (DataRow row in
					Program.StoreDB.GetProductsInCategory((DataRow)nodeSelected.Tag))
				{
					string field = row[StoreDB.ProductField.Name].ToString();
					nodeChild = nodeSelected.Nodes.Add(field);

					// Store the disconnected product information.
					nodeChild.Tag = row;
					nodeChild.ImageIndex = 1;
					nodeChild.SelectedImageIndex = 1;
				}
			}
		}
	}
}