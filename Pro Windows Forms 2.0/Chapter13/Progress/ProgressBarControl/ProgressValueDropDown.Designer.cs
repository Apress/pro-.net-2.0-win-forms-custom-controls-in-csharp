namespace ProgressBarControl
{
	partial class ProgressValueDropDown
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblRange = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.lblValue = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblRange
			// 
			this.lblRange.AutoSize = true;
			this.lblRange.Location = new System.Drawing.Point(4, 3);
			this.lblRange.Name = "lblRange";
			this.lblRange.Size = new System.Drawing.Size(78, 13);
			this.lblRange.TabIndex = 0;
			this.lblRange.Text = "Allowed Range:";
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar1.Location = new System.Drawing.Point(-2, 20);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(192, 45);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// lblValue
			// 
			this.lblValue.Location = new System.Drawing.Point(4, 55);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(186, 12);
			this.lblValue.TabIndex = 2;
			this.lblValue.Text = "Current Value = ";
			this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(182, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(16, 16);
			this.button1.TabIndex = 3;
			this.button1.Text = "X";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ProgressValueDropDown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.lblRange);
			this.Name = "ProgressValueDropDown";
			this.Size = new System.Drawing.Size(198, 71);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRange;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.Button button1;
	}
}
