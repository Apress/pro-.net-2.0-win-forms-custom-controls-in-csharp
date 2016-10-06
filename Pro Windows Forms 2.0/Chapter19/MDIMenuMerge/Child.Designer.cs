namespace MdiMenuMerge
{
	partial class Child
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
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergedSubMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsToolStripMenuItem,
            this.mergedSubMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(233, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.documentsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.documentsToolStripMenuItem.MergeIndex = 0;
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.documentsToolStripMenuItem.Text = "Document";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.testToolStripMenuItem.Text = "Child (in a Replace submenu)";
            // 
            // mergedSubMenuToolStripMenuItem
            // 
            this.mergedSubMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.mergedSubMenuToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mergedSubMenuToolStripMenuItem.Name = "mergedSubMenuToolStripMenuItem";
            this.mergedSubMenuToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.mergedSubMenuToolStripMenuItem.Text = "Merged SubMenu";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.printToolStripMenuItem.MergeIndex = 3;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.printToolStripMenuItem.Text = "Print (Merge Index 3)";
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 104);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Child";
            this.Text = "Child";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mergedSubMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
	}
}