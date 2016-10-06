using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToCollections
{
	public partial class EditableBinding : Form
	{
		public EditableBinding()
		{
			InitializeComponent();
		}

		private void EditableBinding_Load(object sender, EventArgs e)
		{
			BindingList<Product> products = Program.StoreDB.GetProducts();

			cboModelName.DataSource = products;
			cboModelName.DisplayMember = "ModelName";

			// Create the binding.
			Binding costBinding = new Binding("Text", products, "UnitCost");

			// Connect the methods for formatting and parsing data.
			costBinding.Format += new ConvertEventHandler(DecimalToCurrencyString);
			costBinding.Parse += new ConvertEventHandler(CurrencyStringToDecimal);

			// Add the binding.
			txtUnitCost.DataBindings.Add(costBinding);
			txtModelName.DataBindings.Add("Text", products, "ModelName");
			txtModelNumber.DataBindings.Add("Text", products, "ModelNumber");

			txtDescription.DataBindings.Add("Text", products, "Description");
		}

		private object previousValue; 
		private void DecimalToCurrencyString(object sender, ConvertEventArgs e)
		{
			if (e.DesiredType == typeof(string))
			{
				// Use the ToString method to format the value as currency ("c").
				e.Value = ((decimal)e.Value).ToString("c");
			}
		}

		private void CurrencyStringToDecimal(object sender, ConvertEventArgs e)
		{
			if (e.DesiredType == typeof(decimal))
			{
				// Convert the string back to decimal using the static Parse method.
				try
				{
					previousValue = e.Value;
					e.Value = Decimal.Parse(e.Value.ToString(),
							   System.Globalization.NumberStyles.Currency, null);
				}
				catch
				{
					e.Value = previousValue;
				}
			}
		}

		

	}
}