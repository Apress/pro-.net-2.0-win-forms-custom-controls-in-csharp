namespace KeyTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.cmdAsyncState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "<Text will never appear here because of Form.KeyPreview>";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(35, 77);
            this.lbl.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 1;
            // 
            // cmdAsyncState
            // 
            this.cmdAsyncState.Location = new System.Drawing.Point(36, 202);
            this.cmdAsyncState.Name = "cmdAsyncState";
            this.cmdAsyncState.Size = new System.Drawing.Size(141, 24);
            this.cmdAsyncState.TabIndex = 2;
            this.cmdAsyncState.Text = "GetAsyncState() for \"D\"";
            this.cmdAsyncState.Click += new System.EventHandler(this.cmdAsyncState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.cmdAsyncState);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "KeyTest";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Button cmdAsyncState;
	}
}

