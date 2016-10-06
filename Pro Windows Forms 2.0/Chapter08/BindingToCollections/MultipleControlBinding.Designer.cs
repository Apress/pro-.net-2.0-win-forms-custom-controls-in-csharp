namespace BindingToCollections
{
	partial class MultipleControlBinding
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
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblUnitCost = new System.Windows.Forms.Label();
			this.lblModelNumber = new System.Windows.Forms.Label();
			this.cmdNext = new System.Windows.Forms.Button();
			this.cmdPrev = new System.Windows.Forms.Button();
			this.cboModelName = new System.Windows.Forms.ComboBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox1.Controls.Add(this.lblDescription);
			this.GroupBox1.Controls.Add(this.lblUnitCost);
			this.GroupBox1.Controls.Add(this.lblModelNumber);
			this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GroupBox1.Location = new System.Drawing.Point(18, 55);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(312, 174);
			this.GroupBox1.TabIndex = 14;
			this.GroupBox1.TabStop = false;
			// 
			// lblDescription
			// 
			this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblDescription.Location = new System.Drawing.Point(8, 58);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(296, 104);
			this.lblDescription.TabIndex = 6;
			// 
			// lblUnitCost
			// 
			this.lblUnitCost.Location = new System.Drawing.Point(168, 16);
			this.lblUnitCost.Name = "lblUnitCost";
			this.lblUnitCost.Size = new System.Drawing.Size(136, 32);
			this.lblUnitCost.TabIndex = 5;
			// 
			// lblModelNumber
			// 
			this.lblModelNumber.Location = new System.Drawing.Point(8, 16);
			this.lblModelNumber.Name = "lblModelNumber";
			this.lblModelNumber.Size = new System.Drawing.Size(140, 32);
			this.lblModelNumber.TabIndex = 4;
			// 
			// cmdNext
			// 
			this.cmdNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdNext.Location = new System.Drawing.Point(238, 241);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(92, 28);
			this.cmdNext.TabIndex = 13;
			this.cmdNext.Text = "Next >>";
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			// 
			// cmdPrev
			// 
			this.cmdPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdPrev.Enabled = false;
			this.cmdPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdPrev.Location = new System.Drawing.Point(18, 241);
			this.cmdPrev.Name = "cmdPrev";
			this.cmdPrev.Size = new System.Drawing.Size(92, 28);
			this.cmdPrev.TabIndex = 12;
			this.cmdPrev.Text = "<< Prev";
			this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
			// 
			// cboModelName
			// 
			this.cboModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboModelName.FormattingEnabled = true;
			this.cboModelName.Location = new System.Drawing.Point(14, 19);
			this.cboModelName.Name = "cboModelName";
			this.cboModelName.Size = new System.Drawing.Size(316, 21);
			this.cboModelName.TabIndex = 11;
			// 
			// MultipleControlBinding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 282);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.cmdNext);
			this.Controls.Add(this.cmdPrev);
			this.Controls.Add(this.cboModelName);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MultipleControlBinding";
			this.Text = "Multiple Control Binding";
			this.Load += new System.EventHandler(this.MultipleControlBinding_Load);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblUnitCost;
		private System.Windows.Forms.Label lblModelNumber;
		private System.Windows.Forms.Button cmdNext;
		private System.Windows.Forms.Button cmdPrev;
		private System.Windows.Forms.ComboBox cboModelName;
	}
}