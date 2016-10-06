using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace ProjectTreeControl
{
	public class ProjectTreeNode : TreeNode
	{
		private Project project;
		public Project Project
		{
			get { return Project; }
		}

		public ProjectTreeNode(Project project)
		{
			this.project = project;
		}
		public ProjectTreeNode(Project project, string text, int imageIndex, int selectedImageIndex) : base(text,imageIndex,selectedImageIndex)
		{
			this.project = project;
		}
	}
}
