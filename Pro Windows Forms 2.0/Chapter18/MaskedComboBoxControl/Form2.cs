using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaskedComboBoxControl
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void maskedTextBox1_MaskInputRejected(object sender,
  MaskInputRejectedEventArgs e)
		{
			Control control = (Control)sender;
			// Show an error notification.
			toolTip1.Show("That character is not allowed in this text box.",
				  control, new Point(control.Height, control.Height + 1));
		}

		private void maskedTextBox1_TextChanged(object sender, EventArgs e)
		{
			// Hide any error messages.
			toolTip1.Hide((IWin32Window)sender);
		}

	}
}