#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace TestApp
{
	partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("When in the design dialog, you can select and move controls.  Other properties can be set using the property grid.  \n\nClose the dialog to save the changes.");
			this.designModeDialog1.ShowDialog();
		}	
	}
}