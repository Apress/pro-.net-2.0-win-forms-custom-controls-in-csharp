using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SmallOrLargeFonts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Font = SystemFonts.IconTitleFont;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            InitializeComponent();
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.Window)
            {
                this.Font = SystemFonts.IconTitleFont;
            }
        }

        // You must always detach event handlers for static events.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                SystemEvents.UserPreferenceChanged -=
                  new UserPreferenceChangedEventHandler(
                  SystemEvents_UserPreferenceChanged);
                if (components != null) components.Dispose();
            }
            base.Dispose(disposing);
        }

        

    }
}