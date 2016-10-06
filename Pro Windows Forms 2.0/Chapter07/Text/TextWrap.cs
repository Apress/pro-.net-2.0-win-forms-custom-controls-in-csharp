using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Text
{
	public partial class TextWrap : Form
	{
		public TextWrap()
		{
			InitializeComponent();
		}

		private void TextWrap_Paint(object sender, PaintEventArgs e)
		{
			string text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
					
			StringFormat stringFormat = new StringFormat();
			// Center each line of text.
			stringFormat.Alignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), lstAlignmentH.Text);
			// Center the block of text (top to bottom) in the rectangle.
			stringFormat.LineAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), lstAlignmentV.Text);
			
			// Set the wrap style.
			stringFormat.Trimming = (StringTrimming)Enum.Parse(typeof(StringTrimming), lstTrimming.Text);

			Font font = new Font("Verdana", 12);
			Rectangle rect = new Rectangle(30, 110, Width - 60, Height - 160);
			e.Graphics.DrawString(text, font, Brushes.Black, rect, stringFormat);

			Pen pen = Pens.Black;
			e.Graphics.DrawRectangle(pen, rect);

		}

		private void TextWrap_Load(object sender, EventArgs e)
		{
			ResizeRedraw = true;
			lstAlignmentH.DataSource = Enum.GetNames(typeof(StringAlignment));
			lstAlignmentV.DataSource = Enum.GetNames(typeof(StringAlignment));
			lstTrimming.DataSource = Enum.GetNames(typeof(StringTrimming));
		}

		private void lst_Changed(object sender, EventArgs e)
		{
			Invalidate();
		}
	}
}