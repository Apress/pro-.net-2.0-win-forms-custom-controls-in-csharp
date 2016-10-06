namespace CollapsiblePanelHost
{
	partial class CollapseTest
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
            this.collapsiblePanel1 = new Microsoft.Samples.CollapsiblePanel();
            this.collapsiblePanel2 = new Microsoft.Samples.CollapsiblePanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.collapsiblePanel1.SuspendLayout();
            this.collapsiblePanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // collapsiblePanel1
            // 
            this.collapsiblePanel1.Collapsed = false;
            this.collapsiblePanel1.Controls.Add(this.panel1);
            this.collapsiblePanel1.Location = new System.Drawing.Point(209, 12);
            this.collapsiblePanel1.Name = "collapsiblePanel1";
            this.collapsiblePanel1.Size = new System.Drawing.Size(184, 99);
            this.collapsiblePanel1.TabIndex = 2;
            this.collapsiblePanel1.Text = "collapsiblePanel1";
            // 
            // collapsiblePanel2
            // 
            this.collapsiblePanel2.Collapsed = false;
            this.collapsiblePanel2.Controls.Add(this.button2);
            this.collapsiblePanel2.Controls.Add(this.button1);
            this.collapsiblePanel2.Location = new System.Drawing.Point(12, 12);
            this.collapsiblePanel2.Name = "collapsiblePanel2";
            this.collapsiblePanel2.Size = new System.Drawing.Size(182, 99);
            this.collapsiblePanel2.TabIndex = 3;
            this.collapsiblePanel2.Text = "collapsiblePanel2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sample text.";
            // 
            // CollapseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 141);
            this.Controls.Add(this.collapsiblePanel1);
            this.Controls.Add(this.collapsiblePanel2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CollapseTest";
            this.Text = "CollapseTest";
            this.Load += new System.EventHandler(this.CollapseTest_Load);
            this.collapsiblePanel1.ResumeLayout(false);
            this.collapsiblePanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Samples.CollapsiblePanel collapsiblePanel1;
		private Microsoft.Samples.CollapsiblePanel collapsiblePanel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;



	}
}