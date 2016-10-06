using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WebBrowserTest
{
	/// <summary>
	/// Summary description for ScriptedWindow.
	/// </summary>
    [ComVisible(true)]
	public class ScriptedWindow : System.Windows.Forms.Form
	{
		private System.Windows.Forms.WebBrowser webBrowser1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public ScriptedWindow()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(4, 4);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(387, 334);
			this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebBrowser1_Navigating);
			// 
			// ScriptedWindow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(397, 345);
			this.Controls.Add(this.webBrowser1);
			this.Name = "ScriptedWindow";
			this.Text = "Scripted Window";
			this.Load += new System.EventHandler(this.ScriptedWindow_Load);
			this.ResumeLayout(false);

		}
		#endregion


		// Configures WebBrowser1 so script code can access the form.
		// Displays an initial document in WebBrowser1 which asks for the
		// name of the user and passes the name to the Welcome method.
		private void ScriptedWindow_Load(object sender, System.EventArgs e)
		{
			webBrowser1.ObjectForScripting = this;
			webBrowser1.Navigate(System.IO.Path.Combine(Application.StartupPath, "..\\..\\HTML\\feedback.htm"));
		}



		public void Feedback(string userName, string email)
		{
			if (userName != null)
				MessageBox.Show("Welcome, " + userName + " at " + email + ".");

			MessageBox.Show("Was this a complaint? " + webBrowser1.Document.GetElementById("Complaint").GetAttribute("checked"));
			// You can also interrogate other properties like this:
			// Retrieve comments.
			//MessageBox.Show(webBrowser1.Document.All["Comments"].GetAttribute("value"));
			// Test if
			//MessageBox.Show(webBrowser1.Document.All["MessageType"].GetAttribute("checked"));
			//if (webBrowser1.Document.All["MessageType"].GetAttribute("Value"))
			//{
				//MessageBox.Show("Complaint.");
			//}
		}


		// Halts navigation if the user has not entered a name.
		private void WebBrowser1_Navigating(object sender, System.Windows.Forms.WebBrowserNavigatingEventArgs e)
		{
			if (webBrowser1.Document.All["userName"].GetAttribute("value").Equals(""))
			{
				e.Cancel = true;
				System.Windows.Forms.MessageBox.Show("Please enter your name.");
			}
		}


	}
}
