using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImpossibleAPI
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			this.MdiParent = null;
			this.IsMdiContainer = true;
			this.Show();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			this.IsMdiContainer = false;
			this.MdiParent = Program.Main2;
			this.Show();
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			this.IsMdiContainer = false;
			this.MdiParent = Program.Main1;
			this.Show();
		}
	}
}