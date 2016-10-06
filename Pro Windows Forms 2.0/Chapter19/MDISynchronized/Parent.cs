using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiSynchronized
{
	public partial class Parent : Form
	{
		public Parent()
		{
			InitializeComponent();
		}

		private int mdiIndex = 0;

		private void cmdNew(object sender, EventArgs e)
		{
			// Show a new child form.
			Child frmChild = new Child();
			frmChild.MdiParent = this;

			frmChild.RefreshText(synchronizedText);
			mdiIndex++;
			frmChild.Text = "MDI Child #" + mdiIndex.ToString();

			frmChild.Show();
		}

		private void cmdClose(object sender, EventArgs e)
		{
			// Close the active child.
			if (ActiveMdiChild != null)
				ActiveMdiChild.Close();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		string synchronizedText;
		public void RefreshChildren(Child sender, string text)
		{
			// Store text for use when creating a child form, or if needed later.
			synchronizedText = text;

			// Update children.
			foreach (Child frm in this.MdiChildren)
			{
				if (frm != sender)
				{
					frm.RefreshText(text);
				}
			}
		}



		private void mnuMinimizeAll_Click(object sender, System.EventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			{
				frm.WindowState = FormWindowState.Minimized;
			}

		}

		private void mnuTileH_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void mnuTileV_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void mnuCascade_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void windowToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			if (this.MdiChildren.Length == 0)
			{
				// There are no children.
				// The last item in the menu must be a separator.
				// Hide it.
				int lastItem = windowToolStripMenuItem.DropDown.Items.Count - 1;
				windowToolStripMenuItem.DropDown.Items[lastItem].Visible = false;
			}
		}

		private void windowToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
		{
			if (this.MdiChildren.Length == 0)
			{
				int lastItem = windowToolStripMenuItem.DropDown.Items.Count - 1;
				windowToolStripMenuItem.DropDown.Items[lastItem].Visible = true;
			}
		}
	}
}