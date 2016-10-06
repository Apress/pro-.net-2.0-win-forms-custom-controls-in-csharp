//---------------------------------------------------------------------
//  This file is part of the Microsoft .NET Framework SDK Code Samples.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
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
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;


namespace Microsoft.Samples.BoosterSamples.CustomizeToolStrip
{

    /// 
    /// <summary>
    ///   This delegate is declared for the SelectedToolStripChanged event
    ///   on the CustomizeToolStrip component.  The EventArgs-based object
    ///   simply contains a reference to the strip that is newly selected,
    ///   and a place to put the array of ToolStripItem objects which should
    ///   be shown for this event.
    /// </summary>
    /// 
    /// <param name="sender">
    ///   Sending CustomizeToolStrip object.
    /// </param>
    /// 
    /// <param name="ctsea">
    ///   CustomizeToolStripEventArgs object containgin the relevant ToolStrip
    ///   reference, as well as a place to put the items to be shown as
    ///   "available" for it.
    /// </param>
    /// 
    public delegate void SelectedToolStripChangedEventHandler(
                            object sender, 
                            CustomizeToolStripAvailableEventArgs ctsea
    );



    //=----------------------------------------------------------------------=
    // CustomizeToolStrip
    //=----------------------------------------------------------------------=
    /// <summary>
    /// A non-visual component that can be placed on a form (or otherwise 
    /// used directly) that will show a little dialog letting users
    /// customize the ToolStrips and MenuStrips that the programmer wishes
    /// them to.
    /// </summary>
    /// 
    [DefaultProperty("ApplyChangesAfterShow"),
     DefaultEvent("SelectedToolStripChanged")]
    public partial class CustomizeToolStrip : Component
    {
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //                 Private Members/Types/etc...
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=

        ///
        /// <summary>
        /// This is the list of all ToolStrips (and derived classes such as
        /// MenuStrips) to show in the list of available strips which the
        /// user will be permitted to customize.  
        /// </summary>
        /// 
        private ToolStrip [] toolStripsToInclude;

        /// 
        /// <summary>
        /// This is the ToolStrip that should be shown as selected in the
        /// dialog's "Toolbar / Menu" ComboBox.
        /// </summary>
        /// 
        private ToolStrip selectedToolStrip;


        /// 
        /// <summary>
        ///   Controls whether or not we actually <em>apply</em> the changes
        ///   the user made to the toolstrips after showing the dialog, or
        ///   whether the task is left up to the programmer, who may wish to
        ///   do some checking and otherwise control the process.
        /// </summary>
        /// 
        private bool applyChangesAfterShow;


        ///
        /// <summary>
        ///   After the user closes the dialog, we'll save the array of
        ///   strips and proposed item collections in case the programmer 
        ///   doesn't want US to make the changes, but would rather do it 
        ///   themselves.
        /// </summary>
        /// 
        private ToolStripWithItems[] stripsWithItems;




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
        // CustomizeToolStrip
        //=------------------------------------------------------------------=
        /// <summary>
        /// Initializes a new instance of this component.
        /// </summary>
        /// 
        public CustomizeToolStrip()
        {
            InitializeComponent();

            this.applyChangesAfterShow = true;
        }


        //=------------------------------------------------------------------=
        // CustomizeToolStrip
        //=------------------------------------------------------------------=
        /// <summary>
        /// Initializes a new instance of this component.
        /// </summary>
        /// 
        /// <param name="container">
        /// The container in which this component will be hosted.
        /// </param>
        /// 
        public CustomizeToolStrip(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.applyChangesAfterShow = true;
        }


        //=------------------------------------------------------------------=
        // StripsToShow
        //=------------------------------------------------------------------=
        /// <summary>
        /// This is the list of available ToolStrips (and MenuStrips) which
        /// will be shown in the "Toolbar / Menu" ComboBox.  They form the 
        /// set of strips that the user will be permitted to modify.
        /// </summary>
        /// 
        /// <value>
        /// An array of ToolStrips
        /// </value>
        /// 
        [Browsable(false)]
        public ToolStrip[] StripsToShow
        {
            get
            {
                return this.toolStripsToInclude;
            }

            set
            {
                //
                // we'll check that the values are valid when the programmer
                // goes to show the dialog for the first time!
                //
                this.toolStripsToInclude = value;
            }
        }


