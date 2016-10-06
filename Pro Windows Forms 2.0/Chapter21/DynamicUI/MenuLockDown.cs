using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace DynamicUI
{
    public class MenuLockDown
    {
        public static void SearchMenu(ToolStripItemCollection items, DataTable dtPermissions)
        {
            DataRow[] rowMatch;

            foreach (ToolStripItem item in items)
            {
                // Skip separators and other controls
                ToolStripMenuItem mnuItem = item as ToolStripMenuItem;
                if (mnuItem != null)
                {
                    // See if this menu item has a corresponding row.
                    rowMatch = dtPermissions.Select("ControlName = '" + mnuItem.Name + "'");

                    // If it does, configure the menu item state accordingly.			
                    if (rowMatch.GetLength(0) > 0)
                    {
                        DBPermissions.State state;
                        state = (DBPermissions.State)int.Parse(rowMatch[0]["State"].ToString());

                        switch (state)
                        {
                            case DBPermissions.State.Hidden:
                                mnuItem.Visible = false;
                                break;
                            case DBPermissions.State.Disabled:
                                mnuItem.Enabled = false;
                                break;
                        }
                    }
                    else
                    {
                        mnuItem.Visible = true;
                        mnuItem.Enabled = true;
                    }

                    // Search recursively through any submenus.
                    if (mnuItem.DropDownItems.Count > 0)
                    {
                        SearchMenu(mnuItem.DropDownItems, dtPermissions);
                    }
                }
            }
        }
    }
}
