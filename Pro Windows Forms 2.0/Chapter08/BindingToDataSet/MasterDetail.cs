using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToDataSet
{
	public partial class MasterDetail : Form
	{
		public MasterDetail()
		{
			InitializeComponent();
		}

		private BindingManagerBase categoryBinding;
		private DataSet ds;

		private void MasterDetail_Load(object sender, EventArgs e)
		{
			ds = Program.StoreDB.GetCategoriesAndProducts();

			// Bind the lists to different tables.
			lstCategory.DataSource = ds.Tables["Categories"];
			lstCategory.DisplayMember = "CategoryName";

			lstProduct.DataSource = ds.Tables["Products"];
			lstProduct.DisplayMember = "ModelName";

			// Track the binding context and handle position changing.
			categoryBinding = this.BindingContext[ds.Tables["Categories"]];
			categoryBinding.PositionChanged += new EventHandler(Binding_PositionChanged);

			// Update child table at startup.
			UpdateProducts();
		}

		private void Binding_PositionChanged(object sender, System.EventArgs e)
		{
			UpdateProducts();
		}

		private void UpdateProducts()
		{
			string filter;
			DataRow selectedRow;

			// Find the current category row.
			selectedRow = ds.Tables["Categories"].Rows[categoryBinding.Position];

			// Create a filter expression using its CategoryID.
			filter = "CategoryID='" + selectedRow["CategoryID"].ToString() + "'";

			// Modify the view onto the product table.
			ds.Tables["Products"].DefaultView.RowFilter = filter;
		}

	}
}