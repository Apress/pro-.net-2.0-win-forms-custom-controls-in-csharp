namespace DynamicLayout
{
    partial class ModularPortal
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.collapsiblePanel1 = new Microsoft.Samples.CollapsiblePanel();
            this.collapsiblePanel3 = new Microsoft.Samples.CollapsiblePanel();
            this.collapsiblePanel4 = new Microsoft.Samples.CollapsiblePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstModules = new System.Windows.Forms.CheckedListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.collapsiblePanel2 = new Microsoft.Samples.CollapsiblePanel();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.collapsiblePanel1.SuspendLayout();
            this.collapsiblePanel3.SuspendLayout();
            this.collapsiblePanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.collapsiblePanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel4);
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel1);
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel3);
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(667, 463);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // collapsiblePanel1
            // 
            this.collapsiblePanel1.Collapsed = false;
            this.collapsiblePanel1.Controls.Add(this.panel1);
            this.collapsiblePanel1.Location = new System.Drawing.Point(321, 3);
            this.collapsiblePanel1.Name = "collapsiblePanel1";
            this.collapsiblePanel1.Size = new System.Drawing.Size(311, 239);
            this.collapsiblePanel1.TabIndex = 0;
            this.collapsiblePanel1.Text = "PreferencePanel";
            // 
            // collapsiblePanel3
            // 
            this.collapsiblePanel3.Collapsed = false;
            this.collapsiblePanel3.Controls.Add(this.panel2);
            this.collapsiblePanel3.Location = new System.Drawing.Point(3, 251);
            this.collapsiblePanel3.Name = "collapsiblePanel3";
            this.collapsiblePanel3.Size = new System.Drawing.Size(200, 242);
            this.collapsiblePanel3.TabIndex = 3;
            this.collapsiblePanel3.Text = "InfoPanel";
            // 
            // collapsiblePanel4
            // 
            this.collapsiblePanel4.Collapsed = false;
            this.collapsiblePanel4.Controls.Add(this.webBrowser1);
            this.collapsiblePanel4.Location = new System.Drawing.Point(3, 3);
            this.collapsiblePanel4.Name = "collapsiblePanel4";
            this.collapsiblePanel4.Size = new System.Drawing.Size(312, 242);
            this.collapsiblePanel4.TabIndex = 4;
            this.collapsiblePanel4.Text = "WebPanel";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstModules);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded Modules";
            // 
            // lstModules
            // 
            this.lstModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstModules.FormattingEnabled = true;
            this.lstModules.Location = new System.Drawing.Point(12, 19);
            this.lstModules.MultiColumn = true;
            this.lstModules.Name = "lstModules";
            this.lstModules.Size = new System.Drawing.Size(378, 52);
            this.lstModules.TabIndex = 0;
            this.lstModules.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstModules_ItemCheck);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(305, 212);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("http://www.google.ca", System.UriKind.Absolute);
            // 
            // collapsiblePanel2
            // 
            this.collapsiblePanel2.Collapsed = false;
            this.collapsiblePanel2.Controls.Add(this.webBrowser2);
            this.collapsiblePanel2.Location = new System.Drawing.Point(209, 251);
            this.collapsiblePanel2.Name = "collapsiblePanel2";
            this.collapsiblePanel2.Size = new System.Drawing.Size(423, 242);
            this.collapsiblePanel2.TabIndex = 5;
            this.collapsiblePanel2.Text = "HelpPanel";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser2.Location = new System.Drawing.Point(3, 27);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(416, 212);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.Url = new System.Uri("http://msdn.microsoft.com", System.UriKind.Absolute);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Controls.Add(this.checkBox12);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(8, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 206);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 63);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(19, 86);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(77, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 109);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(77, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(19, 132);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(77, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(124, 132);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(77, 17);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(124, 109);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(77, 17);
            this.checkBox8.TabIndex = 10;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(124, 86);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(77, 17);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(124, 63);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(83, 17);
            this.checkBox10.TabIndex = 8;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(124, 40);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(83, 17);
            this.checkBox11.TabIndex = 7;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(124, 17);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(83, 17);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Text = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 201);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 133);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lorum ipsum dolorum. Lorum ipsum dolorum. Lorum ipsum dolorum. Lorum ipsum doloru" +
                "m.";
            // 
            // ModularPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(674, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ModularPortal";
            this.Text = "ModularPortal";
            this.Load += new System.EventHandler(this.ModularPortal_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.collapsiblePanel1.ResumeLayout(false);
            this.collapsiblePanel3.ResumeLayout(false);
            this.collapsiblePanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.collapsiblePanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Microsoft.Samples.CollapsiblePanel collapsiblePanel1;
        private Microsoft.Samples.CollapsiblePanel collapsiblePanel3;
        private Microsoft.Samples.CollapsiblePanel collapsiblePanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox lstModules;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Microsoft.Samples.CollapsiblePanel collapsiblePanel2;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}