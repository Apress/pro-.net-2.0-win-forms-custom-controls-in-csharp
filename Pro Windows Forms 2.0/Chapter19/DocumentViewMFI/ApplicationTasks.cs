using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
	public class ApplicationTasks 
	{		
		private string lastDir = "C:\\Temp";

		public void Open()
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
                Program.DocumentManager.AddForm(frmChild);
				frmChild.Show();
			}
		}

		public void New()
		{
			// Create a new order.
			Order doc = new Order();
			Child frmChild = new Child(doc, Child.ViewType.ItemGrid);
			Program.DocumentManager.AddForm(frmChild);
			frmChild.Show();
		}

		public void Save()
		{
			// Save the current order.
			if (Program.DocumentManager.ActiveDocumentForm != null)
			{
				SaveFileDialog dlgSave = new SaveFileDialog();
				Order doc = ((Child)Program.DocumentManager.ActiveDocumentForm).Document;
				dlgSave.FileName = doc.LastFileName;
				dlgSave.Filter = "Order Files (*.ord)|*.ord";

				if (dlgSave.ShowDialog() == DialogResult.OK)
				{
					try
					{
						doc.Save(dlgSave.FileName);
						Program.DocumentManager.ActiveDocumentForm.Text = dlgSave.FileName;
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

		public void Preview()
		{
			// Launch a print preview child for the active order.
			if (Program.DocumentManager.ActiveDocumentForm != null)
			{
				Order doc = ((Child)Program.DocumentManager.ActiveDocumentForm).Document;

				Child frmChild = new Child(doc, Child.ViewType.PrintPreview);
				Program.DocumentManager.AddForm(frmChild);
				frmChild.Show();
			}
		}

	}
}