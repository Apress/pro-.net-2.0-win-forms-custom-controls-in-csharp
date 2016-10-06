using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicLayout
{
    public partial class TextBoxColumn : Form
    {
        public TextBoxColumn()
        {
            InitializeComponent();

            // Reduce the number of times the layout logic is executed.
            tableLayoutPanel1.SuspendLayout();

            // Add the controls.
            for (int i = 1; i < 15; i++)
            {
                // Create an auto-sizing label for the left column.
                Label lbl = new Label();
                lbl.Text = "This is Setting " + i.ToString();

                lbl.Margin = new Padding(3, 7, 3, 3);
                lbl.AutoSize = true;

                // Create a text box that's docked to fill up the entire second column.
                TextBox txt = new TextBox();
                txt.Dock = DockStyle.Fill;

                Button cmd = new Button();
                cmd.Text = "Browse...";
                cmd.Width = 60;
                
                // Add the controls
                tableLayoutPanel1.Controls.Add(lbl);
                tableLayoutPanel1.Controls.Add(txt);
                tableLayoutPanel1.Controls.Add(cmd);
            }
                       
            tableLayoutPanel1.ResumeLayout();

        }

        private void TextBoxColumn_Load(object sender, EventArgs e)
        {

        }
    }
}