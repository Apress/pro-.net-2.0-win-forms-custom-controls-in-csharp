namespace CollapsiblePanelHost
{
	partial class CollapsibleLayout
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.collapsiblePanel1 = new Microsoft.Samples.CollapsiblePanel();
			this.collapsiblePanel2 = new Microsoft.Samples.CollapsiblePanel();
			this.collapsiblePanel4 = new Microsoft.Samples.CollapsiblePanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel1);
			this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel2);
			this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel4);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 347);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// collapsiblePanel1
			// 
			this.collapsiblePanel1.Collapsed = false;
			this.collapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsiblePanel1.Location = new System.Drawing.Point(13, 13);
			this.collapsiblePanel1.Name = "collapsiblePanel1";
			this.collapsiblePanel1.Size = new System.Drawing.Size(219, 100);
			this.collapsiblePanel1.TabIndex = 6;
			this.collapsiblePanel1.Text = "System Tasks";
			// 
			// collapsiblePanel2
			// 
			this.collapsiblePanel2.Collapsed = false;
			this.collapsiblePanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsiblePanel2.Location = new System.Drawing.Point(13, 119);
			this.collapsiblePanel2.Name = "collapsiblePanel2";
			this.collapsiblePanel2.Size = new System.Drawing.Size(219, 100);
			this.collapsiblePanel2.TabIndex = 4;
			this.collapsiblePanel2.Text = "Personal Tasks";
			// 
			// collapsiblePanel4
			// 
			this.collapsiblePanel4.Collapsed = false;
			this.collapsiblePanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsiblePanel4.Location = new System.Drawing.Point(13, 225);
			this.collapsiblePanel4.Name = "collapsiblePanel4";
			this.collapsiblePanel4.Size = new System.Drawing.Size(219, 100);
			this.collapsiblePanel4.TabIndex = 5;
			this.collapsiblePanel4.Text = "Other Tasks";
			// 
			// CollapsibleLayout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 347);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "CollapsibleLayout";
			this.Text = "Collapsible Layout";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private Microsoft.Samples.CollapsiblePanel collapsiblePanel1;
		private Microsoft.Samples.CollapsiblePanel collapsiblePanel2;
		private Microsoft.Samples.CollapsiblePanel collapsiblePanel4;
	}
}