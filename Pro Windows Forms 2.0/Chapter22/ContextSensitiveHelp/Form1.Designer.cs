namespace ContextSensitiveHelp1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// textBox1
			// 
			this.helpProvider1.SetHelpKeyword(this.textBox1, "BadHelp.htm");
			this.helpProvider1.SetHelpNavigator(this.textBox1, System.Windows.Forms.HelpNavigator.Topic);
			this.textBox1.Location = new System.Drawing.Point(82, 16);
			this.textBox1.Name = "textBox1";
			this.helpProvider1.SetShowHelp(this.textBox1, true);
			this.textBox1.Size = new System.Drawing.Size(214, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "Press F1 here for BadHelp.htm";
			this.textBox1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.textBox1_HelpRequested);
			// 
			// textBox2
			// 
			this.helpProvider1.SetHelpKeyword(this.textBox2, "ValueOfHelp.htm");
			this.helpProvider1.SetHelpNavigator(this.textBox2, System.Windows.Forms.HelpNavigator.Topic);
			this.textBox2.Location = new System.Drawing.Point(82, 46);
			this.textBox2.Name = "textBox2";
			this.helpProvider1.SetShowHelp(this.textBox2, true);
			this.textBox2.Size = new System.Drawing.Size(214, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "Press F1 here for ValueOfHelp.htm";
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "HelpTest.chm";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 301);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.HelpProvider helpProvider1;
	}
}

