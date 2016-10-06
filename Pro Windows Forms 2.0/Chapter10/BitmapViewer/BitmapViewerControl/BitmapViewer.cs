using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;


namespace BitmapViewerControl
{
	/// <summary>
	/// Summary description for BitmapViewer.
	/// </summary>
	public class BitmapViewer : System.Windows.Forms.UserControl
	{
		internal System.Windows.Forms.Panel pnlPictures;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BitmapViewer()
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
			this.SuspendLayout();
			// 
			// pnlPictures
			// 
			this.pnlPictures.AutoScroll = true;
			this.pnlPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlPictures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPictures.Location = new System.Drawing.Point(1, 1);
			this.pnlPictures.Name = "pnlPictures";
			this.pnlPictures.Size = new System.Drawing.Size(530, 218);
			this.pnlPictures.TabIndex = 1;
			// 
			// BitmapViewer
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pnlPictures});
			this.DockPadding.All = 1;
			this.Name = "BitmapViewer";
			this.Size = new System.Drawing.Size(532, 220);
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
			set
			{
				directory = value;
				GetImages();
				UpdateDisplay();
			}
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
				UpdateDisplay();
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
				UpdateDisplay();
			}
		}

		private void GetImages()
		{
			if (this.Directory != "" && this.directory != null)
			{
                images.Clear();
                DirectoryInfo dir = new DirectoryInfo(directory);
				foreach (FileInfo file in dir.GetFiles("*.bmp"))
				{
					images.Add(new NamedImage(Bitmap.FromFile(file.FullName), file.FullName));
				}
			}
		}

		private void UpdateDisplay()
		{
			// Suspend layout to prevent multiple window refreshes.
			pnlPictures.SuspendLayout();
			
			// Clear the current display.
			foreach (Control ctrl in pnlPictures.Controls)
			{
				ctrl.Dispose();
			}
			pnlPictures.Controls.Clear();

			// Row and Col will track the current position where pictures are
			// being inserted. They begin at the top-right corner.
			int row = border, col = border;

			// Iterate through the Images collection, and create PictureBox controls.
			foreach (NamedImage image in images)
			{
				PictureBox pic = new PictureBox();
				pic.Image = image.Image;
				pic.Tag = image.FileName;
				pic.Size = new Size(dimension, dimension);
				pic.Location = new Point(col, row);
				pic.BorderStyle = BorderStyle.FixedSingle;

				// StrechImage mode gives us the "thumbnail" ability.
				pic.SizeMode = PictureBoxSizeMode.StretchImage;

				// Display the picture.
				pnlPictures.Controls.Add(pic);

				// Move to the next column.
				col += dimension + spacing;

				// Handle the event.
				pic.Click += new EventHandler(this.pic_Click);

				// Move to next line if no more pictures will fit.
				if ((col + dimension + spacing + border) > this.Width)
				{
					col = border;
					row += dimension + spacing;
				}
			}
            pnlPictures.ResumeLayout();
        }

		public void RefreshImages()
		{
			GetImages();
			UpdateDisplay();
		}

		protected override void OnSizeChanged(System.EventArgs e)
		{
			UpdateDisplay();
			base.OnSizeChanged(e);
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
