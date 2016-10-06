using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToDataSet
{
	public partial class BindToImage : Form
	{
		public BindToImage()
		{
			InitializeComponent();
		}

		private void FileToImage(object sender, ConvertEventArgs e)
		{
			if (e.DesiredType == typeof(Image))
			{
				// Store the filename.
				picProduct.Tag = e.Value;

				// Look up the corresponding file, and create an Image object.
				try
				{
					lblStatus.Text = "Retrieved picture " + e.Value;
					e.Value = Image.FromFile(Application.StartupPath + "\\" + e.Value);
				}
				catch (Exception err)
				{
					lblStatus.Text = "Could not find picture " + e.Value;

					// You could return an error picture here.
					// This code uses a blank 1x1 pixel image.
					e.Value = new Bitmap(1,1);
				}
			}
		}

		private void ImageToFile(object sender, ConvertEventArgs e)
		{
			if (e.DesiredType == typeof(string))
			{
				// Substitute the filename.
				e.Value = picProduct.Tag;
			}
		}

		private void BindToImage_Load(object sender, EventArgs e)
		{
			DataTable dt = Program.StoreDB.GetProducts();
			
			cboModelName.DataSource = dt;
			cboModelName.DisplayMember = "ModelName";

			Binding pictureBinding = new Binding("Image", dt, "ProductImage");
			pictureBinding.Format += new ConvertEventHandler(FileToImage);
			pictureBinding.Parse += new ConvertEventHandler(ImageToFile);

			picProduct.DataBindings.Add(pictureBinding);

		}
	}
}