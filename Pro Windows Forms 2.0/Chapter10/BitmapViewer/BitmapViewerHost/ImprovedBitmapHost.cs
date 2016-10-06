#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace BitmapViewerHost
{
    partial class ImprovedBitmapHost : Form
    {
        public ImprovedBitmapHost()
        {
            InitializeComponent();
        }

        private void bitmapViewer1_PictureSelected(object sender, BitmapViewerControl.PictureSelectedEventArgs e)
        {
        
        }

        private void ImprovedBitmapHost_Load(object sender, EventArgs e)
        {
            bitmapViewer1.StartLoadingImages(Application.StartupPath);
        }



    }
}