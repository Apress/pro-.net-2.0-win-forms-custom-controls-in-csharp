namespace RichTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdBold = new System.Windows.Forms.ToolStripButton();
            this.cmdItalic = new System.Windows.Forms.ToolStripButton();
            this.cmdUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lstColors = new System.Windows.Forms.ToolStripDropDownButton();
            this.lstFonts = new System.Windows.Forms.ToolStripDropDownButton();
            this.lstFontSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lstZoom = new System.Windows.Forms.ToolStripDropDownButton();
            this.cmdAddImage = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BulletIndent = 5;
            this.richTextBox1.Location = new System.Drawing.Point(12, 37);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 197);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdBold,
            this.cmdItalic,
            this.cmdUnderline,
            this.toolStripSeparator1,
            this.lstColors,
            this.lstFonts,
            this.lstFontSize,
            this.toolStripSeparator2,
            this.lstZoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(341, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdBold
            // 
            this.cmdBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdBold.Image = ((System.Drawing.Image)(resources.GetObject("cmdBold.Image")));
            this.cmdBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBold.Name = "cmdBold";
            this.cmdBold.Size = new System.Drawing.Size(31, 22);
            this.cmdBold.Text = "Bold";
            this.cmdBold.Click += new System.EventHandler(this.cmdBold_Click);
            // 
            // cmdItalic
            // 
            this.cmdItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdItalic.Image = ((System.Drawing.Image)(resources.GetObject("cmdItalic.Image")));
            this.cmdItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdItalic.Name = "cmdItalic";
            this.cmdItalic.Size = new System.Drawing.Size(34, 22);
            this.cmdItalic.Text = "Italic";
            this.cmdItalic.Click += new System.EventHandler(this.cmdItalic_Click);
            // 
            // cmdUnderline
            // 
            this.cmdUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdUnderline.Image = ((System.Drawing.Image)(resources.GetObject("cmdUnderline.Image")));
            this.cmdUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUnderline.Name = "cmdUnderline";
            this.cmdUnderline.Size = new System.Drawing.Size(56, 22);
            this.cmdUnderline.Text = "Underline";
            this.cmdUnderline.Click += new System.EventHandler(this.cmdUnderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lstColors
            // 
            this.lstColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lstColors.Image = ((System.Drawing.Image)(resources.GetObject("lstColors.Image")));
            this.lstColors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(45, 22);
            this.lstColors.Text = "Color";
            this.lstColors.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.lstColors_DropDownItemClicked);
            // 
            // lstFonts
            // 
            this.lstFonts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lstFonts.Image = ((System.Drawing.Image)(resources.GetObject("lstFonts.Image")));
            this.lstFonts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(42, 22);
            this.lstFonts.Text = "Font";
            this.lstFonts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.lstFonts_DropDownItemClicked);
            // 
            // lstFontSize
            // 
            this.lstFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lstFontSize.Image = ((System.Drawing.Image)(resources.GetObject("lstFontSize.Image")));
            this.lstFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lstFontSize.Name = "lstFontSize";
            this.lstFontSize.Size = new System.Drawing.Size(39, 22);
            this.lstFontSize.Text = "Size";
            this.lstFontSize.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.lstFontSize_DropDownItemClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lstZoom
            // 
            this.lstZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lstZoom.Image = ((System.Drawing.Image)(resources.GetObject("lstZoom.Image")));
            this.lstZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lstZoom.Name = "lstZoom";
            this.lstZoom.Size = new System.Drawing.Size(46, 22);
            this.lstZoom.Text = "Zoom";
            this.lstZoom.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.lstZoom_DropDownItemClicked);
            // 
            // cmdAddImage
            // 
            this.cmdAddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAddImage.Location = new System.Drawing.Point(12, 237);
            this.cmdAddImage.Name = "cmdAddImage";
            this.cmdAddImage.Size = new System.Drawing.Size(154, 23);
            this.cmdAddImage.TabIndex = 2;
            this.cmdAddImage.Text = "Insert Image";
            this.cmdAddImage.UseVisualStyleBackColor = true;
            this.cmdAddImage.Click += new System.EventHandler(this.cmdAddImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 266);
            this.Controls.Add(this.cmdAddImage);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "RichTextBox Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdUnderline;
        private System.Windows.Forms.ToolStripButton cmdBold;
        private System.Windows.Forms.ToolStripButton cmdItalic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton lstColors;
        private System.Windows.Forms.ToolStripDropDownButton lstFonts;
        private System.Windows.Forms.ToolStripDropDownButton lstZoom;
        private System.Windows.Forms.ToolStripDropDownButton lstFontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button cmdAddImage;
    }
}

