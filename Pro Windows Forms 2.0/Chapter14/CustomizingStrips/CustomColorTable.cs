using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Strips
{
    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin
        { get { return Color.FromArgb(50, 50, 50); } }

        public override Color ToolStripGradientMiddle
        { get { return Color.FromArgb(60, 50, 50); } }

        public override Color ToolStripGradientEnd
        { get { return Color.LimeGreen; } }
    }

}
