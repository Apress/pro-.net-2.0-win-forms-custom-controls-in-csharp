namespace MaskedComboBoxControl
{
	partial class MaskedComboBoxTest
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
			this.maskedComboBox1 = new MaskedComboBoxControl.MaskedComboBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// maskedComboBox1
			// 
			this.maskedComboBox1.FormattingEnabled = true;
			this.maskedComboBox1.Location = new System.Drawing.Point(48, 70);
			this.maskedComboBox1.Mask = "";
			this.maskedComboBox1.Name = "maskedComboBox1";
			this.maskedComboBox1.Size = new System.Drawing.Size(121, 21);
			this.maskedComboBox1.TabIndex = 0;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(48, 97);
			this.maskedTextBox1.Mask = "(999) 000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
			this.maskedTextBox1.TabIndex = 1;
			// 
			// MaskedComboBoxTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.maskedComboBox1);
			this.Name = "MaskedComboBoxTest";
			this.Text = "MaskedComboBox Test";
			this.Load += new System.EventHandler(this.MaskedComboBoxTest_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaskedComboBox maskedComboBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}