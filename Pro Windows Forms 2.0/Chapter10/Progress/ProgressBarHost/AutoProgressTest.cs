#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace ProgressHost
{
    partial class AutoProgressTest : Form
    {
        public AutoProgressTest()
        {
            InitializeComponent();
        }

        private void AutoProgressTest_Load(object sender, EventArgs e)
        {
        
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            autoProgress.Start();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            autoProgress.Stop();
        }

    }
}