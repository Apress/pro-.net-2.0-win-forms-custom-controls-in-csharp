namespace MarqueeLabelHost
{
    partial class MarqueeTestForm
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
            this.tbInterval = new System.Windows.Forms.TrackBar();
            this.Label1 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TrackBar();
            this.marqueeLabel1 = new MarqueeLabel.MarqueeLabel();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.tbInterval);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.tbAmount);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Location = new System.Drawing.Point(22, 177);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(336, 132);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 76);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 23);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Scroll Interval:";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(96, 72);
            this.tbInterval.Maximum = 500;
            this.tbInterval.Minimum = 10;
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(228, 45);
            this.tbInterval.TabIndex = 5;
            this.tbInterval.TickFrequency = 10;
            this.tbInterval.Value = 100;
            this.tbInterval.ValueChanged += new System.EventHandler(this.tbInterval_ValueChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Scroll Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(96, 16);
            this.tbAmount.Maximum = 20;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(228, 45);
            this.tbAmount.TabIndex = 3;
            this.tbAmount.Value = 10;
            this.tbAmount.ValueChanged += new System.EventHandler(this.tbAmount_ValueChanged);
            // 
            // marqueeLabel1
            // 
            this.marqueeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.marqueeLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.marqueeLabel1.EnableScrolling = true;
            this.marqueeLabel1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marqueeLabel1.ForeColor = System.Drawing.Color.Navy;
            this.marqueeLabel1.Location = new System.Drawing.Point(-2, 7);
            this.marqueeLabel1.Name = "marqueeLabel1";
            this.marqueeLabel1.ScrollTimeInterval = 100;
            this.marqueeLabel1.Size = new System.Drawing.Size(384, 156);
            this.marqueeLabel1.TabIndex = 7;
            this.marqueeLabel1.Tag = "";
            this.marqueeLabel1.Text = "This scrolls!";
            // 
            // MarqueeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 322);
            this.Controls.Add(this.marqueeLabel1);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MarqueeTestForm";
            this.Text = "MarqueeTestForm";
            this.Load += new System.EventHandler(this.MarqueeTestForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MarqueeLabel.MarqueeLabel marqueeLabel1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TrackBar tbInterval;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TrackBar tbAmount;
    }
}