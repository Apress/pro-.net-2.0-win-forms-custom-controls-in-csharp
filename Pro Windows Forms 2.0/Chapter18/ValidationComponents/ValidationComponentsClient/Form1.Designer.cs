namespace ValidationComponentsClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpValidation = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.requiredFirstName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredLastName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.regularExpressionValidator1 = new ValidationComponents.RegularExpressionValidator(this.components);
            this.grpValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(84, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(152, 21);
            this.txtLastName.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 21);
            this.txtEmail.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(84, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(152, 21);
            this.txtFirstName.TabIndex = 4;
            // 
            // grpValidation
            // 
            this.grpValidation.Controls.Add(this.Label3);
            this.grpValidation.Controls.Add(this.txtEmail);
            this.grpValidation.Controls.Add(this.Label2);
            this.grpValidation.Controls.Add(this.Label1);
            this.grpValidation.Controls.Add(this.txtFirstName);
            this.grpValidation.Controls.Add(this.txtLastName);
            this.grpValidation.Location = new System.Drawing.Point(12, 12);
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
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(117, 211);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(76, 24);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "OK";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.CausesValidation = false;
            this.cmdClose.Location = new System.Drawing.Point(199, 211);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(76, 24);
            this.cmdClose.TabIndex = 16;
            this.cmdClose.Text = "Cancel";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // requiredFirstName
            // 
            this.requiredFirstName.CancelFocusChangeWhenInvalid = false;
            this.requiredFirstName.ControlToValidate = this.txtFirstName;
            this.requiredFirstName.ErrorMessage = "A first name is required.";
            this.requiredFirstName.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFirstName.Icon")));
            // 
            // requiredLastName
            // 
            this.requiredLastName.CancelFocusChangeWhenInvalid = false;
            this.requiredLastName.ControlToValidate = this.txtLastName;
            this.requiredLastName.ErrorMessage = "A last name is required.";
            this.requiredLastName.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredLastName.Icon")));
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.CancelFocusChangeWhenInvalid = true;
            this.regularExpressionValidator1.ControlToValidate = this.txtEmail;
            this.regularExpressionValidator1.ErrorMessage = "Not a valid email address.";
            this.regularExpressionValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("regularExpressionValidator1.Icon")));
            this.regularExpressionValidator1.ValidationExpression = "^\\S+@\\S+\\.\\S+$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 247);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.grpValidation);
            this.Controls.Add(this.Button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Validation Component Test";
            this.grpValidation.ResumeLayout(false);
            this.grpValidation.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.GroupBox grpValidation;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button cmdClose;
        private ValidationComponents.RequiredFieldValidator requiredFirstName;
        private ValidationComponents.RequiredFieldValidator requiredLastName;
        private ValidationComponents.RegularExpressionValidator regularExpressionValidator1;
	}
}

