namespace AutomaticObjectBinding
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.Label descriptionLabel;
			System.Windows.Forms.Label modelNameLabel;
			System.Windows.Forms.Label modelNumberLabel;
			System.Windows.Forms.Label unitCostLabel;
			this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.descriptionLabel1 = new System.Windows.Forms.Label();
			this.modelNameComboBox = new System.Windows.Forms.ComboBox();
			this.modelNumberTextBox = new System.Windows.Forms.TextBox();
			this.unitCostTextBox = new System.Windows.Forms.TextBox();
			descriptionLabel = new System.Windows.Forms.Label();
			modelNameLabel = new System.Windows.Forms.Label();
			modelNumberLabel = new System.Windows.Forms.Label();
			unitCostLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingNavigator)).BeginInit();
			this.productListBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// productListBindingSource
			// 
			this.productListBindingSource.DataSource = typeof(AutomaticObjectBinding.ProductList);
			// 
			// productListBindingNavigator
			// 
			this.productListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.productListBindingNavigator.BindingSource = this.productListBindingSource;
			this.productListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.productListBindingNavigator.CountItemFormat = "of {0}";
			this.productListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.productListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem});
			this.productListBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.productListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.productListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.productListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.productListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.productListBindingNavigator.Name = "productListBindingNavigator";
			this.productListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.productListBindingNavigator.Size = new System.Drawing.Size(292, 25);
			this.productListBindingNavigator.TabIndex = 0;
			this.productListBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorSaveItem
			// 
			this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorSaveItem.Enabled = false;
			this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
			this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
			this.bindingNavigatorSaveItem.Text = "Save Data";
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Location = new System.Drawing.Point(30, 49);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new System.Drawing.Size(59, 13);
			descriptionLabel.TabIndex = 1;
			descriptionLabel.Text = "Description:";
			// 
			// descriptionLabel1
			// 
			this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "Description", true));
			this.descriptionLabel1.Location = new System.Drawing.Point(112, 49);
			this.descriptionLabel1.Name = "descriptionLabel1";
			this.descriptionLabel1.Size = new System.Drawing.Size(121, 23);
			this.descriptionLabel1.TabIndex = 2;
			// 
			// modelNameLabel
			// 
			modelNameLabel.AutoSize = true;
			modelNameLabel.Location = new System.Drawing.Point(30, 76);
			modelNameLabel.Name = "modelNameLabel";
			modelNameLabel.Size = new System.Drawing.Size(66, 13);
			modelNameLabel.TabIndex = 3;
			modelNameLabel.Text = "Model Name:";
			// 
			// modelNameComboBox
			// 
			this.modelNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "ModelName", true));
			this.modelNameComboBox.FormattingEnabled = true;
			this.modelNameComboBox.Location = new System.Drawing.Point(112, 76);
			this.modelNameComboBox.Name = "modelNameComboBox";
			this.modelNameComboBox.Size = new System.Drawing.Size(121, 21);
			this.modelNameComboBox.TabIndex = 4;
			// 
			// modelNumberLabel
			// 
			modelNumberLabel.AutoSize = true;
			modelNumberLabel.Location = new System.Drawing.Point(30, 107);
			modelNumberLabel.Name = "modelNumberLabel";
			modelNumberLabel.Size = new System.Drawing.Size(75, 13);
			modelNumberLabel.TabIndex = 5;
			modelNumberLabel.Text = "Model Number:";
			// 
			// modelNumberTextBox
			// 
			this.modelNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "ModelNumber", true));
			this.modelNumberTextBox.Location = new System.Drawing.Point(112, 104);
			this.modelNumberTextBox.Name = "modelNumberTextBox";
			this.modelNumberTextBox.Size = new System.Drawing.Size(121, 20);
			this.modelNumberTextBox.TabIndex = 6;
			// 
			// unitCostLabel
			// 
			unitCostLabel.AutoSize = true;
			unitCostLabel.Location = new System.Drawing.Point(30, 134);
			unitCostLabel.Name = "unitCostLabel";
			unitCostLabel.Size = new System.Drawing.Size(49, 13);
			unitCostLabel.TabIndex = 7;
			unitCostLabel.Text = "Unit Cost:";
			// 
			// unitCostTextBox
			// 
			this.unitCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "UnitCost", true));
			this.unitCostTextBox.Location = new System.Drawing.Point(112, 131);
			this.unitCostTextBox.Name = "unitCostTextBox";
			this.unitCostTextBox.Size = new System.Drawing.Size(121, 20);
			this.unitCostTextBox.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(descriptionLabel);
			this.Controls.Add(this.descriptionLabel1);
			this.Controls.Add(modelNameLabel);
			this.Controls.Add(this.modelNameComboBox);
			this.Controls.Add(modelNumberLabel);
			this.Controls.Add(this.modelNumberTextBox);
			this.Controls.Add(unitCostLabel);
			this.Controls.Add(this.unitCostTextBox);
			this.Controls.Add(this.productListBindingNavigator);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingNavigator)).EndInit();
			this.productListBindingNavigator.ResumeLayout(false);
			this.productListBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource productListBindingSource;
		private System.Windows.Forms.BindingNavigator productListBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
		private System.Windows.Forms.Label descriptionLabel1;
		private System.Windows.Forms.ComboBox modelNameComboBox;
		private System.Windows.Forms.TextBox modelNumberTextBox;
		private System.Windows.Forms.TextBox unitCostTextBox;


	}
}

