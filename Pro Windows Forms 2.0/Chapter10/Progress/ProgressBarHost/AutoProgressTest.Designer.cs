namespace ProgressHost
{
    partial class AutoProgressTest
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
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.autoProgress = new ProgressBarControl.AutoProgress();
            this.SuspendLayout();
// 
// cmdStart
// 
            this.cmdStart.Location = new System.Drawing.Point(62, 165);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start";
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
// 
// cmdStop
// 
            this.cmdStop.Location = new System.Drawing.Point(144, 165);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.TabIndex = 1;
            this.cmdStop.Text = "Stop";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
// 
// autoProgress
// 
            this.autoProgress.Location = new System.Drawing.Point(62, 36);
            
            this.autoProgress.Name = "autoProgress";
            this.autoProgress.PercentPerSecond = 13;
            this.autoProgress.Size = new System.Drawing.Size(164, 40);
            this.autoProgress.TabIndex = 2;
// 
// AutoProgressTest
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(287, 204);
            this.Controls.Add(this.autoProgress);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Name = "AutoProgressTest";
            this.Text = "AutoProgressTest";
            this.Load += new System.EventHandler(this.AutoProgressTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private ProgressBarControl.AutoProgress autoProgress;
    }
}