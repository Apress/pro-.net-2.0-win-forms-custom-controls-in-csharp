using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToCollections
{
	public partial class MultipleControlBinding : Form
	{
		private BindingManagerBase storeBinding;

		public MultipleControlBinding()
		{
			InitializeComponent();
		}

		private void MultipleControlBinding_Load(object sender, EventArgs e)
		{
			BindingList<Product> products = Program.StoreDB.GetProducts();

			cboModelName.DataSource = products;
			cboModelName.DisplayMember = "ModelName";

			lblModelNumber.DataBindings.Add("Text", products, "ModelNumber");
			lblUnitCost.DataBindings.Add("Text", products, "UnitCost", true, DataSourceUpdateMode.OnValidation, 0, "C");
			lblDescription.DataBindings.Add("Text",	products, "Description");
			
			// Keep track of the binding context.
			storeBinding = this.BindingContext[products];

			storeBinding.PositionChanged += new EventHandler(Binding_PositionChanged);
		}

		private void cmdPrev_Click(object sender, System.EventArgs e)
		{
			storeBinding.Position--;
		}

		private void cmdNext_Click(object sender, System.EventArgs e)
		{
			storeBinding.Position++;
		}

		private void Binding_PositionChanged(object sender, System.EventArgs e)
		{
			if (storeBinding.Position == storeBinding.Count - 1)
			{
				cmdNext.Enabled = false;
			}
			else
			{
				cmdNext.Enabled = true;
			}

			if (storeBinding.Position == 0)
			{
				cmdPrev.Enabled = false;
			}
			else
			{
				cmdPrev.Enabled = true;
			}
		}

	}
}