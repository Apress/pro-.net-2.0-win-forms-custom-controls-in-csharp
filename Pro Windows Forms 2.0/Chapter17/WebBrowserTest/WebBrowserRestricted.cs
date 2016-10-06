using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebBrowserTest
{
	public partial class WebBrowserRestricted : Form
	{
		public WebBrowserRestricted()
		{
			InitializeComponent();
		}

		private void WebBrowserRestricted_Load(object sender, EventArgs e)
		{
			webBrowser1.Navigate("http://msdn.microsoft.com");
		}

		private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			// This is the key event.
			// Here you decide whether to allow navigation to the selected page.


			// Check the domain.
			// In this case, only allow the home site.
			if (!e.Url.Host.Contains("microsoft.com"))
			{
				MessageBox.Show("Site restricted for demonstration purposes.");
				e.Cancel = true;
			}

			// Check the page.
			string page = System.IO.Path.GetFileName(e.Url.LocalPath);
			if (page.StartsWith("s"))
			{
				MessageBox.Show("Page restricted for demonstration purposes.");
				e.Cancel = true;
			}
		}

		private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			// Show the progress bar.
			progressBar.Visible = true;
		}

		private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
		{
			// Update the progress bar.
			progressBar.Maximum = (int)e.MaximumProgress;
			if (e.CurrentProgress >= 0 && e.CurrentProgress <= e.MaximumProgress)
			{
				progressBar.Value = (int)e.CurrentProgress;
			}
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			// Hide the progress bar.
			progressBar.Visible = false;
		}

		private void webBrowser1_StatusTextChanged(object sender, EventArgs e)
		{
			// Display the text that IE would ordinarily show
			// in the status bar.
			statusBar.Text = webBrowser1.StatusText;
		}

		private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
		{
			// Never allow external windows.
			e.Cancel = true;
		}
	}
}