namespace OSProject
{
    partial class FormDASHBOARD
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Label lblDescription;
        private Label lblCPUAlgorithms;
        private Label lblCPUList;
        private Label lblDiskAlgorithms;
        private Label lblDiskList;
        private Label lblFeatures;
        private Label lblFeaturesList;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblDescription = new Label();
            lblCPUAlgorithms = new Label();
            lblCPUList = new Label();
            lblDiskAlgorithms = new Label();
            lblDiskList = new Label();
            lblFeatures = new Label();
            lblFeaturesList = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.Location = new Point(50, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(700, 37);
            lblWelcome.Text = "Welcome to Operating System Scheduling Simulator";

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(50, 80);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(600, 21);
            lblDescription.Text = "This application provides comprehensive simulation of CPU and Disk Scheduling algorithms.";

            // panel1
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(50, 130);
            panel1.Size = new Size(300, 200);
            panel1.BackColor = Color.FromArgb(240, 240, 240);

            // lblCPUAlgorithms
            lblCPUAlgorithms.AutoSize = true;
            lblCPUAlgorithms.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCPUAlgorithms.Location = new Point(10, 10);
            lblCPUAlgorithms.Name = "lblCPUAlgorithms";
            lblCPUAlgorithms.Text = "CPU Scheduling Algorithms:";

            // lblCPUList
            lblCPUList.AutoSize = true;
            lblCPUList.Font = new Font("Segoe UI", 10F);
            lblCPUList.Location = new Point(10, 45);
            lblCPUList.Name = "lblCPUList";
            lblCPUList.Size = new Size(280, 150);
            lblCPUList.Text = "";

            panel1.Controls.Add(lblCPUAlgorithms);
            panel1.Controls.Add(lblCPUList);

            // panel2
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(370, 130);
            panel2.Size = new Size(300, 200);
            panel2.BackColor = Color.FromArgb(240, 240, 240);

            // lblDiskAlgorithms
            lblDiskAlgorithms.AutoSize = true;
            lblDiskAlgorithms.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDiskAlgorithms.Location = new Point(10, 10);
            lblDiskAlgorithms.Name = "lblDiskAlgorithms";
            lblDiskAlgorithms.Text = "Disk Scheduling Algorithms:";

            // lblDiskList
            lblDiskList.AutoSize = true;
            lblDiskList.Font = new Font("Segoe UI", 10F);
            lblDiskList.Location = new Point(10, 45);
            lblDiskList.Name = "lblDiskList";
            lblDiskList.Size = new Size(280, 150);
            lblDiskList.Text = "";

            panel2.Controls.Add(lblDiskAlgorithms);
            panel2.Controls.Add(lblDiskList);

            // panel3
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(50, 350);
            panel3.Size = new Size(620, 150);
            panel3.BackColor = Color.FromArgb(240, 240, 240);

            // lblFeatures
            lblFeatures.AutoSize = true;
            lblFeatures.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFeatures.Location = new Point(10, 10);
            lblFeatures.Name = "lblFeatures";
            lblFeatures.Text = "Features:";

            // lblFeaturesList
            lblFeaturesList.AutoSize = true;
            lblFeaturesList.Font = new Font("Segoe UI", 10F);
            lblFeaturesList.Location = new Point(10, 45);
            lblFeaturesList.Name = "lblFeaturesList";
            lblFeaturesList.Size = new Size(600, 100);
            lblFeaturesList.Text = "";

            panel3.Controls.Add(lblFeatures);
            panel3.Controls.Add(lblFeaturesList);

            // FormDASHBOARD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(lblWelcome);
            Controls.Add(lblDescription);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "FormDASHBOARD";
            Text = "Dashboard";
            BackColor = Color.White;
            Load += FormDASHBOARD_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
