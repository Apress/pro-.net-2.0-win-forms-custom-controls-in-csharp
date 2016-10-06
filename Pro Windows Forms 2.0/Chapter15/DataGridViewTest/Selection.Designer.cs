namespace DataGridViewTest
{
	partial class Selection
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
			this.txtSelectionInfo = new System.Windows.Forms.TextBox();
			this.cmdSelectionInfo = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSelectionInfo
			// 
			this.txtSelectionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSelectionInfo.Location = new System.Drawing.Point(7, 7);
			this.txtSelectionInfo.Multiline = true;
			this.txtSelectionInfo.Name = "txtSelectionInfo";
			this.txtSelectionInfo.ReadOnly = true;
			this.txtSelectionInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSelectionInfo.Size = new System.Drawing.Size(395, 89);
			this.txtSelectionInfo.TabIndex = 5;
			// 
			// cmdSelectionInfo
			// 
			this.cmdSelectionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdSelectionInfo.Location = new System.Drawing.Point(408, 13);
			this.cmdSelectionInfo.Name = "cmdSelectionInfo";
			this.cmdSelectionInfo.Size = new System.Drawing.Size(89, 54);
			this.cmdSelectionInfo.TabIndex = 4;
			this.cmdSelectionInfo.Text = "Get Selection Info";
			this.cmdSelectionInfo.Click += new System.EventHandler(this.cmdSelectionInfo_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(0, -2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtSelectionInfo);
			this.splitContainer1.Panel2.Controls.Add(this.cmdSelectionInfo);
			this.splitContainer1.Size = new System.Drawing.Size(509, 370);
			this.splitContainer1.SplitterDistance = 263;
			this.splitContainer1.TabIndex = 2;
			this.splitContainer1.Text = "splitContainer1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.Location = new System.Drawing.Point(8, 7);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(495, 251);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// Selection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 367);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Selection";
			this.Text = "Selection";
			this.Load += new System.EventHandler(this.Selection_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtSelectionInfo;
		private System.Windows.Forms.Button cmdSelectionInfo;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}