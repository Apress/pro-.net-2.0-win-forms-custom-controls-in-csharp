using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Sound
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();

            // This method has been added to configure the SoundPlayer.
            InitializeSound();
        }


        private System.Media.SoundPlayer sound;


        // Sets up the Sound object.
        private void InitializeSound()
        {
            // Create an instance of the Sound class.
            sound = new SoundPlayer();

            // Listen for the LoadCompleted event.
            sound.LoadCompleted += new AsyncCompletedEventHandler(sound_LoadCompleted);

            // Listen for the SoundLocationChanged event.
            sound.SoundLocationChanged += new EventHandler(sound_LocationChanged);
        }


        private void selectFileButton_Click(object sender, System.EventArgs e)
        {
            // Create a new OpenFileDialog.
            OpenFileDialog dlg = new OpenFileDialog();

            // Make sure the dialog checks for existence of the 
            // selected file.
            dlg.CheckFileExists = true;

            // Allow selection of .wav files only.
            dlg.Filter = "WAV files (*.wav)|*.wav";
            dlg.DefaultExt = ".wav";

            // Activate the file selection dialog.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path from the dialog.
                this.filepathTextbox.Text = dlg.FileName;

                // Assign the selected file's path to 
                // the Sound object.  
                sound.SoundLocation = filepathTextbox.Text;
            }
        }


        // Convenience method for setting message text in 
        // the status bar.
        private void ReportStatus(string statusMessage)
        {
            // If the caller passed in a message...
            if ((statusMessage != null) && (statusMessage != String.Empty))
            {
                // ...post the caller's message to the status bar.
                statusLabel.Text = statusMessage;
            }
        }


        // Enables and disables play controls.
        private void EnablePlaybackControls(bool enabled)
        {
            this.playOnceSyncButton.Enabled = enabled;
            this.playOnceAsyncButton.Enabled = enabled;
            this.playLoopAsyncButton.Enabled = enabled;
            this.stopButton.Enabled = enabled;
        }


        private void filepathTextbox_TextChanged(object sender, EventArgs e)
        {
            // Disable playback controls until the new .wav is loaded.
            EnablePlaybackControls(false);
        }


        private void loadSyncButton_Click(object sender, System.EventArgs e)
        {
            // Disable playback controls until the .wav is 
            // successfully loaded. The LoadCompleted event 
            // handler will enable them.
            EnablePlaybackControls(false);

            try
            {
                // Assign the selected file's path to 
                // the Sound object.  
                sound.SoundLocation = filepathTextbox.Text;

                // Load the .wav file.
                sound.Load();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }


        private void loadAsyncButton_Click(System.Object sender, EventArgs e)
        {
            // Disable playback controls until the .wav is 
            // successfully loaded. The LoadCompleted event 
            // handler will enable them.
            EnablePlaybackControls(false);

            try
            {
                // Assign the selected file's path to 
                // the Sound object.  
                sound.SoundLocation = this.filepathTextbox.Text;

                // Load the .wav file.
                sound.LoadAsync();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }


        // Synchronously plays the selected .wav file once.
        // If the file is large, UI response will be visibly 
        // affected.
        private void playOnceSyncButton_Click(object sender, System.EventArgs e)
        {
            ReportStatus("Playing .wav file synchronously.");
            sound.PlaySync();
            ReportStatus("Finished playing .wav file synchronously.");
        }


        // Asynchronously plays the selected .wav file once.
        private void playOnceAsyncButton_Click(object sender, System.EventArgs e)
        {
            ReportStatus("Playing .wav file asynchronously.");
            sound.Play();
        }


        // Asynchronously plays the selected .wav file until the user
        // clicks the Stop button.
        private void playLoopAsyncButton_Click(object sender, System.EventArgs e)
        {
            ReportStatus("Looping .wav file asynchronously.");
            sound.PlayLooping();
        }

        // Stops the currently playing .wav file, if any.
        private void stopButton_Click(System.Object sender, System.EventArgs e)
        {
            sound.Stop();
            ReportStatus("Stopped by user.");
        }


        private void sound_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string message = String.Format("LoadCompleted: {0}", this.filepathTextbox.Text);

            ReportStatus(message);
            EnablePlaybackControls(true);
        }


        private void sound_LocationChanged(object sender, EventArgs e)
        {
            string message = String.Format("SoundLocationChanged: {0}", sound.SoundLocation);

            ReportStatus(message);
        }

        private void SoundTestForm_Load(object sender, System.EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}