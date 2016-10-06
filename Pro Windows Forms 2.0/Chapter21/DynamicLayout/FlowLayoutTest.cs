using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicLayout
{
    public partial class FlowLayoutTest : Form
    {
        public FlowLayoutTest()
        {
            InitializeComponent();
        }

        private void FlowLayoutTest_Load(object sender, EventArgs e)
        {
            lstFlowDirection.Items.AddRange(Enum.GetNames(typeof(FlowDirection)));
            lstFlowDirection.Text = flowLayoutPanel1.FlowDirection.ToString();
        }

        private void lstFlowDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFlowDirection.SelectedIndex != -1)
            {
                flowLayoutPanel1.FlowDirection =
                    (FlowDirection)Enum.Parse(typeof(FlowDirection), lstFlowDirection.Text);
            }
        }

        private void chkWrap_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.WrapContents = chkWrap.Checked;
        }

        private void chkAutoScroll_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = chkAutoScroll.Checked;
        }
    }
}