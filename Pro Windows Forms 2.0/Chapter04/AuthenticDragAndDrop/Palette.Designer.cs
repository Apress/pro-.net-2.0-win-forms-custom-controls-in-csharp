namespace AuthenticDragAndDrop
{
	partial class Palette
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Palette));
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.lblPictureThree = new System.Windows.Forms.Label();
			this.lblPictureTwo = new System.Windows.Forms.Label();
			this.lblPictureOne = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// images
			// 
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.Images.SetKeyName(0, "");
			this.images.Images.SetKeyName(1, "");
			this.images.Images.SetKeyName(2, "");
			// 
			// lblPictureThree
			// 
			this.lblPictureThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPictureThree.ImageIndex = 2;
			this.lblPictureThree.ImageList = this.images;
			this.lblPictureThree.Location = new System.Drawing.Point(12, 113);
			this.lblPictureThree.Name = "lblPictureThree";
			this.lblPictureThree.Size = new System.Drawing.Size(56, 48);
			this.lblPictureThree.TabIndex = 6;
			this.lblPictureThree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
			// 
			// lblPictureTwo
			// 
			this.lblPictureTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPictureTwo.ImageIndex = 1;
			this.lblPictureTwo.ImageList = this.images;
			this.lblPictureTwo.Location = new System.Drawing.Point(12, 61);
			this.lblPictureTwo.Name = "lblPictureTwo";
			this.lblPictureTwo.Size = new System.Drawing.Size(56, 48);
			this.lblPictureTwo.TabIndex = 5;
			this.lblPictureTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
			// 
			// lblPictureOne
			// 
			this.lblPictureOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPictureOne.ImageIndex = 0;
			this.lblPictureOne.ImageList = this.images;
			this.lblPictureOne.Location = new System.Drawing.Point(12, 9);
			this.lblPictureOne.Name = "lblPictureOne";
			this.lblPictureOne.Size = new System.Drawing.Size(56, 48);
			this.lblPictureOne.TabIndex = 4;
			this.lblPictureOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
			// 
			// Palette
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(83, 173);
			this.Controls.Add(this.lblPictureTwo);
			this.Controls.Add(this.lblPictureOne);
			this.Controls.Add(this.lblPictureThree);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Palette";
			this.ShowInTaskbar = false;
			this.Text = "Palette";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList images;
		private System.Windows.Forms.Label lblPictureThree;
		private System.Windows.Forms.Label lblPictureTwo;
		private System.Windows.Forms.Label lblPictureOne;
	}
}