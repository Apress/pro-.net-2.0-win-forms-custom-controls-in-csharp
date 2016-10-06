namespace ControlMedley
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
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(14, 97);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(112, 24);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Label1";
			this.Label1.Click += new System.EventHandler(this.ctrlClick);
			// 
			// TextBox1
			// 
			this.TextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBox1.Location = new System.Drawing.Point(12, 61);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(156, 21);
			this.TextBox1.TabIndex = 7;
			this.TextBox1.Text = "TextBox1";
			this.TextBox1.Click += new System.EventHandler(this.ctrlClick);
			// 
			// Button1
			// 
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button1.Location = new System.Drawing.Point(12, 21);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(96, 28);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "Button1";
			this.Button1.Click += new System.EventHandler(this.ctrlClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 281);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Control Medley";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.Button Button1;
	}
}

