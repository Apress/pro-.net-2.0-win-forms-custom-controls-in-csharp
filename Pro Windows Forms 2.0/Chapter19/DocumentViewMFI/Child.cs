using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
	public partial class Child : Form
	{
		public Child()
		{
			InitializeComponent();
		}
		public enum ViewType
		{
			ItemGrid,
			PrintPreview
		}

		public Order Document;

		public Child(Order doc, ViewType viewType)		
		{
            InitializeComponent();
            
            toolStrip1.Items[0].Image = imgButtons.Images[0];
            toolStrip1.Items[1].Image = imgButtons.Images[1];
            toolStrip1.Items[2].Image = imgButtons.Images[2];
            toolStrip1.Items[3].Image = imgButtons.Images[3];
            toolStrip1.Items[5].Image = imgButtons.Images[4];            

            // Set up window list.
            Program.DocumentManager.WindowListChanged +=
                new EventHandler<WindowListChangedEventArgs>(WindowListChanged);

			// Configure the title.
			this.Text = doc.LastFileName;
			this.Document = doc;

			// Create a reference for the view.
			// This reference can accomodate any type of control.
			Control view = null;

			// Instantiate the appropriate view.
			switch (viewType)
			{
				case ViewType.ItemGrid:
					view = new OrderGridView(doc);
					break;
				case ViewType.PrintPreview:
					view = new OrderPrintPreview(doc);
					this.Text += " (Preview)";
                    toolStrip1.Visible = false;
                    menuStrip1.Visible = false;
					break;
			}

		    // Add the view to the form.
			view.Dock = DockStyle.Fill;
            
			this.Controls.Add(view);
            view.BringToFront();
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Program.AppTasks.New();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Program.AppTasks.Open();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Program.AppTasks.Save();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Program.AppTasks.Preview();
        }

        public void WindowListChanged(object sender, WindowListChangedEventArgs e)
        {
            windowToolStripMenuItem.DropDownItems.Clear();
            foreach (KeyValuePair<Form,string> name in e.WindowNames)
            {
                ToolStripItem menuItem = windowToolStripMenuItem.DropDownItems.Add(name.Value);
                menuItem.Tag = name.Key;
            }
        }

        private void windowToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             // Show the linked form.
            ((Form)e.ClickedItem.Tag).Activate();
        }
	}
}