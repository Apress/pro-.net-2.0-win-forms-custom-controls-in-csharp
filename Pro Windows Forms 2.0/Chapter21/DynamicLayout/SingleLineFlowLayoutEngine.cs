using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Drawing;

namespace DynamicLayout
{
    public class SingleLineFlowLayoutEngine : LayoutEngine
    {
        private int margin;
        public int Margin
        {
            get { return margin; }
            set
            {
                margin = value;
                if (parent != null)
                    base.Layout(parent, new LayoutEventArgs(parent, "Margin"));
            }
        }
        public SingleLineFlowLayoutEngine(int margin)
        {
            Margin = margin;
        }

        
        private Control parent;

        // You could choose to take other properties into account
        // (like parent's padding, and the margins or anchor settings
        // of each child control).
        public override bool Layout(object container, LayoutEventArgs layoutEventArgs)
        {
            parent = container as Control;
            
            int y = 0;
            foreach (Control ctrl in parent.Controls)
            {
                y += Margin;

                // For maximum efficiency, set the 
                // size and location in one step through
                // the Bounds property.
                ctrl.Bounds = new Rectangle(Margin, y,
                    parent.Width - Margin*2, Margin);
            }

            // Return true if the layout should be performed again
            // by the parent.
            return parent.AutoSize;
        }
    }


}
