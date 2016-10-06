namespace TreeViewDataBinding
{
	partial class TreeViewForm
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
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.lblInfo = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Splitter1 = new System.Windows.Forms.Splitter();
			this.treeDB = new System.Windows.Forms.TreeView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.cmdClose = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel2
			// 
			this.Panel2.Controls.Add(this.Panel3);
			this.Panel2.Controls.Add(this.Splitter1);
			this.Panel2.Controls.Add(this.treeDB);
			this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(503, 311);
			this.Panel2.TabIndex = 10;
			// 
			// Panel3
			// 
			this.Panel3.Controls.Add(this.lblInfo);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3.Location = new System.Drawing.Point(239, 0);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(264, 311);
			this.Panel3.TabIndex = 7;
			// 
			// lblInfo
			// 
			this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblInfo.BackColor = System.Drawing.SystemColors.Window;
			this.lblInfo.Location = new System.Drawing.Point(16, 12);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(233, 287);
			this.lblInfo.TabIndex = 1;
			// 
			// Label1
			// 
			this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Label1.BackColor = System.Drawing.SystemColors.Window;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Location = new System.Drawing.Point(4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(257, 311);
			this.Label1.TabIndex = 2;
			// 
			// Splitter1
			// 
			this.Splitter1.Location = new System.Drawing.Point(236, 0);
			this.Splitter1.Name = "Splitter1";
			this.Splitter1.Size = new System.Drawing.Size(3, 311);
			this.Splitter1.TabIndex = 6;
			this.Splitter1.TabStop = false;
			// 
			// treeDB
			// 
			this.treeDB.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeDB.Location = new System.Drawing.Point(0, 0);
			this.treeDB.Name = "treeDB";
			this.treeDB.Size = new System.Drawing.Size(236, 311);
			this.treeDB.TabIndex = 4;
			this.treeDB.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeDB_BeforeExpand);
			this.treeDB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDB_AfterSelect);
			// 
			// Panel1
			// 
			this.Panel1.Controls.Add(this.cmdClose);
			this.Panel1.Controls.Add(this.GroupBox1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new System.Drawing.Point(0, 311);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(503, 36);
			this.Panel1.TabIndex = 9;
			// 
			// cmdClose
			// 
			this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdClose.Location = new System.Drawing.Point(429, 12);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(72, 24);
			this.cmdClose.TabIndex = 4;
			this.cmdClose.Text = "Close";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox1.Location = new System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(501, 8);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			// 
			// TreeViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 347);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Name = "TreeViewForm";
			this.Text = "Product Catalog";
			this.Load += new System.EventHandler(this.TreeViewForm_Load);
			this.Panel2.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.Panel Panel3;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Splitter Splitter1;
		private System.Windows.Forms.TreeView treeDB;
		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.GroupBox GroupBox1;

	}
}