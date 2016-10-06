using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WebBrowserTest
{
	/// <summary>
	/// Summary description for GetAllLinks.
	/// </summary>
	public class GetAllLinks : System.Windows.Forms.Form
    {

        private System.Windows.Forms.Button cmdGetAllLinks;

        private System.Windows.Forms.ListBox lstLinks;
        private SplitContainer splitContainer1;
        private WebBrowser webBrowser;

        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public GetAllLinks()
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
            this.cmdGetAllLinks = new System.Windows.Forms.Button();
            this.lstLinks = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGetAllLinks
            // 
            this.cmdGetAllLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdGetAllLinks.Enabled = false;
            this.cmdGetAllLinks.Location = new System.Drawing.Point(3, 352);
            this.cmdGetAllLinks.Name = "cmdGetAllLinks";
            this.cmdGetAllLinks.Size = new System.Drawing.Size(122, 30);
            this.cmdGetAllLinks.TabIndex = 1;
            this.cmdGetAllLinks.Text = "Get Links";
            this.cmdGetAllLinks.Click += new System.EventHandler(this.cmdGetAllLinks_Click);
            // 
            // lstLinks
            // 
            this.lstLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLinks.FormattingEnabled = true;
            this.lstLinks.IntegralHeight = false;
            this.lstLinks.Location = new System.Drawing.Point(0, 0);
            this.lstLinks.Name = "lstLinks";
            this.lstLinks.Size = new System.Drawing.Size(279, 337);
            this.lstLinks.TabIndex = 2;
            this.lstLinks.SelectedIndexChanged += new System.EventHandler(this.lstLinks_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstLinks);
            this.splitContainer1.Size = new System.Drawing.Size(580, 341);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(289, 337);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://www.zdnet.com", System.UriKind.Absolute);
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // GetAllLinks
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(591, 391);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cmdGetAllLinks);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GetAllLinks";
            this.Text = "Get All Links";
            this.Load += new System.EventHandler(this.GetAllLinks_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion

		private void GetAllLinks_Load(object sender, System.EventArgs e)
		{
			
		}

		private void cmdGetAllLinks_Click(object sender, System.EventArgs e)
		{
				if (webBrowser.ReadyState == WebBrowserReadyState.Complete)
			{
				this.Cursor = Cursors.WaitCursor;
                lstLinks.SuspendLayout();
				lstLinks.Items.Clear();

				HtmlElementCollection elements = webBrowser.Document.GetElementsByTagName("A");
				foreach (HtmlElement element in elements)
				{
					lstLinks.Items.Add(element.GetAttribute("href"));
				}
                lstLinks.ResumeLayout();
				this.Cursor = Cursors.Default;
			}
		}



		HtmlElement previous = null;

		private void lstLinks_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			HtmlElementCollection elements = webBrowser.Document.GetElementsByTagName("A");

			if (previous != null) previous.InnerText = previous.InnerText.Substring(3);

			previous = elements[lstLinks.SelectedIndex];
			previous.InnerText = ">>>" + previous.InnerText;

            
		}

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            cmdGetAllLinks.Enabled = true;
        }

	}
}
