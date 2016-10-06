using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Windows.Forms.Samples.RSS;

namespace System.Windows.Forms.Samples
{
	public partial class MainForm : Form
	{
		private int		_width = -1;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Bind
            this.comboBox1.DataSource = RssLink.Links;

            // Load Links
            int    firstThree = 3;

            foreach (RssLink link in RssLink.Links)
            {
                // Add link
                AddView(link.URL, (firstThree > 0), link.ShowImage);

                // Set to false
                firstThree--;
            }
		}

		private void reportsButton_Click(object sender, EventArgs e)
		{
			(new LinksEditor()).ShowDialog();
		}

        private void AddView(string url, bool maximized, bool showImage)
        {
            // Create view
            RSSView     view = new RSSView();

            // Minimize other views
            //if (maximized)
            //{
            //    MinimizeViews(null);
            //}

            // Initialize view
            view.ShowImage = showImage;
            view.Maximized = maximized;

            // Add to panel
            this.rssFlowPanel.Controls.Add(view);

            // Set URL
            view.URL = url;
        }

		private void button1_Click(object sender, EventArgs e)
		{
			// Add item
            int pos = RssLink.FindLink(this.comboBox1.SelectedValue as string);

            if (pos != -1)
            {
                RssLink link = RssLink.Links[pos];
                AddView(link.URL, true, link.ShowImage);
            }
            else
            {
                AddView(this.comboBox1.SelectedValue as string, true, true);
            }
		}

		private void button2_Click(object sender, EventArgs e)
		{
            // Add item
            AddView(this.textBox1.Text, true, true);
		}

        private void ResetViews()
        {
            foreach (Control ctrl in this.rssFlowPanel.Controls)
            {
                if (ctrl is RSSView)
                {
                    SetViewSize(ctrl as RSSView);
                }
            }
        }

        private void SetViewSize(RSSView view)
        {
            // Get width of view
            int     padding = view.Margin.Right + view.Margin.Left;
            int     viewWidth = view.MinimumSize.Width + padding;
            int     halfWidth = _width / 2;

            // Set width
            if (halfWidth > viewWidth)
            {
                view.Width = halfWidth - padding;
            }
            else
            {
                view.Width = (_width - padding);
            }
        }

        //private void MinimizeViews(RSSView maximized)
        //{
        //    RSSView view;

        //    foreach (Control ctrl in this.rssFlowPanel.Controls)
        //    {
        //        view = (ctrl as RSSView);

        //        if ((null != view) && (view != maximized) && (view.Maximized))
        //        {
        //            view.Maximized = false;
        //        }
        //    }
        //}

        private void FlowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is RSSView)
            {
                RSSView view = e.Control as RSSView;

                // Set Size
                SetViewSize(view);

                // Handle link click
                view.LinkClicked += new System.Windows.Forms.Samples.LinkClickedEventHandler(RSSView_LinkClicked);

                // Handle Expand/Compress
                //view.StateChanged += delegate(object sview, EventArgs args)
                //{
                //    // Check
                //    RSSView     vw = (sview as RSSView);

                //    if ((null != vw) && (vw.Maximized))
                //    {
                //        MinimizeViews(vw);
                //    }
                //};
            }
        }

		void RSSView_LinkClicked(object sender, System.Windows.Forms.Samples.LinkClickedEventArgs e)
		{
			Browser browser = new Browser();

			browser.URL = e.URL;
			browser.Show();
		}

        private void rssFlowPanel_Resize(object sender, EventArgs e)
        {
            // Get the new size
            int     width = this.rssFlowPanel.ClientSize.Width - this.rssFlowPanel.Padding.Left - this.rssFlowPanel.Padding.Right;

            if ((this.ClientSize.Width > 0) && (width != _width))
            {
                // Set Width
                _width = width;
                
                // Reset sizes
                ResetViews();
            }
        }
	}
}