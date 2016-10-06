namespace DynamicUI
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "DynamicMenu";
            this.button1.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 33);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(124, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "DynamicDBMenu";
            this.button11.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "ButtonMaker";
            this.button2.Click += new System.EventHandler(this.cmd_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 205);
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

	}
}

