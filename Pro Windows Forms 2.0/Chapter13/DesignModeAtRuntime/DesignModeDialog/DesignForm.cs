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

namespace Microsoft.Samples
{
	class DesignForm : Form
	{
		// Fields
		PropertyGrid _grid;
		ISelectionService _selection;
		IDesignerHost _host;
		DesignSurface _surface;
		Form _originalForm;
		Hashtable _reparentedControls;
		System.Collections.ObjectModel.Collection<string> _propertiesToDesign;
		Hashtable _customTypeDescriptors;

		public DesignForm(Form originalForm, System.Collections.ObjectModel.Collection<string> propertiesToDesign)
		{
			// Copy parameters to fields
			_originalForm = originalForm;
			_propertiesToDesign = propertiesToDesign;

			// Create hashtables
			_reparentedControls = new Hashtable();
			_customTypeDescriptors = new Hashtable();

			// Create the DesignSurface and get the View from it;
			_surface = new DesignSurface(typeof(Form));

			// Setup UI, note, this can't be called until _surface is non-null 
			SetupUI();
				
			// Get the IDesignerHost for the surface
			_host = _surface.GetService(typeof(IDesignerHost)) as IDesignerHost;

			// Get the ISelectionService and hook the SelectionChanged event
			_selection = _surface.GetService(typeof(ISelectionService)) as ISelectionService;

			if (_selection != null)
			{
				_selection.SelectionChanged += new EventHandler(SelectionChanged);
			}

			// Get the rootForm from the IDesignerHost
			Form rootForm = _host.RootComponent as Form;
			if (rootForm != null)
			{
				//  Clone the Form's properties
				CloneControlProperties(_originalForm, rootForm);

				// Now that a customTypeDescriptor is around for the Form, use it
				SampleCustomTypeDescriptor formDesc = _customTypeDescriptors[rootForm] as SampleCustomTypeDescriptor;
				if (formDesc != null)
				{
					_grid.SelectedObject = formDesc;
				}
				
				// Clone the controls on the Form
				CloneControlsRecursive(_originalForm.Controls, rootForm);
			}
		}

		private void CloneControlProperties(Control original, Control clone)
		{
			// Create two PropertyDescriptorCollections, one for the original control's
			// props and one for the clone's props
			PropertyDescriptorCollection originalProps = TypeDescriptor.GetProperties(original);
			PropertyDescriptorCollection cloneProps = TypeDescriptor.GetProperties(clone);

			// Create a third empty PropertyDescriptorCollection to give the the
			// ICustomTypeDescriptor that the property grid will use
			PropertyDescriptorCollection propsForCustomDescriptor = new PropertyDescriptorCollection(null);

			// Go through all the properties that the caller has told us to care about
			PropertyDescriptor originalTemp, cloneTemp;
			foreach (string propName in _propertiesToDesign)
			{
				// Special case Form location property
				if (!((propName == "Location") && (typeof(Form).IsAssignableFrom(original.GetType()))))
				{
					// Fish out the property descriptors
					originalTemp = originalProps[propName];
					cloneTemp = cloneProps[propName];

					// Make sure the PropertyDescriptors aren't null and
					// That we should set the property (that is, it's non-default)
					if ((originalTemp != null) && (originalTemp.ShouldSerializeValue(original)))
					{
						// Set the clone's value to that of the original
						cloneTemp.SetValue(clone, originalTemp.GetValue(original));
					}

					// Add the property to the collection for the ICustomTypeDescriptor
					propsForCustomDescriptor.Add(cloneTemp);
				}
			}

			// Create a customTypeDescriptor, add it to the table
			_customTypeDescriptors.Add(clone, new SampleCustomTypeDescriptor(clone, propsForCustomDescriptor));

			// Finally, stuff away original control
			clone.Tag = original;
		}

