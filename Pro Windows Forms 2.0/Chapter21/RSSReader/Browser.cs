using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.Samples
{
	public partial class Browser : Form
	{
		public Browser()
		{
			InitializeComponent();
		}

		private void Browser_Load(object sender, EventArgs e)
		{

		}

		public string URL
		{
			get { return this.webBrowser1.Url.ToString(); }
			set { this.webBrowser1.Url = new Uri(value); }
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			this.webBrowser1.GoBack();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			this.webBrowser1.GoForward();
		}

		private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			this.Text = this.webBrowser1.Url.ToString();
		}
	}
}