using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace AnimatedCursor
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = AdvancedCursors.Create(
					Path.Combine(Application.StartupPath, "blob.ani"));
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

	}

	public class AdvancedCursors
	{

		[DllImport("User32.dll")]
		private static extern IntPtr LoadCursorFromFile(String str);

		public static Cursor Create(string filename)
		{
			// Get handle to cursor.
			IntPtr hCursor = LoadCursorFromFile(filename);
			
			// Check if it succeeded.
			if (!IntPtr.Zero.Equals(hCursor))
			{
				return new Cursor(hCursor);
			}
			else
			{
				throw new ApplicationException("Could not create cursor from file " + filename);
			}
		}
	}
}