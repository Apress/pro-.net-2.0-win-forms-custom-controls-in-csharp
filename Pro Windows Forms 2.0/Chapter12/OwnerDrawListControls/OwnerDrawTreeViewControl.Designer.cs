namespace OwnerDrawList
{
	partial class OwnerDrawTreeViewControl
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
            this.multiSelectTreeView1 = new OwnerDrawList.MultiSelectTreeView();
            this.cmdGetSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // multiSelectTreeView1
            // 
            this.multiSelectTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.multiSelectTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.multiSelectTreeView1.Location = new System.Drawing.Point(7, 5);
            this.multiSelectTreeView1.Name = "multiSelectTreeView1";
            this.multiSelectTreeView1.Size = new System.Drawing.Size(276, 226);
            this.multiSelectTreeView1.TabIndex = 0;
            // 
            // cmdGetSelected
            // 
            this.cmdGetSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGetSelected.Location = new System.Drawing.Point(144, 237);
            this.cmdGetSelected.Name = "cmdGetSelected";
            this.cmdGetSelected.Size = new System.Drawing.Size(140, 23);
            this.cmdGetSelected.TabIndex = 2;
            this.cmdGetSelected.Text = "Get Selected Nodes";
            this.cmdGetSelected.UseVisualStyleBackColor = true;
            this.cmdGetSelected.Click += new System.EventHandler(this.cmdGetSelected_Click);
            // 
            // OwnerDrawTreeViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.cmdGetSelected);
            this.Controls.Add(this.multiSelectTreeView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OwnerDrawTreeViewControl";
            this.Text = "CustomTreeView";
            this.Load += new System.EventHandler(this.CustomTreeView_Load);
            this.ResumeLayout(false);

		}

		#endregion

        private MultiSelectTreeView multiSelectTreeView1;
        private System.Windows.Forms.Button cmdGetSelected;


    }
}