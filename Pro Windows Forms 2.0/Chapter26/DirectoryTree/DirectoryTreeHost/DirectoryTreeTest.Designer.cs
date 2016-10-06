namespace DirectoryTreeHost
{
    partial class DirectoryTreeTest
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
            this.directoryTree1 = new DirectoryTreeControl.DirectoryTree();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // directoryTree1
            // 
            this.directoryTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryTree1.Drive = 'C';
            this.directoryTree1.Location = new System.Drawing.Point(281, 4);
            this.directoryTree1.Name = "directoryTree1";
            this.directoryTree1.Size = new System.Drawing.Size(291, 274);
            this.directoryTree1.TabIndex = 4;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(4, 4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.directoryTree1;
            this.propertyGrid1.Size = new System.Drawing.Size(260, 272);
            this.propertyGrid1.TabIndex = 3;
            // 
            // DirectoryTreeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 282);
            this.Controls.Add(this.directoryTree1);
            this.Controls.Add(this.propertyGrid1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DirectoryTreeTest";
            this.Text = "DirectoryTreeTest";
            this.ResumeLayout(false);

        }

        #endregion

        private DirectoryTreeControl.DirectoryTree directoryTree1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}