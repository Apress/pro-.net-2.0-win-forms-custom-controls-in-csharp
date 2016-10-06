using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicUI
{
    public partial class ButtonMaker : Form
    {
        public ButtonMaker()
        {
            InitializeComponent();
        }

        private int buttonCount = 0;
        private void cmdCreate_Click(object sender, EventArgs e)
        {
            buttonCount++;

            // Create the button.
            Button newButton = new Button();
            newButton.Text = "Button " + buttonCount.ToString();
            newButton.Location = new Point(Int32.Parse(txtLeft.Text), Int32.Parse(txtTop.Text));

            // Attach the event handler.
            newButton.Click += new EventHandler(ButtonHandler);

            this.Controls.Add(newButton);
        }

        private void ButtonHandler(object sender, System.EventArgs e)
        {
            lblStatus.Text = " You clicked ... ";
            lblStatus.Text += ((Button)sender).Text;
        }

    }
}