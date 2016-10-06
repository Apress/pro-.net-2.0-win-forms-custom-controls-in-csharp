namespace SimpleChartHost
{
    partial class SimpleChartTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleChartTest));
            this.simpleChart1 = new SimpleChart.SimpleChart();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // simpleChart1
            // 
            this.simpleChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            
            this.simpleChart1.Location = new System.Drawing.Point(15, 10);
            this.simpleChart1.Name = "simpleChart1";
            this.simpleChart1.Size = new System.Drawing.Size(475, 281);
            this.simpleChart1.TabIndex = 5;
            this.simpleChart1.Text = "simpleChart1";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(10, 304);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(357, 36);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Historical Sales Report";
            // 
            // SimpleChartTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 355);
            this.Controls.Add(this.simpleChart1);
            this.Controls.Add(this.Label1);
            this.Name = "SimpleChartTest";
            this.Text = "SimpleChartTest";
            this.Load += new System.EventHandler(this.SimpleChartTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleChart.SimpleChart simpleChart1;
        internal System.Windows.Forms.Label Label1;
    }
}