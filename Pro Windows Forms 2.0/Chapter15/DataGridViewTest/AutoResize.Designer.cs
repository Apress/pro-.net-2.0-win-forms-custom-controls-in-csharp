namespace DataGridViewTest
{
	partial class AutoResize
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optWrapDesc = new System.Windows.Forms.RadioButton();
            this.optNoWrap = new System.Windows.Forms.RadioButton();
            this.optAllWrap = new System.Windows.Forms.RadioButton();
            this.lstAutoSizeRows = new System.Windows.Forms.ComboBox();
            this.lstAutoSizeColumns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 317);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.optWrapDesc);
            this.panel1.Controls.Add(this.optNoWrap);
            this.panel1.Controls.Add(this.optAllWrap);
            this.panel1.Controls.Add(this.lstAutoSizeRows);
            this.panel1.Controls.Add(this.lstAutoSizeColumns);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 51);
            this.panel1.TabIndex = 2;
            // 
            // optWrapDesc
            // 
            this.optWrapDesc.AutoSize = true;
            this.optWrapDesc.Location = new System.Drawing.Point(331, 33);
            this.optWrapDesc.Name = "optWrapDesc";
            this.optWrapDesc.Size = new System.Drawing.Size(132, 17);
            this.optWrapDesc.TabIndex = 6;
            this.optWrapDesc.Text = "Wrap Description Only";
            this.optWrapDesc.CheckedChanged += new System.EventHandler(this.optWrapDesc_CheckedChanged);
            // 
            // optNoWrap
            // 
            this.optNoWrap.AutoSize = true;
            this.optNoWrap.Location = new System.Drawing.Point(331, 17);
            this.optNoWrap.Name = "optNoWrap";
            this.optNoWrap.Size = new System.Drawing.Size(110, 17);
            this.optNoWrap.TabIndex = 5;
            this.optNoWrap.Text = "Wrap No Columns";
            this.optNoWrap.CheckedChanged += new System.EventHandler(this.optNoWrap_CheckedChanged);
            // 
            // optAllWrap
            // 
            this.optAllWrap.AutoSize = true;
            this.optAllWrap.Location = new System.Drawing.Point(331, 1);
            this.optAllWrap.Name = "optAllWrap";
            this.optAllWrap.Size = new System.Drawing.Size(108, 17);
            this.optAllWrap.TabIndex = 4;
            this.optAllWrap.Text = "Wrap All Columns";
            this.optAllWrap.CheckedChanged += new System.EventHandler(this.optAllWrap_CheckedChanged);
            // 
            // lstAutoSizeRows
            // 
            this.lstAutoSizeRows.CausesValidation = false;
            this.lstAutoSizeRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstAutoSizeRows.FormattingEnabled = true;
            this.lstAutoSizeRows.Location = new System.Drawing.Point(133, 24);
            this.lstAutoSizeRows.Name = "lstAutoSizeRows";
            this.lstAutoSizeRows.Size = new System.Drawing.Size(144, 21);
            this.lstAutoSizeRows.TabIndex = 3;
            this.lstAutoSizeRows.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // lstAutoSizeColumns
            // 
            this.lstAutoSizeColumns.CausesValidation = false;
            this.lstAutoSizeColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstAutoSizeColumns.FormattingEnabled = true;
            this.lstAutoSizeColumns.Location = new System.Drawing.Point(133, 1);
            this.lstAutoSizeColumns.Name = "lstAutoSizeColumns";
            this.lstAutoSizeColumns.Size = new System.Drawing.Size(144, 21);
            this.lstAutoSizeColumns.TabIndex = 2;
            this.lstAutoSizeColumns.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AutoSizeRowsMode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AutoSizeColumnsMode:";
            // 
            // AutoResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AutoResize";
            this.Text = "AutoResize";
            this.Load += new System.EventHandler(this.AutoResize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox lstAutoSizeColumns;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox lstAutoSizeRows;
		private System.Windows.Forms.RadioButton optNoWrap;
		private System.Windows.Forms.RadioButton optAllWrap;
		private System.Windows.Forms.RadioButton optWrapDesc;
	}
}