namespace MultithreadingClient
{
    partial class AsyncTestLocking
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.cmdFind = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.txtResults);
            this.GroupBox1.Controls.Add(this.cmdFind);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtTo);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtFrom);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Location = new System.Drawing.Point(9, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(475, 306);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Find Prime Numbers";
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(80, 110);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(383, 179);
            this.txtResults.TabIndex = 7;
            // 
            // cmdFind
            // 
            this.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFind.Location = new System.Drawing.Point(210, 53);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(112, 24);
            this.cmdFind.TabIndex = 5;
            this.cmdFind.Text = "Find Primes";
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 60);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 20);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(80, 56);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 21);
            this.txtTo.TabIndex = 3;
            this.txtTo.Text = "500000";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 32);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "From:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 104);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Results:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(80, 28);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 21);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.Text = "1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPanel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPanel
            // 
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(481, 17);
            this.statusPanel.Spring = true;
            this.statusPanel.Click += new System.EventHandler(this.statusStrip1_DoubleClick);
            // 
            // AsyncTestLocking
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(496, 351);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(354, 254);
            this.Name = "AsyncTestLocking";
            this.Text = "Asynchronous Test";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtResults;
        internal System.Windows.Forms.Button cmdFind;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPanel;

    }
}

