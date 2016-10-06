namespace SimpleDrawing
{
	partial class Smoothing
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
			this.grpHighQuality = new System.Windows.Forms.GroupBox();
			this.picHighQuality = new System.Windows.Forms.PictureBox();
			this.grpAntiAlias = new System.Windows.Forms.GroupBox();
			this.picAntialias = new System.Windows.Forms.PictureBox();
			this.grpHighSpeed = new System.Windows.Forms.GroupBox();
			this.picHighSpeed = new System.Windows.Forms.PictureBox();
			this.grpNone = new System.Windows.Forms.GroupBox();
			this.picNone = new System.Windows.Forms.PictureBox();
			this.grpHighQuality.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picHighQuality)).BeginInit();
			this.grpAntiAlias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAntialias)).BeginInit();
			this.grpHighSpeed.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picHighSpeed)).BeginInit();
			this.grpNone.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picNone)).BeginInit();
			this.SuspendLayout();
			// 
			// grpHighQuality
			// 
			this.grpHighQuality.Controls.Add(this.picHighQuality);
			this.grpHighQuality.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpHighQuality.Location = new System.Drawing.Point(12, 276);
			this.grpHighQuality.Name = "grpHighQuality";
			this.grpHighQuality.Size = new System.Drawing.Size(344, 85);
			this.grpHighQuality.TabIndex = 12;
			this.grpHighQuality.TabStop = false;
			this.grpHighQuality.Text = "HighQuality";
			// 
			// picHighQuality
			// 
			this.picHighQuality.Location = new System.Drawing.Point(8, 16);
			this.picHighQuality.Name = "picHighQuality";
			this.picHighQuality.Size = new System.Drawing.Size(328, 64);
			this.picHighQuality.TabIndex = 0;
			this.picHighQuality.TabStop = false;
			this.picHighQuality.Paint += new System.Windows.Forms.PaintEventHandler(this.picHighQuality_Paint);
			// 
			// grpAntiAlias
			// 
			this.grpAntiAlias.Controls.Add(this.picAntialias);
			this.grpAntiAlias.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpAntiAlias.Location = new System.Drawing.Point(12, 188);
			this.grpAntiAlias.Name = "grpAntiAlias";
			this.grpAntiAlias.Size = new System.Drawing.Size(344, 85);
			this.grpAntiAlias.TabIndex = 11;
			this.grpAntiAlias.TabStop = false;
			this.grpAntiAlias.Text = "AntiAlias";
			// 
			// picAntialias
			// 
			this.picAntialias.Location = new System.Drawing.Point(8, 16);
			this.picAntialias.Name = "picAntialias";
			this.picAntialias.Size = new System.Drawing.Size(328, 64);
			this.picAntialias.TabIndex = 0;
			this.picAntialias.TabStop = false;
			this.picAntialias.Paint += new System.Windows.Forms.PaintEventHandler(this.picAntialias_Paint);
			// 
			// grpHighSpeed
			// 
			this.grpHighSpeed.Controls.Add(this.picHighSpeed);
			this.grpHighSpeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpHighSpeed.Location = new System.Drawing.Point(12, 100);
			this.grpHighSpeed.Name = "grpHighSpeed";
			this.grpHighSpeed.Size = new System.Drawing.Size(344, 85);
			this.grpHighSpeed.TabIndex = 10;
			this.grpHighSpeed.TabStop = false;
			this.grpHighSpeed.Text = "HighSpeed";
			// 
			// picHighSpeed
			// 
			this.picHighSpeed.Location = new System.Drawing.Point(8, 16);
			this.picHighSpeed.Name = "picHighSpeed";
			this.picHighSpeed.Size = new System.Drawing.Size(328, 64);
			this.picHighSpeed.TabIndex = 0;
			this.picHighSpeed.TabStop = false;
			this.picHighSpeed.Paint += new System.Windows.Forms.PaintEventHandler(this.picHighSpeed_Paint);
			// 
			// grpNone
			// 
			this.grpNone.Controls.Add(this.picNone);
			this.grpNone.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpNone.Location = new System.Drawing.Point(12, 12);
			this.grpNone.Name = "grpNone";
			this.grpNone.Size = new System.Drawing.Size(344, 85);
			this.grpNone.TabIndex = 9;
			this.grpNone.TabStop = false;
			this.grpNone.Text = "None";
			// 
			// picNone
			// 
			this.picNone.Location = new System.Drawing.Point(8, 16);
			this.picNone.Name = "picNone";
			this.picNone.Size = new System.Drawing.Size(328, 64);
			this.picNone.TabIndex = 0;
			this.picNone.TabStop = false;
			this.picNone.Paint += new System.Windows.Forms.PaintEventHandler(this.picNone_Paint);
			// 
			// Smoothing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 382);
			this.Controls.Add(this.grpHighQuality);
			this.Controls.Add(this.grpAntiAlias);
			this.Controls.Add(this.grpHighSpeed);
			this.Controls.Add(this.grpNone);
			this.Name = "Smoothing";
			this.Text = "Smoothing";
			this.grpHighQuality.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picHighQuality)).EndInit();
			this.grpAntiAlias.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picAntialias)).EndInit();
			this.grpHighSpeed.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picHighSpeed)).EndInit();
			this.grpNone.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picNone)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpHighQuality;
		private System.Windows.Forms.PictureBox picHighQuality;
		private System.Windows.Forms.GroupBox grpAntiAlias;
		private System.Windows.Forms.PictureBox picAntialias;
		private System.Windows.Forms.GroupBox grpHighSpeed;
		private System.Windows.Forms.PictureBox picHighSpeed;
		private System.Windows.Forms.GroupBox grpNone;
		private System.Windows.Forms.PictureBox picNone;
	}
}