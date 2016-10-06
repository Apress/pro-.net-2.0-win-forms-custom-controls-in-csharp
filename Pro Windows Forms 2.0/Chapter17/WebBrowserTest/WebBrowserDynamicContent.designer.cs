namespace WebBrowserTest
{
    partial class WebBrowserDynamicContent
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
            this.txtHtml = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
// 
// txtHtml
// 
            this.txtHtml.AcceptsReturn = true;
            this.txtHtml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHtml.AutoSize = false;
            this.txtHtml.Location = new System.Drawing.Point(7, 20);
            this.txtHtml.Multiline = true;
            this.txtHtml.Name = "txtHtml";
            this.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHtml.Size = new System.Drawing.Size(377, 138);
            this.txtHtml.TabIndex = 0;
            this.txtHtml.Text = "<html>\r\n\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=win" +
                "dows-1252\">\r\n<meta http-equiv=\"Content-Language\" content=\"en-us\">\r\n<title>New Pa" +
                "ge 1</title>\r\n</head>\r\n\r\n<body>\r\n\r\n<h2><a name=\"top\">Table of Contents</a></h2>\r" +
                "\n<ol>\r\n\t<li><a href=\"#how\"><strong>How do I ... ?</strong></a></li>\r\n\t<li><a hre" +
                "f=\"#where\"><strong>Where can I find ... ?</strong></a></li>\r\n\t<li><a href=\"#why\"" +
                "><strong>Why doesn\'t ... ?</strong></a></li>\r\n\t<li><a href=\"#who\"><strong>Who is" +
                " ... ?</strong></a></li>\r\n\t<li><a href=\"#what\"><strong>What is ... ?</strong></a" +
                "></li>\r\n\t<li><a href=\"#when\"><strong>When is ... ?</strong></a></li>\r\n</ol>\r\n<hr" +
                ">\r\n<h3><a name=\"how\">How do I ... ?</a></h3>\r\n<p>[This is the answer to the ques" +
                "tion.]</p>\r\n<h5><a href=\"#top\">Back to Top</a></h5>\r\n<hr>\r\n<h3><a name=\"where\">W" +
                "here can I find ... ?</a></h3>\r\n<p>[This is the answer to the question.]</p>\r\n<h" +
                "5><a href=\"#top\">Back to Top</a></h5>\r\n<hr>\r\n<h3><a name=\"why\">Why doesn\'t ... ?" +
                "</a></h3>\r\n<p>[This is the answer to the question.]</p>\r\n<h5><a href=\"#top\">Back" +
                " to Top</a></h5>\r\n<hr>\r\n<h3><a name=\"who\">Who is ... ?</a></h3>\r\n<p>[This is the" +
                " answer to the question.]</p>\r\n<h5><a href=\"#top\">Back to Top</a></h5>\r\n<hr>\r\n<h" +
                "3><a name=\"what\">What is ... ?</a></h3>\r\n<p>[This is the answer to the question." +
                "]</p>\r\n<h5><a href=\"#top\">Back to Top</a></h5>\r\n<hr>\r\n<h3><a name=\"when\">When is" +
                " ... ?</a></h3>\r\n<p>[This is the answer to the question.]</p>\r\n<h5><a href=\"#top" +
                "\">Back to Top</a></h5>\r\n<hr>\r\n<h5>Author information goes here.<br>\r\nCopyright ©" +
                " 2001&nbsp; [OrganizationName]. All rights reserved.<br>\r\nRevised: <!--webbot bo" +
                "t=\"TimeStamp\" s-format=\"%m/%d/%y\" s-type=\"EDITED\" -->.</h5>\r\n\r\n</body>\r\n\r\n</html" +
                ">";
            this.txtHtml.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHtml_KeyPress);
            this.txtHtml.TextChanged += new System.EventHandler(this.txtHtml_TextChanged);
// 
// groupBox1
// 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtHtml);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter HTML Here";
// 
// panel1
// 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.webBrowser);
            this.panel1.Location = new System.Drawing.Point(10, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 247);
            this.panel1.TabIndex = 8;
// 
// webBrowser
// 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(382, 245);
            this.webBrowser.TabIndex = 1;
// 
// WebBrowserDynamicContent
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(409, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WebBrowserDynamicContent";
            this.Text = "WebBrowser With Dynamic Content";
            this.Load += new System.EventHandler(this.WebBrowserDynamicContent_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHtml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}