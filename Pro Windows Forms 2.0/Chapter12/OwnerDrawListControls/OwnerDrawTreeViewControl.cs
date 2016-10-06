using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OwnerDrawList
{
	public partial class OwnerDrawTreeViewControl : Form
	{
		public OwnerDrawTreeViewControl()
		{
			InitializeComponent();
		}

		private void CustomTreeView_Load(object sender, EventArgs e)
		{
            MultiSelectTreeNode2 nodeP = new MultiSelectTreeNode2("Node Group");
            multiSelectTreeView1.Nodes.Add(nodeP);

            MultiSelectTreeNode2 node = new MultiSelectTreeNode2("First Node");
            node.Select();
            nodeP.Nodes.Add(node);
            node = new MultiSelectTreeNode2("Second Node");
            nodeP.Nodes.Add(node);
            node = new MultiSelectTreeNode2("Third Node");
            nodeP.Nodes.Add(node);
            node = new MultiSelectTreeNode2("Fourth Node");
            nodeP.Nodes.Add(node);
            node = new MultiSelectTreeNode2("Fifth Node");
            nodeP.Nodes.Add(node);
            node = new MultiSelectTreeNode2("Sixth Node");
            nodeP.Nodes.Add(node);
            node = new MultiSelectTreeNode2("Seventh Node");
            nodeP.Nodes.Add(node);

            multiSelectTreeView1.ExpandAll();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(multiSelectTreeView1.SelectedNodes.Count.ToString());
        }

        private void cmdGetSelected_Click(object sender, EventArgs e)
        {
            string nodeText = "";
            foreach (TreeNode node in multiSelectTreeView1.SelectedNodes)
            {
                nodeText += node.Text + "\n";
            }

            MessageBox.Show(nodeText);
        }
	}
}