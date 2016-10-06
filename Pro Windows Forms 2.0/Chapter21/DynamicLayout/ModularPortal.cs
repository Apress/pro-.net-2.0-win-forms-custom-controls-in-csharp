using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicLayout
{
    public partial class ModularPortal : Form
    {
        public ModularPortal()
        {
            InitializeComponent();
        }

        private void ModularPortal_Load(object sender, EventArgs e)
        {
            
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Panel)
                    lstModules.Items.Add(ctrl.Text, true);

            }
        }

        private void lstModules_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl.Text == lstModules.Text)
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        ctrl.Visible = true;
                    }
                    else
                    {
                        ctrl.Visible = false;
                    }
                     
                    return;
                }
            }
        }

    }
}