using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PopUpHelp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hlp.SetHelpString(cmdAdd, "Choose another item from the catalog.");
            hlp.SetHelpString(cmdDelete, "Delete the selected item from your order.");

        }
    }
}