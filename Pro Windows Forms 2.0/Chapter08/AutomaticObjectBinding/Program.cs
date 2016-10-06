using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutomaticObjectBinding
{
	static class Program
	{
		private static StoreDB storeDB = new StoreDB();
		public static StoreDB StoreDB
		{
			get { return storeDB; }
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}
	}
}