using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicUI
{
    public partial class DynamicDBMenu : Form
    {
        public DynamicDBMenu()
        {
            InitializeComponent();
            permissions = new DBPermissions();
        }

        DBPermissions permissions;
        private void cmdUser_Click(object sender, EventArgs e)
        {
            DataTable dtPermissions;

            // Get permissions for an Admin-level user.
            dtPermissions = permissions.GetPermissions(DBPermissions.Level.User);

            // Update the menu with these permissions.
            MenuLockDown.SearchMenu(MainMenuStrip.Items, dtPermissions);

        }

        private void cmdAdmin_Click(object sender, EventArgs e)
        {
            DataTable dtPermissions;

            // Get permissions for an Admin-level user.
            dtPermissions = permissions.GetPermissions(DBPermissions.Level.Admin);

            // Update the menu with these permissions.
            MenuLockDown.SearchMenu(MainMenuStrip.Items, dtPermissions);

        }

        

    }
}