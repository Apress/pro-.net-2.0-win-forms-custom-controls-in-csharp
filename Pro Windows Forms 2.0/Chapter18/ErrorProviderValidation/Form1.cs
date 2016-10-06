using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ErrorProviderValidation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmdOK_Click(object sender, EventArgs e)
		{
			bool invalidInput = false;

			foreach (Control ctrl in this.grpValidation.Controls)
			{
				if (errProvider.GetError(ctrl) != "")
				{
					invalidInput = true;
					break;
				}
			}

			if (invalidInput)
			{
				MessageBox.Show("You still have invalid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				this.Close();
			}
        
		}

		private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Control ctrl = (Control)sender;
			if (ctrl.Text == "")
			{
				errProvider.SetError(ctrl, "You must enter a first and last name.");
			}
			else
			{
				errProvider.SetError(ctrl, "");
			}
		}


		private void txtEmail_TextChanged(object sender, System.EventArgs e)
		{
			System.Text.RegularExpressions.Regex regex;
			regex = new System.Text.RegularExpressions.Regex(@"^\S+@\S+\.\S+$");

			Control ctrl = (Control)sender;
			if (regex.IsMatch(ctrl.Text))
			{
				errProvider.SetError(ctrl, "");
			}
			else
			{
				errProvider.SetError(ctrl, "Not a valid email.");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtFirstName.Select();
		}
	
	}
}