namespace SimpleDrawing
{
	partial class SimpleDraw
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
			this.chkRepaint = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// chkRepaint
			// 
			this.chkRepaint.AutoSize = true;
			this.chkRepaint.Checked = true;
			this.chkRepaint.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRepaint.Location = new System.Drawing.Point(34, 12);
			this.chkRepaint.Name = "chkRepaint";
			this.chkRepaint.Size = new System.Drawing.Size(133, 17);
			this.chkRepaint.TabIndex = 0;
			this.chkRepaint.Text = "Update when repainted";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 266);
			this.Controls.Add(this.chkRepaint);
			this.Name = "Form1";
			this.Text = "GDI+";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkRepaint;
	}
}

