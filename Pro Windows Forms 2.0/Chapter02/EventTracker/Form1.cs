using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EventTracker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Log(String data)
		{
			lstLog.Items.Add(data);
			int itemsPerPage = (int)(lstLog.Height / lstLog.ItemHeight);
			lstLog.TopIndex = lstLog.Items.Count - itemsPerPage;
		}

		private void txt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			Log("Key Down: " + e.KeyCode.ToString() + e.KeyValue.ToString());
		}

		private void txt_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Log("Key Press: " + e.KeyChar.ToString());
		}

		private void txt_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			Log("Key Up: " + e.KeyCode.ToString() + e.KeyValue.ToString() + " Text is: " + txt.Text);
		}

		private void txt_TextChanged(object sender, System.EventArgs e)
		{
			Log("Changed: " + " Text is: " + txt.Text);
		}

		private void pic_MouseEnter(object sender, System.EventArgs e)
		{
			Log("Mouse Enter");
		}

		private void pic_MouseHover(object sender, System.EventArgs e)
		{
			Log("Mouse Hover");
		}

		private void pic_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Log("Mouse Down: X=" + e.X.ToString() + " Y=" + e.Y.ToString() + " Button=" + e.Button.ToString());
		}

		private void pic_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Log("Mouse Up: X=" + e.X.ToString() + " Y=" + e.Y.ToString() + " Button=" + e.Button.ToString());
		}

		private void pic_Click(object sender, System.EventArgs e)
		{
			Log("Click");
		}

		private void pic_DoubleClick(object sender, System.EventArgs e)
		{
			Log("Double Click");
		}

		private void pic_MouseLeave(object sender, System.EventArgs e)
		{
			Log("Mouse Leave");
		}
	}
}