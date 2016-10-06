namespace ContainerControls
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container2 = new ContainerControls.Container();
            this.containerChild1 = new ContainerControls.ContainerChild();
            this.container1 = new ContainerControls.Container();
            this.containerChild3 = new ContainerControls.ContainerChild();
            this.containerChild2 = new ContainerControls.ContainerChild();
            this.containerChild4 = new ContainerControls.ContainerChild();
            this.container2.SuspendLayout();
            this.container1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container2
            // 
            this.container2.Controls.Add(this.containerChild1);
            this.container2.Location = new System.Drawing.Point(76, 9);
            this.container2.Name = "container2";
            this.container2.Size = new System.Drawing.Size(202, 88);
            this.container2.TabIndex = 8;
            this.container2.Text = "container2";
            // 
            // containerChild1
            // 
            this.containerChild1.Location = new System.Drawing.Point(42, 32);
            this.containerChild1.Name = "containerChild1";
            this.containerChild1.Size = new System.Drawing.Size(88, 23);
            this.containerChild1.TabIndex = 0;
            this.containerChild1.Text = "containerChild1";
            // 
            // container1
            // 
            this.container1.Controls.Add(this.containerChild4);
            this.container1.Controls.Add(this.containerChild3);
            this.container1.Controls.Add(this.containerChild2);
            this.container1.Location = new System.Drawing.Point(76, 128);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(202, 148);
            this.container1.TabIndex = 7;
            this.container1.Text = "container1";
            // 
            // containerChild3
            // 
            this.containerChild3.Location = new System.Drawing.Point(64, 30);
            this.containerChild3.Name = "containerChild3";
            this.containerChild3.Size = new System.Drawing.Size(91, 23);
            this.containerChild3.TabIndex = 1;
            this.containerChild3.Text = "containerChild3";
            // 
            // containerChild2
            // 
            this.containerChild2.Location = new System.Drawing.Point(23, 76);
            this.containerChild2.Name = "containerChild2";
            this.containerChild2.Size = new System.Drawing.Size(90, 23);
            this.containerChild2.TabIndex = 0;
            this.containerChild2.Text = "containerChild2";
            // 
            // containerChild4
            // 
            this.containerChild4.Location = new System.Drawing.Point(101, 106);
            this.containerChild4.Name = "containerChild4";
            this.containerChild4.Size = new System.Drawing.Size(75, 23);
            this.containerChild4.TabIndex = 2;
            this.containerChild4.Text = "containerChild4";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 288);
            this.Controls.Add(this.container2);
            this.Controls.Add(this.container1);
            this.Name = "Test";
            this.Text = "Test";
            this.container2.ResumeLayout(false);
            this.container1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Container container2;
        private ContainerChild containerChild1;
        private Container container1;
        private ContainerChild containerChild3;
        private ContainerChild containerChild2;
        private ContainerChild containerChild4;

    }
}