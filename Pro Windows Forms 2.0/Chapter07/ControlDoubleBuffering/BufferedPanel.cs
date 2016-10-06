using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ControlDoubleBuffering
{
    public partial class BufferedPanel : Panel
    {
       
        public BufferedPanel()
        {
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
//          same as below...
//          this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
//          this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }            
        

		//// only here to disable background painting for testing AllPaintingInWmPaint flag
		//protected override void OnPaintBackground(PaintEventArgs pevent)
		//{
		//    base.OnPaintBackground(pevent);
		//}
    }
}
