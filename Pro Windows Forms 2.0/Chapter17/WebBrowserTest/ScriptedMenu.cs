using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace WebBrowserTest
{
	/// <summary>
	/// Summary description for ScriptedMenu.
	/// </summary>
	[ComVisible(true)]
	public class ScriptedMenu : System.Windows.Forms.Form
	{
		private System.Windows.Forms.WebBrowser webBrowser;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public ScriptedMenu()
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(4, 3);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(422, 341);
            this.webBrowser.TabIndex = 0;
            // 
            // ScriptedMenu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(429, 348);
            this.Controls.Add(this.webBrowser);
            this.Name = "ScriptedMenu";
            this.Text = "Scripted Menu";
            this.Load += new System.EventHandler(this.ScriptedMenu_Load);
            this.ResumeLayout(false);

        }
		#endregion

		private void ScriptedMenu_Load(object sender, System.EventArgs e)
		{
			webBrowser.ObjectForScripting = this;
            webBrowser.Navigate(System.IO.Path.Combine(Application.StartupPath, "..\\..\\HTML\\sample.htm"));
        }


		public void WebClick(string source)
		{
			MessageBox.Show("Received: " + source);
		}



	}
}
