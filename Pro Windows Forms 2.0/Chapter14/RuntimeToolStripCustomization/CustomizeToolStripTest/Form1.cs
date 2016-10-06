//---------------------------------------------------------------------
//  This file is part of the Microsoft .NET Framework SDK Code Samples.
// 
//  Copyright (C) 2004 Microsoft Corporation.  All rights reserved.
// 
//This source code is intended only as a supplement to Microsoft
//Development Tools and/or on-line documentation.  See these other
//materials for detailed information regarding Microsoft code samples.
// 
//THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
//KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//PARTICULAR PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Samples.BoosterSamples.CustomizeToolStrip;



namespace Microsoft.Samples.BoosterSamples.CustomizeToolStripTest
{
	//=----------------------------------------------------------------------=
	// Form1
	//=----------------------------------------------------------------------=
	/// <summary>
	///   A simple form that has a bunch of ToolStrips on it which are used
	///   to demonstrate the use of the CustomizeToolStrip component and 
	///   dialog.  The component's dialog is shown via a context menu in the
	///   rafting container.  After that, 
	/// </summary>
	/// 
	partial class Form1 : Form
	{
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//          Publicly Consumable Methods/Properties/Functions
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=


		//=------------------------------------------------------------------=
		// Form1
		//=------------------------------------------------------------------=
		/// <summary>
		///   Initializes a new instance of this class and sets up the forms
		///   designer-created components.
		/// </summary>
		/// 
		public Form1()
		{
			InitializeComponent();
		}



		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//                  Private Methods/Functions/etc
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=
		//=------------------------------------------------------------------=


		//=------------------------------------------------------------------=
		// customizeToolStripMenuItem_Click
		//=------------------------------------------------------------------=
		/// <summary>
		///   The user has selected the "Customize" Menu Item.  We'll go
		///   ahead and get our non-visual customizer component to do its
		///   work now.
		/// </summary>
		/// 
		/// <param name="sender">
		///   The menu from whence this notification came.
		/// </param>
		/// 
		/// <param name="e">
		///   EventArgs.Empty
		/// </param>
		/// 
		private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RaiseCustomizeDialog();
		}

		/// <summary>
		///  Handle showing/hiding the toolstrips
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolbarContext_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			// Just switch off the text within the item
			switch (e.ClickedItem.Text.Trim('&'))
			{
				case "Standard":
					standardToolStrip.Visible = !standardToolStrip.Visible;
					standardToolStripMenuItem.Checked = standardToolStrip.Visible;
					break;
				case "Clients":
					clientsToolStrip.Visible = !clientsToolStrip.Visible;
					clientsToolStripMenuItem.Checked = clientsToolStrip.Visible;
					break;
				case "Appointments":
					appointmentsToolStrip.Visible = !appointmentsToolStrip.Visible;
					appointmentsToolStripMenuItem.Checked = appointmentsToolStrip.Visible;
					break;
				case "Billing":
					billingToolStrip.Visible = !billingToolStrip.Visible;
					billingToolStripMenuItem.Checked = billingToolStrip.Visible;
					break;
				case "Misc":
					miscToolStrip.Visible = !miscToolStrip.Visible;
					miscToolStripMenuItem.Checked = miscToolStrip.Visible;
					break;
				default:
					break;

			}
		}




		private void RaiseCustomizeDialog()
		{
			//
			// we're going to all the user to customize all of our ToolStrips.
			// Theoretically, the dialog could also handle MenuStrips, but
			// since it doesn't support hierarchical data, it doesn't interact
			// as well with forms designer-created menus.
			//
			this.customizeToolStrip1.StripsToShow = new ToolStrip[] {
                this.standardToolStrip,
                this.clientsToolStrip,
                this.appointmentsToolStrip,
                this.billingToolStrip,
                this.miscToolStrip
            };

			//
			// we'll have it start with customizing the Standard Toolbar.
			// Please note that we've given all of our ToolStrips friendly 
			// names by setting their Text properties ...
			//
			this.customizeToolStrip1.SelectedToolStrip = this.standardToolStrip;

			//
			// show the dialog.  It will almost immediately fire the 
			// SelectedToolStripChanged event so it can get the list of 
			// available buttons for the first strip.
			//
			this.customizeToolStrip1.ShowDialog(this);

		}


		//=------------------------------------------------------------------=
		// customizeToolStrip1_SelectedToolStripChanged
		//=------------------------------------------------------------------=
		/// <summary>
		///   This is fired whenever the selected ToolStrip changes in the 
		///   "Toolbar/Menu" ComboBox, as well as when the dialog is first
		///   shown.
		/// </summary>
		/// 
		/// <param name="sender">
		///   The CustomizeToolStrip component from whence this event comes.
		/// </param>
		/// 
		/// <param name="ctsea">
		///   The CustomizeToolStripAvailableEventArgs event information 
		///   object.  Upon exiting, we need to set the AvailableItems
		///   Property of this object to contain the list of  buttons we want
		///   shown.
		/// </param>
		/// 
		private void customizeToolStrip1_SelectedToolStripChanged
		(
			object sender,
			CustomizeToolStripAvailableEventArgs ctsea)
		{
			System.Reflection.FieldInfo[] fields;
			ArrayList al = new ArrayList();

			//
			// okay, instead of maintaining a huge array of buttons that could
			// change every time we update the sample, we're just going to go
			// and look at ALL of our member variables and just include those
			// that are of a type that we would include in a ToolStrip, 
			// notably buttons, dropdowns, bombox, labels, textbox, and split
			// buttons.
			//

			//
			// we'll first use reflect to get our member variables.
			//
			fields = typeof(Form1).GetFields(BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);

			//
			// for each field on our object, see if it's the right type, and 
			// if so, include that puppy!
			//
			for (int x = 0; x < fields.Length; x++)
			{
				Type t;
				t = fields[x].FieldType;
				if (t == typeof(ToolStripButton)
					|| t == typeof(ToolStripSeparator)
					|| t == typeof(ToolStripComboBox)
					|| t == typeof(ToolStripDropDownButton)
					|| t == typeof(ToolStripLabel)
					|| t == typeof(ToolStripTextBox)
					|| t == typeof(ToolStripSplitButton))
				{
					al.Add(fields[x].GetValue(this));
				}
			}

			//
			// cast the  array to the right type and return it.
			//
			ctsea.AvailableItems = (ToolStripItem[])al.ToArray(typeof(ToolStripItem));
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			RaiseCustomizeDialog();
		}




	}
}
