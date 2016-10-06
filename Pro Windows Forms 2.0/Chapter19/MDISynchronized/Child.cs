using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiSynchronized
{
	public partial class Child : Form
	{
		public Child()
		{
			InitializeComponent();
		}

		private bool isUpdating;

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
			if (this.MdiParent != null && !isUpdating)
			{
				// The reference to the MDI parent must be converted to the appropriate
				// form class in order to access the custom RefreshChildren() method.
				((Parent)this.MdiParent).RefreshChildren(this, textBox1.Text);
			}

		}
		public void RefreshText(string text)
		{
			// Disable the event to prevent an endless string of updates.
			isUpdating = true;

			// Update the control.
			textBox1.Text = text;

			// Re-enable the event handler.
			isUpdating = false;
		}
	}
}