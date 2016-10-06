#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ProjectTreeControl
{
	// Define a higher-level event for node selection.
	public delegate void ProjectSelectedEventHandler(
		object sender, ProjectSelectedEventArgs e);

    public class ProjectSelectedEventArgs : EventArgs
    {
        private Project project;
        public Project Project
        {
            get
            {
                return project;
            }
            set
            {
                project = value;
            }
        }

        public ProjectSelectedEventArgs(Project project)
        {
            Project = project;
        }
    }
}
