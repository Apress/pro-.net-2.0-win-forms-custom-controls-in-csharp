namespace System.Windows.Forms.Samples
{
	partial class Browser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
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
			this.customToolStrip1 = new System.Windows.Forms.Samples.CustomToolStrip();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.customToolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// customToolStrip1
			// 
			this.customToolStrip1.BackgroundImage = System.Windows.Forms.Samples.Properties.Resources.blueheader;
			this.customToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.customToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton2});
			this.customToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.customToolStrip1.Name = "customToolStrip1";
			this.customToolStrip1.Size = new System.Drawing.Size(550, 48);
			this.customToolStrip1.TabIndex = 0;
			this.customToolStrip1.Text = "customToolStrip1";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.ForeColor = System.Drawing.Color.White;
			this.toolStripButton4.Image = System.Windows.Forms.Samples.Properties.Resources.back;
			this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Padding = new System.Windows.Forms.Padding(4);
			this.toolStripButton4.Text = "Back";
			this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.ForeColor = System.Drawing.Color.White;
			this.toolStripButton2.Image = System.Windows.Forms.Samples.Properties.Resources.forward;
			this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Padding = new System.Windows.Forms.Padding(4);
			this.toolStripButton2.Text = "Forward";
			this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 48);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(550, 334);
			this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
			// 
			// Browser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 382);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.customToolStrip1);
			this.Name = "Browser";
			this.Text = "Browser";
			this.Load += new System.EventHandler(this.Browser_Load);
			this.customToolStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Samples.CustomToolStrip customToolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.WebBrowser webBrowser1;
	}
}