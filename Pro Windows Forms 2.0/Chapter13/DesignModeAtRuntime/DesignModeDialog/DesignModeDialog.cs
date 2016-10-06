using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;

namespace Microsoft.Samples
{
	[Designer(typeof(DesignModeDialogDesigner))]
	public class DesignModeDialog : Component
	{
		// Fields
		Form _hostForm;
		Collection<string> _propertiesToDesign;

		public DesignModeDialog()
		{
			_propertiesToDesign = new Collection<string>();
		}

		public Form HostForm
		{
			get
			{
				return _hostForm;
			}
			set
			{
				_hostForm = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Collection<string> PropertiesToDesign
		{
			get
			{
				return _propertiesToDesign;
			}
		}

		public DialogResult ShowDialog()
		{
			DesignForm form = new DesignForm(_hostForm, _propertiesToDesign);
			return form.ShowDialog();
		}
	}
}
