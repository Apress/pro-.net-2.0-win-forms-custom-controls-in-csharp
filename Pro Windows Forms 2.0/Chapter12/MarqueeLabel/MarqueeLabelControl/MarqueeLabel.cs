using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace MarqueeLabel
{
	/// <summary>
	/// Summary description for MarqueeLabel.
	/// </summary>
	public class MarqueeLabel : Control
	{
		private System.ComponentModel.IContainer components;

		public MarqueeLabel()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
        
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

		public void Scroll(bool state)
		{
			tmrScroll.Enabled = state;
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
			this.tmrScroll = new System.Windows.Forms.Timer(this.components);
			// 
			// tmrScroll
			// 
			this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
			// 
			// MarqueeLabel
			// 
			this.Name = "MarqueeLabel";
			this.Size = new System.Drawing.Size(360, 104);
			

		}
		#endregion

		private string text;
		private int scrollAmount = 10;
		internal System.Windows.Forms.Timer tmrScroll;
		private int position = 0;

		private void tmrScroll_Tick(object sender, System.EventArgs e)
		{
			position += scrollAmount;

			// Force a refresh.
			Invalidate();            
		}

		[Browsable(true), 
		DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override string Text
		{
			get
			{
				return text;
				}
			set
			{
				text = value;
				Invalidate();
			}
		}

		public int ScrollTimeInterval
		{
			get
			{
				return tmrScroll.Interval;
			}
			set
			{
				tmrScroll.Interval = value;
			}
		}

		[DefaultValue(10)] 
		public int ScrollPixelAmount
		{
			get
			{
				return scrollAmount;
			}
			set
			{
				scrollAmount = value;
			}
		}


		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
            base.OnPaint(e);

			
			if (position > Width)
			{
				// Reset the text to scroll back onto the control.
				position = -(int)e.Graphics.MeasureString(text, Font).Width;
			}

			//e.Graphics.FillRectangle(new SolidBrush(BackColor), e.ClipRectangle);
			e.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), position, 0);
		}
        
    }
}
