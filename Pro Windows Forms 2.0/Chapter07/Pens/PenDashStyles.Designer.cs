namespace Pens
{
	partial class PenDashStyles
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
			this.SuspendLayout();
			// 
			// PenDashStyles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 385);
			this.Name = "PenDashStyles";
			this.Text = "PenDashStyles";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenDashStyles_Paint);
			this.Resize += new System.EventHandler(this.PenDashStyles_Resize);
			this.ResumeLayout(false);

		}

		#endregion
	}
}