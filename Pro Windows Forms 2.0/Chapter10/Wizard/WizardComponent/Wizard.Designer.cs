namespace WizardComponent
{
    partial class Wizard
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
			if (disposing)
			{
				foreach (System.Windows.Forms.Control ctrl in steps)
				{
					ctrl.Dispose();
				}
			}
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.lblHeader = new System.Windows.Forms.Label();
			this.panelStep = new System.Windows.Forms.Panel();
			this.cmdNext = new System.Windows.Forms.Button();
			this.cmdPrev = new System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel1
			// 
			this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Panel1.BackColor = System.Drawing.Color.White;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.lblHeader);
			this.Panel1.Location = new System.Drawing.Point(4, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(412, 68);
			this.Panel1.TabIndex = 4;
			// 
			// lblHeader
			// 
			this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(16, 1);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(386, 65);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Header Text";
			this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelStep
			// 
			this.panelStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panelStep.AutoScroll = true;
			this.panelStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelStep.Location = new System.Drawing.Point(4, 77);
			this.panelStep.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.panelStep.Name = "panelStep";
			this.panelStep.Size = new System.Drawing.Size(412, 195);
			this.panelStep.TabIndex = 6;
			// 
			// cmdNext
			// 
			this.cmdNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdNext.Location = new System.Drawing.Point(356, 279);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(60, 28);
			this.cmdNext.TabIndex = 8;
			this.cmdNext.Text = "Next >";
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			// 
			// cmdPrev
			// 
			this.cmdPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdPrev.Location = new System.Drawing.Point(293, 279);
			this.cmdPrev.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
			this.cmdPrev.Name = "cmdPrev";
			this.cmdPrev.Size = new System.Drawing.Size(60, 28);
			this.cmdPrev.TabIndex = 9;
			this.cmdPrev.Text = "< Prev";
			this.cmdPrev.Visible = false;
			this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
			// 
			// Wizard
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(419, 315);
			this.Controls.Add(this.cmdPrev);
			this.Controls.Add(this.cmdNext);
			this.Controls.Add(this.panelStep);
			this.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Wizard";
			this.Text = "Wizard";
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel panelStep;
        internal System.Windows.Forms.Label lblHeader;
        internal System.Windows.Forms.Button cmdNext;
        internal System.Windows.Forms.Button cmdPrev;
    }
}