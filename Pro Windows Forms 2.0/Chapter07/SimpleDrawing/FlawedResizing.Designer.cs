namespace SimpleDrawing
{
	partial class FlawedResizing
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
            this.chkResizeRedraw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkResizeRedraw
            // 
            this.chkResizeRedraw.AutoSize = true;
            this.chkResizeRedraw.Location = new System.Drawing.Point(102, 104);
            this.chkResizeRedraw.Name = "chkResizeRedraw";
            this.chkResizeRedraw.Size = new System.Drawing.Size(95, 17);
            this.chkResizeRedraw.TabIndex = 0;
            this.chkResizeRedraw.Text = "ResizeRedraw";
            this.chkResizeRedraw.CheckedChanged += new System.EventHandler(this.chkResizeRedraw_CheckedChanged);
            // 
            // FlawedResizing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.chkResizeRedraw);
            this.Name = "FlawedResizing";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FlawedResizing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FlawedResizing_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkResizeRedraw;
	}
}