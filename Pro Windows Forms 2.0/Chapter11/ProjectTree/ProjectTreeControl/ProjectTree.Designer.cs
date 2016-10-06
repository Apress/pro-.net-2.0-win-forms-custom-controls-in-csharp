namespace ProjectTreeControl
{
	partial class ProjectTree
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectTree));
			this.imagesTree = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// imagesTree
			// 
			this.imagesTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesTree.ImageStream")));
			this.imagesTree.Images.SetKeyName(0, "");
			this.imagesTree.Images.SetKeyName(1, "");
			this.imagesTree.Images.SetKeyName(2, "");
			this.imagesTree.Images.SetKeyName(3, "");
			this.imagesTree.Images.SetKeyName(4, "");
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imagesTree;
	}
}
