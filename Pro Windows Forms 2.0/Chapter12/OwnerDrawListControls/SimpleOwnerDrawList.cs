#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace OwnerDrawList
{
    partial class SimpleOwnerDrawList : Form
    {
        public SimpleOwnerDrawList()
        {
            InitializeComponent();
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            // Specify a fixed height.
            e.ItemHeight = 15;

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background.
            // The color (white or blue) depends on selection.
            e.DrawBackground();

            // Determine the forecolor based on whether or not
            // the item is selected.
            Brush brush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                brush = Brushes.White;
            }
            else
            {
                brush = Brushes.Black;
            }

            // Get the item text.
            string text = ((ListBox)sender).Items[e.Index].ToString();

            // Draw the item text.
            e.Graphics.DrawString(text, ((Control)sender).Font,
              brush, e.Bounds.X, e.Bounds.Y);
        }

        private void SimpleOwnerDrawList_Load(object sender, EventArgs e)
        {
        
        }
    }
}