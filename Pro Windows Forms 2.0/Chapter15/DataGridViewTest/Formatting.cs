using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class Formatting : Form
	{
		public Formatting()
		{
			InitializeComponent();
		}

		private void Formatting_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Program.StoreDB.GetProducts();

			dataGridView1.Columns["ProductImage"].Visible = false;
			dataGridView1.Columns["CategoryID"].Visible = false;
			dataGridView1.Columns["ModelNumber"].DisplayIndex = 4;

			dataGridView1.Columns["ProductID"].Frozen = true;
			dataGridView1.Columns["ProductID"].Resizable = DataGridViewTriState.False;

			// Clean up all the columns.
			foreach (DataGridViewColumn col in dataGridView1.Columns)
			{
				col.HeaderCell.Value = Utility.SplitStringByCase(col.HeaderText);
			}

			dataGridView1.Columns["UnitCost"].DefaultCellStyle.Format = "C";
			dataGridView1.Columns["UnitCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView1.Columns["UnitCost"].DefaultCellStyle.BackColor = Color.LightYellow;

			// Remove cells with the objectionable description.
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (TestForWords(Convert.ToString(row.Cells["Description"].Value)))
					row.Visible = false;
			}
		}

		private bool TestForWords(string stringToTest)
		{
			stringToTest = stringToTest.ToLower();
			return (stringToTest.Contains("warning") || stringToTest.Contains("danger"));
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dataGridView1.Columns[e.ColumnIndex].Name == "UnitCost")
			{
				if (Convert.ToInt32(e.Value) >= 1000)
				{
					e.CellStyle.ForeColor = Color.Red;
					e.CellStyle.BackColor = Color.Yellow;
					e.CellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
				}
			}
		}


	}
}