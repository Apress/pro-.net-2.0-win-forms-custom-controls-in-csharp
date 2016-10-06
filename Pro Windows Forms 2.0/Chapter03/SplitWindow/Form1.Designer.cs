namespace SplitWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlFileList = new System.Windows.Forms.Panel();
            this.cmdHide = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.cmdShow = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlFileList.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(29, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlFileList);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(477, 366);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // pnlFileList
            // 
            this.pnlFileList.Controls.Add(this.cmdHide);
            this.pnlFileList.Controls.Add(this.ListView1);
            this.pnlFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFileList.Location = new System.Drawing.Point(0, 0);
            this.pnlFileList.Name = "pnlFileList";
            this.pnlFileList.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnlFileList.Size = new System.Drawing.Size(155, 366);
            this.pnlFileList.TabIndex = 21;
            // 
            // cmdHide
            // 
            this.cmdHide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdHide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdHide.Location = new System.Drawing.Point(0, 346);
            this.cmdHide.Name = "cmdHide";
            this.cmdHide.Size = new System.Drawing.Size(154, 20);
            this.cmdHide.TabIndex = 23;
            this.cmdHide.Text = "<< Hide";
            this.cmdHide.Click += new System.EventHandler(this.cmdHide_Click);
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1});
            this.ListView1.Location = new System.Drawing.Point(0, 3);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(152, 337);
            this.ListView1.TabIndex = 22;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Name = "ColumnHeader1";
            this.ColumnHeader1.Text = "File";
            this.ColumnHeader1.Width = 99;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TextBox1);
            this.splitContainer2.Size = new System.Drawing.Size(318, 366);
            this.splitContainer2.SplitterDistance = 173;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(318, 173);
            this.webBrowser1.TabIndex = 0;
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(318, 189);
            this.TextBox1.TabIndex = 1;
            // 
            // pnlShow
            // 
            this.pnlShow.Controls.Add(this.cmdShow);
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShow.Location = new System.Drawing.Point(10, 10);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pnlShow.Size = new System.Drawing.Size(19, 366);
            this.pnlShow.TabIndex = 23;
            this.pnlShow.Visible = false;
            // 
            // cmdShow
            // 
            this.cmdShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdShow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShow.Location = new System.Drawing.Point(0, 0);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(16, 366);
            this.cmdShow.TabIndex = 21;
            this.cmdShow.Text = ">";
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 386);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlShow);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Split Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnlFileList.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.pnlShow.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.Panel pnlFileList;
		private System.Windows.Forms.Button cmdHide;
		private System.Windows.Forms.ListView ListView1;
		private System.Windows.Forms.ColumnHeader ColumnHeader1;
		private System.Windows.Forms.Panel pnlShow;
		private System.Windows.Forms.Button cmdShow;
	}
}

