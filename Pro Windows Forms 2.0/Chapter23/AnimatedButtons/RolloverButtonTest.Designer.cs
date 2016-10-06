namespace AnimatedButtons
{
	partial class RolloverButtonTest
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
            this.rolloverButton3 = new AnimatedButtons.RolloverButton();
            this.rolloverButton2 = new AnimatedButtons.RolloverButton();
            this.rolloverButton1 = new AnimatedButtons.RolloverButton();
            this.SuspendLayout();
            // 
            // rolloverButton3
            // 
            this.rolloverButton3.BackColor = System.Drawing.Color.Transparent;
            this.rolloverButton3.CacheImages = true;
            this.rolloverButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rolloverButton3.DisabledImage = null;
            this.rolloverButton3.Location = new System.Drawing.Point(197, 209);
            this.rolloverButton3.MouseOverImage = global::AnimatedButtons.Properties.Resources.buttonDSE_2;
            this.rolloverButton3.Name = "rolloverButton3";
            this.rolloverButton3.NormalImage = global::AnimatedButtons.Properties.Resources.buttonDSE_1;
            this.rolloverButton3.PaintFocusCue = true;
            this.rolloverButton3.PushedImage = null;
            this.rolloverButton3.Size = new System.Drawing.Size(196, 39);
            this.rolloverButton3.TabIndex = 2;
            this.rolloverButton3.Text = "rolloverButton3";
            // 
            // rolloverButton2
            // 
            this.rolloverButton2.BackColor = System.Drawing.Color.Transparent;
            this.rolloverButton2.CacheImages = true;
            this.rolloverButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rolloverButton2.DisabledImage = null;
            this.rolloverButton2.Location = new System.Drawing.Point(135, 132);
            this.rolloverButton2.MouseOverImage = global::AnimatedButtons.Properties.Resources.buttonDS_2;
            this.rolloverButton2.Name = "rolloverButton2";
            this.rolloverButton2.NormalImage = global::AnimatedButtons.Properties.Resources.buttonDS_1;
            this.rolloverButton2.PaintFocusCue = true;
            this.rolloverButton2.PushedImage = global::AnimatedButtons.Properties.Resources.buttonDS_3;
            this.rolloverButton2.Size = new System.Drawing.Size(196, 39);
            this.rolloverButton2.TabIndex = 1;
            this.rolloverButton2.Text = "rolloverButton2";
            // 
            // rolloverButton1
            // 
            this.rolloverButton1.BackColor = System.Drawing.Color.Transparent;
            this.rolloverButton1.CacheImages = false;
            this.rolloverButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rolloverButton1.DisabledImage = null;
            this.rolloverButton1.Location = new System.Drawing.Point(261, 284);
            this.rolloverButton1.MouseOverImage = global::AnimatedButtons.Properties.Resources.buttonC_2;
            this.rolloverButton1.Name = "rolloverButton1";
            this.rolloverButton1.NormalImage = global::AnimatedButtons.Properties.Resources.buttonC_1;
            this.rolloverButton1.PaintFocusCue = true;
            this.rolloverButton1.PushedImage = global::AnimatedButtons.Properties.Resources.buttonC_3;
            this.rolloverButton1.Size = new System.Drawing.Size(197, 40);
            this.rolloverButton1.TabIndex = 0;
            this.rolloverButton1.Text = "rolloverButton1";
            this.rolloverButton1.Click += new System.EventHandler(this.rolloverButton1_Click);
            // 
            // RolloverButtonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AnimatedButtons.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(596, 480);
            this.Controls.Add(this.rolloverButton3);
            this.Controls.Add(this.rolloverButton2);
            this.Controls.Add(this.rolloverButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RolloverButtonTest";
            this.Text = "RolloverTest";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.ResumeLayout(false);

		}

		#endregion

		private RolloverButton rolloverButton2;
		private RolloverButton rolloverButton1;
		private RolloverButton rolloverButton3;





	}
}