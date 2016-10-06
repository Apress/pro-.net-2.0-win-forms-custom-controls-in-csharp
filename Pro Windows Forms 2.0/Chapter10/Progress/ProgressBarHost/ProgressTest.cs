using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ProgressHost
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ProgressTest : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Timer tmrIncrementBar;
		private System.Windows.Forms.Button cmdStart;
		private ProgressBarControl.Progress status;
		private System.ComponentModel.IContainer components;

		public ProgressTest()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.status = new ProgressBarControl.Progress();
			this.tmrIncrementBar = new System.Windows.Forms.Timer(this.components);
			this.cmdStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// status
			// 
			this.status.Location = new System.Drawing.Point(12, 8);
			this.status.Maximum = 100;
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(272, 88);
			this.status.Step = 10;
			this.status.TabIndex = 0;
			this.status.Value = 0;
			// 
			// tmrIncrementBar
			// 
			this.tmrIncrementBar.Interval = 1000;
			this.tmrIncrementBar.Tick += new System.EventHandler(this.tmrIncrementBar_Tick);
			// 
			// cmdStart
			// 
			this.cmdStart.Location = new System.Drawing.Point(104, 152);
			this.cmdStart.Name = "cmdStart";
			this.cmdStart.Size = new System.Drawing.Size(92, 24);
			this.cmdStart.TabIndex = 1;
			this.cmdStart.Text = "Start";
			this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(292, 194);
			this.Controls.Add(this.cmdStart);
			this.Controls.Add(this.status);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Progress Host";
			this.ResumeLayout(false);

        }
		#endregion



		private void tmrIncrementBar_Tick(object sender, System.EventArgs e)
		{
			status.PerformStep();
			if (status.Maximum == status.Value)
			{
				tmrIncrementBar.Enabled = false;
			}

		}

		private void cmdStart_Click(object sender, System.EventArgs e)
		{
			tmrIncrementBar.Enabled = false;

			status.Value = 0;
			status.Maximum = 20;
			status.Step = 1;

			tmrIncrementBar.Enabled = true;           
        }


	}
}
