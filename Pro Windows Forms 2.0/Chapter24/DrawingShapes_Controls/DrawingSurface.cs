using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawingShapes
{
	public partial class DrawingSurface : Form
	{
		public DrawingSurface()
		{
			InitializeComponent();
		}

		private void mnuNewShape_Click(object sender, System.EventArgs e)
		{
			// Create and configure the shape with some defaults.
			Shape newShape = new Shape();
			newShape.Size = new Size(40, 40);
			newShape.ForeColor = Color.Coral;

			// Configure the appropriate shape depending on the menu option selected.
			if (sender == mnuRectangle)
			{
				newShape.Type = Shape.ShapeType.Rectangle;
			}
			else if (sender == mnuEllipse)
			{
				newShape.Type = Shape.ShapeType.Ellipse;
			}
			else if (sender == mnuTriangle)
			{
				newShape.Type = Shape.ShapeType.Triangle;
			}

			// To determine where to place the shape, you need to convert the 
			// current screen-based mouse coordinates into relative form coordinates.
			newShape.Location = this.PointToClient(Control.MousePosition);

			// Attach a context menu to the shape.
			newShape.ContextMenuStrip = mnuSelectShape;

			// Connect the shape to all its event handlers.
			newShape.MouseDown += new MouseEventHandler(ctrl_MouseDown);
			newShape.MouseMove += new MouseEventHandler(ctrl_MouseMove);
			newShape.MouseUp += new MouseEventHandler(ctrl_MouseUp);

			// Add the shape to the form.
			this.Controls.Add(newShape);
		}

		// Keep track of when drag or resize mode is enabled.
		private bool isDragging = false;
		private bool isResizing = false;

		// Store the location where the user clicked on the control.
		private int clickOffsetX, clickOffsetY;

		private void ctrl_MouseDown(object sender,
		 System.Windows.Forms.MouseEventArgs e)
		{
			// Retrieve a reference to the active label.
			Control currentCtrl;
			currentCtrl = (Control)sender;

			// Required for the focus rectangle.
			ctrlToFocus = currentCtrl;
			// Invalidate to show the focus rectangle.
			Invalidate();

			if (e.Button == MouseButtons.Right)
			{
				// Show the context menu.
				currentCtrl.ContextMenuStrip.Show(currentCtrl, new Point(e.X, e.Y));
			}
			else if (e.Button == MouseButtons.Left)
			{
				clickOffsetX = e.X;
				clickOffsetY = e.Y;

				if (currentCtrl.Cursor == Cursors.SizeNWSE ||
			     currentCtrl.Cursor == Cursors.SizeNS ||
                 currentCtrl.Cursor == Cursors.SizeWE)
				{
					// The mouse pointer is at one of the sides,
					// so resizing mode is appropriate.
					isResizing = true;
				}
				else
				{
					// The mouse is somewhere else, so dragging mode is
					// appropriate.
					isDragging = true;
				}
			}
		}

		private void ctrl_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Retrieve a reference to the active shape.
			Control currentCtrl;
			currentCtrl = (Control)sender;

			if (isDragging)
			{
				// Move the control.
				currentCtrl.Left = e.X + currentCtrl.Left - clickOffsetX;
				currentCtrl.Top = e.Y + currentCtrl.Top - clickOffsetY;
			}
			else if (isResizing)
			{
				// Resize the control, according to the resize mode.
				if (currentCtrl.Cursor == Cursors.SizeNWSE)
				{
					currentCtrl.Width = e.X;
					currentCtrl.Height = e.Y;
				}
				else if (currentCtrl.Cursor == Cursors.SizeNS)
				{
					currentCtrl.Height = e.Y;
				}
				else if (currentCtrl.Cursor == Cursors.SizeWE)
				{
					currentCtrl.Width = e.X;
				}
			}
			else
			{
				// Change the cursor if the mouse pointer is on one of the edges
				// of the control.
				if (((e.X + 5) > currentCtrl.Width) &&
				   ((e.Y + 5) > currentCtrl.Height))
				{
					currentCtrl.Cursor = Cursors.SizeNWSE;
				}
				else if ((e.X + 5) > currentCtrl.Width)
				{
					currentCtrl.Cursor = Cursors.SizeWE;
				}
				else if ((e.Y + 5) > currentCtrl.Height)
				{
					currentCtrl.Cursor = Cursors.SizeNS;
				}
				else
				{
					// This misleadingly named cursor is the four-way
					// mouse pointer often used for moving objects.
					currentCtrl.Cursor = Cursors.SizeAll;
				}
			}
		}

		private void ctrl_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			isDragging = false;
			isResizing = false;

			// Invalidate to show the focus rectangle.
			Invalidate();
		}

		private void mnuColorChange_Click(object sender, System.EventArgs e)
		{
			// Show color dialog.
			ColorDialog dlgColor = new ColorDialog();
			if (dlgColor.ShowDialog() == DialogResult.OK)
			{
				// Change shape background.
				mnuSelectShape.SourceControl.BackColor = dlgColor.Color;
			}
		}

		private void DrawingSurface_MouseDown(object sender, MouseEventArgs e)
		{
            if (ctrlToFocus != null)
            {
                ctrlToFocus = null;
                Invalidate();
            }
			if (e.Button == MouseButtons.Right)
			{
				this.ContextMenuStrip.Show(this, new Point(e.X, e.Y));
			}   
		}

		private Control ctrlToFocus;
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (ctrlToFocus != null && !isDragging)
			{
				Rectangle rect = ctrlToFocus.Bounds;
				rect.Inflate(new Size(2, 2));
				ControlPaint.DrawFocusRectangle(e.Graphics, rect);
			}
		}

		private void mnuRemoveShape_Click(object sender, System.EventArgs e)
		{
			Control ctrlShape = mnuSelectShape.SourceControl;
			this.Controls.Remove(ctrlShape);
		}

		private void mnuBringToFront_Click(object sender, EventArgs e)
		{
			Control ctrlShape = mnuSelectShape.SourceControl;
			ctrlShape.BringToFront();
		}

		private void mnuSendToBack_Click(object sender, EventArgs e)
		{
			Control ctrlShape = mnuSelectShape.SourceControl;
			ctrlShape.SendToBack();
		}

	}
}