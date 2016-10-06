using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace AnimatedButtons
{
	public abstract class AnimatedButtonBase : Control, IButtonControl
	{
		public AnimatedButtonBase()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x20;
        //        return cp;
        //    }
        //}

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
            //if (BackColor == Color.Transparent)
            //{
            //    // Do nothing.
            //}
            //else
            //{
            //    base.OnPaintBackground(e);
            //}
        //}

		#region IButtonControl Members

		private DialogResult dialogResult;
		public DialogResult DialogResult
		{
			get { return dialogResult; }
			set { dialogResult = value; }
		}

		public void NotifyDefault(bool value)
		{
			// Fires when the button is made into a default.
			// You could set properties to adjust the rendering,
			// but that's not necessary.
			OnNotifyDefault(value);
		}

		public virtual void OnNotifyDefault(bool value)
		{
			// This method can be overriden in derived classes.
		}

		public void PerformClick()
		{
			OnClick(EventArgs.Empty);
		}

		#endregion

		public enum States
		{
			Normal,
			MouseOver,
			Pushed,
			Disabled
		}
		private States state = States.Normal;
		// This property procedure ensures the control is
		// invalidated only when the state changes.
		private States State
		{
			get { return state; }
			set
			{
				if (state != value)
				{
					state = value;
					Invalidate();
				}
			}
		}

		// You must override this property to invalidate the display and
		// provide automatic refresh when the property is changed.
		public override string Text
		{
		    get
		    {
		        return base.Text;
		    }
		    set
		    {
		        if (value != base.Text)
		        {
		            base.Text = value;
					FlushCache();
		            Invalidate();
		        }
		    }
		}

		protected override void OnEnabledChanged(EventArgs e)
		{
			if (!Enabled)
				State = States.Disabled;
			else if (Enabled && State == States.Disabled)
				State = States.Normal;
			base.OnEnabledChanged(e);
		}

		protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
		{
            
			base.OnMouseMove(e);

			// Do nothing if the button is disabled.
			if (State == States.Disabled) return;

			if (HitTest(e.X, e.Y))
			{
				if (State != States.Pushed) State = States.MouseOver;
			}
			else
			{
				State = States.Normal;
			}
		}

		// If you want to make only a portion of the button
		// clicakble, this is the method to override.
		protected virtual bool HitTest(int X, int Y)
		{
			return true;
		}

		protected override void OnMouseLeave(System.EventArgs e)
		{
			if (State != States.Disabled) State = States.Normal;
		}

		protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
		{
			// Do nothing if the button is disabled.
			if (State == States.Disabled) return;

			if (HitTest(e.X, e.Y))
			{
				if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
				{
                    Focus();
					State = States.Pushed;
				}
			}
		}

		protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
		{
			// Do nothing if the button is disabled.
			if (State == States.Disabled) return;

			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				if (HitTest(e.X, e.Y))
				{
					State = States.MouseOver;
				}
				else
				{
					State = States.Normal;
				}
			}
		}

		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			if (!cacheImages)
			{
				// Version without caching.
				switch (State)
				{
					case States.Normal:
						PaintNormal(e.Graphics);
						break;
					case States.MouseOver:
						PaintMouseOver(e.Graphics);
						break;
					case States.Pushed:
						PaintPushed(e.Graphics);
						break;
					case States.Disabled:
						PaintDisabled(e.Graphics);
						break;
				}
                if (this.Focused && State != States.Disabled) PaintFocusRectangle(e.Graphics);
			}
			else
			{
				switch (State)
				{
					case States.Normal:
						CreateAndPaintCachedImage(normalImage,
							new ClientPaintMethod(PaintNormal), e.Graphics);
						break;
					case States.MouseOver:
						CreateAndPaintCachedImage(mouseOverImage,
							new ClientPaintMethod(PaintMouseOver), e.Graphics);
						break;
					case States.Pushed:
						CreateAndPaintCachedImage(pushedImage,
							new ClientPaintMethod(PaintPushed), e.Graphics);
						break;
					case States.Disabled:
						CreateAndPaintCachedImage(disabledImage,
							new ClientPaintMethod(PaintDisabled), e.Graphics);
						break;
				}
				if (this.Focused) PaintFocusRectangle(e.Graphics);
			}
		}

		private delegate void ClientPaintMethod(Graphics g);
		private void CreateAndPaintCachedImage(
			Image image, ClientPaintMethod paintMethod, Graphics g)
		{
			if (image == null)
			{
				image = new Bitmap(Width, Height);
				Graphics bufferedGraphics = Graphics.FromImage(image);
				paintMethod(bufferedGraphics);
				bufferedGraphics.Dispose();
			}
			g.DrawImageUnscaled(image, new Point(0, 0));
		}

		protected abstract void PaintNormal(Graphics g);

		protected abstract void PaintMouseOver(Graphics g);

		protected abstract void PaintPushed(Graphics g);

		protected abstract void PaintDisabled(Graphics g);

		private bool paintFocusCue = true;
		public bool PaintFocusCue
		{
			get { return paintFocusCue; }
			set
			{
				if (value != paintFocusCue)
				{
					paintFocusCue = value;
					Invalidate();
				}
			}
		}
		protected virtual void PaintFocusRectangle(Graphics g)
		{
			ControlPaint.DrawFocusRectangle(g, this.ClientRectangle);
		}

		protected override void OnGotFocus(EventArgs e)
		{
			if (paintFocusCue) Invalidate();
		}

		protected override void OnLostFocus(EventArgs e)
		{
			if (paintFocusCue) Invalidate();
		}

		protected override void OnClick(System.EventArgs e)
		{
			// Only propagate the click to the client
			// if it's a valid, hit-tested region.
			if (State == States.Pushed)
			{
				base.OnClick(e);
			}
		}

		// Only has an effect if set before other properties.
		// You could use ISupportInitialize, but in this case
		// it's not needed because CacheImages setting is serialized
		// first (alphabetically).
		private bool cacheImages = true;
		public bool CacheImages
		{
			get { return cacheImages; }
			set { cacheImages = value; }
		}

		private Image normalImage;
		private Image mouseOverImage;
		private Image pushedImage;
		private Image disabledImage;

		protected void FlushCache()
		{
			normalImage = null;
			mouseOverImage = null;
			pushedImage = null;
			disabledImage = null;
		}
		// Add code to remove cached images when size, or other
		// properties change.
	}

}
