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
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;


namespace Microsoft.Samples.BoosterSamples.CustomizeToolStrip
{
    //=----------------------------------------------------------------------=
    // CustomizeToolStripForm
    //=----------------------------------------------------------------------=
    /// <summary>
    /// A little dialog that can be brought up to let users customize the 
    /// ToolStrips and MenuStrips in their application.
    /// </summary>
    /// 
    partial class CustomizeToolStripForm : Form
    {

        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //                 Private Members/Types/etc...
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=

        private const string SEPARATOR_NAME = "___SEPARATOR";
        private const string ANCHOR_SEPARATOR = "___ANCHORSEP";


        /// 
        /// <summary>
        /// This structure is used in the toolMenuComboBox, which holds a list
        /// of <em>all</em> ToolStrips and MenuStrips that can be customized.
        /// </summary>
        /// 
        private class StripAndName
        {
            public string Name;
            public ToolStrip Strip;

            public override string ToString()
            {
                return Name;
            }
        }

        /// 
        /// <summary>
        ///   This is a simple structure used by the two list boxes to
        ///   let us store Items in them (so we can paint their icons
        ///   properly in addition to being able to identify them) as
        ///   as well as friendly text for them. (By default, 
        ///   ToolStripItem.ToString() doesn't print what we want it 
        ///   to.)
        /// </summary>
        /// 
        private class ItemAndName
        {
            public string Name;
            public ToolStripItem Item;


            public override string ToString()
            {
                if (this.Name.Equals(SEPARATOR_NAME)
                    || this.Name.Equals(ANCHOR_SEPARATOR))
                {
                    return CustomizeToolStripMain.GetResourceManager().GetString("separatorText");
                }
                else
                {
                    return Name.Replace("&", "");
                }
            }
        }

        ///
        /// <summary>
        ///   This struct is used to track the base list of available 
        ///   items for a given ToolStrip-based strip, as well as those
        ///   items that the user selected for this strip.
        /// </summary>
        /// 
        private class ToolStripItemMap
        {
            public ToolStripItem[] baseAvailableItems;
            public ToolStripItem[] userSelectedItems;
        }

        /// 
        /// <summary>
        ///   This table will be keyed off the handles to ToolStrips and
        ///   will contain the list of available items they are permitted
        ///   to use, as well as the list of items that the user last
        ///   selected in the User Interface.
        /// </summary>
        /// 
        private Hashtable toolStripToItemsMapping;

        /// 
        /// <summary>
        ///   The last value of SelectedIndex in the toolbarMenuComboBox.
        /// </summary>
        /// 
        private int lastSelectedStripIndex;

        /// 
        /// <summary>
        ///   This is the first strip that will be selected in the dialog.
        ///   we save it here because if we set the value before the form
        ///   is fully loaded/shown, then the SelectedIndexChanged event
        ///   isn't fired, which means we can't populate the lists.
        /// </summary>
        /// 
        private ToolStrip initialStripToSelect;

        /// 
        /// <summary>
        /// This is the CustomizeToolStrip in which we are operating.
        /// We need to know this to forward them certain events and
        /// get the return values ...
        /// </summary>
        /// 
        private CustomizeToolStrip parentCustomizer;





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
        // CustomizeToolStripForm
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Initializes a new instance of our dialog.
        /// </summary>
        /// 
        /// <param name="in_cts">
        ///   The parent CustomizeToolStrip in which we are operating. We need
        ///   to hold on to this so we can send them event notifications.
        /// </param>
        /// <param name="in_stripsToList">
        ///   An array of ToolStrips and/or ToolStrip-based MenuStrips to
        ///   list in the "Toolbar / Menu" ComboBox.
        /// </param>
        /// <param name="in_initialSelected">
        ///   A reference to the ToolStrip in the array of strips to list that
        ///   should find itself the first to be selected in the ComboBox. It
        ///   is an error for this parameter to not be a member of the list of
        ///   available ToolStrips.
        /// </param>
        /// 
        protected internal CustomizeToolStripForm
        (
            CustomizeToolStrip in_cts,
            ToolStrip [] in_stripsToList,
            ToolStrip in_initialSelected
        )
        {
            //
            // Sets up all the Windows Forms code behind this class.
            //
            InitializeComponent();

            //
            // these are checked with exceptions in the calling class.
            //
            Debug.Assert(in_stripsToList != null);
            Debug.Assert(in_initialSelected != null);
            Debug.Assert(in_cts != null);

            this.parentCustomizer = in_cts;
            this.toolStripToItemsMapping = new Hashtable();
            this.lastSelectedStripIndex = -1;

            //
            // set the heights of the list boxes to something reasonable
            // for the current font.
            //
            this.availableItemsListBox.ItemHeight = (int)this.Font.GetHeight() + 4;
            this.currentItemsListBox.ItemHeight = (int)this.Font.GetHeight() + 4;
            this.toolbarMenuComboBox.ItemHeight = (int)this.Font.GetHeight() + 4;

            //
            // add the ToolStrips and ilk to the dropdown combobox of
            // available strips.
            //
            insertStripsIntoCombo(in_stripsToList);

            //
            // set the selected item in the ComboBox.
            //
            this.initialStripToSelect = in_initialSelected;
        }


