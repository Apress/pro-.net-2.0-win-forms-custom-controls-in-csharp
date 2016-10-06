using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Design;

// New namespace for snaplines
using System.Windows.Forms.Design.Behavior;

namespace Microsoft.Samples
{
	/// <summary>
	/// Summary description for MyControlDesigner.
	/// </summary>
	public class CollapsiblePanelDesigner : ParentControlDesigner
	{
		DesignerActionListCollection actions;
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				if (actions == null)
				{
					//actions = new DesignerActionListCollection();
					//actions.Add(new CollapsiblePanelActionList((CollapsiblePanel)Control, (ISelectionService)GetService(typeof(ISelectionService))));
				}
				return actions;
			}
		}

		public override IList SnapLines
		{
			get
			{
				IList snapLines = base.SnapLines;

				snapLines.Add(new SnapLine(SnapLineType.Baseline, 6 + Control.Font.Height));
				return snapLines;
			}
		}


	}
}