        //=------------------------------------------------------------------=
        // SelectedToolStrip
        //=------------------------------------------------------------------=
        /// <summary>
        ///   This is the ToolStrip that should be shown as selected in the
        ///   dialog's "Toolbar / Menu" ComboBox when the dialog is shown.
        /// </summary>
        /// 
        /// <value>
        ///   The ToolSTrip to select when showing the dialog.
        /// </value>
        /// 
        [Browsable(false)]
        public ToolStrip SelectedToolStrip
        {
            get
            {
                return this.selectedToolStrip;
            }

            set
            {
                //
                // we'll check that this is a valid value when the programmer
                // goes to show the dialog for the first time.
                //
                this.selectedToolStrip = value;
            }
        }


        //=------------------------------------------------------------------=
        // ShowDialog
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Shows the CustomizeToolStrip dialog which lets users customize 
        ///   the various ToolStrips and MenuStrips on their form. Depending
        ///   on the value of the ApplyChangesAfterShow property on this
        ///   control,  the dialog may go ahead and set the values, or leave
        ///   that as a task to the programmer
        /// </summary>
        /// 
        /// <param name="in_parentForm">
        ///   The form to use as the parent for the modal dialog (this dialog
        ///   cannot be shown modeless).
        /// </param>
        /// 
        public DialogResult ShowDialog(IWin32Window in_parentForm)
        {
            CustomizeToolStripForm ctsf;
            DialogResult dr;
            
            //
            // first thing we want to do is make sure that they have given
            // us a valid list of Strips to show as well as a valid initially
            // selected strip,
            //
            if (this.toolStripsToInclude == null 
                || this.toolStripsToInclude.Length == 0)
            {
                throw new ArgumentException((CustomizeToolStripMain.GetResourceManager()).GetString("excInvalidToolStripsToShow"));
            }
            else if (this.selectedToolStrip == null)
            {
                throw new ArgumentException(CustomizeToolStripMain.GetResourceManager().GetString("excNullSelectedToolStrip"));
            }
            else if (!CustomizeToolStripMain.ArrayContainsStrip(this.toolStripsToInclude, this.selectedToolStrip))
            {
                throw new ArgumentException(CustomizeToolStripMain.GetResourceManager().GetString("excInvalidSelectedToolStrip"));
            }

            //
            // create the new dialog to show.  This will fire the first
            // SelectedToolStripChanged event for the user to populate
            // the list of available items for that strip.
            //
            ctsf = new CustomizeToolStripForm(this,
                                              this.toolStripsToInclude,
                                              this.selectedToolStrip);
            dr = ctsf.ShowDialog(in_parentForm);
            if (dr != DialogResult.Cancel)
            {
                //
                // Save the changes the user made in case the programmer
                // queries the StripsWithItems property.
                //
                this.stripsWithItems = ctsf.GetToolStripsAndItems();

                //
                // if we're supposed to apply the changes ourselves, go and do
                // so now.
                //
                if (this.applyChangesAfterShow)
                {
                    try
                    {
                        if (in_parentForm is Control)
                        {
                            ((Control)in_parentForm).SuspendLayout();
                        }
                        applyChangesToStrips();
                    }
                    finally
                    {
                        if (in_parentForm is Control)
                        {
                            ((Control)in_parentForm).ResumeLayout();
                        }
                    }

                }
            }

            return dr;
        }


        //=------------------------------------------------------------------=
        // ApplyChangesAfterShow
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Controls whether or not we actually <em>apply</em> the changes
        ///   the user made to the toolstrips after showing the dialog, or
        ///   whether the task is left up to the programmer, who may wish to
        ///   do some checking and otherwise control the process.
        /// </summary>
        /// 
        /// <value>
        ///   A boolean indicating whether or this component applies the 
        ///   changes made by the user (true), or whether it leaves the
        ///   ToolStrips and MenuStrips alone (false).
        /// </value>
        /// 
        [DefaultValue(true)]
        public bool ApplyChangesAfterShow
        {
            get
            {
                return this.applyChangesAfterShow;
            }

            set
            {
                this.applyChangesAfterShow = value;
            }
        }


