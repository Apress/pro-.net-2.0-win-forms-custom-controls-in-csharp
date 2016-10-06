using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
    public partial class ColorTableChange : Form
    {
        public ColorTableChange()
        {
            InitializeComponent();
        }

        private void ColorTableChange_Load(object sender, EventArgs e)
        {
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
        }
    }
}