        //=------------------------------------------------------------------=
        // GetToolStripsAndItems
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Used by the CustomizeToolStrip component to get the list of
        ///   ToolStrips and the list of buttons the user wanted selected for
        ///   each.
        /// </summary>
        /// 
        /// <returns>
        ///   An array of ToolStripWithItem objects holding the strips and
        ///   arrays of selected items for them.
        /// </returns>
        /// 
        protected internal ToolStripWithItems [] GetToolStripsAndItems()
        {
            ArrayList al = new ArrayList();
            ToolStripWithItems tswi;
            StripAndName san;

            //
            // loop through all the strips about which we know, getting
            // their currently 'chosen' items.
            //
            for (int x = 0; x < this.toolbarMenuComboBox.Items.Count; x++)
            {
                san = (StripAndName)this.toolbarMenuComboBox.Items[x];

                tswi = new ToolStripWithItems();
                tswi.Strip = san.Strip;
                tswi.Items = fetchSelectedItemsForStrip(san.Strip);
                al.Add(tswi);
            }

            return (ToolStripWithItems[])al.ToArray(typeof(ToolStripWithItems));
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
        // insertStripsIntoCombo
        //=------------------------------------------------------------------=
        /// <summary>
        /// Takes the given array of ToolStrips and MenuStrips and inserts
        /// them into the "Toolbar / Menu" ComboBox on the dialog from which
        /// the user can select which ToolStrip t customize.
        /// </summary>
        /// 
        /// <param name="in_strips">
        /// Array of ToolStrips and friends to insert into the ComboBox.
        /// </param>
        /// 
        private void insertStripsIntoCombo(ToolStrip[] in_strips)
        {
            //
            // This is checked above more robustly.
            //
            System.Diagnostics.Debug.Assert(in_strips != null 
                                            && in_strips.Length != 0);

            //
            // insert them all into the ComboBox one at a time.
            //
            for (int x = 0; x < in_strips.Length; x++)
            {
                StripAndName san = new StripAndName();
                
                san.Name = in_strips[x].Text;
                san.Strip = in_strips[x];

                this.toolbarMenuComboBox.Items.Add(san);
            }
        }


        //=------------------------------------------------------------------=
        // selectToolStripInCombo
        //=------------------------------------------------------------------=
        /// <summary>
        /// Goes and selects the given ToolStrip in the combo of all strips
        /// available for customization, toolMenuComboBox.
        /// </summary>
        /// 
        /// <param name="in_strip">
        /// The strip to mark as the selected item.
        /// </param>
        /// 
        private void selectToolStripInCombo(ToolStrip in_strip)
        {
            StripAndName san;

            for (int x = 0; x < this.toolbarMenuComboBox.Items.Count; x++)
            {
                san = (StripAndName)this.toolbarMenuComboBox.Items[x];

                if (san.Strip == in_strip)
                {
                    this.toolbarMenuComboBox.SelectedIndex = x;
                    return;
                }
            }

            //
            // wait a minute!  how come it's not there any more??
            //
            System.Diagnostics.Debug.Fail("Asked to select an item that " +
                                          "doesn't exist!");
        }


        //=------------------------------------------------------------------=
        // toolbarMenuComboBox_SelectedIndexChanged
        //=------------------------------------------------------------------=
        /// <summary>
        ///   The user has selected a new Toolbar or Menu to customize in the
        ///   "Toolbar / Menu" combo box.  We will go and get the new set of
        ///   available Items for this strip now.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   Source of the event.
        /// </param>
        /// 
        /// <param name="e">
        ///   Details about the event (in this case -- none)
        /// </param>
        /// 
        private void toolbarMenuComboBox_SelectedIndexChanged
        (
            object sender,
            EventArgs e
        )
        {
            ToolStripItem[] items;
            StripAndName san;

            //
            // okay, first go and store away any changed information for the
            // last selected strip (since we're on a new one now).
            //
            storeSelectedItemsForLastStrip();

            //
            // now, get the strip newly selected.
            //
            Debug.Assert(this.toolbarMenuComboBox.SelectedItem is StripAndName);
            san = (StripAndName)this.toolbarMenuComboBox.SelectedItem;

            //
            // get the parent CustomizeToolStrip component to raise the
            // event which will have the user get the items for this strip.
            //
            items = this.parentCustomizer.GetItemsForStrip(san.Strip);

            //
            // okay, given these items, store them away in our mapping 
            // table.
            //
            storeAvailableItemsForStrip(san.Strip, items);
            this.lastSelectedStripIndex = this.toolbarMenuComboBox.SelectedIndex;

            //
            // finally, set the items in the list box of available items
            // as well as the list of currently used items.
            //
            populateAvailableItemsForStrip(san.Strip, items);
            populateCurrentItemsForStrip(san.Strip);
            updateButtons();
        }


        //=------------------------------------------------------------------=
        // populateAvailableItemsForStrip
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Given a list of items that are "available" to be used for a
        ///   given ToolStrip (or MenuStrip), go and populate the 
        ///   availableItemsListBox with these items, removing those that
        ///   are already in the strip.
        /// </summary>
        /// 
        /// <param name="in_strip">
        ///   The ToolStrip for which we have a list of available items.
        /// </param>
        /// 
        /// <param name="in_items">
        ///   The list of available items (or derived objects, of course).
        /// </param>
        /// 
        /// <remarks>
        ///   There are two minor limitations in this code:  
        /// 
        ///   1. For those cases where there is a ToolStrip Label that is
        ///      clearly never intended to be on its own, such as one
        ///      labelled "Search" next to a drop-down ComboBox, we have
        ///      no way to group those right now.
        /// 
        ///   2. Since ToolStripItems are parented strongly (each has an
        ///      Owner property), we make sure that any button we have is
        ///      not owned by another ToolStrip.  This wouldn't be a 100%
        ///      accurate search (in those cases where we were given items
        ///      from ToolStrips about which we did not know), but it's
        ///      good for the 90% case.
        /// </remarks>
        /// 
        private void populateAvailableItemsForStrip
        (
            ToolStrip in_strip,
            ToolStripItem[] in_items
        )
        {
            ItemAndName ian;

            this.availableItemsListBox.Items.Clear();

            // 
            // firstly, add the separator item.
            //
            ian = new ItemAndName();
            ian.Name = SEPARATOR_NAME;
            ian.Item = null;
            this.availableItemsListBox.Items.Add(ian);

            //
            // loop through the list of "available" items, adding those 
            // which are not already in the list of items on the strip.
            //
            for (int x = 0; x < in_items.Length; x++)
            {
                //
                // add non separator items (we handle seps ourselves)
                //
                if (!(in_items[x] is ToolStripSeparator))
                {
                    if (!stripContainsItem(in_strip, in_items[x])
                        && !anyStripsContainItem(in_items[x]))
                    {
                        ian = new ItemAndName();
                        ian.Name = in_items[x].Text;
                        ian.Item = in_items[x];

                        this.availableItemsListBox.Items.Add(ian);
                    }
                }
            }
        }


        //=------------------------------------------------------------------=
        // populateCurrentItemsForStrip
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Given a ToolStrip, go and populate the currentItemsListBOx
        ///   list with all the buttons in it.
        /// </summary>
        /// 
        /// <param name="in_strip">
        ///   The ToolStrip to process.
        /// </param>
        /// 
        private void populateCurrentItemsForStrip(ToolStrip in_strip)
        {
            ToolStripItem[] items;
            ItemAndName ian;

            this.currentItemsListBox.Items.Clear();

            items = fetchSelectedItemsForStrip(in_strip);

            // 
            // for each item, go and add it to the list of currently
            // included items.
            //
            for (int x = 0; x < items.Length; x++)
            {
                ian = new ItemAndName();

                //
                // replace any separators with our own special separator
                // item.
                //
                if (items[x] is ToolStripSeparator)
                {
                    ian.Name = SEPARATOR_NAME;
                    ian.Item = null;
                }
                else
                {
                    ian.Name = items[x].Text;
                    ian.Item = items[x];
                }

                this.currentItemsListBox.Items.Add(ian);
            }

            //
            // Finally, add the special Anchor Spearator Item that cannot
            // be removed.
            //
            ian = new ItemAndName();
            ian.Name = ANCHOR_SEPARATOR;
            ian.Item = null;
            this.currentItemsListBox.Items.Add(ian);
        }


        //=------------------------------------------------------------------=
        // drawItemForListBox
        //=------------------------------------------------------------------=
        /// <summary>
        ///   We've been asked to paint an item in one of the list boxes, and
        ///   the code is so similar, we've factored it out into one routine.
        /// </summary>
        /// 
        /// <param name="in_listBox">
        ///   ListBox asking for painting.
        /// </param>
        /// 
        /// <param name="in_diea">
        ///   DrawItemEventArgs with the details.
        /// </param>
        /// 
        private void drawItemForListBox
        (
            ListBox in_listBox,
            DrawItemEventArgs in_diea
        )
        {
            SolidBrush b = null;
            ItemAndName ian;
            bool selected;

            //
            // draw the the background for the dude.  This does the right
            // thing for selection as well, which is nice.
            //
            Debug.Assert(in_listBox != null && in_diea != null);
            in_diea.DrawBackground();

            Debug.Assert(in_listBox.Items[in_diea.Index] is ItemAndName);
            ian = (ItemAndName)in_listBox.Items[in_diea.Index];

            //
            // if the item is a special separator item, then don't draw the
            // image for it.  Otherwise, draw the image now, if there is one.
            //
            if (!ian.Name.Equals(SEPARATOR_NAME)
                && !ian.Name.Equals(ANCHOR_SEPARATOR))
            {
                in_diea.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                //
                // we first have to figure out from where the image is to
                // come...
                //
                if (ian.Item.Image != null)
                {
                    in_diea.Graphics.DrawImage(ian.Item.Image,
                                               new Point(in_diea.Bounds.Left + 1,
                                                         in_diea.Bounds.Top + 1));
                }
                else if (ian.Item.ImageIndex >= 0)
                {
                    ian.Item.Owner.ImageList.Draw(in_diea.Graphics,
                                                  new Point(in_diea.Bounds.Left + 1,
                                                           in_diea.Bounds.Top + 1),
                                                  ian.Item.ImageIndex);
                }
            }

            //
            // finally, draw the text
            //
            try
            {
                selected = (in_diea.State & DrawItemState.Selected) != 0;

                //
                // figure out what color brush we need.
                //
                if (selected)
                {
                    b = new SolidBrush(this.availableItemsListBox.BackColor);
                }
                else if (ian.Name.Equals(ANCHOR_SEPARATOR))
                {
                    b = new SolidBrush(SystemColors.ControlDark);
                }
                else
                {
                    b = new SolidBrush(SystemColors.ControlText);
                }

                in_diea.Graphics.DrawString(ian.ToString(), this.Font,
                                            b, 18, in_diea.Bounds.Top + 2);

                //
                // don't forget to draw the focus rectangle if we're selected
                // 
                if (selected)
                {
                    in_diea.DrawFocusRectangle();
                }
            }
            finally
            {
                // 
                // clean up!
                //
                if (b != null)
                {
                    b.Dispose();
                }
            }
        }


        //=------------------------------------------------------------------=
        // availableItemsListBox_DrawItem
        //=------------------------------------------------------------------=
        /// <summary>
        ///   We've been asked to paint an item in the availableItemsListBox
        ///   control.  Do so now.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   ListBox that wants to be painted.
        /// </param>
        /// 
        /// <param name="e">
        ///   Details (in this case, none)
        /// </param>
        /// 
        private void availableItemsListBox_DrawItem
        (
            object sender,
            DrawItemEventArgs e
        )
        {
            drawItemForListBox(this.availableItemsListBox, e);
        }


        //=------------------------------------------------------------------=
        // currentItemsListBox_DrawItem
        //=------------------------------------------------------------------=
        /// <summary>
        ///   We've been asked to paint an item in the currentItemsListBox
        ///   control.  Do so now.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   ListBox that wants to be painted.
        /// </param>
        /// 
        /// <param name="e">
        ///   Details (in this case, none)
        /// </param>
        /// 
        private void currentItemsListBox_DrawItem
        (
            object sender,
            DrawItemEventArgs e
        )
        {
            drawItemForListBox(this.currentItemsListBox, e);
        }


        //=------------------------------------------------------------------=
        // addButton_Click
        //=------------------------------------------------------------------=
        /// <summary>
        ///   The user has clicked on the "Add >>" button, to move the 
        ///   currently selected button from the available list box to the
        ///   currently used list box.  This code attempts to execute that
        ///   move.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   From whence cometh the event (Add button).
        /// </param>
        /// 
        /// <param name="e">
        ///   Information about the event (in this case, none).
        /// </param>
        /// 
        private void addButton_Click(object sender, EventArgs e)
        {
            int insertAt, insertFrom;
            ItemAndName ian;

            //
            // get the selected index, making sure it's valid.
            //
            insertFrom = this.availableItemsListBox.SelectedIndex;
            if (insertFrom == -1)
            {
                return;
            }

            //
            // add the item to the currentItemsListBox before the currently
            // selection.  If it's a separator, we'll create a new instance
            // of it.
            //
            ian = (ItemAndName)this.availableItemsListBox.Items[insertFrom];
            if (ian.Item == null)
            {
                ian = new ItemAndName();
                ian.Name = SEPARATOR_NAME;
                ian.Item = null;
            }

            insertAt = this.currentItemsListBox.SelectedIndex;
            if (insertAt == -1)
            {
                insertAt = this.currentItemsListBox.Items.Count - 1;
            }
            this.currentItemsListBox.Items.Insert(insertAt, ian);

            //
            // remove it from the available list, provided it's not the
            // separator
            //
            if (ian.Item != null)
            {
                this.availableItemsListBox.Items.Remove(ian);

                //
                // make sure some item is still selected.
                //
                if (insertFrom < this.availableItemsListBox.Items.Count)
                {
                    this.availableItemsListBox.SelectedIndex = insertFrom;
                }
                else
                {
                    this.availableItemsListBox.SelectedIndex = insertFrom - 1;
                }
            }

            //
            // enable and disable the appropriate buttons.
            //
            updateButtons();
        }


        //=------------------------------------------------------------------=
        // removeButton_Click
        //=------------------------------------------------------------------=
        /// <summary>
        ///   The user has clicked on the "Remove >>" button, to move the 
        ///   currently selected button from the currently usedlist box to the
        ///   available list box.  This code attempts to execute that
        ///   move.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   From whence cometh the event (Add button).
        /// </param>
        /// 
        /// <param name="e">
        ///   Information about the event (in this case, none).
        /// </param>
        /// 
        private void removeButton_Click(object sender, EventArgs e)
        {
            int insertFrom, insertTo;
            ItemAndName ian;
            ToolStrip ts;

            //
            // find out from where we're removing and make sure it's a valid
            // item to remove.
            //
            insertFrom = this.currentItemsListBox.SelectedIndex;
            if (insertFrom == -1
                || insertFrom == this.currentItemsListBox.Items.Count - 1)
            {
                return;
            }

            //
            // add the item back to the available list box, provided it's not a
            // separator
            //
            ian = (ItemAndName)this.currentItemsListBox.Items[insertFrom];
            if (ian.Item != null)
            {
                //
                // it's not a separator -- figure out where to re-insert this
                // into the array of available items (we will attempt to 
                // preserve the order when we move things around so as not to
                // mess this up terribly.)
                //
                ts = ((StripAndName)this.toolbarMenuComboBox.SelectedItem).Strip;
                insertTo = determineReinsertIndex(ts,
                                                  this.availableItemsListBox,
                                                  ian.Item);
                if (insertTo != -1)
                {
                    this.availableItemsListBox.Items.Insert(insertTo, ian);
                }
            }

            //
            // remove that puppy!
            //
            this.currentItemsListBox.Items.Remove(ian);

            //
            // make sure there's still an item selected.
            //
            if (insertFrom < this.currentItemsListBox.Items.Count - 1)
            {
                this.currentItemsListBox.SelectedIndex = insertFrom;
            }
            else
            {
                this.currentItemsListBox.SelectedIndex = insertFrom - 1;
            }

            //
            // finally, udpate da butttons.
            //
            updateButtons();
        }


        //=------------------------------------------------------------------=
        // resetButton_Click
        //=------------------------------------------------------------------=
        /// <summary>
        ///   This isn't too complicated -- when the user presses this button,
        ///   we want to restore the buttons to their 'original' state, which
        ///   just so happens to be recorded in their Items collections, since
        ///   we don't actually apply the changes in this dialog class.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   Reset Button
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty
        /// </param>
        /// 
        private void resetButton_Click(object sender, EventArgs e)
        {
            ToolStripItemMap tsim;
            StripAndName san;
            object o;

            //
            // all we have to do is clear out the collections of items for
            // the various strips we have handy.
            //
            for (int x = 0; x < this.toolbarMenuComboBox.Items.Count; x++)
            {
                san = (StripAndName)this.toolbarMenuComboBox.Items[x];
                o = this.toolStripToItemsMapping[san.Strip];
                if (o != null)
                {
                    //
                    // clear these out and re-set them in the map.
                    //
					tsim = (ToolStripItemMap)o;
					// commenting this out to avoid setting the base items to null - there likely are base items.
					//tsim.baseAvailableItems = null;
                    tsim.userSelectedItems = null;
					this.toolStripToItemsMapping[san.Strip] = tsim;
                }
            }
        }


        //=------------------------------------------------------------------=
        // moveUpButton_Click
        //=------------------------------------------------------------------=
        /// <summary>
        ///   The user has clicked on the "Move Up" button.  Moves up the
        ///   selected item in the currently selected list box, provided there
        ///   are items to select.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   The "Move Up" Button
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty
        /// </param>
        /// 
        private void moveUpButton_Click(object sender, EventArgs e)
        {
            int indexFrom;
            object o;

            //
            // get the currently selected index and item.  if there is no
            // selection, or it's the first item in the list (or the very
            // special Anchor Separator), then we do nothing.
            //
            indexFrom = this.currentItemsListBox.SelectedIndex;
            if (indexFrom == -1 
                || indexFrom == 0 
                || indexFrom == this.currentItemsListBox.Items.Count - 1)
            {
                return;
            }

            o = this.currentItemsListBox.SelectedItem;

            //
            // remove this item and insert it one item earlier.
            //
            this.currentItemsListBox.Items.RemoveAt(indexFrom);
            this.currentItemsListBox.Items.Insert(indexFrom - 1, o);

            //
            // make sure it's selected, update our buttons, and go to bed.
            //
            this.currentItemsListBox.SelectedIndex = indexFrom - 1;
            updateButtons();
        }


        //=------------------------------------------------------------------=
        // moveDownButton_Click
        //=------------------------------------------------------------------=
        /// <summary>
        ///   The user has clicked on the "Move Down" button.  Moves down the
        ///   selected item in the currently selected list box, provided there
        ///   are items to select.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   The "Move Down" Button
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty
        /// </param>
        /// 
        private void moveDownButton_Click(object sender, EventArgs e)
        {
            int indexFrom;
            object o;

            //
            // get the currently selected index and item.  if there is no 
            // selection or it's the last item in the list, then go away.
            //
            indexFrom = this.currentItemsListBox.SelectedIndex;
            if (indexFrom == -1
                || indexFrom == this.currentItemsListBox.Items.Count - 2
                || indexFrom == this.currentItemsListBox.Items.Count - 1)
            {
                return;
            }
            o = this.currentItemsListBox.SelectedItem;

            //
            // remove this item and insert it one later.
            //
            //this.currentItemsListBox.Items.RemoveAt(indexFrom);
            this.currentItemsListBox.Items.Remove(o);
            this.currentItemsListBox.Items.Insert(indexFrom + 1, o);

            //
            // make sure it's still selected, update the buttons, and go home
            //
            this.currentItemsListBox.SelectedIndex = indexFrom + 1;
            updateButtons();
        }


        //=------------------------------------------------------------------=
        // updateButtons
        //=------------------------------------------------------------------=
        /// <summary>
        ///   This routine makes sure that the appropriate buttons are enabled
        ///   and disabled at the appropraite times.
        /// </summary>
        /// 
        private void updateButtons()
        {
            //
            // the add and remove buttons.
            //
            this.addButton.Enabled = this.availableItemsListBox.SelectedIndex != -1;
            this.removeButton.Enabled = this.currentItemsListBox.Items.Count > 0;

            //
            // move "up" button.
            //
            if (this.currentItemsListBox.Items.Count > 1
                && this.currentItemsListBox.SelectedIndex > 0
                && (this.currentItemsListBox.SelectedIndex
                       != this.currentItemsListBox.Items.Count - 1))
            {
                this.moveUpButton.Enabled = true;
            }
            else
            {
                this.moveUpButton.Enabled = false;
            }

            //
            // move "down" button
            //
            if (this.currentItemsListBox.Items.Count > 0
                && this.currentItemsListBox.SelectedIndex >= 0
                && (this.currentItemsListBox.SelectedIndex
                       < this.currentItemsListBox.Items.Count - 2))
            {
                this.moveDownButton.Enabled = true;
            }
            else
            {
                this.moveDownButton.Enabled = false;
            }

            //
            // "Remove" button
            //
            if (this.currentItemsListBox.Items.Count > 0
                && this.currentItemsListBox.SelectedIndex >= 0
                && (this.currentItemsListBox.SelectedIndex
                       != this.currentItemsListBox.Items.Count - 1))
            {
                this.removeButton.Enabled = true;
            }
            else
            {
                this.removeButton.Enabled = false;
            }
        }


        //=------------------------------------------------------------------=
        // storeAvailableItemsForStrip
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Goes and sets up the list of available buttons in our table
        ///   that maps strips and available and selected buttons.  If this
        ///   strip isn't in the table yet, this routine goes and creates an
        ///   entry for it.
        /// </summary>
        /// 
        /// <param name="in_strip">
        ///   ToolStrip whose settings are being remembered.
        /// </param>
        /// 
        /// <param name="in_items">
        ///   Items to remember as available for this strip.
        /// </param>
        /// 
        private void storeAvailableItemsForStrip
        (
            ToolStrip in_strip,
            ToolStripItem[] in_items
        )
        {
            ToolStripItemMap tsim;

            if (this.toolStripToItemsMapping.ContainsKey(in_strip))
            {
                tsim = (ToolStripItemMap)this.toolStripToItemsMapping[in_strip];
                tsim.baseAvailableItems = in_items;
                this.toolStripToItemsMapping[in_strip] = tsim;
            }
            else
            {
                tsim = new ToolStripItemMap();
                tsim.baseAvailableItems = in_items;
                tsim.userSelectedItems = null;
                this.toolStripToItemsMapping.Add(in_strip, tsim);
            }
        }


        //=------------------------------------------------------------------=
        // storeSelectedItemsForStrip
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Something has caused us to either switch the currently viewed
        ///   strip or shut the dialog down.  Save out the current state of
        ///   selected items for the last ToolStrip with which we were
        ///   working.
        /// </summary>
        /// 
        private void storeSelectedItemsForLastStrip()
        {
            ToolStripItemMap tsim;
            StripAndName san;

            if (this.lastSelectedStripIndex != -1)
            {
                san = (StripAndName)this.toolbarMenuComboBox.Items[this.lastSelectedStripIndex];
                if (this.toolStripToItemsMapping.ContainsKey(san.Strip))
                {
                    tsim = (ToolStripItemMap)this.toolStripToItemsMapping[san.Strip];
                    tsim.userSelectedItems = getCurrentSelectedItems();
                    this.toolStripToItemsMapping[san.Strip] = tsim;
                }
                else
                {
                    Debug.Fail("This should have been inserted into the table by now!");
                }
            }
        }


        //=------------------------------------------------------------------=
        // fetchSelectedItemsForStrip
        //=------------------------------------------------------------------=
        /// <summary>
        ///   If the user has already fiddled with this ToolStrip a bit, then
        ///   this routine returns the list of buttons they have selected for
        ///   it from the Hashtable in which we store such info.
        ///   If not, then it just returns the buttons that already exist
        ///   for it. 
        /// </summary>
        /// 
        /// <param name="in_strip">
        ///   Toolstrip whose selected items we want to obtain.
        /// </param>
        /// 
        /// <returns>
        ///   An array of ToolStripItems which the user has selected for this
        ///   strip, or just the existing set on the ToolStrip itself if the
        ///   user hasn't touched this strip yet.
        /// </returns>
        /// 
        private ToolStripItem[] fetchSelectedItemsForStrip(ToolStrip in_strip)
        {
            ToolStripItem [] items;
            ToolStripItemMap tsim;

            if (this.toolStripToItemsMapping.ContainsKey(in_strip))
            {
                tsim = (ToolStripItemMap)this.toolStripToItemsMapping[in_strip];
                if (tsim.userSelectedItems != null)
                {
                    return tsim.userSelectedItems;
                }
            }

            //
            // if we're here, that means the user hasn't fiddled with this
            // strip yet.
            //
            items = new ToolStripItem[in_strip.Items.Count];
            in_strip.Items.CopyTo(items, 0);
            return items;
        }


        //=------------------------------------------------------------------=
        // fetchAvailableItemsForStrip
        //=------------------------------------------------------------------=
        /// <summary>
        ///   This routine returns the array of available items for this
        ///   ToolStrip.
        /// </summary>
        /// 
        /// <param name="in_strip">
        ///   Toolstrip whose available items we want to obtain.
        /// </param>
        /// 
        /// <returns>
        ///   An array of ToolStripItems which the user has available for this
        ///   strip.
        /// </returns>
        /// 
        private ToolStripItem[] fetchAvailableItemsForStrip(ToolStrip in_strip)
        {
            ToolStripItemMap tsim;

            if (this.toolStripToItemsMapping.ContainsKey(in_strip))
            {
                tsim = (ToolStripItemMap)this.toolStripToItemsMapping[in_strip];
                return tsim.baseAvailableItems;
            }
            else
            {
                throw new ArgumentException("LOCALISE ME: bogus strip");
            }
        }


        //=------------------------------------------------------------------=
        // getCurrentSelectedItems
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Returns a list of all items that are selected to be in the
        ///   currently selected ToolStrip control.  Does not include the
        ///   placeholding/final terminating [Separator] item, but does 
        ///   include other separators the user has added.
        /// </summary>
        /// 
        /// <returns>
        ///   An array of ToolStripItems representing the way the user
        ///   has configured the ToolStrip.
        /// </returns>
        /// 
        private ToolStripItem[] getCurrentSelectedItems()
        {
            ArrayList al = new ArrayList();
            ItemAndName ian;

            for (int x = 0; x < this.currentItemsListBox.Items.Count - 1; x++)
            {
                ian = (ItemAndName)this.currentItemsListBox.Items[x];
                if (ian.Name.Equals(SEPARATOR_NAME))
                {
                    al.Add(new ToolStripSeparator());
                }
                else
                {
                    al.Add(ian.Item);
                }
                Debug.Assert(!ian.Name.Equals(ANCHOR_SEPARATOR));
            }

            return (ToolStripItem[])al.ToArray(typeof(ToolStripItem));
        }



        //=------------------------------------------------------------------=
        // determineReinsertIndex
        //=------------------------------------------------------------------=
        /// <summary>
        ///   We have been asked to remove an item from the currently selected
        ///   list box and put it back in the available list box.  We can 
        ///   put it back in the "right place" by looking at the original list
        ///   of available items we were given and finding its location in 
        ///   that list.
        /// </summary>
        /// 
        /// <param name="in_strip">
        ///   The ToolStrip in which this item is currently slated to live.
        /// </param>
        /// 
        /// <param name="in_currentAvailable">
        ///   The current list of available items in the
        ///   availableItemsListBox.
        /// </param>
        /// 
        /// <param name="in_item">
        ///   The ToolStripItem we want to put back in the available list.
        /// </param>
        /// 
        /// <returns>
        ///   An integer index into the available list box where this item 
        ///   should be reinserted.
        /// </returns>
        /// 
        private int determineReinsertIndex
        (
            ToolStrip in_strip,
            ListBox in_currentAvailable,
            ToolStripItem in_item
        )
        {
            ToolStripItem[] availableItems;
            int idx;
            int x;

            //
            // okay, we have to get the list of original available items for
            // this strip.
            //
            availableItems = fetchAvailableItemsForStrip(in_strip);

            //
            // find the index of this item in the original array.
            //
            for (x = 0; x < availableItems.Length - 1; x++)
            {
                if (availableItems[x] == in_item)
                {
                    break;
                }
            }
            
            //
            // if it isn't there, that's killer bad.
            //
            if (x == availableItems.Length)
            {
                Debug.Fail("Unable to determine re-insertion index.  Item shoudl be here!");
                return -1;
            }

            //
            // okay, we're only half way done:  now we need to see which
            // items before this one are actually in the ListBox ...
            //
            for (int y = x - 1; y >= 0; y--)
            {
                idx = getIndexOfToolStripItem(availableItems[x], 
                                              in_currentAvailable);
                if (idx != -1)
                {
                    //
                    // + 1 because we want to insert AFTER this item.
                    //
                    return idx + 1;
                }
            }

            //
            // if we're here then none of the items that are supposed to 
            // come before are in the available list any longer.  we're the
            // first (after the [Separator] item ...)
            //
            return 1;
        }


        //=------------------------------------------------------------------=
        // getIndexOfToolStripItem
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Given a ToolStripItem and a ListBox containing creatures of
        ///   this sort, get the index of this item in the list or -1 if
        ///   it's not in the list.
        /// </summary>
        /// 
        /// <param name="in_item">
        ///   ToolStripItem for which to seek.
        /// </param>
        /// 
        /// <param name="in_listBox">
        ///   ListBox in which to seek.
        /// </param>
        /// 
        /// <returns>
        ///   The integer index within the ListBox's items of this item, or
        ///   -1 if it wasn't found.
        /// </returns>
        /// 
        private int getIndexOfToolStripItem
        (
            ToolStripItem in_item,
            ListBox in_listBox
        )
        {
            ItemAndName ian;

            for (int x = 0; x < in_listBox.Items.Count; x++)
            {
                ian = (ItemAndName)in_listBox.Items[x];
                if (ian.Item != null && ian.Item == in_item)
                {
                    return x;
                }
            }

            return -1;
        }


        //=------------------------------------------------------------------=
        // availableItemsListBox_SelectedIndexChanged
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Whenever the user selects a new item, we need to update all
        ///   the buttons on the form.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   From whence comes the event.
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty.
        /// </param>
        /// 
        private void availableItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButtons();
        }


