using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;

namespace DynamicLayout
{
    public class SingleLineFlowLayoutManager
    {
        private Control container;

        // Instead of using a simple integer, you could use a full Padding structure.
        private int margin;
        public int Margin
        {
            get { return margin; }
            set { margin = value;
            container.PerformLayout();
            }
        }

        public SingleLineFlowLayoutManager(Control container, int margin)
        {
            this.container = container;
            this.margin = margin;

            // Attach the event handler.
            container.Layout += new LayoutEventHandler(UpdateLayout);

            // Refresh the layout.
            container.PerformLayout(container, "LayoutManager");
        }

        private void UpdateLayout(object sender,
         System.Windows.Forms.LayoutEventArgs e)
        {
            string debugMessage = "Called: " +
                "\n Affected Control: " + e.AffectedControl.Name +
                "\n Affected Property: " + e.AffectedProperty;
            Debug.WriteLine(debugMessage);

            if (e.AffectedProperty == "Visible") return;
            int y = 0;
            foreach (Control ctrl in container.Controls)
            {
                y += Margin;

                // For maximum efficiency, set the 
                // size and location in one step through
                // the Bounds property.
                ctrl.Bounds = new Rectangle(Margin, y,
                    container.Width - Margin*2, Margin);
            }
        }

    }

}
