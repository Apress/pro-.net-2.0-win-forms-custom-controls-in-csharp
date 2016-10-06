using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VisualInheritance
{
	public class Descendant : VisualInheritance.Ancestor
	{
		private System.ComponentModel.IContainer components = null;

		public Descendant()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		protected override void cmdNext_Click(System.Object sender, System.EventArgs e)
		{
			// Call the original version.
			base.cmdNext_Click(sender, e);

			MessageBox.Show("Descendant form event handler.");

		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}

