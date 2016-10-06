using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing;

namespace DirectoryTreeControl
{
	[ToolboxBitmap(typeof(DirectoryTree), "DirectoryTree.bmp")]
	[DefaultEvent("DirectorySelected"), 
	DefaultProperty("Drive"), 
	Designer(typeof(DirectoryTreeDesigner))]
	public class DirectoryTree : TreeView
	{
		public delegate void DirectorySelectedDelegate(object sender,
			DirectorySelectedEventArgs e);
		public event DirectorySelectedDelegate DirectorySelected;
		
		private Char drive;
		//[Editor(typeof(DriveEditor), typeof(UITypeEditor))]
		[TypeConverter(typeof(DriveCharConverter))]
		public Char Drive
		{
			get
			{
				return drive;
			}
			set
			{
				drive = value;
				RefreshDisplay();
			}
		}
		
		// This is public so a Refresh can be triggered manually.
		public void RefreshDisplay()
		{
			// Erase the existing tree.
			this.Nodes.Clear();
			
			// Set the first node.
			TreeNode rootNode = new TreeNode(drive + ":\\");
			this.Nodes.Add(rootNode);
			
			// Fill the first level and expand it.
			Fill(rootNode);
			this.Nodes[0].Expand();
		}
		
		private void Fill(TreeNode dirNode)
		{
			DirectoryInfo dir = new DirectoryInfo(dirNode.FullPath);
            
			// An exception could be thrown in this code if you don't
			// have sufficient security permissions for a file or directory.
			// You can catch and then ignore this exception.
			
			foreach (DirectoryInfo dirItem in dir.GetDirectories())
			{
				// Add node for the directory.
				TreeNode newNode = new TreeNode(dirItem.Name);
				dirNode.Nodes.Add(newNode);
				newNode.Nodes.Add("*");
			}
		}
		
		protected override void OnBeforeExpand(TreeViewCancelEventArgs e)
		{
			base.OnBeforeExpand(e);

			// If a dummy node is found, remove it and read the real directory list.
			if (e.Node.Nodes[0].Text == "*")
			{
				e.Node.Nodes.Clear();
				Fill(e.Node);
			}
		}
		
		protected override void OnAfterSelect(TreeViewEventArgs e)
		{
			base.OnAfterSelect(e);
			
			// Raise the DirectorySelected event.
			if (DirectorySelected != null)
			{
				DirectorySelected(this,
					new DirectorySelectedEventArgs(e.Node.FullPath));
			}
		}
	}

	public class DirectorySelectedEventArgs : EventArgs
	{
		public string DirectoryName;

		public DirectorySelectedEventArgs(string directoryName)
		{
			this.DirectoryName = directoryName;
		}
	}


}
