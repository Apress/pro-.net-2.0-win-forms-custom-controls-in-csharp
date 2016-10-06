using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;

namespace ContainerControls
{
    //[ToolboxItem(false)]
    [Designer(typeof(ContainerChildDesigner))]
	public class ContainerChild : Control
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.Red, this.ClientRectangle);
            e.Graphics.DrawString(Text, SystemFonts.IconTitleFont,
                Brushes.White, this.ClientRectangle);
		}

        protected override void OnParentChanged(EventArgs e)
        {            
            // Allow a null parent to support drag-and-drop
            // (from one Container to another) at design time.
            if ((this.Parent is Container) || (this.Parent == null))
            {
                base.OnParentChanged(e);
            }
            else
            {
                throw new NotSupportedException("A ContainerChild control can only be added to a Container control");
            }
        }
	}

	public class ContainerChildDesigner : ControlDesigner
	{       
		public override bool CanBeParentedTo(IDesigner parentDesigner)
		{
			// Control can only be parented by Container. 
			return (parentDesigner is ContainerDesigner);
		}
	} 
}
