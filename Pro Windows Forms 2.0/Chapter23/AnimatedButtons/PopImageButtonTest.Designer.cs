namespace AnimatedButtons
{
    partial class PopImageButtonTest
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
            this.popImageButton3 = new AnimatedButtons.PopImageButton();
            this.popImageButton2 = new AnimatedButtons.PopImageButton();
            this.popImageButton1 = new AnimatedButtons.PopImageButton();
            this.SuspendLayout();
            // 
            // popImageButton3
            // 
            this.popImageButton3.CacheImages = true;
            this.popImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.popImageButton3.Image = global::AnimatedButtons.Properties.Resources.Folder;
            this.popImageButton3.Location = new System.Drawing.Point(67, 121);
            this.popImageButton3.Name = "popImageButton3";
            this.popImageButton3.PaintFocusCue = true;
            this.popImageButton3.Size = new System.Drawing.Size(116, 35);
            this.popImageButton3.TabIndex = 2;
            this.popImageButton3.Text = "popImageButton3";
            // 
            // popImageButton2
            // 
            this.popImageButton2.CacheImages = true;
            this.popImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.popImageButton2.Enabled = false;
            this.popImageButton2.Image = global::AnimatedButtons.Properties.Resources.Key;
            this.popImageButton2.Location = new System.Drawing.Point(67, 76);
            this.popImageButton2.Name = "popImageButton2";
            this.popImageButton2.PaintFocusCue = true;
            this.popImageButton2.Size = new System.Drawing.Size(116, 23);
            this.popImageButton2.TabIndex = 1;
            this.popImageButton2.Text = "popImageButton2";
            // 
            // popImageButton1
            // 
            this.popImageButton1.CacheImages = true;
            this.popImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.popImageButton1.Image = global::AnimatedButtons.Properties.Resources.Key;
            this.popImageButton1.Location = new System.Drawing.Point(67, 32);
            this.popImageButton1.Name = "popImageButton1";
            this.popImageButton1.PaintFocusCue = true;
            this.popImageButton1.Size = new System.Drawing.Size(116, 23);
            this.popImageButton1.TabIndex = 0;
            this.popImageButton1.Text = "popImageButton1";
            // 
            // PopImageButtonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.popImageButton3);
            this.Controls.Add(this.popImageButton2);
            this.Controls.Add(this.popImageButton1);
            this.Name = "PopImageButtonTest";
            this.Text = "PopImageButtonTest";
            this.ResumeLayout(false);

        }

        #endregion

        private PopImageButton popImageButton1;
        private PopImageButton popImageButton2;
        private PopImageButton popImageButton3;
    }
}