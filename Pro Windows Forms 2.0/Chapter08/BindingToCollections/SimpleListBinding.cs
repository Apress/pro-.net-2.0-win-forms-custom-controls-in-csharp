using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToCollections
{
	public partial class SimpleListBinding : Form
	{
		public SimpleListBinding()
		{
			InitializeComponent();
		}

		private void SimpleListBinding_Load(object sender, EventArgs e)
		{
			lstModelName.DataSource = Program.StoreDB.GetProducts();
			//lstModelName.DisplayMember = "ModelName";
		}


		private void lstModelName_DoubleClick(object sender, EventArgs e)
		{
			Product product = (Product)lstModelName.SelectedItem;
			MessageBox.Show(String.Format("Costs {0:C}", product.UnitCost));
		}
	}
}