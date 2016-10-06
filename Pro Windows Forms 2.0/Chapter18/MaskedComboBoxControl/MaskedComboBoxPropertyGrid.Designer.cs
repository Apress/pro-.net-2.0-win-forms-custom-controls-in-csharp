namespace MaskedComboBoxControl
{
	partial class MaskedComboBoxPropertyGrid
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
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// maskedComboBox1
			// 
			this.maskedComboBox1.FormattingEnabled = true;
			this.maskedComboBox1.Location = new System.Drawing.Point(12, 12);
			this.maskedComboBox1.Mask = "";
			this.maskedComboBox1.Name = "maskedComboBox1";
			this.maskedComboBox1.Size = new System.Drawing.Size(121, 21);
			this.maskedComboBox1.TabIndex = 0;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Location = new System.Drawing.Point(12, 52);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.SelectedObject = this.maskedComboBox1;
			this.propertyGrid1.Size = new System.Drawing.Size(242, 202);
			this.propertyGrid1.TabIndex = 1;
			// 
			// MaskedComboBoxPropertyGrid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.maskedComboBox1);
			this.Name = "MaskedComboBoxPropertyGrid";
			this.Text = "MaskedComboBoxPropertyGrid";
			this.Load += new System.EventHandler(this.MaskedComboBoxPropertyGrid_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MaskedComboBox maskedComboBox1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
	}
}