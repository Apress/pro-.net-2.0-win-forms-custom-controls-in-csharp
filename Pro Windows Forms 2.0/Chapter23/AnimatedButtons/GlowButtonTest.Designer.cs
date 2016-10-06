namespace AnimatedButtons
{
	partial class GlowButtonTest
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
			this.simpleGlowButton1 = new AnimatedButtons.SimpleGlowButton();
			this.simpleGlowButton2 = new AnimatedButtons.SimpleGlowButton();
			this.simpleGlowButton3 = new AnimatedButtons.SimpleGlowButton();
			this.SuspendLayout();
			// 
			// simpleGlowButton1
			// 
			this.simpleGlowButton1.CacheImages = true;
			this.simpleGlowButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.simpleGlowButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleGlowButton1.Location = new System.Drawing.Point(30, 28);
			this.simpleGlowButton1.Name = "simpleGlowButton1";
			this.simpleGlowButton1.PaintFocusCue = true;
			this.simpleGlowButton1.Size = new System.Drawing.Size(132, 23);
			this.simpleGlowButton1.TabIndex = 1;
			this.simpleGlowButton1.Text = "simpleGlowButton1";
			this.simpleGlowButton1.Click += new System.EventHandler(this.simpleGlowButton1_Click);
			// 
			// simpleGlowButton2
			// 
			this.simpleGlowButton2.CacheImages = true;
			this.simpleGlowButton2.DialogResult = System.Windows.Forms.DialogResult.None;
			this.simpleGlowButton2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleGlowButton2.Location = new System.Drawing.Point(30, 68);
			this.simpleGlowButton2.Name = "simpleGlowButton2";
			this.simpleGlowButton2.PaintFocusCue = true;
			this.simpleGlowButton2.Size = new System.Drawing.Size(132, 23);
			this.simpleGlowButton2.TabIndex = 2;
			this.simpleGlowButton2.Text = "simpleGlowButton2";
			// 
			// simpleGlowButton3
			// 
			this.simpleGlowButton3.CacheImages = true;
			this.simpleGlowButton3.DialogResult = System.Windows.Forms.DialogResult.None;
			this.simpleGlowButton3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleGlowButton3.Location = new System.Drawing.Point(30, 108);
			this.simpleGlowButton3.Name = "simpleGlowButton3";
			this.simpleGlowButton3.PaintFocusCue = true;
			this.simpleGlowButton3.Size = new System.Drawing.Size(132, 23);
			this.simpleGlowButton3.TabIndex = 3;
			this.simpleGlowButton3.Text = "simpleGlowButton3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.simpleGlowButton3);
			this.Controls.Add(this.simpleGlowButton2);
			this.Controls.Add(this.simpleGlowButton1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "ButtonTest";
			this.ResumeLayout(false);

		}

		#endregion

		private SimpleGlowButton simpleGlowButton1;
		private SimpleGlowButton simpleGlowButton2;
		private SimpleGlowButton simpleGlowButton3;



	}
}

