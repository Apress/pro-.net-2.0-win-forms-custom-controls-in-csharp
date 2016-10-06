namespace Clipping
{
	partial class Form1
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
			this.chkClipping = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// chkClipping
			// 
			this.chkClipping.AutoSize = true;
			this.chkClipping.Checked = true;
			this.chkClipping.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkClipping.Location = new System.Drawing.Point(12, 300);
			this.chkClipping.Name = "chkClipping";
			this.chkClipping.Size = new System.Drawing.Size(80, 17);
			this.chkClipping.TabIndex = 0;
			this.chkClipping.Text = "Use Clipping";
			this.chkClipping.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 329);
			this.Controls.Add(this.chkClipping);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Clipping";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkClipping;
	}
}

