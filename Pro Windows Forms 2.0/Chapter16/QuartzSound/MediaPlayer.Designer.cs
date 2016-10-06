namespace QuartzMediaPlayer
{
	partial class MediaPlayer
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdPlay = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdPause = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.statusLabel2,
            this.statusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 93);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.statusLabel1.Size = new System.Drawing.Size(10, 27);
            // 
            // statusLabel2
            // 
            this.statusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.statusLabel2.Size = new System.Drawing.Size(14, 27);
            // 
            // statusLabel3
            // 
            this.statusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.statusLabel3.Name = "statusLabel3";
            this.statusLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.statusLabel3.Size = new System.Drawing.Size(93, 27);
            this.statusLabel3.Text = "Using test.mp3";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(24, 25);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(75, 26);
            this.cmdPlay.TabIndex = 1;
            this.cmdPlay.Text = "Play";
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(186, 25);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 26);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(105, 25);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(75, 26);
            this.cmdPause.TabIndex = 3;
            this.cmdPause.Text = "Pause";
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 125);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MediaPlayer";
            this.Text = "MediaPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MediaPlayer_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button cmdPlay;
		private System.Windows.Forms.Button cmdStop;
		private System.Windows.Forms.Button cmdPause;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel3;
	}
}