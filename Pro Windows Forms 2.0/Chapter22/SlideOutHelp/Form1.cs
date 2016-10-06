using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SlideOutHelp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdShowHide_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel2Collapsed = true;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel2Collapsed = false;
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			Control ctrl = (Control)sender;
			webBrowser1.Navigate(Application.StartupPath + @"\..\..\Help\" + ctrl.Tag);
		}


	}
}