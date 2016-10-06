using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleValidation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (((TextBox)sender).Text == "")
			{
				MessageBox.Show("You must enter a first and last name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				e.Cancel = true;
			}
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
            // This triggers validation.
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtFirstName.Select();
		}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
                DialogResult result = MessageBox.Show(
                    "There are still errors on the form. Do you wish to close the form?",
                    "Errors found", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) e.Cancel = false;
            }
        }
	}
}