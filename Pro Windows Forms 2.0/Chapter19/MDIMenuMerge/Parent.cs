using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiMenuMerge
{
	public partial class Parent : Form
	{
		public Parent()
		{
			InitializeComponent();
		}

		private void noMergeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Child child = new Child();
            child.MdiParent = this;
            child.SetNoMerge();
			child.Show();
		}

		private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Child child = new Child();
			child.MdiParent = this;
			child.Show();
		}
	}
}