#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;

#endregion

namespace GradientPanelControl
{
    public class GradientPanelActionList : System.ComponentModel.Design.DesignerActionList
    {
        private GradientPanel linkedControl;

        // The constructor associates the control to the smart tag action list. 

        public GradientPanelActionList(GradientPanel ctrl) :base(ctrl)
        {
            linkedControl = ctrl;
        }


        // A helper method to retrieve control properties.
        // GetProperties ensures undo and menu updates to work properly. 

        private PropertyDescriptor GetPropertyByName(String propName)
        {

            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(linkedControl)[propName];

            if (null == prop)
            {
                throw new ArgumentException(
                "Matching property not found.", propName);
            }
            else
            {
                return prop;
            }
        }


        // Properties that are targets of DesignerActionPropertyItem 
        // entries. 

        public Color ColorA
        {
            get
            {
                return linkedControl.ColorA;
            }
            set
            {
                GetPropertyByName("ColorA").SetValue(linkedControl, value);
            }
        }

        public Color ColorB
        {
            get
            {
                return linkedControl.ColorB;
            }
            set
            {
                GetPropertyByName("ColorB").SetValue(linkedControl, value);
            }
        }

        public LinearGradientMode GradientFillStyle
        {
            get
            {
                return linkedControl.GradientFillStyle;
            }
            set
            {
                GetPropertyByName("GradientFillStyle").SetValue(linkedControl, value);
            }
        }

        // Method that is target of a DesignerActionMethodItem 

        public void ChooseRandomColors()
        {
            Random rand = new Random();

            // Set the colors through the property procedures
            // in this class.
            ColorA = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            ColorB = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            
        }



        // Implementation of this abstract method creates smart tag 
        // items, associates their targets, and collects into list. 
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            // Create 8 items.
            DesignerActionItemCollection items = new DesignerActionItemCollection();

            // Begin by creating the headers.
            items.Add(new DesignerActionHeaderItem("Appearance"));
            items.Add(new DesignerActionHeaderItem("Information"));

            // Add items that wrap the properties.
            items.Add(new DesignerActionPropertyItem("ColorA",
                "Gradient Color A", "Appearance",
                "Sets the first color in the gradient."));

            items.Add(new DesignerActionPropertyItem("ColorB",
              "Gradient Color B", "Appearance",
              "Sets the second color in the gradient."));

            items.Add(new DesignerActionPropertyItem("GradientFillStyle",
              "Gradient Fill Style", "Appearance",
              "Sets the blend direction for the gradient."));

            // Add an action link. 
            // This item is also added to the context menu 
            // as a designer verb. 
            items.Add(new DesignerActionMethodItem(this,
                "ChooseRandomColors", "Randomize colors",
                "Appearance",
                "Chooses random colors for the gradient.",
                true));

            // Create entries for static Information section. 
            items.Add(new DesignerActionTextItem(
                "Location: " + linkedControl.Location.ToString(),
              "Information"));

            items.Add(new DesignerActionTextItem(
                "Location: " + linkedControl.Size.ToString(),
              "Information"));

            return items;

        }


    }

}
