namespace AutoComplete
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
            this.lstColors = new System.Windows.Forms.ComboBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
// 
// lstColors
// 
            this.lstColors.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.lstColors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstColors.FormattingEnabled = true;
            this.lstColors.Location = new System.Drawing.Point(13, 13);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(267, 21);
            this.lstColors.TabIndex = 0;
            this.toolTip2.SetToolTip(this.lstColors, "kljkllklj");
// 
// toolTip2
// 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
// 
// Form1
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(296, 82);
            this.Controls.Add(this.lstColors);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "AutoComplete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox lstColors;
        private System.Windows.Forms.ToolTip toolTip2;


    }
}

