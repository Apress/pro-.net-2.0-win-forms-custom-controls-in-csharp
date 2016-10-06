using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace BitmapViewerControl
{
	/// <summary>
	/// Summary description for BitmapViewer.
	/// </summary>
	public class ImprovedBitmapViewer : System.Windows.Forms.UserControl
	{
        internal System.Windows.Forms.Panel pnlPictures;
        private FlowLayoutPanel pnlFlow;
        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public ImprovedBitmapViewer()
        {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlPictures = new System.Windows.Forms.Panel();
			this.pnlFlow = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlPictures.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlPictures
			// 
			this.pnlPictures.AutoScroll = true;
			this.pnlPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlPictures.Controls.Add(this.pnlFlow);
			this.pnlPictures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPictures.Location = new System.Drawing.Point(1, 1);
			this.pnlPictures.Name = "pnlPictures";
			this.pnlPictures.Size = new System.Drawing.Size(530, 218);
			this.pnlPictures.TabIndex = 1;
			// 
			// pnlFlow
			// 
			this.pnlFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlFlow.AutoScroll = true;
			this.pnlFlow.Location = new System.Drawing.Point(0, 0);
			this.pnlFlow.Name = "pnlFlow";
			this.pnlFlow.Size = new System.Drawing.Size(523, 211);
			this.pnlFlow.TabIndex = 0;
			// 
			// ImprovedBitmapViewer
			// 
			this.Controls.Add(this.pnlPictures);
			this.Name = "ImprovedBitmapViewer";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.Size = new System.Drawing.Size(532, 220);
			this.pnlPictures.ResumeLayout(false);
			this.ResumeLayout(false);

        }
		#endregion
	
		public delegate void PictureSelectedDelegate(object sender, PictureSelectedEventArgs e);
		public event PictureSelectedDelegate PictureSelected;

		// The directory that will be scanned for image.
		private string directory="";

		// Each picture box will be a square of dimension X dimension pixels.
		private int dimension;

		// The space between the images and the top, left, and right sides.
		private int border = 5;

		// The space between each image.
		private int spacing;

		// The images that were found in the selected directory.
        private List<NamedImage> images = new List<NamedImage>();

		public string Directory
		{
			get
			{
				return directory;
			}
		}

        public void StartLoadingImages(string directory)
        {
        	this.directory = directory;
			GetImages();
		}

        public int Dimension
        {
            get
            {
                return dimension;
            }
            set
            {
                dimension = value;
            }
        }

        public int Spacing
		{
			get
			{
				return spacing;
			}
			set
			{
				spacing = value;
			}
		}

        private void GetImages()
        {
			// Create a delegate that points to the method
			// that you want to run asynchronously.
			// The MethodInvoker delegate works because it
			// matches the signature (no parameters or return value).
            MethodInvoker asyncTask = new MethodInvoker(this.ReadImagesFromFile);

			// Borrow a thread from the CLR.
			asyncTask.BeginInvoke(null, null);
        }

        private void ReadImagesFromFile()
        {
            lock (images)
            {
                if (directory != "")
                {
                    images.Clear();
                    Image thumbnail;
                    DirectoryInfo dir = new DirectoryInfo(directory);
                    foreach (FileInfo file in dir.GetFiles("*.bmp"))
                    {
                        thumbnail = Bitmap.FromFile(file.FullName).GetThumbnailImage(
                                    Dimension, Dimension, null, IntPtr.Zero);
                        images.Add(new NamedImage(thumbnail, file.Name));
                    }
                }
            }

            // Update the display on the UI thread.
            pnlFlow.Invoke(new MethodInvoker(this.UpdateDisplay));
        }

        private void UpdateDisplay()
		{
			// Suspend layout to prevent multiple window refreshes.
			pnlFlow.SuspendLayout();

			// Clear the current display.
			foreach (Control ctrl in pnlFlow.Controls)
			{
				ctrl.Dispose();
			}
			pnlFlow.Controls.Clear();


			// Row and Col will track the current position where pictures are
			// being inserted. They begin at the top-right corner.
			pnlFlow.Padding = new Padding(border);

			// Iterate through the Images collection, and create PictureBox controls.
			lock (images)
			{
				foreach (NamedImage image in images)
				{
					PictureBox pic = new PictureBox();
					pic.Image = image.Image;
					pic.Tag = image.FileName;
					pic.Size = new Size(dimension, dimension);
					pic.Margin = new Padding(spacing);
					pic.BorderStyle = BorderStyle.FixedSingle;

					// Display the picture.
					pnlFlow.Controls.Add(pic);

					// Handle the event.
					pic.Click += new EventHandler(this.pic_Click);
				}
			}
            pnlFlow.ResumeLayout();
        }

		public void RefreshImages()
		{
			GetImages();
		}

		private PictureBox picSelected;

		private void pic_Click(object sender, System.EventArgs e)
		{
			// Clear the border style from the last selected picture box.
			if (picSelected != null)
			{
				picSelected.BorderStyle = BorderStyle.FixedSingle;
			}

			// Get the new selection.
			picSelected = (PictureBox)sender;
			picSelected.BorderStyle = BorderStyle.Fixed3D;

			// Fire the selection event.
			PictureSelectedEventArgs args = new 
				PictureSelectedEventArgs((string)picSelected.Tag, picSelected.Image);
			if (PictureSelected != null)
			{
				PictureSelected(this, args);
			}
		}

		
	}

}
