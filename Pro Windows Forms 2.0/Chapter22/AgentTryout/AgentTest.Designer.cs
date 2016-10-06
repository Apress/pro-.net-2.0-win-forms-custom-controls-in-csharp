namespace AgentTryout
{
    partial class AgentTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentTest));
            this.axAgent1 = new AxAgentObjects.AxAgent();
            this.cmdClose = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.cmdMove = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdSpeak = new System.Windows.Forms.Button();
            this.txtSpeak = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.lstAnimations = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAgent1)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axAgent1
            // 
            this.axAgent1.Enabled = true;
            this.axAgent1.Location = new System.Drawing.Point(59, 322);
            this.axAgent1.Name = "axAgent1";
            this.axAgent1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAgent1.OcxState")));
            this.axAgent1.Size = new System.Drawing.Size(32, 32);
            this.axAgent1.TabIndex = 18;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdClose.Location = new System.Drawing.Point(294, 329);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(96, 24);
            this.cmdClose.TabIndex = 17;
            this.cmdClose.Text = "Close";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.txtY);
            this.GroupBox3.Controls.Add(this.txtX);
            this.GroupBox3.Controls.Add(this.cmdMove);
            this.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox3.Location = new System.Drawing.Point(7, 249);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(384, 64);
            this.GroupBox3.TabIndex = 16;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Move";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(84, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(20, 16);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Y:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(20, 16);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "X:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(104, 24);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(36, 21);
            this.txtY.TabIndex = 9;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(36, 24);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(36, 21);
            this.txtX.TabIndex = 8;
            // 
            // cmdMove
            // 
            this.cmdMove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdMove.Location = new System.Drawing.Point(248, 24);
            this.cmdMove.Name = "cmdMove";
            this.cmdMove.Size = new System.Drawing.Size(72, 20);
            this.cmdMove.TabIndex = 7;
            this.cmdMove.Text = "Move";
            this.cmdMove.Click += new System.EventHandler(this.cmdMove_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.cmdSpeak);
            this.GroupBox2.Controls.Add(this.txtSpeak);
            this.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox2.Location = new System.Drawing.Point(7, 161);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(384, 80);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Speak";
            // 
            // cmdSpeak
            // 
            this.cmdSpeak.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSpeak.Location = new System.Drawing.Point(248, 20);
            this.cmdSpeak.Name = "cmdSpeak";
            this.cmdSpeak.Size = new System.Drawing.Size(72, 20);
            this.cmdSpeak.TabIndex = 6;
            this.cmdSpeak.Text = "Speak";
            this.cmdSpeak.Click += new System.EventHandler(this.cmdSpeak_Click);
            // 
            // txtSpeak
            // 
            this.txtSpeak.AcceptsReturn = true;
            this.txtSpeak.Location = new System.Drawing.Point(8, 20);
            this.txtSpeak.Multiline = true;
            this.txtSpeak.Name = "txtSpeak";
            this.txtSpeak.Size = new System.Drawing.Size(232, 48);
            this.txtSpeak.TabIndex = 4;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.cmdStop);
            this.GroupBox1.Controls.Add(this.cmdPlay);
            this.GroupBox1.Controls.Add(this.lstAnimations);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Location = new System.Drawing.Point(7, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(384, 144);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Animate";
            // 
            // cmdStop
            // 
            this.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdStop.Location = new System.Drawing.Point(248, 48);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(72, 20);
            this.cmdStop.TabIndex = 6;
            this.cmdStop.Text = "Stop";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdPlay.Location = new System.Drawing.Point(248, 24);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(72, 20);
            this.cmdPlay.TabIndex = 5;
            this.cmdPlay.Text = "Play";
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // lstAnimations
            // 
            this.lstAnimations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAnimations.IntegralHeight = false;
            this.lstAnimations.Location = new System.Drawing.Point(8, 22);
            this.lstAnimations.Name = "lstAnimations";
            this.lstAnimations.Size = new System.Drawing.Size(232, 109);
            this.lstAnimations.TabIndex = 4;
            // 
            // AgentTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 364);
            this.Controls.Add(this.axAgent1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AgentTest";
            this.Text = "AgentTest";
            this.Load += new System.EventHandler(this.AgentTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAgent1)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxAgentObjects.AxAgent axAgent1;
        internal System.Windows.Forms.Button cmdClose;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtY;
        internal System.Windows.Forms.TextBox txtX;
        internal System.Windows.Forms.Button cmdMove;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button cmdSpeak;
        internal System.Windows.Forms.TextBox txtSpeak;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button cmdStop;
        internal System.Windows.Forms.Button cmdPlay;
        internal System.Windows.Forms.ListBox lstAnimations;
    }
}