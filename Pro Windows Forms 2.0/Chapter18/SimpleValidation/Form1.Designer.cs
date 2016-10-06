namespace SimpleValidation
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtFirstName);
            this.GroupBox1.Controls.Add(this.txtLastName);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(368, 88);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Last Name:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(84, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(152, 21);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(84, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(152, 21);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(122, 214);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(76, 24);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "OK";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.CausesValidation = false;
            this.cmdClose.Location = new System.Drawing.Point(204, 214);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(76, 24);
            this.cmdClose.TabIndex = 14;
            this.cmdClose.Text = "Cancel";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 250);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Simple Validation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button cmdClose;
	}
}

