using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.ObjectModel;

namespace OwnerDrawList
{
	public class MultiSelectTreeView : TreeView
	{
        // Force the tree to use owner drawing.
        public MultiSelectTreeView() : base()
        {
            base.DrawMode = TreeViewDrawMode.OwnerDrawText;
        }

        // Track the selected nodes.
        internal List<MultiSelectTreeNode2> selectedNodes =
        new List<MultiSelectTreeNode2>();

        public ReadOnlyCollection<MultiSelectTreeNode2> SelectedNodes
        {
            get
            {
                // Return a read-only wrapper for this collection.
                // The only way to change selection is through the
                // MultiSelectTreeNode methods.
                return selectedNodes.AsReadOnly();
            }
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            // Check for multiple selection support.
            MultiSelectTreeNode2 multiNode = e.Node as MultiSelectTreeNode2;
            if (multiNode != null)
            {
                // Retrieve the node font. If the node font has not been set,
                // use the TreeView font.
                Font nodeFont = multiNode.NodeFont;
                if (nodeFont == null) nodeFont = base.Font;

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
                e.Graphics.DrawString(e.Node.Text, nodeFont, foreBrush, e.Bounds.X, e.Bounds.Y);

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
                if (multiNode.IsSelected == false)
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

        protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
        {
            TreeNode nodeHit = base.HitTest(e.X, e.Y).Node;
            if (nodeHit != null)
            {
                MultiSelectTreeNode2 multiNode = nodeHit as MultiSelectTreeNode2;
                if (multiNode != null)
                {
                    // Use advanced selection rules.
                    if ((Control.ModifierKeys & Keys.Control) == 0)
                    {
                        // Ctrl is not held down.
                        // Remove previous selection.
                        List<MultiSelectTreeNode2> nodesToDelete =
                            new List<MultiSelectTreeNode2>();
                        foreach (MultiSelectTreeNode2 node in selectedNodes)
                        {
                            if (node != multiNode)
                            {
                                nodesToDelete.Add(node);
                            }
                        }
                        foreach (MultiSelectTreeNode2 node in nodesToDelete)
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

        public void Select(MultiSelectTreeNode2 node)
        {
            if (!node.IsSelected)
            {
                node.IsSelected = true;
                
                // Update the collection.
                selectedNodes.Add(node);
                base.Invalidate(base.Bounds);
            }
        }

        public void UnSelect(MultiSelectTreeNode2 node)
        {
            if (node.IsSelected)
            {
                node.IsSelected = false;

                // Update the collection.
                selectedNodes.Remove(node);
                base.Invalidate(base.Bounds);
            }
        }

	}

    public class MultiSelectTreeNode2 : TreeNode
    {
        private MultiSelectTreeView MultiSelectTreeView
        {
            get
            {
                return base.TreeView as MultiSelectTreeView;
            }
        }

        public MultiSelectTreeNode2(string text) : base(text)
        {
            
        }
        
        private bool selected = false;
        public new bool IsSelected
        {
            get { return selected; }
            internal set { selected = value; }
        }

        public void Select()
        {
            // Check if the selection is being changed.
            if (selected != true)
            {
                if (MultiSelectTreeView != null) MultiSelectTreeView.Select(this);
            }

        }

        public void UnSelect()
        {
            // Check if the selection is being changed.
            if (selected != false)
            {
                if (MultiSelectTreeView != null) MultiSelectTreeView.UnSelect(this);
            }
        }

      
    }
}
