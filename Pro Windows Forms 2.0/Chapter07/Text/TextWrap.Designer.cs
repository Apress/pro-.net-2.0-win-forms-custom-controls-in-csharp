namespace Text
{
	partial class TextWrap
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
			this.label2 = new System.Windows.Forms.Label();
			this.lstAlignmentH = new System.Windows.Forms.ComboBox();
			this.lstTrimming = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lstAlignmentV = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Alignment (Horizontal):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Trimming:";
			// 
			// lstAlignmentH
			// 
			this.lstAlignmentH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstAlignmentH.FormattingEnabled = true;
			this.lstAlignmentH.Location = new System.Drawing.Point(131, 16);
			this.lstAlignmentH.Name = "lstAlignmentH";
			this.lstAlignmentH.Size = new System.Drawing.Size(121, 21);
			this.lstAlignmentH.TabIndex = 2;
			this.lstAlignmentH.SelectedIndexChanged += new System.EventHandler(this.lst_Changed);
			// 
			// lstTrimming
			// 
			this.lstTrimming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstTrimming.FormattingEnabled = true;
			this.lstTrimming.Location = new System.Drawing.Point(131, 69);
			this.lstTrimming.Name = "lstTrimming";
			this.lstTrimming.Size = new System.Drawing.Size(121, 21);
			this.lstTrimming.TabIndex = 3;
			this.lstTrimming.SelectedIndexChanged += new System.EventHandler(this.lst_Changed);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Alignment (Vertical):";
			// 
			// lstAlignmentV
			// 
			this.lstAlignmentV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstAlignmentV.FormattingEnabled = true;
			this.lstAlignmentV.Location = new System.Drawing.Point(131, 42);
			this.lstAlignmentV.Name = "lstAlignmentV";
			this.lstAlignmentV.Size = new System.Drawing.Size(121, 21);
			this.lstAlignmentV.TabIndex = 5;
			this.lstAlignmentV.SelectedIndexChanged += new System.EventHandler(this.lst_Changed);
			// 
			// TextWrap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 296);
			this.Controls.Add(this.lstAlignmentV);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lstTrimming);
			this.Controls.Add(this.lstAlignmentH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "TextWrap";
			this.Text = "Text Wrap";
			this.Load += new System.EventHandler(this.TextWrap_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.TextWrap_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox lstAlignmentH;
		private System.Windows.Forms.ComboBox lstTrimming;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox lstAlignmentV;
	}
}

