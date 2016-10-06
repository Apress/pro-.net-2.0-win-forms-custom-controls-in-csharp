using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WebBrowserTest
{
	/// <summary>
	/// Summary description for ExploreDOM.
	/// </summary>
	public class ExploreDOM : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;

		private System.Windows.Forms.TreeView treeDOM;
        private System.Windows.Forms.WebBrowser webBrowser;
        private SplitContainer splitContainer1;

        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public ExploreDOM()
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
            this.button1 = new System.Windows.Forms.Button();
            this.treeDOM = new System.Windows.Forms.TreeView();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Analyze Page";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeDOM
            // 
            this.treeDOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDOM.Location = new System.Drawing.Point(0, 0);
            this.treeDOM.Name = "treeDOM";
            this.treeDOM.Size = new System.Drawing.Size(392, 358);
            this.treeDOM.TabIndex = 5;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(196, 358);
            this.webBrowser.TabIndex = 6;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
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
            this.splitContainer1.Panel2.Controls.Add(this.treeDOM);
            this.splitContainer1.Size = new System.Drawing.Size(600, 362);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // ExploreDOM
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(615, 426);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExploreDOM";
            this.Text = "ExploreDOM";
            this.Load += new System.EventHandler(this.ExploreDOM_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion

		private void ExploreDOM_Load(object sender, System.EventArgs e)
		{
            webBrowser.Navigate("http://www.nytimes.com");
        }

		private void button1_Click(object sender, System.EventArgs e)
		{
            // Analyzing a page takes a non-trivial amount of time.
            // Use the hourglass cursor to warn the user.
            this.Cursor = Cursors.WaitCursor;

            // Show the title.
			this.Text = webBrowser.Document.Title;
            
            treeDOM.SuspendLayout();

			// Process all the HTML elements on the page.
			ProcessElement(webBrowser.Document.Body.Children, treeDOM.Nodes);
            
            treeDOM.ExpandAll();
            treeDOM.ResumeLayout();
            this.Cursor = Cursors.Default;       

        }

		private void ProcessElement(HtmlElementCollection elements, TreeNodeCollection nodes)
		{
			// Scan through the collection of elements.
			foreach (HtmlElement element in elements)
			{
				// Create a new node that shows the tag name.
				TreeNode node = new TreeNode("<" + element.TagName + ">");
				nodes.Add(node);
				
				if ((element.Children.Count == 0) && (element.InnerText != null))
				{
					// If this element doesn't contain any other elements, add
					// any leftover text content as a new node.
					node.Nodes.Add(element.InnerText);
				}
				else
				{
					// If this element contains other elements, process them recursively.
					ProcessElement(element.Children, node.Nodes);
				}
			}
		}

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
        }

	}
}
