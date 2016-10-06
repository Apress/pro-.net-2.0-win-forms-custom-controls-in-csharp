namespace DynamicUI
{
    partial class ButtonMaker
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtLeft);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cmdCreate);
            this.GroupBox1.Controls.Add(this.txtTop);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(168, 128);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Left:";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(76, 52);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(68, 20);
            this.txtLeft.TabIndex = 4;
            this.txtLeft.Text = "200";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Top:";
            // 
            // cmdCreate
            // 
            this.cmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCreate.Location = new System.Drawing.Point(36, 84);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(112, 28);
            this.cmdCreate.TabIndex = 2;
            this.cmdCreate.Text = "Create Button";
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(76, 24);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(68, 20);
            this.txtTop.TabIndex = 3;
            this.txtTop.Text = "50";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 216);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(391, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(376, 17);
            this.lblStatus.Spring = true;
            // 
            // ButtonMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 238);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "ButtonMaker";
            this.Text = "ButtonMaker";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtLeft;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button cmdCreate;
        internal System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}