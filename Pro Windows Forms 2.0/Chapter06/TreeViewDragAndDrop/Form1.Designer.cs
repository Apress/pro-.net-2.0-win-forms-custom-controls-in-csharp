namespace TreeViewDragAndDrop
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
            this.treeOne = new System.Windows.Forms.TreeView();
            this.treeTwo = new System.Windows.Forms.TreeView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeOne);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeTwo);
            this.splitContainer1.Size = new System.Drawing.Size(456, 391);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // treeOne
            // 
            this.treeOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeOne.HideSelection = false;
            this.treeOne.Location = new System.Drawing.Point(0, 0);
            this.treeOne.Name = "treeOne";
            this.treeOne.Size = new System.Drawing.Size(236, 391);
            this.treeOne.TabIndex = 5;
            this.treeOne.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            this.treeOne.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.treeOne.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
            this.treeOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
            // 
            // treeTwo
            // 
            this.treeTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTwo.Location = new System.Drawing.Point(0, 0);
            this.treeTwo.Name = "treeTwo";
            this.treeTwo.Size = new System.Drawing.Size(214, 391);
            this.treeTwo.TabIndex = 7;
            this.treeTwo.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            this.treeTwo.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.treeTwo.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
            this.treeTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 391);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "TreeView Drag-And-Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeOne;
		private System.Windows.Forms.TreeView treeTwo;
	}
}

