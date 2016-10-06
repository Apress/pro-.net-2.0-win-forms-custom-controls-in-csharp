#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace WebBrowserTest
{
    partial class WebBrowserDynamicContent : Form
    {
        public WebBrowserDynamicContent()
        {
            InitializeComponent();
        }

        private void txtHtml_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


        private void txtHtml_TextChanged(object sender, EventArgs e)
        {
            webBrowser.DocumentText = txtHtml.Text;
        }

        private void WebBrowserDynamicContent_Load(object sender, EventArgs e)
        {
            webBrowser.DocumentText = txtHtml.Text;
        }
    }
}