        //=------------------------------------------------------------------=
        // currentItemsListBox_SelectedIndexChanged
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Whenever the user selects a new item, we need to update all
        ///   the buttons on the form.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   From whence comes the event.
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty.
        /// </param>
        /// 
        private void currentItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButtons();
        }


        //=------------------------------------------------------------------=
        // CustomizeToolStripForm_Load
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Called when the form is fully loaded and ready to show.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   The form.
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty
        /// </param>
        /// 
        private void CustomizeToolStripForm_Load(object sender, EventArgs e)
        {
            selectToolStripInCombo(this.initialStripToSelect);
            updateButtons();
        }


        //=------------------------------------------------------------------=
        // stripContainsItem
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Figures out if the "current version" of the given ToolStrip
        ///   contains the given item or not.  The current version is what
        ///   the ToolStrip would look like if the user committed the current
        ///   changes to the strip.
        /// </summary>
        /// 
        /// <param name="in_strip">
        ///   The strip we want to search.
        /// </param>
        /// 
        /// <param name="in_item">
        ///   The item which we seek.
        /// </param>
        /// 
        /// <returns>
        ///   A boolean value indicating whether or not the current version
        ///   of the ToolStrip contains the given button.
        /// </returns>
        /// 
        private bool stripContainsItem(ToolStrip in_strip, ToolStripItem in_item)
        {
            ToolStripItem[] items = fetchSelectedItemsForStrip(in_strip);

            for (int x = 0; x < items.Length; x++)
            {
                if (items[x] == in_item)
                {
                    return true;
                }
            }

            return false;
        }


