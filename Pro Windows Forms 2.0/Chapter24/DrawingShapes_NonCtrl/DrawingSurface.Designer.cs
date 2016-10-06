namespace DrawingShapes
{
    partial class DrawingSurface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingSurface));
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdRectangle = new System.Windows.Forms.ToolStripButton();
            this.cmdEllipse = new System.Windows.Forms.ToolStripButton();
            this.cmdTriangle = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mnuForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShape = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mnuForm.SuspendLayout();
            this.mnuShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.cmdDelete,
            this.toolStripSeparator,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(567, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton1.Text = "Change Color";
            this.toolStripButton1.Click += new System.EventHandler(this.mnuColorChange_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(50, 22);
            this.cmdDelete.Text = "Remove";
            this.cmdDelete.Click += new System.EventHandler(this.mnuRemoveShape_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "To Front";
            this.toolStripButton2.Click += new System.EventHandler(this.mnuToFront_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton3.Text = "To Back";
            this.toolStripButton3.Click += new System.EventHandler(this.mnuToBack_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.cmdRectangle,
            this.cmdEllipse,
            this.cmdTriangle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(567, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdRectangle
            // 
            this.cmdRectangle.Image = ((System.Drawing.Image)(resources.GetObject("cmdRectangle.Image")));
            this.cmdRectangle.ImageTransparentColor = System.Drawing.Color.White;
            this.cmdRectangle.Name = "cmdRectangle";
            this.cmdRectangle.Size = new System.Drawing.Size(75, 22);
            this.cmdRectangle.Text = "Rectangle";
            this.cmdRectangle.Click += new System.EventHandler(this.mnuNewShape_Click);
            // 
            // cmdEllipse
            // 
            this.cmdEllipse.Image = ((System.Drawing.Image)(resources.GetObject("cmdEllipse.Image")));
            this.cmdEllipse.ImageTransparentColor = System.Drawing.Color.White;
            this.cmdEllipse.Name = "cmdEllipse";
            this.cmdEllipse.Size = new System.Drawing.Size(56, 22);
            this.cmdEllipse.Text = "Ellipse";
            this.cmdEllipse.Click += new System.EventHandler(this.mnuNewShape_Click);
            // 
            // cmdTriangle
            // 
            this.cmdTriangle.Image = ((System.Drawing.Image)(resources.GetObject("cmdTriangle.Image")));
            this.cmdTriangle.ImageTransparentColor = System.Drawing.Color.White;
            this.cmdTriangle.Name = "cmdTriangle";
            this.cmdTriangle.Size = new System.Drawing.Size(65, 22);
            this.cmdTriangle.Text = "Triangle";
            this.cmdTriangle.Click += new System.EventHandler(this.mnuNewShape_Click);
            // 
            // mnuForm
            // 
            this.mnuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRectangle,
            this.mnuEllipse,
            this.mnuTriangle,
            this.toolStripSeparator2,
            this.newDrawingToolStripMenuItem,
            this.saveDrawingToolStripMenuItem,
            this.loadDrawingToolStripMenuItem});
            this.mnuForm.Name = "mnuForm";
            this.mnuForm.Size = new System.Drawing.Size(192, 142);
            // 
            // mnuRectangle
            // 
            this.mnuRectangle.Name = "mnuRectangle";
            this.mnuRectangle.Size = new System.Drawing.Size(191, 22);
            this.mnuRectangle.Text = "Create New Rectange";
            this.mnuRectangle.Click += new System.EventHandler(this.mnuNewShape_Click);
            // 
            // mnuEllipse
            // 
            this.mnuEllipse.Name = "mnuEllipse";
            this.mnuEllipse.Size = new System.Drawing.Size(191, 22);
            this.mnuEllipse.Text = "Create New Ellipse";
            this.mnuEllipse.Click += new System.EventHandler(this.mnuNewShape_Click);
            // 
            // mnuTriangle
            // 
            this.mnuTriangle.Name = "mnuTriangle";
            this.mnuTriangle.Size = new System.Drawing.Size(191, 22);
            this.mnuTriangle.Text = "Create New Triangle";
            this.mnuTriangle.Click += new System.EventHandler(this.mnuNewShape_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // newDrawingToolStripMenuItem
            // 
            this.newDrawingToolStripMenuItem.Name = "newDrawingToolStripMenuItem";
            this.newDrawingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.newDrawingToolStripMenuItem.Text = "New Drawing";
            this.newDrawingToolStripMenuItem.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // saveDrawingToolStripMenuItem
            // 
            this.saveDrawingToolStripMenuItem.Name = "saveDrawingToolStripMenuItem";
            this.saveDrawingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveDrawingToolStripMenuItem.Text = "Save Drawing";
            this.saveDrawingToolStripMenuItem.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // loadDrawingToolStripMenuItem
            // 
            this.loadDrawingToolStripMenuItem.Name = "loadDrawingToolStripMenuItem";
            this.loadDrawingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.loadDrawingToolStripMenuItem.Text = "Load Drawing";
            this.loadDrawingToolStripMenuItem.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // mnuShape
            // 
            this.mnuShape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.removeShapeToolStripMenuItem,
            this.toolStripSeparator3,
            this.bringToFrontToolStripMenuItem,
            this.sendToBackToolStripMenuItem});
            this.mnuShape.Name = "mnuShape";
            this.mnuShape.Size = new System.Drawing.Size(158, 98);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.mnuColorChange_Click);
            // 
            // removeShapeToolStripMenuItem
            // 
            this.removeShapeToolStripMenuItem.Name = "removeShapeToolStripMenuItem";
            this.removeShapeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.removeShapeToolStripMenuItem.Text = "Remove Shape";
            this.removeShapeToolStripMenuItem.Click += new System.EventHandler(this.mnuRemoveShape_Click);
            // 
            // bringToFrontToolStripMenuItem
            // 
            this.bringToFrontToolStripMenuItem.Name = "bringToFrontToolStripMenuItem";
            this.bringToFrontToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bringToFrontToolStripMenuItem.Text = "Bring To Front";
            this.bringToFrontToolStripMenuItem.Click += new System.EventHandler(this.mnuToFront_Click);
            // 
            // sendToBackToolStripMenuItem
            // 
            this.sendToBackToolStripMenuItem.Name = "sendToBackToolStripMenuItem";
            this.sendToBackToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sendToBackToolStripMenuItem.Text = "Send To Back";
            this.sendToBackToolStripMenuItem.Click += new System.EventHandler(this.mnuToBack_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // DrawingSurface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 431);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DrawingSurface";
            this.Text = "Drawing Shapes";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mnuForm.ResumeLayout(false);
            this.mnuShape.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdRectangle;
        private System.Windows.Forms.ToolStripButton cmdEllipse;
        private System.Windows.Forms.ToolStripButton cmdTriangle;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip mnuForm;
        private System.Windows.Forms.ToolStripMenuItem mnuRectangle;
        private System.Windows.Forms.ToolStripMenuItem mnuEllipse;
        private System.Windows.Forms.ToolStripMenuItem mnuTriangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem newDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDrawingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mnuShape;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem bringToFrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToBackToolStripMenuItem;
    }
}