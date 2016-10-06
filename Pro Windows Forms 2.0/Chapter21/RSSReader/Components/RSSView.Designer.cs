namespace System.Windows.Forms.Samples
{
	partial class RSSView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSSView));
            this.contentPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewLinkColumn();
            this.RssItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footerStrip = new System.Windows.Forms.ToolStrip();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.nextButton = new System.Windows.Forms.ToolStripButton();
            this.prevButton = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feedBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.headerStrip = new System.Windows.Forms.Samples.GradientHeaderStrip();
            this.closeItem = new System.Windows.Forms.Samples.ToolStripHoverItem();
            this.compressItem = new System.Windows.Forms.Samples.ToolStripHoverItem();
            this.headerTextLabel = new System.Windows.Forms.ToolStripLabel();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RssItemBindingSource)).BeginInit();
            this.footerStrip.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.dataGridView1);
            this.contentPanel.Controls.Add(this.footerStrip);
            this.contentPanel.Controls.Add(this.imagePanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 25);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(3);
            this.contentPanel.Size = new System.Drawing.Size(390, 175);
            this.contentPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title});
            this.dataGridView1.DataSource = this.RssItemBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 18;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(384, 85);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RssItemBindingSource
            // 
            this.RssItemBindingSource.DataSource = typeof(System.Windows.Forms.Samples.RSS.RssItem);
            // 
            // footerStrip
            // 
            this.footerStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.footerStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.footerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateButton,
            this.nextButton,
            this.prevButton,
            this.addButton});
            this.footerStrip.Location = new System.Drawing.Point(3, 147);
            this.footerStrip.Name = "footerStrip";
            this.footerStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.footerStrip.ShowItemToolTips = false;
            this.footerStrip.Size = new System.Drawing.Size(384, 25);
            this.footerStrip.TabIndex = 4;
            this.footerStrip.Text = "toolStrip1";
            // 
            // updateButton
            // 
            this.updateButton.Image = global::System.Windows.Forms.Samples.Properties.Resources.update;
            this.updateButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateButton.Name = "updateButton";
            this.updateButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.updateButton.Size = new System.Drawing.Size(71, 22);
            this.updateButton.Text = "Refresh";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nextButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.nextButton.Margin = new System.Windows.Forms.Padding(0, 1, 6, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(33, 22);
            this.nextButton.Text = "next";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.prevButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(33, 22);
            this.prevButton.Text = "prev";
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addButton.Enabled = false;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(35, 22);
            this.addButton.Text = "Save";
            this.addButton.ToolTipText = "Add to Favorites";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.AutoSize = true;
            this.imagePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imagePanel.Controls.Add(this.pictureBox1);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagePanel.Location = new System.Drawing.Point(3, 3);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.imagePanel.Size = new System.Drawing.Size(384, 59);
            this.imagePanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // feedBackgroundWorker
            // 
            this.feedBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.feedBackgroundWorker_DoWork);
            this.feedBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.feedBackgroundWorker_RunWorkerCompleted);
            // 
            // headerStrip
            // 
            this.headerStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.headerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeItem,
            this.compressItem,
            this.headerTextLabel});
            this.headerStrip.Location = new System.Drawing.Point(0, 0);
            this.headerStrip.Name = "headerStrip";
            this.headerStrip.Size = new System.Drawing.Size(390, 25);
            this.headerStrip.TabIndex = 0;
            this.headerStrip.Text = "gradientHeaderStrip1";
            // 
            // closeItem
            // 
            this.closeItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeItem.Checked = false;
            this.closeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeItem.Image = global::System.Windows.Forms.Samples.Properties.Resources.close;
            this.closeItem.ImageCheck = null;
            this.closeItem.ImageCheckHover = null;
            this.closeItem.ImageHover = global::System.Windows.Forms.Samples.Properties.Resources.close2;
            this.closeItem.ImageNormal = global::System.Windows.Forms.Samples.Properties.Resources.close;
            this.closeItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closeItem.Name = "closeItem";
            this.closeItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.closeItem.Size = new System.Drawing.Size(16, 22);
            this.closeItem.Text = "toolStripHoverItem1";
            this.closeItem.Click += new System.EventHandler(this.closeItem_Click);
            // 
            // compressItem
            // 
            this.compressItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.compressItem.Checked = false;
            this.compressItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compressItem.Image = global::System.Windows.Forms.Samples.Properties.Resources.compress;
            this.compressItem.ImageCheck = global::System.Windows.Forms.Samples.Properties.Resources.expand;
            this.compressItem.ImageCheckHover = global::System.Windows.Forms.Samples.Properties.Resources.expand2;
            this.compressItem.ImageHover = global::System.Windows.Forms.Samples.Properties.Resources.compress2;
            this.compressItem.ImageNormal = global::System.Windows.Forms.Samples.Properties.Resources.compress;
            this.compressItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.compressItem.Name = "compressItem";
            this.compressItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.compressItem.Size = new System.Drawing.Size(16, 22);
            this.compressItem.Text = "toolStripHoverItem2";
            this.compressItem.CheckedChanged += new System.EventHandler(this.compressItem_CheckedChanged);
            // 
            // headerTextLabel
            // 
            this.headerTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.headerTextLabel.Name = "headerTextLabel";
            this.headerTextLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.headerTextLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.headerTextLabel.Size = new System.Drawing.Size(42, 22);
            this.headerTextLabel.Text = "[Text]";
            // 
            // RSSView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerStrip);
            this.MinimumSize = new System.Drawing.Size(390, 30);
            this.Name = "RSSView";
            this.Size = new System.Drawing.Size(390, 200);
            this.Load += new System.EventHandler(this.RSSView_Load);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RssItemBindingSource)).EndInit();
            this.footerStrip.ResumeLayout(false);
            this.footerStrip.PerformLayout();
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerStrip.ResumeLayout(false);
            this.headerStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Panel contentPanel;
		private ToolStrip footerStrip;
		private ToolStripButton nextButton;
		private ToolStripButton prevButton;
		private ToolStripButton updateButton;
		private DataGridView dataGridView1;
		private Panel imagePanel;
		private PictureBox pictureBox1;
		private BindingSource RssItemBindingSource;
		private GradientHeaderStrip headerStrip;
		private ToolStripHoverItem closeItem;
		private ToolStripHoverItem compressItem;
		private ToolStripLabel headerTextLabel;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripButton addButton;
		private System.ComponentModel.BackgroundWorker feedBackgroundWorker;
        private DataGridViewLinkColumn Title;

	}
}
