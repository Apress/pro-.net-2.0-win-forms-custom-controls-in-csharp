namespace ExtenderProvidersHost
{
    partial class HelpIconProviderTest
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.helpIconProvider1 = new ExtenderProviders.HelpIconProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.helpIconProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.helpIconProvider1.SetHelpID(this.textBox2, "ValueOfHelp.htm");
            this.textBox2.Location = new System.Drawing.Point(12, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "The Value of Help";
            // 
            // textBox1
            // 
            this.helpIconProvider1.SetHelpID(this.textBox1, "BadHelp.htm");
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Bad Help";
            // 
            // helpIconProvider1
            // 
            this.helpIconProvider1.HelpFile = "HelpTest.chm";
            // 
            // HelpIconProviderTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 235);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.helpIconProvider1.SetHelpID(this, "");
            this.Name = "HelpIconProviderTest";
            this.Text = "HelpIconProviderTest";
            this.Load += new System.EventHandler(this.HelpIconProviderTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.helpIconProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExtenderProviders.HelpIconProvider helpIconProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}