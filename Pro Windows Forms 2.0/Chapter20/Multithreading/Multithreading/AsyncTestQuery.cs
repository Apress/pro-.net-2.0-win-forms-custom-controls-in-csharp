#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

#endregion

namespace MultithreadingClient
{
    partial class AsyncTestQuery : Form
    {
        public AsyncTestQuery()
        {
            InitializeComponent();
        }

        public int From
        {
            get
            {
                int from;
                Int32.TryParse(txtFrom.Text, out from);
                return from;
            }
        }

        public int To
        {
            get
            {
                int to;
                Int32.TryParse(txtTo.Text, out to);
                return to;
            }
        }

    }
}