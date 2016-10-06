using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.IO;
using Microsoft.VisualBasic;
using System.Globalization;

namespace Microsoft.Samples
{
    /// <summary>
    /// Summary description for form.
    /// </summary>
    public partial class Form1 : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private IPv5 ip;

        private static uint logCount = 1;

        public Form1()
        {
            InitializeComponent();
        }

        // Event handlers
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Add items to the ComboBoxes
            this.prompCharComboBox.Items.AddRange(new object[] {
            "_",
            " ",
            "$",
            "#",
            "N",
            "A"});

            this.passwordCharCombo.Items.AddRange(new object[] {
            " ",
            "*",
            "#",
            "^",
            "P",
            "O"});

			this.textMaskFormatComboBox.Items.AddRange(Enum.GetNames(typeof(MaskFormat)));
			this.copyMaskFormatComboBox.Items.AddRange(Enum.GetNames(typeof(MaskFormat)));

            // Sync up properties UI to MaskedTextBox
            SyncUIToControl();

            // Setup MaskedTextBox validating type
            this.maskedTextBox1.ValidatingType = typeof(IPv5);

            // Bind outPutTextBox.Text to MaskedTextBox.Text
            this.outputTextBox.DataBindings.Add(new Binding("Text", this.maskedTextBox1, "Text", false, DataSourceUpdateMode.OnPropertyChanged, CultureInfo.CurrentCulture));
        }

        private void maskedTextBox1_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {
            AppendLog("Mask input rejected at position: " + e.Position.ToString(CultureInfo.CurrentCulture));
            this.eventLogTextBox.ScrollToCaret();
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, System.Windows.Forms.TypeValidationEventArgs e)
        {
            if (e.IsValidInput)
            {
                AppendLog("Type validation succeeded.  Message: " + e.Message);
                ip = e.ReturnValue as IPv5;
            }
            else
            {
                ip = IPv5.InvalidIPv5;

                AppendLog("Type validation failed.  Message: " + e.Message);
                this.eventLogTextBox.ScrollToCaret();
            }
        }

        // Methods
        private void SyncUIToControl()
        {
            this.hidePromptOnLeaveCheckBox.Checked = this.maskedTextBox1.HidePromptOnLeave;
            this.useSystemPasswordCharCheckBox.Checked = this.maskedTextBox1.UseSystemPasswordChar;
            this.beepOnErrorCheckBox.Checked = this.maskedTextBox1.BeepOnError;
            
			this.passwordCharCombo.SelectedIndex = 0;
            this.prompCharComboBox.SelectedIndex = 0;
			this.textMaskFormatComboBox.SelectedIndex = 3;
			this.copyMaskFormatComboBox.SelectedIndex = 3;

            // Set the Insert key mode checkbox
			this.maskedTextBox1.InsertKeyMode = InsertKeyMode.Insert;
            this.InsertKeyModeCheckBox.Checked = true;
            
            // Set read only properties 
            this.maskCompletedStatusStripPanel.Text = "Mask Completed: " + this.maskedTextBox1.MaskCompleted.ToString();
            this.maskFullStatusStripPanel.Text = "Mask Full: " + this.maskedTextBox1.MaskFull.ToString();
        }

        private void maskedTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            this.maskCompletedStatusStripPanel.Text = "Mask Completed: " + this.maskedTextBox1.MaskCompleted.ToString();
            this.maskFullStatusStripPanel.Text = "Mask Full: " + this.maskedTextBox1.MaskFull.ToString();
        }

        private void propertyCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            // Cast the sender to a CheckBox
            CheckBox cb = sender as CheckBox;

            // Make sure we don't have a null ref
            if (cb != null)
            {
                // Switch on the CheckBoxes name and 
                // set the corresponding property value
                switch (cb.Name)
                {
                    case "hidePromptOnLeaveCheckBox":
                        this.maskedTextBox1.HidePromptOnLeave = cb.Checked;
                        break;
                    case "includeLiteralsCheckBox":
						this.maskedTextBox1.SkipLiterals = cb.Checked;
                        break;
                    case "includePromptCheckBox":
						this.maskedTextBox1.AllowPromptAsInput = cb.Checked;
                        break;
                    case "useSystemPasswordCharCheckBox":
                        this.maskedTextBox1.UseSystemPasswordChar = cb.Checked;
                        break;
                    case "beepOnErrorCheckBox":
                        this.maskedTextBox1.BeepOnError = cb.Checked;
                        break;
                    case "InsertKeyModeCheckBox":
						if (cb.Checked)
						{
							this.maskedTextBox1.InsertKeyMode = InsertKeyMode.Insert;
						}
						else
						{
							this.maskedTextBox1.InsertKeyMode = InsertKeyMode.Overwrite;
						}
                        break;
                }
            }
        }

        private void passwordCharCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                // Set the PasswordChar
                char pwdChar = this.passwordCharCombo.SelectedItem.ToString().ToCharArray()[0];

                // Special case a space as the null char
                if( pwdChar == ' ')
                {
                    pwdChar = '\0';
                }

                this.maskedTextBox1.PasswordChar = pwdChar;
            }
            catch(InvalidOperationException ex )
            {
                MessageBox.Show( ex.Message );
                this.passwordCharCombo.SelectedIndex = 0;
            }
        }

        private void prompCharComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                // Set the PromptChar 
                this.maskedTextBox1.PromptChar = this.prompCharComboBox.SelectedItem.ToString().ToCharArray()[0];
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                this.prompCharComboBox.SelectedIndex = 0;
            }
        }

		private void textMaskFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.maskedTextBox1.TextMaskFormat = (MaskFormat)Enum.Parse(typeof(MaskFormat), this.textMaskFormatComboBox.SelectedItem.ToString());
		}

		private void copyMaskFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.maskedTextBox1.CutCopyMaskFormat = (MaskFormat)Enum.Parse(typeof(MaskFormat), this.textMaskFormatComboBox.SelectedItem.ToString());
		}

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("IP Address: " + ip.ToString(), "MaskedTextBox.Value", MessageBoxButtons.OK);
        }

        private void AppendLog(string msg)
        {
            this.eventLogTextBox.AppendText(logCount + ". " + msg + "\r\n");
            logCount++;
		}
    }
}

