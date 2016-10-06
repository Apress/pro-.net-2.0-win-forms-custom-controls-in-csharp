using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace SaveFormPosition
{
	public class FormPositionHelper
	{
		[Serializable]
		[StructLayout(LayoutKind.Sequential)]
		private class ManagedPt
		{
			public int X = 0;
			public int Y = 0;

			public ManagedPt()
			{
			}

			public ManagedPt(int x, int y)
			{
				X = x;
				Y = y;
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential)]
		private class ManagedRect
		{
			public int X = 0;
			public int Y = 0;
			public int Right = 0;
			public int Bottom = 0;

			public ManagedRect()
			{
			}

			public ManagedRect(int x, int y, int right, int bottom)
			{
				X = x;
				Y = y;
				Right = right;
				Bottom = bottom;
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential)]
		private class ManagedWindowPlacement
		{
			public uint Length = 0;
			public uint Flags = 0;
			public uint ShowCmd = 0;
			public ManagedPt MinPosition = null;
			public ManagedPt MaxPosition = null;
			public ManagedRect NormalPosition = null;

			public ManagedWindowPlacement()
			{
				Length = (uint)Marshal.SizeOf(this);
			}
		}

		[DllImport("user32.dll")]
		private static extern bool GetWindowPlacement(IntPtr handle,
		   [In, Out] ManagedWindowPlacement placement);

		[DllImport("user32.dll")]
		private static extern bool SetWindowPlacement(IntPtr handle,
		   ManagedWindowPlacement placement);
		
		public static string RegPath = @"Software\App\";

		public static void SaveSize(System.Windows.Forms.Form frm)
		{
			// Create or retrieve a reference to a key where the settings
			// will be stored.
			RegistryKey key;
			key = Registry.LocalMachine.CreateSubKey(RegPath + frm.Name);

			// Get the window placement.
			ManagedWindowPlacement placement = new ManagedWindowPlacement(); 
			GetWindowPlacement(frm.Handle, placement);
			
			MemoryStream ms = new MemoryStream();
			BinaryFormatter f = new BinaryFormatter();
			f.Serialize(ms, placement);
					
			key.SetValue("Placement", ms.ToArray());
		}

		public static void SetSize(System.Windows.Forms.Form frm)
		{
			RegistryKey key;
			key = Registry.LocalMachine.OpenSubKey(RegPath + frm.Name);

			if (key != null)
			{
				MemoryStream ms = new MemoryStream((byte[])key.GetValue("Placement"));
				BinaryFormatter f = new BinaryFormatter();
				ManagedWindowPlacement placement = (ManagedWindowPlacement)f.Deserialize(ms);
				SetWindowPlacement(frm.Handle, placement);
			}
		}

	}

}
