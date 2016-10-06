using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ValidationComponents
{
	public abstract partial class BaseValidator : Component
	{
		public BaseValidator()
		{
			InitializeComponent();
		}

		public BaseValidator(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		// Use an internal error provider to show error icons.
		private ErrorProvider errorProvider = new ErrorProvider();

		// Expose whatever ErrorProvider settings you want the
		// user to be able to modify (like Icon, BlinkStyle, and BlinkRate).
		// This class only exposes Icon.
		public Icon Icon 
		{
			get { return errorProvider.Icon; }
			set { errorProvider.Icon = value; }
		}
		
		// This is the error message that will be shown if validation fails.
		private string errorMessage;
    	public string ErrorMessage 
		{
			get { return errorMessage; }
			set { errorMessage = value; }
		}
		
		private bool cancelFocus = false;
		public bool CancelFocusChangeWhenInvalid
		{
			get { return cancelFocus; }
			set { cancelFocus = value; }
		}

		// This is the control that will be validated.
		// The ReferenceConverter allows the user to choose a control from
		// a drop-down list with all the controls on the form.
		private Control controlToValidate;
		[TypeConverter(typeof(ReferenceConverter))]
		public Control ControlToValidate 
		{
			get { return controlToValidate; }
			set 
			{
				// Detach from previous control.
				if ((controlToValidate != null) && (!DesignMode))
				{
					controlToValidate.Validating -= new CancelEventHandler(ControlToValidate_Validating);
				}

				controlToValidate = value;
      			// Hook up the control's Validating event.
				if ((controlToValidate != null) && (!DesignMode)) 
				{
					controlToValidate.Validating += new CancelEventHandler(ControlToValidate_Validating);
				}
			}
		}

		// This property allows you to check if validation succeeded.
		// The safest option is to default to false, and assume that
		// any unvalidated data is not valid.
		private bool isValid = false;		
		public bool IsValid 
		{
			get { return isValid; }
		}  
    
		// Validate the control when the Validating event fires.
		private void ControlToValidate_Validating(object sender, CancelEventArgs e) 
		{
			Validate();
			// Cancel the focus change if the data is invalid,
			// and this is the configured behavior.
			if (!isValid && cancelFocus) e.Cancel = true;
		}

		// This is a public method so that validation can be triggered
		// manually if you want, not just in response to the Validating event.
		public bool Validate() 
		{
			// Validate the control (using whatever functionality
			// is provided in the derived class).
			isValid = EvaluateIsValid();

			if (isValid) 
			{
				// Clear the error message.
				errorProvider.SetError(controlToValidate, "");
			}
			else
			{
				// Display the error message.
				errorProvider.SetError(controlToValidate, errorMessage);
			}
			return isValid;
		}

		// This is the method where the derived classes will
		// execute their validation logic.
		protected abstract bool EvaluateIsValid();

		public static bool IsFormValid(IContainer formComponents)
		{
			bool invalidInput = false;

			// Make sure all the validation is performed.
			foreach (IComponent component in formComponents.Components)
			{
				BaseValidator validator = component as BaseValidator;
				if (validator != null)
				{
					validator.Validate();
					if (!validator.IsValid) invalidInput = true;
				}
			}
			return !invalidInput;
		}
	}
}
