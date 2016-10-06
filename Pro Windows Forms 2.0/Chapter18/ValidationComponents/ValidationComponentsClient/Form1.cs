using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValidationComponents;

namespace ValidationComponentsClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (BaseValidator.IsFormValid(this.components))
			{
				this.Close();
			}
			else
			{
				MessageBox.Show("You still have invalid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
            // Allow form closing regardless of the allow focus change
            // settings of individual validators.
            this.AutoValidate = AutoValidate.Disable;
			this.Close();
		}
	}
}