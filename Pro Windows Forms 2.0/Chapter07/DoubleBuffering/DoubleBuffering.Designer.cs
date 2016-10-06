namespace DoubleBuffering
{
	partial class DoubleBuffering
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
			this.components = new System.ComponentModel.Container();
			this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
			this.chkDoubleBuffer = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// tmrRefresh
			// 
			this.tmrRefresh.Interval = 10;
			this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
			// 
			// chkDoubleBuffer
			// 
			this.chkDoubleBuffer.BackColor = System.Drawing.Color.PaleTurquoise;
			this.chkDoubleBuffer.Location = new System.Drawing.Point(12, 12);
			this.chkDoubleBuffer.Name = "chkDoubleBuffer";
			this.chkDoubleBuffer.Size = new System.Drawing.Size(336, 16);
			this.chkDoubleBuffer.TabIndex = 2;
			this.chkDoubleBuffer.Text = "Use Double Buffering";
			this.chkDoubleBuffer.UseVisualStyleBackColor = false;
			// 
			// DoubleBuffering
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 373);
			this.Controls.Add(this.chkDoubleBuffer);
			this.Name = "DoubleBuffering";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.DoubleBuffering_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DoubleBuffering_Paint);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrRefresh;
		private System.Windows.Forms.CheckBox chkDoubleBuffer;
	}
}

