namespace Microsoft.Samples.BoosterSamples.CustomizeToolStrip
{
    partial class CustomizeToolStripForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.availableItemsLabel = new System.Windows.Forms.Label();
            this.availableItemsListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.toolbarMenuLabel = new System.Windows.Forms.Label();
            this.toolbarMenuComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.currentItemsLabel = new System.Windows.Forms.Label();
            this.currentItemsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
// 
// availableItemsLabel
// 
            this.availableItemsLabel.AutoSize = true;
            this.availableItemsLabel.Location = new System.Drawing.Point(8, 11);
            this.availableItemsLabel.Name = "availableItemsLabel";
            this.availableItemsLabel.Size = new System.Drawing.Size(133, 14);
            this.availableItemsLabel.TabIndex = 0;
            this.availableItemsLabel.Text = "&Available ToolStrip Items:";
// 
// availableItemsListBox
// 
            this.availableItemsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.availableItemsListBox.FormattingEnabled = true;
            this.availableItemsListBox.IntegralHeight = false;
            this.availableItemsListBox.Location = new System.Drawing.Point(8, 29);
            this.availableItemsListBox.Name = "availableItemsListBox";
            this.availableItemsListBox.Size = new System.Drawing.Size(174, 210);
            this.availableItemsListBox.TabIndex = 1;
            this.availableItemsListBox.SelectedIndexChanged += new System.EventHandler(this.availableItemsListBox_SelectedIndexChanged);
            this.availableItemsListBox.DoubleClick += new System.EventHandler(this.availableItemsListBox_DoubleClick);
            this.availableItemsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.availableItemsListBox_DrawItem);
// 
// closeButton
// 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.Location = new System.Drawing.Point(472, 42);
            this.closeButton.Name = "closeButton";
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "&Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
// 
// cancelButton
// 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(472, 72);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Ca&ncel";
// 
// resetButton
// 
            this.resetButton.Location = new System.Drawing.Point(472, 102);
            this.resetButton.Name = "resetButton";
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "R&eset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
// 
// moveUpButton
// 
            this.moveUpButton.Location = new System.Drawing.Point(473, 171);
            this.moveUpButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.TabIndex = 14;
            this.moveUpButton.Text = "Move &Up";
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
// 
// moveDownButton
// 
            this.moveDownButton.Location = new System.Drawing.Point(473, 199);
            this.moveDownButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.TabIndex = 15;
            this.moveDownButton.Text = "Move &Down";
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
// 
// toolbarMenuLabel
// 
            this.toolbarMenuLabel.AutoSize = true;
            this.toolbarMenuLabel.Location = new System.Drawing.Point(191, 11);
            this.toolbarMenuLabel.Name = "toolbarMenuLabel";
            this.toolbarMenuLabel.Size = new System.Drawing.Size(83, 14);
            this.toolbarMenuLabel.TabIndex = 2;
            this.toolbarMenuLabel.Text = "&Toolbar / Menu:";
// 
// toolbarMenuComboBox
// 
            this.toolbarMenuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolbarMenuComboBox.FormattingEnabled = true;
            this.toolbarMenuComboBox.Location = new System.Drawing.Point(272, 8);
            this.toolbarMenuComboBox.Name = "toolbarMenuComboBox";
            this.toolbarMenuComboBox.Size = new System.Drawing.Size(275, 21);
            this.toolbarMenuComboBox.TabIndex = 3;
            this.toolbarMenuComboBox.SelectedIndexChanged += new System.EventHandler(this.toolbarMenuComboBox_SelectedIndexChanged);
// 
// addButton
// 
            this.addButton.Location = new System.Drawing.Point(190, 95);
            this.addButton.Name = "addButton";
            this.addButton.TabIndex = 4;
            this.addButton.Text = "A&dd >>";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
// 
// removeButton
// 
            this.removeButton.Location = new System.Drawing.Point(191, 125);
            this.removeButton.Name = "removeButton";
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "<< &Remove";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
// 
// currentItemsLabel
// 
            this.currentItemsLabel.AutoSize = true;
            this.currentItemsLabel.Location = new System.Drawing.Point(272, 42);
            this.currentItemsLabel.Name = "currentItemsLabel";
            this.currentItemsLabel.Size = new System.Drawing.Size(117, 14);
            this.currentItemsLabel.TabIndex = 6;
            this.currentItemsLabel.Text = "Current Toolbar &Items:";
// 
// currentItemsListBox
// 
            this.currentItemsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.currentItemsListBox.FormattingEnabled = true;
            this.currentItemsListBox.IntegralHeight = false;
            this.currentItemsListBox.Location = new System.Drawing.Point(273, 62);
            this.currentItemsListBox.Name = "currentItemsListBox";
            this.currentItemsListBox.Size = new System.Drawing.Size(188, 176);
            this.currentItemsListBox.TabIndex = 7;
            this.currentItemsListBox.SelectedIndexChanged += new System.EventHandler(this.currentItemsListBox_SelectedIndexChanged);
            this.currentItemsListBox.DoubleClick += new System.EventHandler(this.currentItemsListBox_DoubleClick);
            this.currentItemsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.currentItemsListBox_DrawItem);
// 
// CustomizeToolStripForm
// 
            this.ClientSize = new System.Drawing.Size(560, 256);
            this.Controls.Add(this.currentItemsListBox);
            this.Controls.Add(this.currentItemsLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.toolbarMenuComboBox);
            this.Controls.Add(this.toolbarMenuLabel);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.availableItemsListBox);
            this.Controls.Add(this.availableItemsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(13, 14);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizeToolStripForm";
            this.Text = "CustomizeToolStrip";
            this.Load += new System.EventHandler(this.CustomizeToolStripForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label availableItemsLabel;
        private System.Windows.Forms.ListBox availableItemsListBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Label toolbarMenuLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label currentItemsLabel;
        private System.Windows.Forms.ListBox currentItemsListBox;
        
        internal System.Windows.Forms.ComboBox toolbarMenuComboBox;
    }
}