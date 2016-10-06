#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace WizardComponent
{
    public partial class Wizard : Form
    {
        public Wizard(List<IWizardItem> steps, Dictionary<string, string>[] state) :
            this(steps)
        {
            this.state = state;
        }

        public Wizard(List<IWizardItem> steps)
        {
            InitializeComponent();
            if (steps.Count > 0)
            {
                this.steps = steps;
                totalSteps = steps.Count;
                currentStep = 1;
                ShowStep();
            }
        }
		
        private void ShowStep()
        {
            // Update buttons.
            cmdPrev.Visible = (currentStep != 1);
            if (currentStep == totalSteps)
                cmdNext.Text = "Finish";
            else
                cmdNext.Text = "Next >";
            
            // Get headings.
            lblHeader.Text = steps[currentStep - 1].HeaderTitle;
            Text = "Step " + currentStep.ToString() + " of " + totalSteps.ToString();

            // Get the child control.
            
            // See if there's state to be restored.
            if (state != null && state[currentStep - 1] != null)
            {
                steps[currentStep - 1].ApplyValues(state[currentStep - 1]);
            }

            // Show step content.
            panelStep.Controls.Clear();
            UserControl ctrl = (UserControl)steps[currentStep - 1];
            panelStep.Controls.Add(ctrl);
        }

    
        private int currentStep;
        private int totalSteps;
        private List<IWizardItem> steps;

        private void cmdPrev_Click(object sender, EventArgs e)
        {
            currentStep--;
            ShowStep();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            if (currentStep == totalSteps)
            {
                state = new Dictionary<string, string>[totalSteps];
                for (int i = 0; i < totalSteps; i++)
                {
                    state[i] = steps[i].GetValues();
                }
                Close();
            }
            else
            {
                currentStep++;
                ShowStep();
            }
        }


        private Dictionary<string, string>[] state;
        public Dictionary<string, string>[] State
        {
            get { return state; }
        }


    }
}