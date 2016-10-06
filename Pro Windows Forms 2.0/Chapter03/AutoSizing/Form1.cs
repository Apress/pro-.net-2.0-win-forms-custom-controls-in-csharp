using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoSizing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSetText_Click(object sender, EventArgs e)
        {
            
            // There is no width boundary.
            label1.MaximumSize = new Size(0,0);
            label1.Text = "";
            label1.Text = textBox1.Text;
        }

        private void cmdSetTextConstraint_Click(object sender, EventArgs e)
        {
            // There is a width boundary.
            label1.MaximumSize = new Size(200,0);
            label1.Text = textBox1.Text;
        }
    }
}