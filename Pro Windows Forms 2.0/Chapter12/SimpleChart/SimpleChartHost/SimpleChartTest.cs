using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SimpleChart;

namespace SimpleChartHost
{
    public partial class SimpleChartTest : Form
    {
        public SimpleChartTest()
        {
            InitializeComponent();
        }

        private void SimpleChartTest_Load(object sender, EventArgs e)
        {
            simpleChart1.Bars.Add(new BarItem("Sales 2002", 10000));
            simpleChart1.Bars.Add(new BarItem("Sales 2003", 20000));
            simpleChart1.Bars.Add(new BarItem("Sales 2004", 5000));
            simpleChart1.Bars.Add(new BarItem("Sales 2005", 27000));
            simpleChart1.RebuildChart();
        }
    }
}