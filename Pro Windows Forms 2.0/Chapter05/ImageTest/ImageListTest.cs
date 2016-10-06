using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ImageTest
{
    public partial class ImageListTest : Form
    {
        public ImageListTest()
        {
            InitializeComponent();
        }

        private void cmdFillImageList_Click(object sender, EventArgs e)
        {
            // Configure the ImageList.
            iconImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            iconImages.ImageSize = new System.Drawing.Size(16, 16);

            // Get all the icon files in the current directory.
            string[] iconFiles = Directory.GetFiles(Application.StartupPath, "*.ico");

            // Create an Image object for each file and add it to the ImageList.
            // You can also use an Image subclass (like Icon).
            foreach (string iconFile in iconFiles)
            {
                Icon newIcon = new Icon(iconFile);
                iconImages.Images.Add(newIcon);
            }

        }

        private void cmdPaintImages_Click(object sender, EventArgs e)
        {
            // Get the graphics device context for the form.
            Graphics g = this.CreateGraphics();

            // Draw each image using the ImageList.Draw() method.
            for (int i = 0; i < iconImages.Images.Count; i++)
            {
                iconImages.Draw(g, 30 + i * 30, 30, i);
            }

            // Release the graphics device context.
            g.Dispose();

        }
    }
}