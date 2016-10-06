namespace ErrorProviderValidation
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
			this.components = new System.ComponentModel.Container();
			this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.grpValidation = new System.Windows.Forms.GroupBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.cmdOK = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
			this.grpValidation.SuspendLayout();
			this.SuspendLayout();
			// 
			// errProvider
			// 
			this.errProvider.ContainerControl = this;
			this.errProvider.DataMember = "";
			// 
			// grpValidation
			// 
			this.grpValidation.Controls.Add(this.Label3);
			this.grpValidation.Controls.Add(this.txtEmail);
			this.grpValidation.Controls.Add(this.Label2);
			this.grpValidation.Controls.Add(this.Label1);
			this.grpValidation.Controls.Add(this.txtFirstName);
			this.grpValidation.Controls.Add(this.txtLastName);
			this.grpValidation.Location = new System.Drawing.Point(5, 9);
			this.grpValidation.Name = "grpValidation";
			this.grpValidation.Size = new System.Drawing.Size(368, 124);
			this.grpValidation.TabIndex = 15;
			this.grpValidation.TabStop = false;
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(16, 88);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(64, 16);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(84, 84);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(152, 21);
			this.txtEmail.TabIndex = 9;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
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
			// cmdOK
			// 
			this.cmdOK.Location = new System.Drawing.Point(118, 206);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(76, 24);
			this.cmdOK.TabIndex = 14;
			this.cmdOK.Text = "OK";
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// cmdClose
			// 
			this.cmdClose.CausesValidation = false;
			this.cmdClose.Location = new System.Drawing.Point(200, 206);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(76, 24);
			this.cmdClose.TabIndex = 16;
			this.cmdClose.Text = "Cancel";
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 242);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.grpValidation);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
			this.grpValidation.ResumeLayout(false);
			this.grpValidation.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ErrorProvider errProvider;
		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.GroupBox grpValidation;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
	}
}

