using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgentTryout
{
    public partial class AgentTest : Form
    {
        public AgentTest()
        {
            InitializeComponent();
        }

        private AgentController controller;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            controller = new AgentController(axAgent1, "Genie");

            lstAnimations.DataSource = controller.GetAnimations();

            controller.Show();
        }

        private void cmdPlay_Click(object sender, System.EventArgs e)
        {
            controller.Animate(lstAnimations.Text);
        }

        private void cmdStop_Click(object sender, System.EventArgs e)
        {
            controller.StopAll();
        }

        private void cmdSpeak_Click(object sender, System.EventArgs e)
        {
            controller.Speak(txtSpeak.Text);
        }

        private void cmdMove_Click(object sender, System.EventArgs e)
        {
            controller.MoveTo(short.Parse(txtX.Text), short.Parse(txtY.Text));
        }

        private void cmdClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void AgentTest_Load(object sender, EventArgs e)
        {
            controller = new AgentController(axAgent1, "Genie");

            lstAnimations.DataSource = controller.GetAnimations();

            controller.Show();
        }
    }
}