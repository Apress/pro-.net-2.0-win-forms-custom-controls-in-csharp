using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace DynamicLayout
{
    public class SurveyDeserializer
    {
        private string fileName;
        private Panel targetContainer;
        public SurveyDeserializer(string fileName, Panel targetContainer)
        {
            this.fileName = fileName;
            this.targetContainer = targetContainer;
        }

        public void LoadForm()
        {
            // Dispose the child controls.
            foreach (Control ctrl in targetContainer.Controls)
            {
                ctrl.Dispose();
            }

            try
            {
                // Load the form into memory.
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);

                // Iterate over panel nodes.
                foreach (XmlNode nodePanel in doc.DocumentElement.ChildNodes)
                {
                    // Convert the element name into the appropriate enum value.
                    PanelTypes type =
                        (PanelTypes)Enum.Parse(typeof(PanelTypes), nodePanel.LocalName);

                    // Check for caption node.
                    string caption = CheckForAttribute(nodePanel, "caption");

                    // Create the container for this survey element.
                    // It's placed into the next available cell.
                    Control container = CreateContainer(type, caption);
                    container.SuspendLayout();

                    // Iterate over the nested nodes.        
                    foreach (XmlNode nodeItem in nodePanel.ChildNodes)
                    {
                        // Get the node information.
                        string id = CheckForAttribute(nodeItem, "id");
                        caption = CheckForAttribute(nodeItem, "caption");
                        if (caption == "") caption = id;

                        // Create the content inside the survey element.
                        CreateContent(type, nodeItem.LocalName,
                            caption, id, container);
                    }
                    container.ResumeLayout();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Failure parsing file.\n" + err.Message);
            }
        }

        private Control CreateContainer(PanelTypes type, string caption)
        {
            // Represents the top-level container
            // (a TableLayoutPanel or FlowLayoutPanel,
            // depending on the survey element).
            TableLayoutPanel pnlTable = null;
            FlowLayoutPanel pnlFlow = null;

            // Represents the control object that contains
            // the rest of the survey content.
            // Often, this is the same as the top-level
            // container, but not so with the CheckBoxList.
            // For this survey element, a FlowLayoutPanel
            // hosts the caption and CheckBoxList, but
            // the CheckBoxList is container for survey elements,
            // not the FlowLayoutPanel.
            Control container = null;

            // Represents a caption that can be inserted at
            // the top of the panel.
            Label lblCaption;

            switch (type)
            {
                case PanelTypes.TextBoxPanel:
                    pnlTable = new TableLayoutPanel();
                    pnlTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
                    pnlTable.ColumnCount = 2;

                    // When created programmatically, a TableLayoutPanel
                    // has no ColumnStyle objects.
                    // In this case, they're added to ensure the
                    // label column sizes to fits its content and
                    // the text box column fills all the remaining space
                    //pnlTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 0));
                    //pnlTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

                    // Make sure the full width of the form is used
                    // for the text box.
                    pnlTable.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                    container = pnlTable;
                    break;

                case PanelTypes.GroupSelectionPanel:
                    pnlFlow = new FlowLayoutPanel();

                    // Each radio button should take
                    // a full line.
                    pnlFlow.FlowDirection = FlowDirection.TopDown;

                    // Add a caption.
                    lblCaption = new Label();
                    lblCaption.Text = caption;
                    lblCaption.AutoSize = true;
                    pnlFlow.Controls.Add(lblCaption);

                    container = pnlFlow;
                    break;

                case PanelTypes.CheckBoxListPanel:
                    pnlTable = new TableLayoutPanel();

                    // Size the table to fill the content.
                    //pnlTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 0));
                    //pnlTable.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));
                    pnlTable.ColumnCount = 1;

                    // Add a caption.
                    lblCaption = new Label();
                    lblCaption.Text = caption;
                    lblCaption.AutoSize = true;
                    pnlTable.Controls.Add(lblCaption);

                    // Add the checkbox list.
                    CheckedListBox checks = new CheckedListBox();
                    checks.AutoSize = true;
                    pnlTable.Controls.Add(checks);

                    container = checks;
                    break;

                case PanelTypes.LargeTextBoxPanel:
                    pnlTable = new TableLayoutPanel();

                    // Size the table to fill the available area.
                    //pnlTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 100));
                    //pnlTable.RowStyles.Add(new RowStyle(SizeType.AutoSize, 100));
                    pnlTable.ColumnCount = 1;

                    //pnlTable.Width = pnlForm.Width;
                    pnlTable.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                    // Add a caption.
                    lblCaption = new Label();
                    lblCaption.Text = caption;
                    lblCaption.AutoSize = true;
                    pnlTable.Controls.Add(lblCaption);

                    container = pnlTable;
                    break;
            }

            // Add the top-level container (the
            // FlowLayoutPanel or TableLayoutPanel)
            // to the table.
            Panel pnl = null;
            if (pnlTable != null)
            {
                pnl = pnlTable;
            }
            else
            {
                pnl = pnlFlow;
            }
            pnl.AutoSize = true;
            pnl.Margin = new Padding(7);
            targetContainer.Controls.Add(pnl);

            // Return the container control, so more content can
            // be inserted inside it.
            return container;
        }

        private void CreateContent(PanelTypes type,
            string elementName, string caption, string id,
            Control container)
        {
            Control ctrl = null;
            switch (type)
            {
                case PanelTypes.TextBoxPanel:
                    if (elementName != "TextItem") throw new XmlException("Element " + elementName + " not expected");
                    ctrl = new Label();
                    ctrl.Text = caption;
                    container.Controls.Add(ctrl);

                    ctrl = new TextBox();
                    ctrl.Name = id;
                    ctrl.Dock = DockStyle.Fill;
                    container.Controls.Add(ctrl);
                    break;
                case PanelTypes.GroupSelectionPanel:
                    if (elementName != "SelectionItem") throw new XmlException("Element " + elementName + " not expected");
                    ctrl = new RadioButton();

                    ctrl.Name = id;
                    ctrl.Text = caption;
                    ctrl.Margin = new Padding(3, 0, 3, 0);
                    container.Controls.Add(ctrl);
                    break;
                case PanelTypes.CheckBoxListPanel:
                    if (elementName != "SelectionItem") throw new XmlException("Element " + elementName + " not expected");
                    ((CheckedListBox)container).Items.Add(
                        new CheckBoxListItem(caption, id));
                    break;
                case PanelTypes.LargeTextBoxPanel:
                    if (elementName != "TextItem") throw new XmlException("Element " + elementName + " not expected");
                    ctrl = new TextBox();
                    ctrl.Dock = DockStyle.Fill;
                    ((TextBox)ctrl).WordWrap = true;
                    ((TextBox)ctrl).AcceptsReturn = true;
                    ((TextBox)ctrl).Multiline = true;
                    ctrl.Height *= 3;
                    container.Controls.Add(ctrl);
                    break;
            }
        }

        private string CheckForAttribute(XmlNode node, string name)
        {
            foreach (XmlAttribute attr in node.Attributes)
            {
                if (attr.Name == name) return attr.Value;
            }
            return "";
        }

        public class CheckBoxListItem
        {
            public string Caption;
            public string ID;

            public CheckBoxListItem(string caption, string id)
            {
                Caption = caption;
                ID = id;
            }

            public override string ToString()
            {
                return Caption;
            }
        }

        enum PanelTypes
        {
            TextBoxPanel, GroupSelectionPanel,
            CheckBoxListPanel, LargeTextBoxPanel
        }
    }
}
