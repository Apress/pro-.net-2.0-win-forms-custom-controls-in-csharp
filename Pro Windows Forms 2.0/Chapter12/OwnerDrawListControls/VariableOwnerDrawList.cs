#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

#endregion

namespace OwnerDrawList
{
    partial class VariableOwnerDrawList : Form
    {
        public VariableOwnerDrawList()
        {
            InitializeComponent();
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {

            ListBox list = (ListBox)sender;
            FormattedListItemWrapper item = list.Items[e.Index] as FormattedListItemWrapper;
            if (item == null || item.Font == null)
            {
                e.ItemHeight = 15;
            }
            else
            {
                // Get the height from the current item's font.
                Font font = item.Font;
                e.ItemHeight = font.Height;
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            ListBox list = (ListBox)sender;
            FormattedListItemWrapper item = list.Items[e.Index] as FormattedListItemWrapper;
            
            Font font = null;
            Color foreColor = Color.Empty;
            Color backColor = Color.Empty;

            if (item != null)
            {
                font = item.Font;
                foreColor = item.ForeColor;
                backColor = item.BackColor;
            }

            
            // Get the font from the current item.
            // It could be null if there is no
            // ListItemWrapper or the ListItemWrapper doesn't
            // specify a font.
            if (font == null)
            {
                // Use the ListBox font if no custom font is provided.
                font = list.Font;
            }

            // Set the color. It could be empty if there is no
            // ListItemWrapper or the ListItemWrapper doesn't
            // specify a color.
            Brush brush;
            if (foreColor == Color.Empty)
            {
                // Use the default color.
                brush = Brushes.Black;
            }
            else
            {
                // Use the custom color.
                brush = new SolidBrush(item.ForeColor);
            }

            // Override the color if the item is selected.
            // Alternatively, you could add SelectedForeColor and
            // SelectedBackColor properties to the wrapper.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                brush = Brushes.White;
            }

            // Paint the background.
            if (backColor == Color.Empty)
            {
                // Draw the background.
                e.DrawBackground();
            }
            else
            {
                Brush brushBackground = new SolidBrush(item.BackColor);
                e.Graphics.FillRectangle(brushBackground, e.Bounds);
            }

            // Get the item text.
            string text = list.Items[e.Index].ToString();

            // Draw the item text.
            e.Graphics.DrawString(text, font,
              brush, e.Bounds.X, e.Bounds.Y);
        }

        private void VariableOwnerDrawList_Load(object sender, EventArgs e)
        {
			
           InstalledFontCollection families = new InstalledFontCollection();

           foreach (FontFamily family in families.Families)
           {
               try
               {
                   Font font = new Font(family.Name, 12);
                   FormattedListItemWrapper item = new FormattedListItemWrapper(family.Name, font);
                   listBox1.Items.Add(item);
               }
               catch (ArgumentException err)
               {
                   // Ignore fonts that don't support the default size.
               }
           }
       }
    }
}