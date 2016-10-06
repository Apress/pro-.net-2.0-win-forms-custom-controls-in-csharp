using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Microsoft.Samples
{
	// This class is the base for all button controls in this project.
	// It contains fields so that inheriting buttons can track 
	// button state (normal, hover, pressed, and disabled)
	public abstract class StateButtonBase : Control, IButtonControl 
	{
		#region Fields
		DialogResult dialogResult = DialogResult.None;
		StateButtonState state;
		#endregion

		#region Constructor
		public StateButtonBase() 
		{
			SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, false);
		}
		#endregion

		#region Properties
		protected override Size DefaultSize 
		{
			get 
			{
				return new Size(75, 23);
			}
		}

		[
		Category("Behavior"),
		DefaultValue(typeof(DialogResult), "DialogResult.None"),
		Description("Specifies the dialog result that this button will return when a form is closed by clicking it")
		]
		public DialogResult DialogResult 
		{
			get 
			{
				return dialogResult;
			}
			set 
			{
				dialogResult = value;
			}
		}
        
		protected StateButtonState State 
		{
			get 
			{
				return state;
			}
		}
		#endregion

		#region Methods & Event Handlers
		void SetState(StateButtonState setState, bool set) 
		{
			StateButtonState newState = this.state;
			if (set) 
			{
				newState |= setState;
			}
			else 
			{
				newState &= ~setState;
			}

			if (this.state != newState) 
			{
				this.state = newState;
				Invalidate();
			}
		}

		void IButtonControl.NotifyDefault(bool isDefault) 
		{
			SetState(StateButtonState.Default, isDefault);
		}

		public void PerformClick() 
		{
			OnClick(EventArgs.Empty);
		}

		protected override void OnMouseDown(MouseEventArgs e) 
		{
			SetState(StateButtonState.Pressed, true);
			base.OnMouseDown(e);
		}
		protected override void OnMouseUp(MouseEventArgs e) 
		{
			bool click = false;
			if ((State & StateButtonState.Pressed) != 0) 
			{
				click = true;
			}
			SetState(StateButtonState.Pressed, false);
			base.OnMouseUp(e);
            
			if (click) 
			{
				Update();
				PerformClick();
			}
		}
		protected override void OnMouseMove(MouseEventArgs e) 
		{
			if (Capture) 
			{
				SetState(StateButtonState.Pressed, ClientRectangle.Contains(e.X, e.Y));
			}
			base.OnMouseMove(e);
		}
		protected override void OnMouseEnter(EventArgs e) 
		{
			SetState(StateButtonState.MouseHover, true);
			base.OnMouseEnter(e);
		}
		protected override void OnMouseLeave(EventArgs e) 
		{
			SetState(StateButtonState.MouseHover, false);
			base.OnMouseLeave(e);
		}
		#endregion
	}

	// This cenum is used for the states which a button can have
	[Flags]
	public enum StateButtonState 
	{
		None        = 0x00,
		Pressed     = 0x01,
		MouseHover  = 0x02,
		Default     = 0x04,
		Disabled    = 0x08,
	}
}
