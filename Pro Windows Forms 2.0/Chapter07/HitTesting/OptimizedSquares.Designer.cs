namespace HitTesting
{
	partial class OptimizedSquares
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
			this.lblCount = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblCount
			// 
			this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblCount.Location = new System.Drawing.Point(0, 245);
			this.lblCount.Name = "lblCount";
			this.lblCount.Padding = new System.Windows.Forms.Padding(2);
			this.lblCount.Size = new System.Drawing.Size(292, 21);
			this.lblCount.TabIndex = 1;
			// 
			// OptimizedSquares
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.lblCount);
			this.Name = "OptimizedSquares";
			this.Text = "OptimizedSquares";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSquare_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawSquare_MouseDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblCount;
	}
}