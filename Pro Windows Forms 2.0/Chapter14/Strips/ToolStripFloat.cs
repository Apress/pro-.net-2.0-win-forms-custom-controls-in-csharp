using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
    public partial class ToolStripFloat : Form
    {
        public ToolStripFloat()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(floatToolStrip1);
            floatToolStrip1.FloatForm.Close();
            floatToolStrip1.FloatForm.Dispose();

            toolStripButton1.Enabled = false;
        }

        private void floatToolStrip1_Undocked(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = true;
        }
    }

    public class FloatToolStrip : ToolStrip
    {
        private Form floatForm;
        public Form FloatForm
        {
            get { return floatForm; }
        }

        public event EventHandler Undocked;

        protected override void OnMouseDown(MouseEventArgs mea)
        {
            if (this.GripRectangle.Contains(mea.Location))
            {              
                Point location = PointToScreen(Point.Empty);

                // For more control, this would be a custom form.
                // You could then event handlers that would react when
                // it is dragged, and re-dock it automatically.
                floatForm = new Form();
                floatForm.Owner = this.FindForm();
                floatForm.StartPosition = FormStartPosition.Manual;
                Point pt = location;
                pt.Offset(5, 5);
                floatForm.Location = pt;
                floatForm.Text = this.Text;

                floatForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                floatForm.ClientSize = this.Size;

                floatForm.Controls.Add(this);
                floatForm.Show();

                if (Undocked != null) Undocked(this, EventArgs.Empty);
            }
            else
            {
                base.OnMouseDown(mea);
            }
        }

        // Another approach.
        //protected override void OnMouseDown(MouseEventArgs mea)
        //{
        //    if (this.GripRectangle.Contains(mea.Location))
        //    {
        //        isDragging = true;
        //        clickOffsetX = mea.X;
        //        clickOffsetY = mea.Y;    
        //    }
        //    else
        //    {
        //        base.OnMouseDown(mea);
        //    }
        //}

        //protected override void OnMouseUp(MouseEventArgs mea)
        //{
        //    isDragging = false;
        //    base.OnMouseUp(mea);
        //}

        //// Keep track of when fake "drag and drop" mode is enabled.
        //private bool isDragging = false;

        //// Store the location where the user clicked the control.
        //private int clickOffsetX, clickOffsetY;


        //protected override void OnMouseMove(MouseEventArgs mea)
        //{
        //    if (isDragging)
        //    {
        //        // The control coordinates are converted into form coordinates
        //        // by adding the label position offset.
        //        // The offset where the user clicked in the control is also
        //        // accounted for. Otherwise, it looks like the top-left corner
        //        // of the label is attached to the mouse.
        //        this.Location = new Point(mea.X + this.Left - clickOffsetX,
        //            mea.Y + this.Top - clickOffsetY);
        //    }
        //    else
        //    {
        //        base.OnMouseMove(mea);
        //    }
        //}

        
    }


}