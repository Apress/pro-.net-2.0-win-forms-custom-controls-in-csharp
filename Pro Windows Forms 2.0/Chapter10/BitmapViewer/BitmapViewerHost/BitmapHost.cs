using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BitmapViewerHost
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class BitmapHost : System.Windows.Forms.Form
	{
        private BitmapViewerControl.BitmapViewer bitmapViewer1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BitmapHost()
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
				if (components != null) 
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
            this.bitmapViewer1 = new BitmapViewerControl.BitmapViewer();
            this.SuspendLayout();
            // 
            // bitmapViewer1
            // 
            this.bitmapViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bitmapViewer1.Dimension = 80;
            this.bitmapViewer1.Directory = null;
            this.bitmapViewer1.Location = new System.Drawing.Point(3, 3);
            this.bitmapViewer1.Name = "bitmapViewer1";
            this.bitmapViewer1.Padding = new System.Windows.Forms.Padding(1);
            this.bitmapViewer1.Size = new System.Drawing.Size(314, 259);
            this.bitmapViewer1.Spacing = 10;
            this.bitmapViewer1.TabIndex = 0;
            this.bitmapViewer1.PictureSelected += new BitmapViewerControl.BitmapViewer.PictureSelectedDelegate(this.bitmapViewer1_PictureSelected);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(320, 266);
            this.Controls.Add(this.bitmapViewer1);
            this.Name = "Form1";
            this.Text = "BitmapViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion


		private void Form1_Load(object sender, System.EventArgs e)
		{
			bitmapViewer1.Directory = Application.StartupPath;
		}

		private void bitmapViewer1_PictureSelected(object sender, BitmapViewerControl.PictureSelectedEventArgs e)
		{
			    MessageBox.Show("You chose " + System.IO.Path.GetFileName(e.FileName));
		}

	
	}
}
