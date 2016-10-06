#region Using directives

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomControl
{
    public class NumericTextBox : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Ignore all non-control and non-numeric key presses.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
            // Call the implementation in the base TextBox class,
            // which raises the KeyPress event.
            base.OnKeyPress(e);
        }
    }
}
