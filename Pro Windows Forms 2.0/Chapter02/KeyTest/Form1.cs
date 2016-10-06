using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeyTest
{
	public partial class Form1 : Form
	{
		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(
			System.Windows.Forms.Keys vKey); // Keys enumeration


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
	
			// Show the key letter that was pressed. For example, if the user presses
			// the D key, the key value will always be “D” regardless of whether Shift
			// was held down or not).
			lbl.Text = "Key Down: " + e.KeyValue.ToString();
			lbl.Text += "\nKey Code: " + e.KeyCode.ToString();
			lbl.Text += "\nKey Data: " + e.KeyData.ToString();

			// The KeyCode contains information about every key that was held down,
			// using the Keys enumeration. Check if one of these keys is Shift.
			if ((e.Modifiers & Keys.Shift) == Keys.Shift)
			{
				lbl.Text += "\n" + "Shift was held down.";
			}

			if ((e.Modifiers & Keys.Control) == Keys.Control)
			{
				lbl.Text += "\n" + "Control was held down.";
			}

			// The easier approach.
			if (e.Alt)
			{
				lbl.Text += "\n" + "Alt was held down.";
			}
		}

		private void cmdAsyncState_Click(object sender, EventArgs e)
		{
			// Test for the letter D.
			short state = GetAsyncKeyState(Keys.D);
			switch (state)
			{
				case 0:
					lbl.Text = "D has not been pressed since the last call.";
                    break;
				case 1:
                    lbl.Text = "D is not currently pressed, but has been pressed since the last call.";
                    break;
				case -32767:
					lbl.Text = "D is currently pressed.";
                    break;
			}
		}


	}
}