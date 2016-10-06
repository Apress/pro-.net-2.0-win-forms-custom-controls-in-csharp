using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectTreeControl;

namespace ProjectTreeHost
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			projectTree1.AddProject(new Project("Migration to .NET", "", Project.StatusType.InProgress));
			projectTree1.AddProject(new Project("Revamp pricing site", "", Project.StatusType.Unassigned));
			projectTree1.AddProject(new Project("Prepare L-DAP feasibility report", "", Project.StatusType.Unassigned));
			projectTree1.AddProject(new Project("Update E201-G to Windows XP", "", Project.StatusType.Closed));
			projectTree1.AddProject(new Project("Annual meeting", "", Project.StatusType.Closed));


		}
	}
}