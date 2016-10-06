#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Forms.Design;

#endregion

namespace System.Windows.Forms.Samples
{
	[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
	public class ToolStripHoverItem : ToolStripLabel
	{
		private Image	_hoverImage = null;
		private Image	_image = null;
		private Image	_checkImage = null;
		private Image	_checkHoverImage = null;
		private Image	_onEnter = null;
		private Image	_onLeave = null;
		private bool	_checked = false;
		private bool	_hover = false;

		public ToolStripHoverItem()
		{
			this.DisplayStyle = ToolStripItemDisplayStyle.Image;
		}

		#region Public Properties
		public Image ImageHover
		{
			get { return _hoverImage; }
			set
			{
				_hoverImage = value;

				// Set default OnEnter image
				if (null == _onEnter)
				{
					_onEnter = _hoverImage;
				}
			}
		}

		public Image ImageNormal
		{
			get { return _image; }
			set
			{
				_image = value;

				// Set as default
				if (null == base.Image)
				{
					base.Image = _image;
				}

				// Set default OnLeave image
				if (null == _onLeave)
				{
					_onLeave = _image;
				}
			}
		}

		public Image ImageCheck
		{
			get { return _checkImage; }
			set { _checkImage = value; }
		}

		public Image ImageCheckHover
		{
			get { return _checkHoverImage; }
			set { _checkHoverImage = value; }
		}

		public bool Checked
		{
			get { return _checked; }
            set { SetState(value);  }
		}

		public event EventHandler CheckedChanged;

		protected virtual void OnCheckedChanged(EventArgs e)
		{
			if (null != CheckedChanged)
			{
				CheckedChanged(this, e);
			}
		}
		#endregion

		#region Overrides
		protected override void OnMouseEnter(EventArgs e)
		{
			// Save image
			if (null != _onEnter)
			{
				// Swap
				base.Image = _onEnter;
				_hover = true;
			}

			// Call base
			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			// Swap image
			if (null != _onLeave)
			{
				base.Image = _onLeave;
				_hover = false;
			}

			// Call base
			base.OnMouseLeave(e);
		}

        private void SetState(bool state)
        {
            // Then do our work
            if (_checked != state)
            {
                _checked = state;

                // Set clicked images
                if ((null != _checkImage) && (null != _checkHoverImage))
                {
                    if (_checked)
                    {
                        _onEnter = _checkHoverImage;
                        _onLeave = _checkImage;
                    }
                    else
                    {
                        _onEnter = _hoverImage;
                        _onLeave = _image;
                    }

                    // Set image based on click and hover state
                    base.Image = (_hover ? _onEnter : _onLeave);

                    // Fire on CheckedChanged
                    OnCheckedChanged(EventArgs.Empty);
                }
            }
        }

		protected override void OnClick(EventArgs e)
		{
			// Call the base (click event first)
			base.OnClick(e);

            // Set the state
            SetState(!_checked);
		}
		#endregion
	}
}
