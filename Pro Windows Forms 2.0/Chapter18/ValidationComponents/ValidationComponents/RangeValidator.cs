using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ValidationComponents
{
	// Allow for different types of range comparison.
	// You could add different options to support more
	// data types, like dates.
	public enum ValidationDataType
	{
		Integer,
		Double,
		Text
	}

	public partial class RangeValidator : BaseValidator
	{
		public RangeValidator()
		{
			InitializeComponent();
		}

		public RangeValidator(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		// Determines how the ranges are compared
		// (numerically or alphabetically).
		private ValidationDataType validationDataType;
		public ValidationDataType Type
		{
			get { return validationDataType; }
			set { validationDataType = value; }
		}

		// Set a minimum and maximum allowed value.
		// You could add checks to make sure the minimum value
		// isn't greater than the maximum value.
		private string minimumValue = "";
		public string MinimumValue
		{
			get { return minimumValue; }
			set { minimumValue = value; }
		}

		private string maximumValue = "";
		public string MaximumValue
		{
			get { return maximumValue; }
			set { maximumValue = value; }
		}

		// Check if the value falls in the range.
		protected override bool EvaluateIsValid()
		{
			// Don't validate if empty (that's a job for the RequiredFieldValidator).
			if (ControlToValidate.Text.Trim() == "") return true;

			switch (validationDataType)
			{
				case ValidationDataType.Double:
				case ValidationDataType.Integer:
					if (validationDataType == ValidationDataType.Integer)
					{
						// Check there's no decimal point.
						if (ControlToValidate.Text.IndexOf(".") != -1) return false;
					}

					try
					{
						double valD = Double.Parse(ControlToValidate.Text);
						return ((valD >= Double.Parse(minimumValue)) && (valD <= Double.Parse(maximumValue)));
					}
					catch
					{
						// The text can't be converted to a number
						return false;
					}
				case ValidationDataType.Text:
					string valS = ControlToValidate.Text;
					return ((String.Compare(valS, minimumValue) >= 0) && (String.Compare(valS, maximumValue) <= 0));
				default:
					return false;
			}
		}

	}
}
