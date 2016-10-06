using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
	public partial class Parent : Form
	{
		public Parent()
		{
			InitializeComponent();
		}
		private string lastDir = "C:\\Temp";

		private void cmdOpen(object sender, EventArgs e)
		{
			OpenFileDialog dlgOpen = new OpenFileDialog();
			dlgOpen.InitialDirectory = lastDir;
			dlgOpen.Filter = "Order Files (*.ord)|*.ord";

			// Show the open dialog.
			if (dlgOpen.ShowDialog() == DialogResult.OK)
			{
				Order doc = new Order();

				try
				{
					doc.Open(dlgOpen.FileName);
				}
				catch (Exception err)
				{
					// All exceptions bubble up to this level.
					MessageBox.Show(err.ToString());
					return;
				}

				// Create the child form for the selected file.
				Child frmChild = new Child(doc, Child.ViewType.ItemGrid);
				frmChild.MdiParent = this;
				frmChild.Show();
			}
		}

		private void cmdNew(object sender, EventArgs e)
		{
			// Create a new order.
			Order doc = new Order();
			Child frmChild = new Child(doc, Child.ViewType.ItemGrid);
			frmChild.MdiParent = this;
			frmChild.Show();
		}

		private void cmdSave(object sender, EventArgs e)
		{
			// Save the current order.
			if (ActiveMdiChild != null)
			{
				SaveFileDialog dlgSave = new SaveFileDialog();
				Order doc = ((Child)ActiveMdiChild).Document;
				dlgSave.FileName = doc.LastFileName;
				dlgSave.Filter = "Order Files (*.ord)|*.ord";

				if (dlgSave.ShowDialog() == DialogResult.OK)
				{
					try
					{
						doc.Save(dlgSave.FileName);
						ActiveMdiChild.Text = dlgSave.FileName;
					}
					catch (Exception err)
					{
						// All exceptions bubble up to this level.
						MessageBox.Show(err.ToString());
						return;
					}
				}
			}
		}

		private void cmdClose(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
				ActiveMdiChild.Close();
		}

		private void cmdPreview(object sender, EventArgs e)
		{
			// Launch a print preview child for the active order.
			if (ActiveMdiChild != null)
			{
				Order doc = ((Child)ActiveMdiChild).Document;

				Child frmChild = new Child(doc, Child.ViewType.PrintPreview);
				frmChild.MdiParent = this;
				frmChild.Show();
			}
		}

		private void Parent_Load(object sender, EventArgs e)
		{
			toolStrip1.Items[0].Image = imgButtons.Images[0];
			toolStrip1.Items[1].Image = imgButtons.Images[1];
			toolStrip1.Items[2].Image = imgButtons.Images[2];
			toolStrip1.Items[3].Image = imgButtons.Images[3];
			toolStrip1.Items[5].Image = imgButtons.Images[4];
			
		}

	}
}