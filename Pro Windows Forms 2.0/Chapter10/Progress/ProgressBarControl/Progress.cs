using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ProgressBarControl
{
	/// <summary>
	/// Summary description for Progress.
	/// </summary>
	public class Progress : System.Windows.Forms.UserControl
	{
		internal System.Windows.Forms.Label lblProgress;
		internal System.Windows.Forms.ProgressBar Bar;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public Progress()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblProgress = new System.Windows.Forms.Label();
			this.Bar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// lblProgress
			// 
			this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.lblProgress.Location = new System.Drawing.Point(5, 46);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(152, 16);
			this.lblProgress.TabIndex = 3;
			this.lblProgress.Text = "0% Done";
			this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Bar
			// 
			this.Bar.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.Bar.Location = new System.Drawing.Point(5, 6);
			this.Bar.Name = "Bar";
			this.Bar.Size = new System.Drawing.Size(154, 32);
			this.Bar.TabIndex = 2;
			// 
			// Progress
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblProgress,
																		  this.Bar});
			this.Name = "Progress";
			this.Size = new System.Drawing.Size(164, 68);
			this.ResumeLayout(false);

		}
		#endregion
		public int Value
		{
			get
			{
				return Bar.Value;
			}
			set
			{
				Bar.Value = value;
				UpdateLabel();
			}
		}

		public int Maximum
		{
			get
			{
				return Bar.Maximum;
			}
			set
			{
				Bar.Maximum = value;
			}
		}

		public int Step
		{
			get
			{
				return Bar.Step;
			}
			set
			{
				Bar.Step = value;
			}
		}

		public void PerformStep()
		{
			Bar.PerformStep();
			UpdateLabel();
		}

		private void UpdateLabel()
		{
			lblProgress.Text = (Math.Round((decimal)(Bar.Value * 100) /
				Bar.Maximum)).ToString();
			lblProgress.Text += "% Done";
		}
	}

}
