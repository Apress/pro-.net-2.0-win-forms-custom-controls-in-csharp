namespace DynamicLayout
{
	partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "HandMadeLayoutManager";
            this.button1.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 33);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(144, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "FlowLayoutTest";
            this.button11.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "TableLayoutTest";
            this.button2.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "CellSpanning";
            this.button3.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "LocalizableDialog";
            this.button4.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "ProportionalResizing";
            this.button5.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "TextBoxColumn";
            this.button6.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 196);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "FormsFromFile";
            this.button7.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 225);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "CustomLayoutEngine";
            this.button8.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 254);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "ModularPortal";
            this.button9.Click += new System.EventHandler(this.cmd_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 297);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

	}
}

