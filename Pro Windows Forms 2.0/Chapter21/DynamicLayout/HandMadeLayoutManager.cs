using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicLayout
{
    public partial class HandMadeLayoutManager : Form
    {
        public HandMadeLayoutManager()
        {
            InitializeComponent();
        }

        private void HandMadeLayoutManager_Load(object sender, EventArgs e)
        {
            // Create and attach the layout manager.
            SingleLineFlowLayoutManager layoutManager =
              new SingleLineFlowLayoutManager(tabPage1, 20);

            tabPage1.SuspendLayout();
            // Add 10 sample checkboxes.
            CheckBox chkbox;
            
            for (int i = 1; i < 11; i++)
            {
                chkbox = new CheckBox();
                chkbox.Name = "checkBox" + i.ToString();
                chkbox.Text = "Setting " + i.ToString();
                tabPage1.Controls.Add(chkbox);
            }
            tabPage1.ResumeLayout();
        }
    }
}