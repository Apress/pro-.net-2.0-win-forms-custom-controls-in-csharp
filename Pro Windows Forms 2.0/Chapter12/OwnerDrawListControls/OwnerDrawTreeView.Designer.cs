namespace OwnerDrawList
{
	partial class OwnerDrawTreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cmdGetSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeView1.Location = new System.Drawing.Point(7, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(277, 251);
            this.treeView1.TabIndex = 0;
            this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // cmdGetSelected
            // 
            this.cmdGetSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGetSelected.Location = new System.Drawing.Point(144, 263);
            this.cmdGetSelected.Name = "cmdGetSelected";
            this.cmdGetSelected.Size = new System.Drawing.Size(140, 23);
            this.cmdGetSelected.TabIndex = 1;
            this.cmdGetSelected.Text = "Get Selected Nodes";
            this.cmdGetSelected.UseVisualStyleBackColor = true;
            this.cmdGetSelected.Click += new System.EventHandler(this.button1_Click);
            // 
            // OwnerDrawTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 291);
            this.Controls.Add(this.cmdGetSelected);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OwnerDrawTreeView";
            this.Text = "OwnerDrawnTreeView";
            this.Load += new System.EventHandler(this.OwnerDrawnTreeView_Load);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button cmdGetSelected;
	}
}