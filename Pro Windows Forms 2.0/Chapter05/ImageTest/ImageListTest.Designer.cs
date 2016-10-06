namespace ImageTest
{
    partial class ImageListTest
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
            this.components = new System.ComponentModel.Container();
            this.cmdFillImageList = new System.Windows.Forms.Button();
            this.cmdPaintImages = new System.Windows.Forms.Button();
            this.iconImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // cmdFillImageList
            // 
            this.cmdFillImageList.Location = new System.Drawing.Point(29, 217);
            this.cmdFillImageList.Name = "cmdFillImageList";
            this.cmdFillImageList.Size = new System.Drawing.Size(118, 23);
            this.cmdFillImageList.TabIndex = 0;
            this.cmdFillImageList.Text = "Fill Image List";
            this.cmdFillImageList.UseVisualStyleBackColor = true;
            this.cmdFillImageList.Click += new System.EventHandler(this.cmdFillImageList_Click);
            // 
            // cmdPaintImages
            // 
            this.cmdPaintImages.Location = new System.Drawing.Point(153, 217);
            this.cmdPaintImages.Name = "cmdPaintImages";
            this.cmdPaintImages.Size = new System.Drawing.Size(112, 23);
            this.cmdPaintImages.TabIndex = 1;
            this.cmdPaintImages.Text = "Paint Images";
            this.cmdPaintImages.UseVisualStyleBackColor = true;
            this.cmdPaintImages.Click += new System.EventHandler(this.cmdPaintImages_Click);
            // 
            // iconImages
            // 
            this.iconImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iconImages.ImageSize = new System.Drawing.Size(16, 16);
            this.iconImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImageListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.cmdPaintImages);
            this.Controls.Add(this.cmdFillImageList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ImageListTest";
            this.Text = "ImageListTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFillImageList;
        private System.Windows.Forms.Button cmdPaintImages;
        private System.Windows.Forms.ImageList iconImages;
    }
}