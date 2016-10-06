namespace ColorChanger
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
			this.lblSaturation = new System.Windows.Forms.Label();
			this.lblHue = new System.Windows.Forms.Label();
			this.lblBrightness = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lstColors = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lblSaturation
			// 
			this.lblSaturation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblSaturation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSaturation.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblSaturation.Location = new System.Drawing.Point(268, 57);
			this.lblSaturation.Name = "lblSaturation";
			this.lblSaturation.Size = new System.Drawing.Size(136, 20);
			this.lblSaturation.TabIndex = 4;
			this.lblSaturation.Text = " Saturation";
			// 
			// lblHue
			// 
			this.lblHue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblHue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHue.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblHue.Location = new System.Drawing.Point(268, 33);
			this.lblHue.Name = "lblHue";
			this.lblHue.Size = new System.Drawing.Size(136, 20);
			this.lblHue.TabIndex = 3;
			this.lblHue.Text = " Hue";
			// 
			// lblBrightness
			// 
			this.lblBrightness.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblBrightness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBrightness.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblBrightness.Location = new System.Drawing.Point(268, 9);
			this.lblBrightness.Name = "lblBrightness";
			this.lblBrightness.Size = new System.Drawing.Size(136, 20);
			this.lblBrightness.TabIndex = 2;
			this.lblBrightness.Text = " Brightness";
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Label1.Location = new System.Drawing.Point(12, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(200, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = " Choose a Background Color:";
			// 
			// lstColors
			// 
			this.lstColors.FormattingEnabled = true;
			this.lstColors.Location = new System.Drawing.Point(12, 37);
			this.lstColors.Name = "lstColors";
			this.lstColors.Size = new System.Drawing.Size(200, 238);
			this.lstColors.TabIndex = 1;
			this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 284);
			this.Controls.Add(this.lblSaturation);
			this.Controls.Add(this.lblHue);
			this.Controls.Add(this.lblBrightness);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lstColors);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Color Changer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblSaturation;
		private System.Windows.Forms.Label lblHue;
		private System.Windows.Forms.Label lblBrightness;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ListBox lstColors;

	}
}

