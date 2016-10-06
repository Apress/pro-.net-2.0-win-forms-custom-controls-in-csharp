namespace FormOwnership
{
	partial class OwnerForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.cmdReleaseOwnership = new System.Windows.Forms.Button();
			this.cmdAddOwnership = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 80);
			this.label1.TabIndex = 7;
			this.label1.Text = "To test form ownership, try minimizing this form when the second form is owned. T" +
				"hen try, minimizing it when the second form is not owned.";
			// 
			// cmdReleaseOwnership
			// 
			this.cmdReleaseOwnership.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdReleaseOwnership.Location = new System.Drawing.Point(150, 197);
			this.cmdReleaseOwnership.Name = "cmdReleaseOwnership";
			this.cmdReleaseOwnership.Size = new System.Drawing.Size(128, 32);
			this.cmdReleaseOwnership.TabIndex = 6;
			this.cmdReleaseOwnership.Text = "Remove Ownership";
			this.cmdReleaseOwnership.Click += new System.EventHandler(this.cmdReleaseOwnership_Click);
			// 
			// cmdAddOwnership
			// 
			this.cmdAddOwnership.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdAddOwnership.Location = new System.Drawing.Point(14, 197);
			this.cmdAddOwnership.Name = "cmdAddOwnership";
			this.cmdAddOwnership.Size = new System.Drawing.Size(120, 32);
			this.cmdAddOwnership.TabIndex = 5;
			this.cmdAddOwnership.Text = "Set Ownership";
			this.cmdAddOwnership.Click += new System.EventHandler(this.cmdAddOwnership_Click);
			// 
			// OwnerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdReleaseOwnership);
			this.Controls.Add(this.cmdAddOwnership);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "OwnerForm";
			this.Text = "Owner";
			this.Load += new System.EventHandler(this.OwnerForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdReleaseOwnership;
		private System.Windows.Forms.Button cmdAddOwnership;
	}
}

