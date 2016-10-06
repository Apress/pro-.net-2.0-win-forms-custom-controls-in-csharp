namespace BindingToDataSet
{
	partial class LookupTable
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
			this.Label4 = new System.Windows.Forms.Label();
			this.cboModelName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(12, 27);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(88, 16);
			this.Label4.TabIndex = 25;
			this.Label4.Text = "Select a Record:";
			// 
			// cboModelName
			// 
			this.cboModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboModelName.FormattingEnabled = true;
			this.cboModelName.Location = new System.Drawing.Point(122, 23);
			this.cboModelName.Name = "cboModelName";
			this.cboModelName.Size = new System.Drawing.Size(267, 21);
			this.cboModelName.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 16);
			this.label1.TabIndex = 27;
			this.label1.Text = "Change its Category:";
			// 
			// cboCategory
			// 
			this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(122, 53);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(267, 21);
			this.cboCategory.TabIndex = 26;
			// 
			// LookupTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 218);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboCategory);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.cboModelName);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "LookupTable";
			this.Text = "Lookup Table";
			this.Load += new System.EventHandler(this.LookupTable_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.ComboBox cboModelName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboCategory;
	}
}