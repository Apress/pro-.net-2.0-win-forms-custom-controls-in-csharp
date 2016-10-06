using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class ChildForm : Form
	{
		public ChildForm()
		{
			InitializeComponent();
		}

		private void ChildForm_Load(object sender, EventArgs e)
		{

		}

		private int categoryID;

		public int CategoryID
		{
			get
			{
				return categoryID;
			}
			set
			{
				categoryID = value;
				DataSet ds = Program.StoreDB.GetCategoriesAndProducts();
				dataGridView1.DataSource = ds.Tables["Products"];
				ds.Tables["Products"].DefaultView.RowFilter =
				  "CategoryID =" + categoryID.ToString();
			}
		}

	}
}