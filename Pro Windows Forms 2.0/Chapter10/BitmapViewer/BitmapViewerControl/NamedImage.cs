#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
#endregion

namespace BitmapViewerControl
{
    internal class NamedImage
    {
        private Image image;
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public NamedImage(Image image, string fileName)
        {
            this.Image = image;
            this.FileName = fileName;
        }
    }

    public class PictureSelectedEventArgs : EventArgs
    {
        private Image image;
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public PictureSelectedEventArgs(String fileName, Image image)
        {
            FileName = fileName;
            Image = image;
        }

    }

}