		private void CloneControlsRecursive(System.Windows.Forms.Control.ControlCollection originalControls, Control cloneContainer)
		{
			// Go through each control in the original container
			Control clone;
			foreach (Control original in originalControls)
			{
				// Create a fresh control of the proper type
				clone = _host.CreateComponent(original.GetType()) as Control;
				if (clone != null)
				{
					// Clone the control properties
					CloneControlProperties(original, clone);

					// Add the control to the new parent
					cloneContainer.Controls.Add(clone);

					// If we've already got the same number of controls as the original
					// don't recurse through the controls collection
					if (clone.Controls.Count != original.Controls.Count)
					{
						// Recursively continue for child controls
						CloneControlsRecursive(original.Controls, clone);
					}
				}

			}
		}

		private void me_FormClosing(object sender, FormClosingEventArgs e)
		{
			Form rootForm = _host.RootComponent as Form;

			if (rootForm != null)
			{
				// Restore Form proeprties
				CloneControlProperties(rootForm, _originalForm);

				// Restore child control properties
				RestoreControlsRecursive(rootForm.Controls, _originalForm.Controls);

				// Deal with any reparented controls
				ReparentControls();
			}
		}

		private void ReparentControls()
		{
			// Look through all the reparented controls and reparent 
			// them on the original form as well
			IDictionaryEnumerator enumerator = _reparentedControls.GetEnumerator();

			Control original;
			Control originalParent;

			while (enumerator.MoveNext())
			{
				// Fish out the control and it's new parent
				original = enumerator.Key as Control;
				originalParent = enumerator.Value as Control;

				if ((original != null) && (originalParent != null)) 
				{
					// Once we find the control and it's parent on the original form
					// we can reparent it
					Control destinationControl = original.Tag as Control;
					Control destinationParent = originalParent.Tag as Control;

					if ((destinationControl != null) && (destinationParent != null)) {
						destinationParent.Controls.Add(destinationControl);
					}
				}
			}
		}

		private void RestoreControlsRecursive(System.Windows.Forms.Control.ControlCollection newControls, System.Windows.Forms.Control.ControlCollection originalControls)
		{
			bool found;
			foreach (Control newControl in newControls)
			{
				// Fish out the 
				Control originalControlFromTag = newControl.Tag as Control;

				if (originalControlFromTag != null)
				{
					// Restore properties
					CloneControlProperties(newControl, originalControlFromTag);

					// Restore child controls
					RestoreControlsRecursive(newControl.Controls, originalControlFromTag.Controls);
				}

				// Look for the control to make sure it hasn't been reparented
				found = false;
				foreach (Control originalControl in originalControls)
				{
					if (originalControlFromTag == originalControl)
					{
						found = true;
						break;
					}
				}
				// If it's been reparented, stash it away so we can change it's parent later
				if (!found)
				{
					_reparentedControls[newControl] = newControls.Owner;
				}
			}
		}

		private void SelectionChanged(object sender, EventArgs e)
		{
			// Fish out the custom type descriptor and use it
			SampleCustomTypeDescriptor controlDesc = _customTypeDescriptors[_selection.PrimarySelection] as SampleCustomTypeDescriptor;
			if (controlDesc != null)
			{
				_grid.SelectedObject = controlDesc;
			}
		}

		private void SetupUI()
		{
			// Create controls
			Control view = _surface.View as Control;
			Splitter splitter = new Splitter();

			// If we got a view control out of the DesignSurface, setup the Form
			if (view != null)
			{
				_grid = new PropertyGrid();
				_grid.Size = new Size(250, _grid.Size.Height);
				_grid.Dock = DockStyle.Right;
				_grid.PropertySort = PropertySort.Alphabetical;
				_grid.ToolbarVisible = false;
				_grid.CommandsVisibleIfAvailable = false;

				splitter.Dock = DockStyle.Right;

				view.Dock = DockStyle.Fill;

				this.Size = new Size(_originalForm.Size.Width + 315, _originalForm.Size.Height + 85);
				this.FormClosing += new FormClosingEventHandler(me_FormClosing);
				this.Controls.Add(view);
				this.Controls.Add(splitter);
				this.Controls.Add(_grid);
			}
		}
	}
}
