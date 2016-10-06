namespace VisualInheritance
{
	partial class Ancestor
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
			this.cmdNext = new System.Windows.Forms.Button();
			this.lblHeader = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox1.Location = new System.Drawing.Point(10, 225);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(284, 4);
			this.GroupBox1.TabIndex = 8;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "GroupBox1";
			// 
			// cmdNext
			// 
			this.cmdNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdNext.Location = new System.Drawing.Point(234, 233);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(60, 28);
			this.cmdNext.TabIndex = 7;
			this.cmdNext.Text = "Next";
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			// 
			// lblHeader
			// 
			this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(16, 16);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(262, 28);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Header Text";
			// 
			// Panel1
			// 
			this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Panel1.BackColor = System.Drawing.Color.White;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.lblHeader);
			this.Panel1.Location = new System.Drawing.Point(6, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(292, 68);
			this.Panel1.TabIndex = 6;
			// 
			// Ancestor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 266);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.cmdNext);
			this.Controls.Add(this.Panel1);
			this.Name = "Ancestor";
			this.Text = "Ancestor";
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Button cmdNext;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Panel Panel1;

	}
}