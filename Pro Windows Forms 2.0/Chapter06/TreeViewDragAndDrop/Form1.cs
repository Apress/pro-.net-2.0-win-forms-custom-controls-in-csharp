using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeViewDragAndDrop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			TreeNode node = treeOne.Nodes.Add("Fruits");
			node.Nodes.Add("Apple");
			node.Nodes.Add("Peach");
			node.Expand();

			node = treeTwo.Nodes.Add("Vegetables");
			node.Nodes.Add("Tomato");
			node.Nodes.Add("Eggplant");
			node.Expand();

			treeTwo.AllowDrop = true;
			treeOne.AllowDrop = true;
		}

		private void tree_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Get the tree.
			TreeView tree = (TreeView)sender;

			// Get the node underneath the mouse.
			TreeNode node = tree.GetNodeAt(e.X, e.Y);
			tree.SelectedNode = node;

			// Start the drag-and-drop operation with the node.
			if (node != null)
			{
				tree.DoDragDrop(node, DragDropEffects.Copy);
			}
		}
		private void tree_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// Get the tree.
			TreeView tree = (TreeView)sender;

			// Drag and drop denied by default.
			e.Effect = DragDropEffects.None;

			TreeNode nodeSource = (TreeNode)e.Data.GetData(typeof(TreeNode));

			// Make sure it's a valid format?
			if (nodeSource != null)
			{
				// Make sure it's not from the current tree.
				if (nodeSource.TreeView != tree)
				{
					// Get the screen point.
					Point pt = new Point(e.X, e.Y);

					// Convert to a point in the TreeView's coordinate system.
					pt = tree.PointToClient(pt);

					// Is the mouse over a valid node?
					TreeNode nodeTarget = tree.GetNodeAt(pt);
					if (nodeTarget != null)
					{
						e.Effect = DragDropEffects.Copy;
						tree.SelectedNode = nodeTarget;
					}
				}
			}
		}
		private void tree_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// Get the tree.
			TreeView tree = (TreeView)sender;

			// Get the screen point.
			Point pt = new Point(e.X, e.Y);

			// Convert to a point in the TreeView's coordinate system.
			pt = tree.PointToClient(pt);

			// Get the node underneath the mouse.
			TreeNode nodeTarget = tree.GetNodeAt(pt);

			// Add a child node.
			TreeNode nodeSource = (TreeNode)e.Data.GetData(typeof(TreeNode));
			nodeTarget.Nodes.Add((TreeNode)nodeSource.Clone());

			// Uncomment to make this a move.
			//nodeSource.Remove();

			// Show the newly added node if it is not already visible.
			nodeTarget.Expand();
		}

        private void tree_DoubleClick(object sender, EventArgs e)
        {
           MessageBox.Show(((TreeView)sender).SelectedNode.FullPath);
            
        }

	}
}