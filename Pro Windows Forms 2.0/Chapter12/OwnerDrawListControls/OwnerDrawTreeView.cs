using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OwnerDrawList
{
	public partial class OwnerDrawTreeView : Form
	{
		public OwnerDrawTreeView()
		{
			InitializeComponent();
		}

		private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
		{
			// Check for multiple selection support.
			MultiSelectTreeNode multiNode = e.Node as MultiSelectTreeNode;
			if (multiNode != null)
			{
				// Retrieve the node font. If the node font has not been set,
				// use the TreeView font.
				Font nodeFont = multiNode.NodeFont;
				if (nodeFont == null) nodeFont = ((TreeView)sender).Font;

				// Create brushes for the background and foreground.
				Brush backBrush, foreBrush;
				if (multiNode.IsSelected)
				{
					foreBrush = SystemBrushes.HighlightText;
					backBrush = SystemBrushes.Highlight;
				}
				else
				{
					if (multiNode.ForeColor != Color.Empty)
					{
						foreBrush = new SolidBrush(multiNode.ForeColor);
					}
					else
					{
						foreBrush = new SolidBrush(multiNode.TreeView.ForeColor);
					}
					if (multiNode.BackColor != Color.Empty)
					{
						backBrush = new SolidBrush(multiNode.BackColor);
					}
					else
					{
						backBrush = new SolidBrush(multiNode.TreeView.BackColor);
					}
				}					
				
				// Draw the background of the selected node.
                Rectangle bounds = e.Bounds;
                bounds.X += 1;
                e.Graphics.FillRectangle(backBrush, bounds);

				// Draw the node text.
				e.Graphics.DrawString(e.Node.Text, nodeFont, foreBrush, e.Bounds.X,e.Bounds.Y);
                
				// If the node has focus, draw the focus rectangle.
				if ((e.State & TreeNodeStates.Focused) != 0)
				{
					using (Pen focusPen = new Pen(Color.Black))
					{
						focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
						Rectangle focusBounds = e.Bounds;
						focusBounds.Size = new Size(focusBounds.Width,
						  focusBounds.Height - 1);
                        
						e.Graphics.DrawRectangle(focusPen, focusBounds);
					}
				}

				// Dispose brushes if they were created
				// just for this node.
				if (!multiNode.IsSelected)
				{
					backBrush.Dispose();
					foreBrush.Dispose();
				}
			}
			else
			{
			    // No multiple selection support.
			    e.DrawDefault = true;
			}
		}

		private void OwnerDrawnTreeView_Load(object sender, EventArgs e)
		{
			MultiSelectTreeNode nodeP = new MultiSelectTreeNode("Node Group", selectedNodes );
			treeView1.Nodes.Add(nodeP);
            
			MultiSelectTreeNode node = new MultiSelectTreeNode("First Node", selectedNodes);
			node.Select();
			nodeP.Nodes.Add(node);
			node = new MultiSelectTreeNode("Second Node", selectedNodes);
			nodeP.Nodes.Add(node);
			node = new MultiSelectTreeNode("Third Node", selectedNodes);
			nodeP.Nodes.Add(node);
			node = new MultiSelectTreeNode("Fourth Node", selectedNodes);
			nodeP.Nodes.Add(node);
			node = new MultiSelectTreeNode("Fifth Node", selectedNodes);
			nodeP.Nodes.Add(node);
			node = new MultiSelectTreeNode("Sixth Node", selectedNodes);
			nodeP.Nodes.Add(node);
			node = new MultiSelectTreeNode("Seventh Node", selectedNodes);
			nodeP.Nodes.Add(node);

            treeView1.ExpandAll();
		}

		private List<MultiSelectTreeNode> selectedNodes = 
			new List<MultiSelectTreeNode>();

			
		private void treeView1_MouseDown(object sender, MouseEventArgs e)
		{
			TreeNode nodeHit = treeView1.HitTest(e.X, e.Y).Node;
			if (nodeHit != null)
			{
				MultiSelectTreeNode multiNode = nodeHit as MultiSelectTreeNode;
				if (multiNode != null)
				{
					// Use advanced selection rules.
					if ((Control.ModifierKeys & Keys.Control) == 0)
					{
						// Ctrl is not held down.
						// Remove previous selection.
						List<MultiSelectTreeNode> nodesToDelete =
							new List<MultiSelectTreeNode>();
						foreach (MultiSelectTreeNode node in selectedNodes)
						{
							if (node != multiNode)
							{
								nodesToDelete.Add(node);
							}
						}
						foreach (MultiSelectTreeNode node in nodesToDelete)
						{
							node.UnSelect();
						}
					}

					if (multiNode.IsSelected)
					{
						// Node is already selected.
						// Toggle it off.
						multiNode.UnSelect();
					}
					else
					{
						// Add new selection.
						multiNode.Select();
					}
				}
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            string nodeText = "";
            foreach (TreeNode node in selectedNodes)
            {
                nodeText += node.Text + "\n";
            }

            MessageBox.Show(nodeText);
        }
	}
}

public class MultiSelectTreeNode : TreeNode
{
	private List<MultiSelectTreeNode> selectedNodes;

	public MultiSelectTreeNode(string text, List<MultiSelectTreeNode> selectedNodes) : base(text)
	{
		this.selectedNodes = selectedNodes;
	}

	private bool selected = false;
	public new bool IsSelected
	{
		get { return selected; }
	}

	public void Select()
	{
		// Check if the selection is being changed.
		if (selected != true)
		{
			selected = true;

			// Update the collection.
		    selectedNodes.Add(this);
			RepaintNode();
		}
		
	}

	public void UnSelect()
	{
		// Check if the selection is being changed.
		if (selected != false)
		{
			selected = false;

			// Update the collection.
			selectedNodes.Remove(this);
			RepaintNode();
		}
		
	}

	private void RepaintNode()
	{
		// TreeView will be null if the node hasn't been
		// added yet.
		if (base.TreeView != null)
		{
			// Repaint the node.
			base.TreeView.Invalidate(base.Bounds);
		}
	}				
}