        //=------------------------------------------------------------------=
        // anyStripsContainItem
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Searches through all the strips with which we are working, and,
        ///   looking at their current state, determines if any of them is
        ///   already hosting this button.
        /// </summary>
        /// 
        /// <param name="in_item">
        ///   The ToolStripItem which we seek in any of the ToolStrips about
        ///   which we know.
        /// </param>
        /// 
        /// <returns>
        ///   A boolean indicating whether any ToolStrip with which we are
        ///   working contains this button in its "current version" according
        ///   to the dialog.
        /// </returns>
        /// 
        public bool anyStripsContainItem(ToolStripItem in_item)
        {
            StripAndName san;

            //
            // zip through all the strips we know about and see if they
            // contain this item.
            //
            for (int x = 0; x < this.toolbarMenuComboBox.Items.Count; x++)
            {
                san = (StripAndName)this.toolbarMenuComboBox.Items[x];
                if (stripContainsItem(san.Strip, in_item))
                {
                    return true;
                }
            }

            return false;
        }


        //=------------------------------------------------------------------=
        // availableItemsListBox_DoubleClick
        //=------------------------------------------------------------------=
        /// <summary>
        ///   This is the same as clicking the Add Button
        /// </summary>
        /// 
        /// <param name="sender">
        ///   The availableItemsListBox
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty
        /// </param>
        /// 
        private void availableItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            addButton_Click(sender, e);
        }


        //=------------------------------------------------------------------=
        // currentItemsListBox_DoubleClick
        //=------------------------------------------------------------------=
        /// <summary>
        ///   This is the same as clicking the Remove Button
        /// </summary>
        /// 
        /// <param name="sender">
        ///   The currentItemsListBox
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty
        /// </param>
        /// 
        private void currentItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            removeButton_Click(sender, e);
        }


        //=------------------------------------------------------------------=
        // closeButton_Click
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Make sure we save out the items the user was working on when
        ///   we close the dialog.
        /// </summary>
        /// 
        /// <param name="sender">
        ///   From whence cometh the event.
        /// </param>
        /// 
        /// <param name="e">
        ///   EventArgs.Empty
        /// </param>
        /// 
        private void closeButton_Click(object sender, EventArgs e)
        {
            //
            // before we close our dialog, make sure we take a snapshot
            // of the currently selected strip's view.
            //
            storeSelectedItemsForLastStrip();
        }

    }

}


