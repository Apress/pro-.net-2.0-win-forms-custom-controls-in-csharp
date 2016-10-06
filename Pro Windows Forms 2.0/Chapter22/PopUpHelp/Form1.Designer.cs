namespace PopUpHelp
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
            this.hlp = new System.Windows.Forms.HelpProvider();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 68);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tab to a button and press F1.";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(28, 71);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(92, 20);
            this.cmdDelete.TabIndex = 6;
            this.cmdDelete.Text = "Delete";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(28, 19);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(92, 20);
            this.cmdAdd.TabIndex = 5;
            this.cmdAdd.Text = "Add";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Pop-Up Help";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.HelpProvider hlp;
        internal System.Windows.Forms.Button cmdDelete;
        internal System.Windows.Forms.Button cmdAdd;
    }
}

