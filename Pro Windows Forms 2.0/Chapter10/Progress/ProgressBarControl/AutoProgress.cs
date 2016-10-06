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
	public class AutoProgress : System.Windows.Forms.UserControl
    {
        internal System.Windows.Forms.ProgressBar Bar;
        internal Timer tmrIncrementBar;
        private IContainer components;

		public AutoProgress()
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
            this.components = new System.ComponentModel.Container();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.tmrIncrementBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
// 
// Bar
// 
            this.Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(164, 42);
            this.Bar.TabIndex = 2;
// 
// tmrIncrementBar
// 
            this.tmrIncrementBar.Tick += new System.EventHandler(this.tmrIncrementBar_Tick);
// 
// AutoProgress
// 
            this.Controls.Add(this.Bar);
            this.Name = "AutoProgress";
            this.Size = new System.Drawing.Size(164, 42);
            this.ResumeLayout(false);

        }
		#endregion

        private int percentPerSecond = 5;
        public int PercentPerSecond
		{
			get
			{
				return percentPerSecond;
			}
			set
			{
                if (value < 0)
                {
                    throw new ArgumentException("Progress cannot go backward.");
                }
                else if (value == 0)
                {
                    throw new ArgumentException("Progress must go on.");
                }
                percentPerSecond = value;
			}
		}           
		
		public void Start()
		{
			// The maximum isn't controls how fine-grained
			// the progress bar is. 200 is a good choice.
			Bar.Maximum = 200;

			// Calculation is based on a timer that
			// fires 10 times per second (an interval of 100).
			tmrIncrementBar.Interval = 100;
			decimal step = Math.Round((decimal)Bar.Maximum * PercentPerSecond / 1000);
			Bar.Step = (int)step;

			// Reset the progress and start counting.
            Bar.Value = 0;
            tmrIncrementBar.Start();
        }

        public void Stop()
        {
            tmrIncrementBar.Stop();
            Bar.Value = 0;
        }

        public void Finish()
        {
            tmrIncrementBar.Stop();
            Bar.Value = Bar.Maximum;
        }

        private void tmrIncrementBar_Tick(object sender, EventArgs e)
        {
            Bar.PerformStep();
            if (Bar.Value == Bar.Maximum)
            {
                Bar.Value = 0;
            }
        }
	}

}
