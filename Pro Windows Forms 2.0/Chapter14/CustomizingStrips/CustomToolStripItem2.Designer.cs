namespace Strips
{
	partial class CustomToolStripItem2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomToolStripItem2));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.customToolStripButton1 = new Strips.CustomToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customToolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(292, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// customToolStripButton1
			// 
			this.customToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.customToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("customToolStripButton1.Image")));
			this.customToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.customToolStripButton1.Name = "customToolStripButton1";
			this.customToolStripButton1.Text = "customToolStripButton1";
			// 
			// CustomToolStripItem2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.toolStrip1);
			this.Name = "CustomToolStripItem2";
			this.Text = "CustomToolStripItem2";
			this.Load += new System.EventHandler(this.CustomToolStripItem2_Load);
			this.toolStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private CustomToolStripButton customToolStripButton1;
	}
}