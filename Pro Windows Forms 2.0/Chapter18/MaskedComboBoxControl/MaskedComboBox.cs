using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Runtime.InteropServices;

namespace MaskedComboBoxControl
{
	public class MaskedComboBox : ComboBox
	{
		private MaskedTextProvider maskProvider = null;

		// Used to check Insert key state.
		[DllImport("user32.dll")]
		extern static int GetKeyState(int key);

		
		public string Mask
		{
			get
			{
				if (maskProvider == null)
				{
					return "";
				}
				else
				{
					return maskProvider.Mask;
				}
			}
			set
			{
				if (value == "")
				{
					maskProvider = null;
					this.Text = "";
				}
				else
				{
					// This seems to be necessary because Mask is read-only.
					maskProvider = new MaskedTextProvider(value);
					this.Text = maskProvider.ToDisplayString();
				}
			}
		}

		

		public bool MaskCompleted
		{
			get
			{
				if (maskProvider == null)
				{
					return false;
				}
				else
				{
					return maskProvider.MaskCompleted;
				}
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			int pos = this.SelectionStart;

			// Deleting a character (Delete key).
			// Currently this does nothing if you try to delete
			// a format character (unliked MaskedTextBox, which
			// deletes the next input character).
			// Could use our private SkipToEditableCharacter
			// method to change this behavior.
			if ((int)e.KeyCode == (int)Keys.Delete && pos < (this.Text.Length))
			{
				if (maskProvider.RemoveAt(pos))
				{
					RefreshText(pos);
				}
				e.Handled = true;
			}
			base.OnKeyDown(e);
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if (maskProvider != null)
			{
				int pos = this.SelectionStart;

				// Deleting a character (backspace).
				// Currently this steps over a format character
				// (unliked MaskedTextBox, which steps over and
				// deletes the next input character).
				// Could use our private SkipToEditableCharacter
				// method to change this behavior.
				if ((int)e.KeyChar == (int)Keys.Back)
				{
					if (pos > 0)
					{
						pos--;
						maskProvider.RemoveAt(pos);
					}
				}
				// Adding a character.
				else if (pos < this.Text.Length)
				{
					pos = SkipToEditableCharacter(pos);

					// Overwrite mode is on.
					if (GetKeyState((int)Keys.Insert) == 1)
					{
						if (maskProvider.Replace(e.KeyChar, pos))
						{
							pos++;
						}
					}
					// Insert mode is on.
					else
					{
						if (maskProvider.InsertAt(e.KeyChar, pos))
						{
							pos++;
						}
					}

					// Find the new cursor position.
					pos = SkipToEditableCharacter(pos);
				}
				RefreshText(pos);
				e.Handled = true;
			}

			base.OnKeyPress(e);
		}


		private void RefreshText(int pos)
		{
			// Refresh string.
			// Any way to do this more efficiently?
			// Spec mentions enumerating over characters, but I don't
			// think that makes a difference here (as changing any character
			// in essence creates a new string object).
			this.Text = maskProvider.ToDisplayString();

			// Position cursor.
			this.SelectionStart = pos;
		}

		// Finds the next non-mask character.
		private int SkipToEditableCharacter(int startPos)
		{
			int newPos = maskProvider.FindEditPositionFrom(startPos, true);
			if (newPos == -1)
			{
				// Already at the end of the string.
				return startPos;
			}
			else
			{
				return newPos;
			}
		}
	}
}