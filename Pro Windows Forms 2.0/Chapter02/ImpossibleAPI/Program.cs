using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImpossibleAPI
{
	static class Program
	{
		public static Form1 Main1 = new Form1();
		public static Form1 Main2 = new Form1();
		public static Form2 Child = new Form2();

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Main1.Text = "Parent 2";
			Main2.Text = "Parent 1";
			Main1.Show();
			Main2.Show();

			Child.MdiParent = Main2;
			Child.Show();

			System.Windows.Forms.Application.Run();
		}
	}
}