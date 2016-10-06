using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace ContainerControls
{
	[Designer(typeof(ContainerDesigner))]
	public class Container : Control
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			Pen p = new Pen(Color.Blue, 10);
			e.Graphics.DrawRectangle(Pens.Blue, this.ClientRectangle);
			p.Dispose();
		}

        protected override Control.ControlCollection CreateControlsInstance()
        {
            return new ContainerChildControlCollection(this);
        }    
	}

    public class ContainerChildControlCollection : Control.ControlCollection
    {
        public ContainerChildControlCollection(Control owner)
            : base(owner)
        {}

        public override void Add(System.Windows.Forms.Control value)
        {
            if (value is ContainerChild)
            {
                base.Add(value);
            }
            else
            {
                throw new NotSupportedException("Only ContainerChild controls can be added to a Container control.");
            }
        }
    }

    
	public class ContainerDesigner : ParentControlDesigner
	{
		public override bool CanParent(Control control)
		{			
		    // Children can only be of type ContainerChild. 
		    return (control is ContainerChild);
		}
	}	
	
}
