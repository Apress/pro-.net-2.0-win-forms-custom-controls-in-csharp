using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace DynamicLayout
{
    public partial class CustomLayoutEngine : Form
    {
        public CustomLayoutEngine()
        {
            InitializeComponent();
        }

        private void CustomLayoutEngine_Load(object sender, EventArgs e)
        {

        }

        private SingleLineFlowLayoutEngine layoutEngine = null;
        public override LayoutEngine LayoutEngine
        {
            get
            {
                if (layoutEngine == null)
                {
                    layoutEngine = new SingleLineFlowLayoutEngine(20);
                }
                return layoutEngine;
            }
        }
    }
}