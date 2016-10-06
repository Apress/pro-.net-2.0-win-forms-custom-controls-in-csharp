namespace ImpossibleAPI
{
	partial class Form2
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
			this.Button3 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Button3
			// 
			this.Button3.Location = new System.Drawing.Point(120, 56);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(88, 32);
			this.Button3.TabIndex = 8;
			this.Button3.Text = "Become Child of Parent2";
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// Button2
			// 
			this.Button2.Location = new System.Drawing.Point(12, 56);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(88, 32);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "Become Child of Parent1";
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(12, 12);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(88, 32);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "Become Parent";
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 154);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button1;
	}
}