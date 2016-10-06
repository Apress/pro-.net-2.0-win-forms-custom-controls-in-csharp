using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Drawing.Design;

namespace ProgressBarControl
{
	public class ProgressValueEditor : UITypeEditor
	{
		
		public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(
			System.ComponentModel.ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.DropDown;
		}

		public override object EditValue(
			System.ComponentModel.ITypeDescriptorContext context,
			System.IServiceProvider provider, object value)
		{

			if (provider != null)
			{
				IWindowsFormsEditorService editorService =
					provider.GetService(
					typeof(IWindowsFormsEditorService))
					as IWindowsFormsEditorService;


				if (editorService != null)
				{
					Progress ctrl = (Progress)context.Instance;
					ProgressValueDropDown selectionControl =
						new ProgressValueDropDown(
						(int)value, ctrl.Maximum,
						editorService);

					editorService.DropDownControl(selectionControl);

					value = selectionControl.Value;
				}
			}
			return value;

		}

		public override bool GetPaintValueSupported(
			System.ComponentModel.ITypeDescriptorContext context)
		{
			// No special thumbnail will be shown for the grid.
			return false;
		}

	}

}
