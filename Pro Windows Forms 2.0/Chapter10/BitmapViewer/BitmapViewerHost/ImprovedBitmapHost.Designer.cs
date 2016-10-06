namespace BitmapViewerHost
{
    partial class ImprovedBitmapHost
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
            this.bitmapViewer1 = new BitmapViewerControl.ImprovedBitmapViewer();
            this.SuspendLayout();
            // 
            // bitmapViewer1
            // 
            this.bitmapViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bitmapViewer1.Dimension = 80;
            this.bitmapViewer1.Location = new System.Drawing.Point(3, 3);
            this.bitmapViewer1.Name = "bitmapViewer1";
            this.bitmapViewer1.Padding = new System.Windows.Forms.Padding(1);
            this.bitmapViewer1.Size = new System.Drawing.Size(450, 220);
            this.bitmapViewer1.Spacing = 10;
            this.bitmapViewer1.TabIndex = 0;
            // 
            // ImprovedBitmapHost
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(455, 272);
            this.Controls.Add(this.bitmapViewer1);
            this.Name = "ImprovedBitmapHost";
            this.Text = "ImprovedBitmapHost";
            this.Load += new System.EventHandler(this.ImprovedBitmapHost_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BitmapViewerControl.ImprovedBitmapViewer bitmapViewer1;


    }
}