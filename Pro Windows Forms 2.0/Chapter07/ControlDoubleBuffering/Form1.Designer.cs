namespace ControlDoubleBuffering
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
			this.bufferedPanel = new ControlDoubleBuffering.BufferedPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkShowBufferedPanel = new System.Windows.Forms.CheckBox();
			this.chkShowPanel = new System.Windows.Forms.CheckBox();
			this.chkShowManualBufferedPanel = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// bufferedPanel
			// 
			this.bufferedPanel.BackColor = System.Drawing.Color.Transparent;
			this.bufferedPanel.Location = new System.Drawing.Point(32, 271);
			this.bufferedPanel.Name = "bufferedPanel";
			this.bufferedPanel.Size = new System.Drawing.Size(193, 195);
			this.bufferedPanel.TabIndex = 2;
			this.bufferedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logo2_Paint);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(256, 271);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(213, 195);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.logo2_Paint);
			// 
			// chkShowBufferedPanel
			// 
			this.chkShowBufferedPanel.AutoSize = true;
			this.chkShowBufferedPanel.BackColor = System.Drawing.Color.Transparent;
			this.chkShowBufferedPanel.Checked = true;
			this.chkShowBufferedPanel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowBufferedPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowBufferedPanel.ForeColor = System.Drawing.Color.White;
			this.chkShowBufferedPanel.Location = new System.Drawing.Point(32, 216);
			this.chkShowBufferedPanel.Name = "chkShowBufferedPanel";
			this.chkShowBufferedPanel.Size = new System.Drawing.Size(134, 17);
			this.chkShowBufferedPanel.TabIndex = 4;
			this.chkShowBufferedPanel.Text = "Show BufferedPanel";
			this.chkShowBufferedPanel.UseVisualStyleBackColor = false;
			this.chkShowBufferedPanel.CheckedChanged += new System.EventHandler(this.chkShowBufferedPanel_CheckedChanged);
			// 
			// chkShowPanel
			// 
			this.chkShowPanel.AutoSize = true;
			this.chkShowPanel.BackColor = System.Drawing.Color.Transparent;
			this.chkShowPanel.Checked = true;
			this.chkShowPanel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowPanel.ForeColor = System.Drawing.Color.White;
			this.chkShowPanel.Location = new System.Drawing.Point(256, 216);
			this.chkShowPanel.Name = "chkShowPanel";
			this.chkShowPanel.Size = new System.Drawing.Size(86, 17);
			this.chkShowPanel.TabIndex = 5;
			this.chkShowPanel.Text = "Show Panel";
			this.chkShowPanel.UseVisualStyleBackColor = false;
			this.chkShowPanel.CheckedChanged += new System.EventHandler(this.chkShowPanel_CheckedChanged);
			// 
			// chkShowManualBufferedPanel
			// 
			this.chkShowManualBufferedPanel.AutoSize = true;
			this.chkShowManualBufferedPanel.BackColor = System.Drawing.Color.Transparent;
			this.chkShowManualBufferedPanel.Checked = true;
			this.chkShowManualBufferedPanel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowManualBufferedPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowManualBufferedPanel.ForeColor = System.Drawing.Color.White;
			this.chkShowManualBufferedPanel.Location = new System.Drawing.Point(499, 216);
			this.chkShowManualBufferedPanel.Name = "chkShowManualBufferedPanel";
			this.chkShowManualBufferedPanel.Size = new System.Drawing.Size(191, 17);
			this.chkShowManualBufferedPanel.TabIndex = 7;
			this.chkShowManualBufferedPanel.Text = "Show Manually Buffered Panel";
			this.chkShowManualBufferedPanel.UseVisualStyleBackColor = false;
			this.chkShowManualBufferedPanel.CheckedChanged += new System.EventHandler(this.chkShowManualBufferedPanel_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Location = new System.Drawing.Point(499, 271);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(213, 195);
			this.panel2.TabIndex = 6;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.logo2_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ControlDoubleBuffering.Properties.Resources.ShopFloor_030;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(721, 522);
			this.Controls.Add(this.chkShowManualBufferedPanel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.chkShowPanel);
			this.Controls.Add(this.chkShowBufferedPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.bufferedPanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "DoubleBuffered Controls";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private BufferedPanel bufferedPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkShowBufferedPanel;
		private System.Windows.Forms.CheckBox chkShowPanel;
		private System.Windows.Forms.CheckBox chkShowManualBufferedPanel;
		private System.Windows.Forms.Panel panel2;





    }
}

