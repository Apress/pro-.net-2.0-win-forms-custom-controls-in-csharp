using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace QuartzMediaPlayer
{
	public partial class MediaPlayer : Form
	{
		public MediaPlayer()
		{
			InitializeComponent();
		}

		// The FilgraphManager is the central source for all other interfaces.
		private QuartzTypeLib.FilgraphManager graphManager;

		// The IMediate control interface allows you control playback.
		private QuartzTypeLib.IMediaControl mc;

		// IBasicAudio exposes Volume and Balance properties.
		private QuartzTypeLib.IBasicAudio audio;

		// IMediaPosition exposes the CurrentPosition property.
		private QuartzTypeLib.IMediaPosition position;

		// IMediaEventEx allows you to receive events, including when playback stops.
		private QuartzTypeLib.IMediaEventEx mEventEx;

		private void MediaPlayer_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer1.Stop();
			if (mc != null) mc.Stop();
		}




		private string ConvertTimeToString(int seconds)
		{
			int hours = seconds / 3600;
			int minutes = (seconds - (hours * 3600)) / 60;
			seconds = seconds - (hours * 3600 + minutes * 60);
			return String.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (position != null)
			{
				statusLabel2.Text = "Current: " +
				  ConvertTimeToString((int)position.CurrentPosition);
			}
		}

		private const int WM_APP = 0x8000;
		private const int WM_GRAPHNOTIFY = WM_APP + 1;
		private const int EC_COMPLETE = 0x01;

		protected override void WndProc(ref Message m)
		{
			// Check if it's a notification message from the Quart component.
			if (m.Msg == WM_GRAPHNOTIFY)
			{
				int lEventCode;
				int lParam1, lParam2;

				try
				{
					// Retrieve the message.
					mEventEx.GetEvent(out lEventCode, out lParam1,
					  out lParam2, 0);
					mEventEx.FreeEventParams(lEventCode, lParam1, lParam2);

					// Check if it's the end-of-file message.
					if (lEventCode == EC_COMPLETE)
					{
						// Restart the playback.
						mc.Stop();
						position.CurrentPosition = 0;
						mc.Run();
					}
				}
				catch (Exception)
				{
					// Never throw an exception from WndProc().
					// You may want to log it, however.
				}
			}
			// Pass the message along to .NET.
			base.WndProc(ref m);
		}

		private void cmdPlay_Click(object sender, EventArgs e)
		{
			if (mc == null)
			{
				// This audio is being played for the first time.
				// Load the file.

				// Access the IMediaControl interface.
				graphManager = new QuartzTypeLib.FilgraphManager();
				mc = (QuartzTypeLib.IMediaControl)graphManager;
				audio = (QuartzTypeLib.IBasicAudio)graphManager;
				position = (QuartzTypeLib.IMediaPosition)graphManager;
				mEventEx = (QuartzTypeLib.IMediaEventEx)graphManager;

				try
				{
					// Choose a file.
					mc.RenderFile(Application.StartupPath + "\\test.mp3");
					mEventEx.SetNotifyWindow((int)this.Handle, WM_GRAPHNOTIFY, 0);			
				}
				catch (FileNotFoundException err)
				{
					MessageBox.Show("File not found.");
					return;
				}
				catch (COMException err)
				{
					MessageBox.Show("COM error.");
					return;
				}
			}

			// Start playing the audio asynchronously.
			try
			{
				statusLabel1.Text = "Total: " +
					ConvertTimeToString((int)position.Duration);

				mc.Run();
				timer1.Start();			
			}
			catch (COMException err)
			{
				MessageBox.Show("COM error.");
			}
		}

		private void cmdStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			if (mc != null) mc.Stop();
			position.CurrentPosition = 0;
			statusLabel2.Text = "Current: 00:00:00";
		}

		private void cmdPause_Click(object sender, EventArgs e)
		{
			if (mc != null) mc.Pause();
		}

	}
}