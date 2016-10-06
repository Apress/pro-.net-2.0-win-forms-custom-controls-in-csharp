#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace MultithreadingClient
{
    partial class AsyncTestResult : Form
    {
        public AsyncTestResult()
        {
            InitializeComponent();
        }

        private void AsyncTestResult_Load(object sender, EventArgs e)
        {
        
        }

        public void ShowList(string text)
        {
            txtResults.Text = text;
        }
    }
}