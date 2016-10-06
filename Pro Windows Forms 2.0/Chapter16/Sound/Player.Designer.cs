namespace Sound
{
    partial class Player
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
            this.loadAsyncButton = new System.Windows.Forms.Button();
            this.playLoopAsyncButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playOnceAsyncButton = new System.Windows.Forms.Button();
            this.playOnceSyncButton = new System.Windows.Forms.Button();
            this.loadSyncButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.filepathTextbox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadAsyncButton
            // 
            this.loadAsyncButton.Location = new System.Drawing.Point(149, 50);
            this.loadAsyncButton.Name = "loadAsyncButton";
            this.loadAsyncButton.Size = new System.Drawing.Size(147, 23);
            this.loadAsyncButton.TabIndex = 20;
            this.loadAsyncButton.Text = "Load Asynchronously";
            this.loadAsyncButton.Click += new System.EventHandler(this.loadAsyncButton_Click);
            // 
            // playLoopAsyncButton
            // 
            this.playLoopAsyncButton.Location = new System.Drawing.Point(7, 106);
            this.playLoopAsyncButton.Name = "playLoopAsyncButton";
            this.playLoopAsyncButton.Size = new System.Drawing.Size(142, 23);
            this.playLoopAsyncButton.TabIndex = 18;
            this.playLoopAsyncButton.Text = "Loop Asynchronously";
            this.playLoopAsyncButton.Click += new System.EventHandler(this.playLoopAsyncButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(149, 106);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(147, 23);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playOnceAsyncButton
            // 
            this.playOnceAsyncButton.Location = new System.Drawing.Point(149, 83);
            this.playOnceAsyncButton.Name = "playOnceAsyncButton";
            this.playOnceAsyncButton.Size = new System.Drawing.Size(147, 23);
            this.playOnceAsyncButton.TabIndex = 16;
            this.playOnceAsyncButton.Text = "Play Once Asynchronously";
            this.playOnceAsyncButton.Click += new System.EventHandler(this.playOnceAsyncButton_Click);
            // 
            // playOnceSyncButton
            // 
            this.playOnceSyncButton.Location = new System.Drawing.Point(7, 83);
            this.playOnceSyncButton.Name = "playOnceSyncButton";
            this.playOnceSyncButton.Size = new System.Drawing.Size(142, 23);
            this.playOnceSyncButton.TabIndex = 15;
            this.playOnceSyncButton.Text = "Play Once Synchronously";
            this.playOnceSyncButton.Click += new System.EventHandler(this.playOnceSyncButton_Click);
            // 
            // loadSyncButton
            // 
            this.loadSyncButton.Location = new System.Drawing.Point(7, 50);
            this.loadSyncButton.Name = "loadSyncButton";
            this.loadSyncButton.Size = new System.Drawing.Size(142, 23);
            this.loadSyncButton.TabIndex = 14;
            this.loadSyncButton.Text = "Load Synchronously";
            this.loadSyncButton.Click += new System.EventHandler(this.loadSyncButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = ".wav path or URL:";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileButton.Location = new System.Drawing.Point(274, 22);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(23, 21);
            this.selectFileButton.TabIndex = 12;
            this.selectFileButton.Text = "...";
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // filepathTextbox
            // 
            this.filepathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filepathTextbox.Location = new System.Drawing.Point(7, 22);
            this.filepathTextbox.Name = "filepathTextbox";
            this.filepathTextbox.Size = new System.Drawing.Size(261, 21);
            this.filepathTextbox.TabIndex = 11;
            this.filepathTextbox.TextChanged += new System.EventHandler(this.filepathTextbox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 164);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(363, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 186);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.loadAsyncButton);
            this.Controls.Add(this.playLoopAsyncButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playOnceAsyncButton);
            this.Controls.Add(this.playOnceSyncButton);
            this.Controls.Add(this.loadSyncButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.filepathTextbox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.SoundTestForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadAsyncButton;
        private System.Windows.Forms.Button playLoopAsyncButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playOnceAsyncButton;
        private System.Windows.Forms.Button playOnceSyncButton;
        private System.Windows.Forms.Button loadSyncButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox filepathTextbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}