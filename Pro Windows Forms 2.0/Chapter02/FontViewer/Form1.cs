using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FontViewer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
			foreach (FontFamily family in fonts.Families)
			{
				lstFonts.Items.Add(family.Name);
			}

			RegistryKey rk;
			rk = Registry.LocalMachine.OpenSubKey("Software\\ProseTech\\FontViewer");
			if (rk != null) this.Text += " - " + rk.GetValue("Customer");

		}

		private void lstFonts_SelectedIndexChanged(object sender, EventArgs e)
		{
            this.Invalidate();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			if (lstFonts.SelectedIndex != -1)
			{
				try
				{
					e.Graphics.DrawString(lstFonts.Text, new Font(lstFonts.Text, 50), Brushes.Black, 10, 50);
					statusBar.Items[0].Text = "";
				}
				catch (ArgumentException err)
				{
					statusBar.Items[0].Text = err.Message;
				}
			}
		}
	}
}