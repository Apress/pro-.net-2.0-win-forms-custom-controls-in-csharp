#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;

#endregion

namespace GradientPanelControl
{
    public class GradientPanelDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {
        private DesignerActionListCollection actionLists;

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (actionLists == null)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new GradientPanelActionList((GradientPanel)Control));
                }
                return actionLists;
            }
        }
    }
}