        //=------------------------------------------------------------------=
        // StripsAndItems
        //=------------------------------------------------------------------=
        /// <summary>
        ///   After the user has finished working with the dialog, the 
        ///   application author might wish to go and see what changes were
        ///   made (especially if the ApplyChangesAfterShow property was set
        ///   to false).  This property returns an array of items holding both
        ///   each of the strips in the dialog, along with the set of items 
        ///   the user indicated they would like to see with said strips.
        /// </summary>
        /// 
        /// <value>
        ///   An array of items; each holding a strip handle and the set of
        ///   items the user said they wished to see associated with that
        ///   strip.
        /// </value>
        /// 
        [Browsable(false)]
        public ToolStripWithItems[] StripsAndItems
        {
            get
            {
                return this.stripsWithItems;
            }
        }


        //=------------------------------------------------------------------=
        // GetItemsForStrip
        //=------------------------------------------------------------------=
        /// <summary>
        ///   The user has changed the selected Toolbar or Menu in the 
        ///   CustomizeToolStripForm form.  We need to get the list of 
        ///   available items for this strip from the user now.  We'll raise
        ///   an event to get them to tell us.
        /// </summary>
        /// 
        /// <param name="in_strip">
        ///   The ToolStrip (or MenuStrip) that was newly selected.
        /// </param>
        /// 
        /// <returns>
        ///   An array of ToolStripItems that should be considered available
        ///   to this ToolStrip.
        /// </returns>
        /// 
        internal ToolStripItem[] GetItemsForStrip(ToolStrip in_strip)
        {
            CustomizeToolStripAvailableEventArgs ctsaea;

            ctsaea = new CustomizeToolStripAvailableEventArgs(in_strip);

            //
            // fire the event with the user in the normal overridable 
            // fashion and then return the list of available items
            // for this strip.
            //
            OnSelectedToolStripChanged(ctsaea);
            return ctsaea.AvailableItems;
        }




        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //           Private/Protected Methods/Functions/Properties
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=


        //=------------------------------------------------------------------=
        // OnSelectedToolStripChanged
        //=------------------------------------------------------------------=
        /// <summary>
        ///   A method to invoke the SelectedToolStripChanged event.  The pattern
        ///   of having an overridable protected OnXXX method to actually do
        ///   the event raising is followed here to encourage people
        ///   subclassing this control to not hook up events on themselves.
        /// </summary>
        /// 
        /// <param name="in_ctsaea">
        ///   Event details with the ToolStrip affected as well as a place to
        ///   put the resulting available items.
        /// </param>
        /// 
        protected void OnSelectedToolStripChanged
        (
            CustomizeToolStripAvailableEventArgs in_ctsaea
        )
        {
            if (SelectedToolStripChanged != null)
            {
                SelectedToolStripChanged(this, in_ctsaea);
            }
        }


        //=------------------------------------------------------------------=
        // applyChangesToStrips
        //=------------------------------------------------------------------=
        /// <summary>
        ///   The user has closed the CustomizeToolStripForm dialog, and the
        ///   ApplyChangesAfterShow property is set to True, which means they
        ///   want us to apply the changes for them.  We do sow now.
        /// </summary>
        /// 
        private void applyChangesToStrips()
        {
            int x;

            //
            // First step, clear out ALL strips.  We have to do this before
            // ANY setting is done so that there are no accidental attempts
            // to give an item a second parent ...
            //
            for (x = 0; x < this.stripsWithItems.Length; x++)
            {
                this.StripsAndItems[x].Strip.Items.Clear();
            }

            //
            // Next, for each strip, go and set the buttons on it.
            //
            for (x = 0; x < this.StripsAndItems.Length; x++)
            {
                this.StripsAndItems[x].Strip.Items.AddRange(this.StripsAndItems[x].Items);
            }

            //
            // and that should do it!!
            //
        }






        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //                            Events
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=

