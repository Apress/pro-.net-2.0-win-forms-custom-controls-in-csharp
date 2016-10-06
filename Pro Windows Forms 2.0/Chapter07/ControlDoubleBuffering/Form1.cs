using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ControlDoubleBuffering
{
    public partial class Form1 : Form
    {
        BufferedPanel logo1;
        
        public Form1()
        {
            InitializeComponent();
            
            // bug in line below - this isn't respected if BackgroundImage is set
            this.SetStyle(ControlStyles.ResizeRedraw, false);

            this.DoubleBuffered = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logo1 == null)
            {
                logo1 = new BufferedPanel();
                logo1.Location = new System.Drawing.Point(105, 29);
                logo1.Name = "logo1";
                logo1.Size = new System.Drawing.Size(160, 200);
                logo1.TabIndex = 0;
                this.Controls.Add(logo1);
            }
            else
            {
                this.Controls.Remove(logo1);
                logo1 = null;
            }
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("invalidated");
            base.OnInvalidated(e);
        }

		const int RINGCOUNT = 100;
		const float SWEEP = 2f;
		const float INTERVAL = 5f;
		const int INCREMENTS = 72; // usually 360/INTERVAL
		
		private void logo2_Paint(object sender, PaintEventArgs e)
		{
			Control ctrl = (Control)sender;
			// intentionally slow painting algorith here

			// Decide whether or not to use manual double-buffering.
			Graphics g;
			Bitmap bitmap = null;
			if (sender == panel2)
			{
				bitmap = new Bitmap(ctrl.ClientRectangle.Width, ctrl.ClientRectangle.Height);
				g = Graphics.FromImage(bitmap);
			}
			else
			{
				g = e.Graphics;
			}


			g.SmoothingMode = SmoothingMode.AntiAlias;
			RectangleF paintRect = new Rectangle(ctrl.Width / 2, ctrl.Height / 2, 0, 0);
			Rectangle borderRect = ctrl.ClientRectangle;

			borderRect.Size = new Size(borderRect.Width - 1, borderRect.Height - 1);
			g.DrawRectangle(Pens.Yellow, borderRect);
			float hScale = (float)this.Width / ((float)RINGCOUNT * 2f);
			float vScale = (float)this.Height / ((float)RINGCOUNT * 2f);

			for (int i = 0; i < RINGCOUNT; i++)
			{
				paintRect.Inflate(hScale, vScale);

				for (int j = 0; j < INCREMENTS; j++)
				{
					g.DrawArc(Pens.Yellow, paintRect, (float)j * INTERVAL, SWEEP);
				}
			}

			// If using double buffering, render the final image and dispose of it.
			if (sender == panel2)
			{
				e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
				g.Dispose();
				bitmap.Dispose();
			}
		}
        

		private void chkShowBufferedPanel_CheckedChanged(object sender, EventArgs e)
		{
			bufferedPanel.Visible = chkShowBufferedPanel.Checked;
		}

		private void chkShowPanel_CheckedChanged(object sender, EventArgs e)
		{
			panel1.Visible = chkShowPanel.Checked;
		}

		private void chkShowManualBufferedPanel_CheckedChanged(object sender, EventArgs e)
		{
			panel2.Visible = chkShowManualBufferedPanel.Checked;
		}

    
    }
}