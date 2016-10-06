namespace BindingToDataSet
{
	partial class BindToImage
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.picProduct = new System.Windows.Forms.PictureBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.cboModelName = new System.Windows.Forms.ComboBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.picProduct);
			this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GroupBox1.Location = new System.Drawing.Point(12, 44);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(191, 148);
			this.GroupBox1.TabIndex = 26;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Display Value for ProductImage";
			// 
			// picProduct
			// 
			this.picProduct.Location = new System.Drawing.Point(16, 24);
			this.picProduct.Name = "picProduct";
			this.picProduct.Size = new System.Drawing.Size(128, 88);
			this.picProduct.TabIndex = 18;
			this.picProduct.TabStop = false;
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(20, 12);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 16);
			this.Label1.TabIndex = 25;
			this.Label1.Text = "Product:";
			// 
			// cboModelName
			// 
			this.cboModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboModelName.FormattingEnabled = true;
			this.cboModelName.Location = new System.Drawing.Point(84, 8);
			this.cboModelName.Name = "cboModelName";
			this.cboModelName.Size = new System.Drawing.Size(248, 21);
			this.cboModelName.TabIndex = 23;
			// 
			// lblStatus
			// 
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblStatus.Location = new System.Drawing.Point(0, 215);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Padding = new System.Windows.Forms.Padding(3);
			this.lblStatus.Size = new System.Drawing.Size(355, 21);
			this.lblStatus.TabIndex = 27;
			// 
			// BindToImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 236);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cboModelName);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "BindToImage";
			this.Text = "Bind To Image";
			this.Load += new System.EventHandler(this.BindToImage_Load);
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.PictureBox picProduct;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ComboBox cboModelName;
		private System.Windows.Forms.Label lblStatus;
	}
}