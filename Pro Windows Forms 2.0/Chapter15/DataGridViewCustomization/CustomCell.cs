using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewCustomization
{
	public partial class CustomCell : Form
	{
		public CustomCell()
		{
			InitializeComponent();
		}

		private void CustomCell_Load(object sender, EventArgs e)
		{
			
			dataGridView1.DataSource = Program.StoreDB.GetProducts();

			// Hide the ordinary version of this column.
			dataGridView1.Columns[0].Visible = false;

			// Create custom column.
			GradientRolloverColumn colGradient = new GradientRolloverColumn(Color.SlateBlue);
			colGradient.DataPropertyName = dataGridView1.Columns[0].DataPropertyName;
			colGradient.HeaderText = dataGridView1.Columns[0].HeaderText;
			colGradient.Width = dataGridView1.Columns[0].Width;
			colGradient.ReadOnly = dataGridView1.Columns[0].ReadOnly;
			colGradient.ValueType = dataGridView1.Columns[0].ValueType;
			colGradient.DisplayIndex = 0;

			// Add the custom column.
			dataGridView1.Columns.Add(colGradient);
		}
	}
}