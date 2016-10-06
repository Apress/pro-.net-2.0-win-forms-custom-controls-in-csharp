namespace BindingUnusualProperties
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
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lstFonts = new System.Windows.Forms.ListBox();
			this.lblSampleText = new System.Windows.Forms.Label();
			this.lstColors = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(209, 11);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(140, 12);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Choose a Font:";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(13, 11);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(140, 12);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Choose a Color:";
			// 
			// lstFonts
			// 
			this.lstFonts.FormattingEnabled = true;
			this.lstFonts.Location = new System.Drawing.Point(209, 27);
			this.lstFonts.Name = "lstFonts";
			this.lstFonts.Size = new System.Drawing.Size(180, 134);
			this.lstFonts.TabIndex = 12;
			// 
			// lblSampleText
			// 
			this.lblSampleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblSampleText.Location = new System.Drawing.Point(17, 183);
			this.lblSampleText.Name = "lblSampleText";
			this.lblSampleText.Size = new System.Drawing.Size(372, 96);
			this.lblSampleText.TabIndex = 11;
			this.lblSampleText.Text = "Click an item in one of the lists above to change the font or color of this text." +
				" Once the initial conditions are set up (i.e., the binding), this operation happ" +
				"ens automatically.";
			// 
			// lstColors
			// 
			this.lstColors.FormattingEnabled = true;
			this.lstColors.Location = new System.Drawing.Point(13, 27);
			this.lstColors.Name = "lstColors";
			this.lstColors.Size = new System.Drawing.Size(176, 134);
			this.lstColors.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 291);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lstFonts);
			this.Controls.Add(this.lblSampleText);
			this.Controls.Add(this.lstColors);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Binding Unsual Properties";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ListBox lstFonts;
		private System.Windows.Forms.Label lblSampleText;
		private System.Windows.Forms.ListBox lstColors;
	}
}

