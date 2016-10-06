using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DocumentView
{
	static class Program
	{
        private static ApplicationTasks appTasks = new ApplicationTasks();
        public static ApplicationTasks AppTasks
        {
            get { return appTasks; }
        }

        private static DocumentManager documentManager = new DocumentManager();
        public static DocumentManager DocumentManager
        {
            get { return documentManager; }
        }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();

            // Start with one document.
            AppTasks.New();

			Application.Run();
		}
	}
}