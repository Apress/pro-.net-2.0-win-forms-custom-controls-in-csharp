using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool previousSelectionState = false;
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                cmdBold.Checked = richTextBox1.SelectionFont.Bold;
                cmdItalic.Checked = richTextBox1.SelectionFont.Italic;
                cmdUnderline.Checked = richTextBox1.SelectionFont.Underline;
            }
        }

        private void cmdBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                // The selection includes multiple fonts. Sadly,
                // there's no way to get information about any
                // of them.
                return;
            }

            // Get the current style.
            FontStyle style = richTextBox1.SelectionFont.Style;
            
            // Adjust as required.
            if (richTextBox1.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;
                
            }

            // Assign font with new style.
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void cmdItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                // The selection includes multiple fonts. Sadly,
                // there's no way to get information about any
                // of them.
                return;
            }

            // Get the current style.
            FontStyle style = richTextBox1.SelectionFont.Style;

            // Adjust as required.
            if (richTextBox1.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            // Assign font with new style.
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void cmdUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                // The selection includes multiple fonts. Sadly,
                // there's no way to get information about any
                // of them.
                return;
            }

            // Get the current style.
            FontStyle style = richTextBox1.SelectionFont.Style;

            // Adjust as required.
            if (richTextBox1.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            // Assign font with new style.
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create color list.
            string[] colorNames;
            colorNames = System.Enum.GetNames(typeof(KnownColor));
            foreach (string colorName in colorNames)
            {
                lstColors.DropDown.Items.Add(colorName);
            }
            // Create font list.
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                lstFonts.DropDown.Items.Add(family.Name);
            }

            // Create zoom list.
            for (int i = 25; i < 525; i += 25)
            {
                lstZoom.DropDown.Items.Add(i.ToString() + "%");             
            }

            // Create font size list.
            for (int i = 5; i < 60; i += 5)
            {
                lstFontSize.DropDown.Items.Add(i.ToString());
            }
        }

       
        private void lstColors_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
          KnownColor selectedColor;
          selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text);

            richTextBox1.SelectionColor = Color.FromKnownColor(selectedColor);
        }

        private void lstFonts_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                // The selection includes multiple fonts. Sadly,
                // there's no way to get information about any
                // of them.
                richTextBox1.SelectionFont = new Font(e.ClickedItem.Text, richTextBox1.Font.Size);
            }
            richTextBox1.SelectionFont = new Font(e.ClickedItem.Text, richTextBox1.SelectionFont.Size);
        }

        private void lstZoom_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {            
            float zoomPercent = Convert.ToSingle(e.ClickedItem.Text.Trim('%'));
            richTextBox1.ZoomFactor = zoomPercent / 100;
        }

        private void lstFontSize_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                // The selection includes multiple fonts. Sadly,
                // there's no way to get information about any
                // of them.
                return;
            }
            richTextBox1.SelectionFont =
                new Font(richTextBox1.SelectionFont.FontFamily,
                Convert.ToInt32(e.ClickedItem.Text),
                richTextBox1.SelectionFont.Style);
        }

         private void cmdAddImage_Click(object sender, EventArgs e)
        {
             // Get the image.
             Image img = Image.FromFile(Path.Combine(Application.StartupPath, "planet.jpg"));
             // Place it on the clipboard.
             Clipboard.SetImage(img);
             
             // Move to the front.
             richTextBox1.SelectionStart = 0;

             // Paste the image.
             richTextBox1.Paste();

             // Optionally remove the data from the clipboard.
             Clipboard.Clear();
        }


    }
}