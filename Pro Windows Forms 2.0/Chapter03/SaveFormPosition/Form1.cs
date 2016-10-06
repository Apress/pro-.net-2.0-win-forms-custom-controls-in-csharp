using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SaveFormPosition
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormPositionHelper.SaveSize(this);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormPositionHelper.SetSize(this);
		}
	}
}