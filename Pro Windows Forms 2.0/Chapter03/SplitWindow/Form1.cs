using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SplitWindow
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdHide_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel1Collapsed = true;
			pnlShow.Visible = true;

		}

		private void cmdShow_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel1Collapsed = false;
			pnlShow.Visible = false;
			

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DirectoryInfo d = new DirectoryInfo(Application.StartupPath);
			foreach (FileInfo f in d.GetFiles())
			{
				ListView1.Items.Add(f.Name);
			}
		}

		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				// Construct the objects required for the Navigate2 method call.
				// C# does not support optional parameters.
				string urlText = Path.Combine(Application.StartupPath, ListView1.SelectedItems[0].Text);


				webBrowser1.Navigate(urlText);
				StreamReader r = File.OpenText(urlText);
				TextBox1.Text = r.ReadToEnd();
				r.Close();
			}
			catch
			{
			}

		}

	}
}