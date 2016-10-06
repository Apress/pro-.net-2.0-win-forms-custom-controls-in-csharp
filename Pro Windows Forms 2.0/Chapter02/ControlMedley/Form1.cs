using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlMedley
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void ctrlClick(System.Object sender, EventArgs e)
		{
			Control ctrl = (Control)sender;
			MessageBox.Show("You clicked: " + ctrl.Name);
		}
	}
}