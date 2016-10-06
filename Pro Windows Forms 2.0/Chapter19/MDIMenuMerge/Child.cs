using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiMenuMerge
{
	public partial class Child : Form
	{
		public Child()
		{
			InitializeComponent();
		}

        public void SetNoMerge()
        {
            menuStrip1.AllowMerge = false;
        }
	}
}