        //=------------------------------------------------------------------=
        // SelectedToolStripChanged
        //=------------------------------------------------------------------=
        /// <summary>
        ///   This event is raised whenever the user selects a new ToolStrip 
        ///   or MenuStrip in the "Toolbar / Menu" ComboBox in the 
        ///   CustomizeToolStrip dialog that is shown from this component.
        /// </summary>
        /// 
        public event SelectedToolStripChangedEventHandler SelectedToolStripChanged;

    }




    //=----------------------------------------------------------------------=
    // CustomizeToolStripEventArgs
    //=----------------------------------------------------------------------=
    /// <summary>
    /// 
    /// </summary>
    /// 
    public class CustomizeToolStripEventArgs : EventArgs
    {
        /// 
        /// summary>
        /// 
        /// </summary>
        /// 
        private ToolStrip affectedStrip;

        //=------------------------------------------------------------------=
        // CustomizeToolStripEventArgs
        //=------------------------------------------------------------------=
        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="in_affectedStrip">
        /// 
        /// </param>
        /// 
        internal CustomizeToolStripEventArgs(ToolStrip in_affectedStrip)
        {
            Debug.Assert(in_affectedStrip != null);
            this.affectedStrip = in_affectedStrip;
        }


        //=------------------------------------------------------------------=
        // Strip
        //=------------------------------------------------------------------=
        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <value>
        /// 
        /// </value>
        /// 
        public ToolStrip Strip
        {
            get
            {
                return this.affectedStrip;
            }
        }
    }

    //=----------------------------------------------------------------------=
    // CustomizeToolStripAvailableEventArgs
    //=----------------------------------------------------------------------=
    /// <summary>
    ///   This class is included in the SelectedToolStripChanged event raised
    ///   by  the CustomizeToolStrip class.  It contains a handle to the newly
    ///   selected ToolStrip or MenuStrip, as well as a place to put all the
    ///   ToolStripItems that should be shown as "available" to the 
    ///   ToolStrip.  Please note that the callee should just show all items
    ///   that would normally be available to the strip; the dialog will 
    ///   remove any items that are already included in the ToolStrip.
    /// </summary>
    /// 
    public class CustomizeToolStripAvailableEventArgs 
        : CustomizeToolStripEventArgs
    {
        /// 
        /// <summary>
        ///   The array of items to be shown as available to be placed on
        ///   the given ToolStrip (or MenuStrip).
        /// </summary>
        /// 
        private ToolStripItem [] availableItems;

        //=------------------------------------------------------------------=
        // CustomizeToolStripAvailableEventArgs
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Initializes a new instance of our class.
        /// </summary>
        /// 
        /// <param name="in_affectedStrip">
        ///   The ToolStrip for which we want to get the list of available
        ///   ToolStripItems to show.
        /// </param>
        /// 
        internal CustomizeToolStripAvailableEventArgs
        (
            ToolStrip in_affectedStrip
        )
        : base(in_affectedStrip)
        {
        }


        //=------------------------------------------------------------------=
        // AvailableItems
        //=------------------------------------------------------------------=
        /// <summary>
        ///   An array containing the list of available items for this
        ///   ToolStrip.  The invoked event handler should set this array to
        ///   those items that should be possibly listed for this 
        ///   ToolStrip (or MenuStrip).  The invoked handler should simply
        ///   return a set of all <em>possible</em> items.  The dialog will
        ///   make sure to remove any from the list that are actually already
        ///   on the ToolStrip or MenuStrip.
        /// </summary>
        /// 
        /// <value>
        ///   An array of ToolStripItems (or derived classes) that should 
        ///   be shown as available to be placed in the given ToolStrip.
        /// </value>
        /// 
        public ToolStripItem[] AvailableItems
        {
            get
            {
                return this.availableItems;
            }

            set
            {
                this.availableItems = value;
            }
        }

    }

}
