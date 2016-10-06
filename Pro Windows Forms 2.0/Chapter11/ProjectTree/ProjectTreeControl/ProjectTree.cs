using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectTreeControl
{
	[Designer(typeof(ProjectTreeDesigner))]
		public partial class ProjectTree : TreeView
	{
		public ProjectTree():base()
		{
			InitializeComponent();
			// Set the images.
			ImageList = this.imagesTree;

			// Created the first level of nodes.
			nodeUnassigned = new TreeNode("Unassigned",
				(int)NodeImages.UnassignedGroup, (int)NodeImages.UnassignedGroup);
			nodeInProgress = new TreeNode("In Progress",
				(int)NodeImages.InProgressGroup, (int)NodeImages.InProgressGroup);
			nodeClosed = new TreeNode("Closed",
				(int)NodeImages.ClosedGroup, (int)NodeImages.ClosedGroup);

			// Add the project category nodes.
			Nodes.Add(nodeUnassigned);
			Nodes.Add(nodeInProgress);
			Nodes.Add(nodeClosed);

		}

		
			// Specific numbers correspond to the image index.
			private enum NodeImages
			{
				UnassignedGroup = 0,
				InProgressGroup = 1,
				ClosedGroup = 2,
				NormalProject = 3,
				SelectedProject = 4
			}

			// Store references to the three main node branches.
			private TreeNode nodeUnassigned;
			private TreeNode nodeInProgress;
			private TreeNode nodeClosed;

			public TreeNode UnassignedProjectsNode
			{
				get
				{
					return nodeUnassigned;
				}
			}

			public TreeNode InProgressProjectsNode
			{
				get
				{
					return nodeInProgress;
				}
			}

			public TreeNode ClosedProjectsNode
			{
				get
				{
					return nodeClosed;
				}
			}


			

			// Provide a specialized method the client can use to add nodes.
			public void AddProject(Project project)
			{
				//TreeNode nodeNew = new TreeNode(project.Name,
				//	(int)NodeImages.NormalProject, (int)NodeImages.SelectedProject);

				// Store the project object for later use
				// (when the event is raised).
				//nodeNew.Tag = project;
				ProjectTreeNode nodeNew = new ProjectTreeNode(project, project.Name,
					(int)NodeImages.NormalProject, (int)NodeImages.SelectedProject);

				//	(int)NodeImages.NormalProject, (int)NodeImages.SelectedProject);

				// Store the project object for later use
				// (when the event is raised).
				//nodeNew.Tag = project;

				switch (project.Status)
				{
					case Project.StatusType.Unassigned:
						nodeUnassigned.Nodes.Add(nodeNew);
						break;
					case Project.StatusType.InProgress:
						nodeInProgress.Nodes.Add(nodeNew);
						break;
					case Project.StatusType.Closed:
						nodeClosed.Nodes.Add(nodeNew);
						break;
				}
			}

			public Project GetProject(string name, Project.StatusType status)
			{
				TreeNodeCollection nodes = null;
				
				switch (status)
				{
					case Project.StatusType.Unassigned:
						nodes = nodeUnassigned.Nodes;
						break;
					case Project.StatusType.InProgress:
						nodes = nodeInProgress.Nodes;
						break;
					case Project.StatusType.Closed:
						nodes = nodeClosed.Nodes;
						break;
				}

				foreach (TreeNode node in nodes)
				{
					if (node.Text == name)
					{
						Project project = node.Tag as Project;
						if (project != null) return project;
					}
				}
				return null;
			}

			public event ProjectSelectedEventHandler ProjectSelected;

			protected override void OnAfterSelect(TreeViewEventArgs e)
			{
				base.OnAfterSelect(e);

				// Check that at least one event listener is registered
				// before continuing.
				if (ProjectSelected != null)
				{
					// To determine if it's a project node,
					// you can examine the node's parent or (in this case)
					// just check the level.
					if (e.Node.Level == 1)
					{
						Project project = ((ProjectTreeNode)e.Node).Project;
						ProjectSelectedEventArgs arg = new ProjectSelectedEventArgs(project);
						ProjectSelected(this, arg);
					}
				}
			}


		}
	}
