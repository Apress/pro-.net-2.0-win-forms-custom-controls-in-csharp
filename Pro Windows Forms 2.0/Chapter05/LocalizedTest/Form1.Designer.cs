namespace LocalizedTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AccessibleDescription = null;
            this.lblFirstName.AccessibleName = null;
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Font = null;
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblLastName
            // 
            this.lblLastName.AccessibleDescription = null;
            this.lblLastName.AccessibleName = null;
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Font = null;
            this.lblLastName.Name = "lblLastName";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = null;
            this.textBox1.AccessibleName = null;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackgroundImage = null;
            this.textBox1.Font = null;
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = null;
            this.textBox2.AccessibleName = null;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.BackgroundImage = null;
            this.textBox2.Font = null;
            this.textBox2.Name = "textBox2";
            // 
            // Form1
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Font = null;
            this.Icon = null;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

