using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DataGridViewTest
{
	public partial class Barebones : Form
	{
		public Barebones()
		{
			InitializeComponent();
		}

		private void Barebones_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Program.StoreDB.GetProducts();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (!row.IsNewRow && Convert.ToInt32(row.Cells["UnitCost"].Value) > 50)
				{
					Debug.WriteLine(row.Cells["ProductID"].Value);
				}
			}

			foreach (DataGridViewColumn col in dataGridView1.Columns)
			{
				col.HeaderText = Regex.Replace(col.HeaderText, @"(\p{Ll})(\p{Lu})|_+", "$1 $2");
			}
		}

	

		
	}
}