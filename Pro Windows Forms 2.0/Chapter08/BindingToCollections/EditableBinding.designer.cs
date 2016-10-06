namespace BindingToCollections
{
	partial class EditableBinding
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtModelName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtUnitCost = new System.Windows.Forms.TextBox();
			this.txtModelNumber = new System.Windows.Forms.TextBox();
			this.cboModelName = new System.Windows.Forms.ComboBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(14, 21);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(88, 16);
			this.Label4.TabIndex = 23;
			this.Label4.Text = "Select a Record:";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtModelName);
			this.GroupBox1.Controls.Add(this.txtDescription);
			this.GroupBox1.Controls.Add(this.txtUnitCost);
			this.GroupBox1.Controls.Add(this.txtModelNumber);
			this.GroupBox1.Location = new System.Drawing.Point(14, 57);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(400, 234);
			this.GroupBox1.TabIndex = 22;
			this.GroupBox1.TabStop = false;
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(220, 56);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(36, 16);
			this.Label3.TabIndex = 18;
			this.Label3.Text = "Cost:";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(16, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(52, 16);
			this.Label2.TabIndex = 17;
			this.Label2.Text = "Model:";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(16, 28);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(52, 16);
			this.Label1.TabIndex = 16;
			this.Label1.Text = "Name:";
			// 
			// txtModelName
			// 
			this.txtModelName.Location = new System.Drawing.Point(68, 24);
			this.txtModelName.Name = "txtModelName";
			this.txtModelName.Size = new System.Drawing.Size(316, 21);
			this.txtModelName.TabIndex = 15;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(12, 92);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(372, 116);
			this.txtDescription.TabIndex = 14;
			// 
			// txtUnitCost
			// 
			this.txtUnitCost.Location = new System.Drawing.Point(256, 52);
			this.txtUnitCost.Name = "txtUnitCost";
			this.txtUnitCost.Size = new System.Drawing.Size(128, 21);
			this.txtUnitCost.TabIndex = 13;
			// 
			// txtModelNumber
			// 
			this.txtModelNumber.Location = new System.Drawing.Point(68, 52);
			this.txtModelNumber.Name = "txtModelNumber";
			this.txtModelNumber.Size = new System.Drawing.Size(136, 21);
			this.txtModelNumber.TabIndex = 12;
			// 
			// cboModelName
			// 
			this.cboModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboModelName.FormattingEnabled = true;
			this.cboModelName.Location = new System.Drawing.Point(106, 17);
			this.cboModelName.Name = "cboModelName";
			this.cboModelName.Size = new System.Drawing.Size(308, 21);
			this.cboModelName.TabIndex = 21;
			// 
			// lblStatus
			// 
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblStatus.Location = new System.Drawing.Point(0, 306);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Padding = new System.Windows.Forms.Padding(3);
			this.lblStatus.Size = new System.Drawing.Size(428, 21);
			this.lblStatus.TabIndex = 24;
			// 
			// EditableBinding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 327);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.cboModelName);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "EditableBinding";
			this.Text = "Editable Binding";
			this.Load += new System.EventHandler(this.EditableBinding_Load);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox txtModelName;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtUnitCost;
		private System.Windows.Forms.TextBox txtModelNumber;
		private System.Windows.Forms.ComboBox cboModelName;
		private System.Windows.Forms.Label lblStatus;
	}
}