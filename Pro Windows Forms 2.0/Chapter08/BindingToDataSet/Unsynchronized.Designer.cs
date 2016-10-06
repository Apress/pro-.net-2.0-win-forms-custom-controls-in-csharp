namespace BindingToDataSet
{
	partial class Unsynchronized
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
			this.grpB = new System.Windows.Forms.GroupBox();
			this.lstModelNameB = new System.Windows.Forms.ListBox();
			this.grpA = new System.Windows.Forms.GroupBox();
			this.lstModelNameA = new System.Windows.Forms.ListBox();
			this.grpB.SuspendLayout();
			this.grpA.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpB
			// 
			this.grpB.Controls.Add(this.lstModelNameB);
			this.grpB.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpB.Location = new System.Drawing.Point(6, 134);
			this.grpB.Name = "grpB";
			this.grpB.Size = new System.Drawing.Size(280, 136);
			this.grpB.TabIndex = 7;
			this.grpB.TabStop = false;
			// 
			// lstModelNameB
			// 
			this.lstModelNameB.FormattingEnabled = true;
			this.lstModelNameB.Location = new System.Drawing.Point(16, 24);
			this.lstModelNameB.Name = "lstModelNameB";
			this.lstModelNameB.Size = new System.Drawing.Size(248, 95);
			this.lstModelNameB.TabIndex = 1;
			// 
			// grpA
			// 
			this.grpA.Controls.Add(this.lstModelNameA);
			this.grpA.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpA.Location = new System.Drawing.Point(6, -3);
			this.grpA.Name = "grpA";
			this.grpA.Size = new System.Drawing.Size(280, 136);
			this.grpA.TabIndex = 6;
			this.grpA.TabStop = false;
			// 
			// lstModelNameA
			// 
			this.lstModelNameA.FormattingEnabled = true;
			this.lstModelNameA.Location = new System.Drawing.Point(16, 24);
			this.lstModelNameA.Name = "lstModelNameA";
			this.lstModelNameA.Size = new System.Drawing.Size(248, 95);
			this.lstModelNameA.TabIndex = 0;
			// 
			// Unsynchronized
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 285);
			this.Controls.Add(this.grpB);
			this.Controls.Add(this.grpA);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Unsynchronized";
			this.Text = "Unsynchronized";
			this.Load += new System.EventHandler(this.Unsynchronized_Load);
			this.grpB.ResumeLayout(false);
			this.grpA.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpB;
		private System.Windows.Forms.ListBox lstModelNameB;
		private System.Windows.Forms.GroupBox grpA;
		private System.Windows.Forms.ListBox lstModelNameA;
	}
}