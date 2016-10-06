#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace AutoComplete
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colorNames;
            colorNames = System.Enum.GetNames(typeof(KnownColor));

            lstColors.Items.AddRange(colorNames);

        }
    }
}