using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToDataSet
{
	public partial class LookupTable : Form
	{
		public LookupTable()
		{
			InitializeComponent();
		}

		private void LookupTable_Load(object sender, EventArgs e)
		{
			DataSet ds = Program.StoreDB.GetCategoriesAndProducts();

			// Connect the product list used for navigation.
			cboModelName.DataSource = ds.Tables["Products"];
			cboModelName.DisplayMember = "ModelName";

			// Connect the category list used for editing.
			cboCategory.DataSource = ds.Tables["Categories"];
			cboCategory.DisplayMember = "CategoryName";
			cboCategory.ValueMember = "CategoryID";
			cboCategory.DataBindings.Add("SelectedValue", ds.Tables["Products"],
				"CategoryID");

		}
	}
}