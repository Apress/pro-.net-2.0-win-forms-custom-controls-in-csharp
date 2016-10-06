using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualInheritance
{
	public partial class Ancestor : Form
	{
		public Ancestor()
		{
			InitializeComponent();
		}

		public string HeaderText
		{
			get
			{
				return lblHeader.Text;
			}
			set
			{
				lblHeader.Text = value;
			}
		}

		protected virtual void cmdNext_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Base Class Event");
		}

	}
}