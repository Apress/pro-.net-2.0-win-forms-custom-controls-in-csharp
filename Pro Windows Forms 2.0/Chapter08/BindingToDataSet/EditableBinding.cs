using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToDataSet
{
	public partial class EditableBinding : Form
	{
		public EditableBinding()
		{
			InitializeComponent();
		}

		private void EditableBinding_Load(object sender, EventArgs e)
		{
			DataTable dt = Program.StoreDB.GetProducts();

			cboModelName.DataSource = dt;
			cboModelName.DisplayMember = "ModelName";

			// Create the binding.
			Binding costBinding = new Binding("Text", dt, "UnitCost");

			// Connect the methods for formatting and parsing data.
			costBinding.Format += new ConvertEventHandler(DecimalToCurrencyString);
			costBinding.Parse += new ConvertEventHandler(CurrencyStringToDecimal);
            
			// Add the binding.
			txtUnitCost.DataBindings.Add(costBinding);
			txtModelName.DataBindings.Add("Text", dt, "ModelName");
			txtModelNumber.DataBindings.Add("Text", dt, "ModelNumber");
			
			txtDescription.DataBindings.Add("Text", dt, "Description");

			// Register an event handler for changes to the DataTable (optional).
			dt.ColumnChanged += new DataColumnChangeEventHandler(TableChanged);
		}

		object previousUnitCost;
		private void DecimalToCurrencyString(object sender, ConvertEventArgs e)
		{
			if (e.DesiredType == typeof(string))
			{
				previousUnitCost = e.Value;
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
					e.Value = Decimal.Parse(e.Value.ToString());
				}
				catch
				{
					e.Value = previousUnitCost;
				}
			}
		}

		private void TableChanged(object sender, System.Data.DataColumnChangeEventArgs e)
		{
			lblStatus.Text = "Detected change. Column " + e.Column.ColumnName;
			lblStatus.Text += " updated to " + e.ProposedValue.ToString() + ".";
		}


	}
}