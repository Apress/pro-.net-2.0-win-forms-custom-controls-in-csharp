using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DrawingShapes
{
    public partial class DrawingSurface : Form
    {
        public DrawingSurface()
        {
            InitializeComponent();
        }


        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Check for a hit on a focus square.
            Shape.HitSpot hitSpot;
            if ((currentShape != null) && (currentShape.Selected) &&
             (currentShape.HitTestFocusBorder(new Point(e.X, e.Y), out hitSpot)))
            {
                // The border was clicked. Turn on resize mode.
                clickOffsetX = e.X - currentShape.Location.X;
                clickOffsetY = e.Y - currentShape.Location.Y;
                isResizing = true;
            }
            else
            {
                // Remove the last selected shape.
                ClearSelectedShape();

                // Retrieve a reference to the selected shape
                // using hit testing.
                currentShape = shapes.HitTest(new Point(e.X, e.Y));

                if (currentShape == null)
                {
                    // No shape was clicked.
                    // Depending on the mouse button, show a menu.
                    if (e.Button == MouseButtons.Right)
                    {
                        mnuForm.Show(this, new Point(e.X, e.Y));
                    }
                }
                else
                {
                    // Select the new shape and refresh the form.
                    currentShape.Selected = true;

                    // Make sure the display is updated to reflect
                    // newly selected or de-selected shapes.
                    //Invalidate();
                    Invalidate(currentShape.GetLargestPossibleRegion());

                    // Check what action should be performed with the
                    // shape, depending on the mouse button that was clicked.
                    if (e.Button == MouseButtons.Right)
                    {
                        // Show the context menu.       
                        mnuShape.Show(this, new Point(e.X, e.Y));
                    }
                    else if (e.Button == MouseButtons.Left)
                    {
                        // Start dragging mode.
                        clickOffsetX = e.X - currentShape.Location.X;
                        clickOffsetY = e.Y - currentShape.Location.Y;
                        isDragging = true;
                    }
                }

            }
        }

        private void mnuNewShape_Click(object sender, System.EventArgs e)
        {
            // Create and configure the shape with some defaults.
            Shape newShape = null;
            // Configure the appropriate shape depending on the menu option selected.
            if (sender == mnuRectangle || sender == cmdRectangle)
            {
                newShape = new RectangleShape();
            }
            else if (sender == mnuEllipse || sender == cmdEllipse)
            {
                newShape = new EllipseShape();
            }
            else if (sender == mnuTriangle || sender == cmdTriangle)
            {
                newShape = new TriangleShape();
            }
            else
            {
                throw new ApplicationException("Not a valid shape command.");
            }

            newShape.Size = new Size(40, 40);
            newShape.ForeColor = Color.Coral;

            if (sender is ToolStripButton)
            {
                newShape.Location = new Point(150, 100);
            }
            else
            {
                // To determine where to place the shape, you need to convert the 
                // current screen-based mouse coordinates into relative form coordinates.
                newShape.Location = PointToClient(Control.MousePosition);
            }

            // Remove the last selected shape.
            ClearSelectedShape();
            currentShape = newShape;
            currentShape.Selected = true;
            
            // Add the shape to the form and trigger a refresh.
            shapes.Add(newShape);
            Invalidate(newShape.GetLargestPossibleRegion());
        }


        // Keep track of when drag or resize mode is enabled.
        private bool isDragging = false;
        private bool isResizing = false;
        private Shape.HitSpot resizingMode;

        // Store the location where the user clicked on the control.
        private int clickOffsetX, clickOffsetY;

        // Store the selected shape.
        private Shape currentShape;


        private void mnuColorChange_Click(object sender, System.EventArgs e)
        {
            if (currentShape == null) return;
            // Show color dialog.
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {

                // Change shape background.
                currentShape.BackColor = dlgColor.Color;
                Invalidate(currentShape.Region);
            }
        }


        private void mnuRemoveShape_Click(object sender, System.EventArgs e)
        {
            if (currentShape == null) return;
            shapes.Remove(currentShape);
            //Invalidate(currentShape.GetLargestPossibleRegion());
            ClearSelectedShape();
        }

        private void mnuToFront_Click(object sender, EventArgs e)
        {
            if (currentShape == null) return;
            shapes.BringShapeToFront(currentShape);
            Invalidate(currentShape.GetLargestPossibleRegion());
        }

        private void mnuToBack_Click(object sender, EventArgs e)
        {
            if (currentShape == null) return;
            shapes.SendShapeToBack(currentShape);
            Invalidate(currentShape.GetLargestPossibleRegion());
        }

        private ShapeCollection shapes = new ShapeCollection();

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            shapes.ReverseSort();
            foreach (Shape shape in shapes)
            {
                if (e.ClipRectangle.IntersectsWith(shape.GetLargestPossibleRegion()))
                {
                    shape.Render(g);
                }
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Rectangle oldPosition = currentShape.GetLargestPossibleRegion();
                currentShape.Location = new Point(e.X - clickOffsetX, e.Y - clickOffsetY);

                Rectangle newPosition = currentShape.GetLargestPossibleRegion();
                //Invalidate();
                Invalidate(Rectangle.Union(oldPosition, newPosition));
            }
            else if (isResizing)
            {
                int minSize = 5;

                // Keep track of the old size. Useful
                // for invalidating when NOT double-buffering.
                Rectangle oldPosition = currentShape.GetLargestPossibleRegion();

                // Resize the control, according to the resize mode.
                switch (resizingMode)
                {
                    case Shape.HitSpot.Top:
                    case Shape.HitSpot.TopRightCorner:
                        if (e.Y < (currentShape.Location.Y + currentShape.Size.Height - minSize))
                        {
                            currentShape.Size = new Size(currentShape.Size.Width,
                                currentShape.Location.Y + currentShape.Size.Height - (e.Y - clickOffsetY));
                            currentShape.Location = new Point(currentShape.Location.X, e.Y - clickOffsetY);
                        }
                        break;
                    case Shape.HitSpot.Bottom:
                        if (e.Y > (currentShape.Location.Y + minSize))
                        {
                            currentShape.Size = new Size(currentShape.Size.Width, e.Y - currentShape.Location.Y);
                        }
                        break;
                    case Shape.HitSpot.Left:
                    case Shape.HitSpot.BottomLeftCorner:
                    case Shape.HitSpot.TopLeftCorner:
                        if (e.X < (currentShape.Location.X + currentShape.Size.Width - minSize))
                        {
                            currentShape.Size = new Size((currentShape.Location.X + currentShape.Size.Width) - (e.X - clickOffsetX), currentShape.Size.Height);
                            currentShape.Location = new Point(e.X - clickOffsetX, currentShape.Location.Y);
                        }
                        break;
                    case Shape.HitSpot.Right:
                        if (e.X > (currentShape.Location.X + minSize))
                        {
                            currentShape.Size = new Size(e.X - currentShape.Location.X, currentShape.Size.Height);
                        }
                        break;
                    case Shape.HitSpot.BottomRightCorner:
                        if (e.Y > (currentShape.Location.Y + minSize))
                        {
                            currentShape.Size = new Size(currentShape.Size.Width, e.Y - currentShape.Location.Y);
                        }
                        if (e.X > (currentShape.Location.X + minSize))
                        {
                            currentShape.Size = new Size(e.X - currentShape.Location.X, currentShape.Size.Height);
                        }
                        break;
                }

                // Invalidate()
                // Find the largest invalidate area for NO double buffer scenario.
                Rectangle newPosition = currentShape.GetLargestPossibleRegion();
                Invalidate(Rectangle.Union(oldPosition, newPosition));
            }
            else
            {
                if ((currentShape != null) && (currentShape.Selected)
                    && (currentShape.HitTestFocusBorder(new Point(e.X, e.Y), out resizingMode)))
                {
                    switch (resizingMode)
                    {
                        case Shape.HitSpot.Top:
                        case Shape.HitSpot.Bottom:
                        case Shape.HitSpot.TopRightCorner:
                            Cursor = Cursors.SizeNS;
                            break;
                        case Shape.HitSpot.Left:
                        case Shape.HitSpot.Right:
                        case Shape.HitSpot.BottomLeftCorner:
                        case Shape.HitSpot.TopLeftCorner:
                            Cursor = Cursors.SizeWE;
                            break;
                        case Shape.HitSpot.BottomRightCorner:
                            Cursor = Cursors.SizeNWSE;
                            break;
                        default:
                            Cursor = Cursors.Arrow;
                            break;
                    }
                }
                else
                {
                    Cursor = Cursors.Arrow;
                }
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }



        private void ClearSelectedShape()
        {
            if (currentShape != null)
            {
                currentShape.Selected = false;

                // Make sure the display is updated to reflect
                // newly de-selected shape.
                // Only use if NO double-buffering.
                Invalidate(currentShape.GetLargestPossibleRegion());
            }
            currentShape = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs =
                        File.Create(saveFileDialog.FileName))
                    {
                        BinaryFormatter f = new BinaryFormatter();
                        f.Serialize(fs, shapes);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error while saving. " + err.Message);
                }
            }
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShapeCollection newShapes = null;
                try
                {
                    using (FileStream fs =
                        File.Open(openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter f = new BinaryFormatter();
                        newShapes = (ShapeCollection)f.Deserialize(fs, null);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error while loading. " + err.Message);
                }

                // Trigger a refresh.
                shapes = newShapes;
                Invalidate();
            }
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            Invalidate();
        }



    }
}