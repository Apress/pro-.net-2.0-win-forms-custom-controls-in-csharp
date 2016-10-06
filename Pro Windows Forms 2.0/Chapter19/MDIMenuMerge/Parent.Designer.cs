namespace MdiMenuMerge
{
	partial class Parent
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noMergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.parentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mergedSubMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.documentToolStripMenuItem,
            this.mergedSubMenuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(292, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noMergeToolStripMenuItem,
            this.mergeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Text = "File";
			// 
			// noMergeToolStripMenuItem
			// 
			this.noMergeToolStripMenuItem.Name = "noMergeToolStripMenuItem";
			this.noMergeToolStripMenuItem.Text = "Show Without Merging";
			this.noMergeToolStripMenuItem.Click += new System.EventHandler(this.noMergeToolStripMenuItem_Click);
			// 
			// mergeToolStripMenuItem
			// 
			this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
			this.mergeToolStripMenuItem.Text = "Show With Merging";
			this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
			// 
			// documentToolStripMenuItem
			// 
			this.documentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentToolStripMenuItem});
			this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
			this.documentToolStripMenuItem.Text = "Document";
			// 
			// parentToolStripMenuItem
			// 
			this.parentToolStripMenuItem.Name = "parentToolStripMenuItem";
			this.parentToolStripMenuItem.Text = "Parent";
			// 
			// mergedSubMenuToolStripMenuItem
			// 
			this.mergedSubMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
			this.mergedSubMenuToolStripMenuItem.Name = "mergedSubMenuToolStripMenuItem";
			this.mergedSubMenuToolStripMenuItem.Text = "Merged SubMenu";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Text = "New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Text = "Quit";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			// 
			// Parent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Parent";
			this.Text = "Parent";
			this.menuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noMergeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mergedSubMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

