namespace DynamicLayout
{
    partial class ProportionalResizing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node2");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Item1");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Item2");
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 136);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Name = "treeView1";
			treeNode4.Name = "Node1";
			treeNode4.Text = "Node1";
			treeNode5.Name = "Node2";
			treeNode5.Text = "Node2";
			treeNode6.Name = "Node0";
			treeNode6.Text = "Node0";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
			this.treeView1.Scrollable = false;
			this.treeView1.Size = new System.Drawing.Size(122, 130);
			this.treeView1.TabIndex = 1;
			// 
			// listView1
			// 
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
			this.listView1.Location = new System.Drawing.Point(131, 3);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(123, 130);
			this.listView1.TabIndex = 3;
			// 
			// BiPaneProportionalResize
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(263, 151);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "BiPaneProportionalResize";
			this.Text = "Bi-Pane Proportional Resize";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;

    }
}