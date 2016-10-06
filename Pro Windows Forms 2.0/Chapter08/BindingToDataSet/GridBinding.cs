using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToDataSet
{
	public partial class GridBinding : Form
	{
		public GridBinding()
		{
			InitializeComponent();
		}

		private void GridBinding_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Program.StoreDB.GetProducts();
		}
	}
}