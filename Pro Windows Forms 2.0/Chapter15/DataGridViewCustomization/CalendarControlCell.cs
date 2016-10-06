using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewCustomization
{
    public partial class CalendarControlCell : Form
    {
        public CalendarControlCell()
        {
            InitializeComponent();
        }

        private void CalendarControlCell_Load(object sender, EventArgs e)
        {
            CalendarColumn col = new CalendarColumn();
            this.dataGridView1.Columns.Add(col);
            this.dataGridView1.RowCount = 5;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells[0].Value = DateTime.Now;
            }

        }
    }
}