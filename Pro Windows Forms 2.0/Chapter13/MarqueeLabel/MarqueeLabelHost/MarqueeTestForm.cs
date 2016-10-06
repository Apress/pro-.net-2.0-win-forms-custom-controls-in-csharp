using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarqueeLabelHost
{
    public partial class MarqueeTestForm : Form
    {
        public MarqueeTestForm()
        {
            InitializeComponent();
        }

        private void tbAmount_ValueChanged(object sender, EventArgs e)
        {
            marqueeLabel1.ScrollPixelAmount = tbAmount.Value;
        }

        private void tbInterval_ValueChanged(object sender, EventArgs e)
        {
            marqueeLabel1.ScrollTimeInterval = tbInterval.Value;
        }
    }
}