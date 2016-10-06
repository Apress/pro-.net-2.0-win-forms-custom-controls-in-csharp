using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
	public partial class CustomizableStrip : Form
	{
		public CustomizableStrip()
		{
			InitializeComponent();
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void newToolStripButton_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			ToolStripManager.SaveSettings(this,"Test");
		}

		private void cmdRestore_Click(object sender, EventArgs e)
		{
			ToolStripManager.LoadSettings(this,"Test");
		}
	}
}