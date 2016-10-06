namespace SimpleDrawing
{
	partial class SmoothingText
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
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.Color.White;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label3.Location = new System.Drawing.Point(271, 171);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(128, 16);
			this.Label3.TabIndex = 8;
			this.Label3.Text = " ClearTypeGridFit";
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.Color.White;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label2.Location = new System.Drawing.Point(271, 103);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(128, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = " AntiAliasGridFit";
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.White;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label1.Location = new System.Drawing.Point(271, 39);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(128, 16);
			this.Label1.TabIndex = 6;
			this.Label1.Text = " SingleBitPerPixelGridFit";
			// 
			// SmoothingText
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 315);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Name = "SmoothingText";
			this.Text = "SmoothingText";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.SmoothingText_Paint);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
	}
}