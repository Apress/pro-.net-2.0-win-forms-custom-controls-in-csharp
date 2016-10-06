namespace CustomControlTest
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
            this.numericTextBox1 = new CustomControl.NumericTextBox();
            this.SuspendLayout();
// 
// numericTextBox1
// 
            this.numericTextBox1.Location = new System.Drawing.Point(13, 13);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.TabIndex = 0;
// 
// Form1
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(248, 130);
            this.Controls.Add(this.numericTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.NumericTextBox numericTextBox1;

    }
}

