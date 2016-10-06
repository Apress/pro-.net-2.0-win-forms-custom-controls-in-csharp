namespace FontViewer
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lstFonts = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lstFonts);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(7, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 40);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// lstFonts
			// 
			this.lstFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstFonts.DropDownWidth = 340;
			this.lstFonts.FormattingEnabled = true;
			this.lstFonts.Location = new System.Drawing.Point(100, 12);
			this.lstFonts.Name = "lstFonts";
			this.lstFonts.Size = new System.Drawing.Size(340, 21);
			this.lstFonts.TabIndex = 1;
			this.lstFonts.SelectedIndexChanged += new System.EventHandler(this.lstFonts_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Choose Font:";
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
			this.statusBar.Location = new System.Drawing.Point(0, 155);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(516, 22);
			this.statusBar.TabIndex = 2;
			this.statusBar.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 177);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusBar);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "FontViewer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.groupBox1.ResumeLayout(false);
			this.statusBar.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox lstFonts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
	}
}

