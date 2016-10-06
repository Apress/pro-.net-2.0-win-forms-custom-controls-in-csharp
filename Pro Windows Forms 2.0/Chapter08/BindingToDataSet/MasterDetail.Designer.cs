namespace BindingToDataSet
{
	partial class MasterDetail
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
			this.lstProduct = new System.Windows.Forms.ListBox();
			this.lstCategory = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(212, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(120, 16);
			this.Label2.TabIndex = 13;
			this.Label2.Text = "Products:";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(12, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 16);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "Categories:";
			// 
			// lstProduct
			// 
			this.lstProduct.FormattingEnabled = true;
			this.lstProduct.Location = new System.Drawing.Point(212, 25);
			this.lstProduct.Name = "lstProduct";
			this.lstProduct.Size = new System.Drawing.Size(208, 225);
			this.lstProduct.TabIndex = 11;
			// 
			// lstCategory
			// 
			this.lstCategory.FormattingEnabled = true;
			this.lstCategory.Location = new System.Drawing.Point(12, 25);
			this.lstCategory.Name = "lstCategory";
			this.lstCategory.Size = new System.Drawing.Size(192, 225);
			this.lstCategory.TabIndex = 10;
			// 
			// MasterDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 266);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lstProduct);
			this.Controls.Add(this.lstCategory);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MasterDetail";
			this.Text = "Master Detail";
			this.Load += new System.EventHandler(this.MasterDetail_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ListBox lstProduct;
		private System.Windows.Forms.ListBox lstCategory;
	}
}