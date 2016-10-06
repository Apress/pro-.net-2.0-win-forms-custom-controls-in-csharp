using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToDataSet
{
	public partial class Validation : Form
	{
		public Validation()
		{
			InitializeComponent();
		}

		private int currentPage;
		private bool errFlag;
		private BindingManagerBase storeBinding;

		private void EditableBinding_Load(object sender, EventArgs e)
		{
			DataTable dt = Program.StoreDB.GetProducts();

			cboModelName.DataSource = dt;
			cboModelName.DisplayMember = "ModelName";

			Binding costBinding = new Binding("Text", dt, "UnitCost");
			txtUnitCost.DataBindings.Add(costBinding);
			txtModelName.DataBindings.Add("Text", dt, "ModelName");
			txtModelNumber.DataBindings.Add("Text", dt, "ModelNumber");	
			txtDescription.DataBindings.Add("Text", dt, "Description");

			// Keep track of the binding context.
			storeBinding = this.BindingContext[dt];

			dt.ColumnChanged += new DataColumnChangeEventHandler(TableChanged);
			storeBinding.PositionChanged += new EventHandler(Binding_PositionChanged);
		}

		private void Binding_PositionChanged(object sender, System.EventArgs e)
		{
			if (errFlag)
			{
				// Reset the page.
				storeBinding.Position = currentPage;
			}
			else
			{
				// Allow the page to change and update the currentPage variable.
				currentPage = storeBinding.Position;
			}
		}

		private void TableChanged(object sender, System.Data.DataColumnChangeEventArgs e)
		{
			string errors = Program.StoreDB.ValidateProduct(e.Row);

			if (errors == "")
			{
				errFlag = false;
			}
			else
			{
				errFlag = true;
			}
			lblStatus.Text = errors;
		}

	}
}