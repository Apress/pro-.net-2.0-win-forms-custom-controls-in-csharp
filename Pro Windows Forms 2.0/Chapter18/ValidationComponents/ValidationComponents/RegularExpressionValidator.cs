using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationComponents
{
	public partial class RegularExpressionValidator : BaseValidator
	{
		public RegularExpressionValidator()
		{
			InitializeComponent();
		}

		public RegularExpressionValidator(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		// Store the regular expression.
		private string validationExpression;
		public string ValidationExpression
		{
			get { return validationExpression; }
			set { validationExpression = value; }
		}

		// Validate with the regular expression.
		protected override bool EvaluateIsValid()
		{
			// Don't validate if empty (that's a job for the RequiredFieldValidator).
			if (ControlToValidate.Text.Trim() == "") return true;

			// Evaluate the regular expression.
			Regex regex = new Regex(validationExpression);
			return regex.IsMatch(ControlToValidate.Text);
		}

	}
}
