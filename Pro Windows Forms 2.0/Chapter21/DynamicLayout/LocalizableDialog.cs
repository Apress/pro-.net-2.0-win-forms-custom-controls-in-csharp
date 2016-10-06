using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicLayout
{
    public partial class LocalizableDialog : Form
    {
        public LocalizableDialog()
        {
            InitializeComponent();
        }

        private void optShort_CheckedChanged(object sender, EventArgs e)
        {
            button2.Text = "button2";
        }

        private void optLong_CheckedChanged(object sender, EventArgs e)
        {
            button2.Text = "This is the much longer text string.";
        }
    }
}