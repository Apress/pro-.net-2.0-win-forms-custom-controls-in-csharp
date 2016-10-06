using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToDataSet
{
	public partial class FilteredListBinding : Form
	{
		public FilteredListBinding()
		{
			InitializeComponent();
		}

		private void SimpleListBinding_Load(object sender, EventArgs e)
		{
			DataTable dt = Program.StoreDB.GetProducts();
			dt.DefaultView.RowFilter = "UnitCost < 5";

			lstModelName.DataSource = dt;
			lstModelName.DisplayMember = "ModelName";
		}
	}
}