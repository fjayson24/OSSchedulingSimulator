namespace OSProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pnDashboard = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            diskSchedulingContainer = new FlowLayoutPanel();
            panel10 = new Panel();
            diskScheduling = new Button();
            panel11 = new Panel();
            button8 = new Button();
            panel12 = new Panel();
            button9 = new Button();
            panel13 = new Panel();
            button10 = new Button();
            panel14 = new Panel();
            button11 = new Button();
            panel15 = new Panel();
            button6 = new Button();
            panel16 = new Panel();
            button12 = new Button();
            pnExit = new Panel();
            exitButton = new Button();
            cpuSchedulingContainer = new FlowLayoutPanel();
            panel7 = new Panel();
            cpuScheduling = new Button();
            panel8 = new Panel();
            button7 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button2 = new Button();
            panel9 = new Panel();
            button5 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            cpuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            diskTransition = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelChildForm = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            pnDashboard.SuspendLayout();
            diskSchedulingContainer.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            pnExit.SuspendLayout();
            cpuSchedulingContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 39);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 3);
            label1.Name = "label1";
            label1.Size = new Size(442, 32);
            label1.TabIndex = 2;
            label1.Text = "CPU SCHEDULING | OPERATING SYSTEM";
            label1.Click += label1_Click;
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(1, 1);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(42, 37);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(pnDashboard);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(cpuSchedulingContainer);
            sidebar.Controls.Add(diskSchedulingContainer);
            sidebar.Controls.Add(pnExit);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 39);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(220, 553);
            sidebar.TabIndex = 1;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(button1);
            pnDashboard.Location = new Point(3, 3);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(207, 53);
            pnDashboard.TabIndex = 3;
            pnDashboard.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-6, -39);
            button1.Name = "button1";
            button1.Size = new Size(237, 148);
            button1.TabIndex = 2;
            button1.Text = "  Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 0);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // diskSchedulingContainer
            // 
            diskSchedulingContainer.BackColor = Color.FromArgb(23, 24, 29);
            diskSchedulingContainer.Controls.Add(panel10);
            diskSchedulingContainer.Controls.Add(panel11);
            diskSchedulingContainer.Controls.Add(panel12);
            diskSchedulingContainer.Controls.Add(panel13);
            diskSchedulingContainer.Controls.Add(panel14);
            diskSchedulingContainer.Controls.Add(panel15);
            diskSchedulingContainer.Controls.Add(panel16);
            diskSchedulingContainer.Location = new Point(3, 127);
            diskSchedulingContainer.Name = "diskSchedulingContainer";
            diskSchedulingContainer.Size = new Size(207, 53);
            diskSchedulingContainer.TabIndex = 9;
            // 
            // panel10
            // 
            panel10.Controls.Add(diskScheduling);
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(207, 53);
            panel10.TabIndex = 6;
            // 
            // diskScheduling
            // 
            diskScheduling.BackColor = Color.FromArgb(23, 24, 29);
            diskScheduling.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diskScheduling.ForeColor = Color.White;
            diskScheduling.Image = (Image)resources.GetObject("diskScheduling.Image");
            diskScheduling.ImageAlign = ContentAlignment.MiddleLeft;
            diskScheduling.Location = new Point(-6, -63);
            diskScheduling.Name = "diskScheduling";
            diskScheduling.Size = new Size(237, 172);
            diskScheduling.TabIndex = 2;
            diskScheduling.Text = "   Disk Scheduling";
            diskScheduling.UseVisualStyleBackColor = false;
            diskScheduling.Click += diskScheduling_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(button8);
            panel11.Location = new Point(3, 62);
            panel11.Name = "panel11";
            panel11.Size = new Size(207, 53);
            panel11.TabIndex = 6;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(23, 24, 29);
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-6, -56);
            button8.Name = "button8";
            button8.Size = new Size(237, 165);
            button8.TabIndex = 2;
            button8.Text = "  FCFS";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(button9);
            panel12.Location = new Point(3, 121);
            panel12.Name = "panel12";
            panel12.Size = new Size(207, 53);
            panel12.TabIndex = 6;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(23, 24, 29);
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-6, -56);
            button9.Name = "button9";
            button9.Size = new Size(237, 165);
            button9.TabIndex = 2;
            button9.Text = "  SSTF";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(button10);
            panel13.Location = new Point(3, 180);
            panel13.Name = "panel13";
            panel13.Size = new Size(207, 53);
            panel13.TabIndex = 7;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(23, 24, 29);
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(-6, -56);
            button10.Name = "button10";
            button10.Size = new Size(237, 165);
            button10.TabIndex = 2;
            button10.Text = "  SCAN";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // panel14
            // 
            panel14.Controls.Add(button11);
            panel14.Location = new Point(3, 239);
            panel14.Name = "panel14";
            panel14.Size = new Size(207, 53);
            panel14.TabIndex = 9;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(23, 24, 29);
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(-6, -56);
            button11.Name = "button11";
            button11.Size = new Size(237, 165);
            button11.TabIndex = 2;
            button11.Text = "  C-SCAN";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(button6);
            panel15.Location = new Point(3, 298);
            panel15.Name = "panel15";
            panel15.Size = new Size(207, 53);
            panel15.TabIndex = 10;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(23, 24, 29);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-6, -56);
            button6.Name = "button6";
            button6.Size = new Size(237, 165);
            button6.TabIndex = 2;
            button6.Text = "  LOOK";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_2;
            // 
            // panel16
            // 
            panel16.Controls.Add(button12);
            panel16.Location = new Point(3, 357);
            panel16.Name = "panel16";
            panel16.Size = new Size(207, 53);
            panel16.TabIndex = 10;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(23, 24, 29);
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(-6, -56);
            button12.Name = "button12";
            button12.Size = new Size(237, 165);
            button12.TabIndex = 2;
            button12.Text = "  C-LOOK";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // pnExit
            // 
            pnExit.Controls.Add(exitButton);
            pnExit.Location = new Point(3, 186);
            pnExit.Name = "pnExit";
            pnExit.Size = new Size(207, 53);
            pnExit.TabIndex = 11;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(23, 24, 29);
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.White;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.ImageAlign = ContentAlignment.MiddleLeft;
            exitButton.Location = new Point(-6, -56);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(237, 165);
            exitButton.TabIndex = 2;
            exitButton.Text = "  Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // cpuSchedulingContainer
            // 
            cpuSchedulingContainer.BackColor = Color.FromArgb(23, 24, 29);
            cpuSchedulingContainer.Controls.Add(panel7);
            cpuSchedulingContainer.Controls.Add(panel8);
            cpuSchedulingContainer.Controls.Add(panel5);
            cpuSchedulingContainer.Controls.Add(panel6);
            cpuSchedulingContainer.Controls.Add(panel9);
            cpuSchedulingContainer.Location = new Point(3, 68);
            cpuSchedulingContainer.Name = "cpuSchedulingContainer";
            cpuSchedulingContainer.Size = new Size(207, 53);
            cpuSchedulingContainer.TabIndex = 8;
            cpuSchedulingContainer.Paint += menuContainer_Paint_1;
            // 
            // panel7
            // 
            panel7.Controls.Add(cpuScheduling);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(207, 53);
            panel7.TabIndex = 6;
            // 
            // cpuScheduling
            // 
            cpuScheduling.BackColor = Color.FromArgb(23, 24, 29);
            cpuScheduling.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpuScheduling.ForeColor = Color.White;
            cpuScheduling.Image = (Image)resources.GetObject("cpuScheduling.Image");
            cpuScheduling.ImageAlign = ContentAlignment.MiddleLeft;
            cpuScheduling.Location = new Point(-6, -61);
            cpuScheduling.Name = "cpuScheduling";
            cpuScheduling.Size = new Size(237, 171);
            cpuScheduling.TabIndex = 2;
            cpuScheduling.Text = "   CPU Scheduling";
            cpuScheduling.UseVisualStyleBackColor = false;
            cpuScheduling.Click += menu_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(button7);
            panel8.Location = new Point(3, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(207, 53);
            panel8.TabIndex = 6;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(23, 24, 29);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-6, -56);
            button7.Name = "button7";
            button7.Size = new Size(237, 165);
            button7.TabIndex = 2;
            button7.Text = "  FIFO";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 53);
            panel5.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(23, 24, 29);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-6, -56);
            button4.Name = "button4";
            button4.Size = new Size(237, 165);
            button4.TabIndex = 2;
            button4.Text = "  SJF";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(button2);
            panel6.Location = new Point(3, 180);
            panel6.Name = "panel6";
            panel6.Size = new Size(207, 53);
            panel6.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 24, 29);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-6, -56);
            button2.Name = "button2";
            button2.Size = new Size(237, 165);
            button2.TabIndex = 2;
            button2.Text = "  SRT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // panel9
            // 
            panel9.Controls.Add(button5);
            panel9.Location = new Point(3, 239);
            panel9.Name = "panel9";
            panel9.Size = new Size(207, 53);
            panel9.TabIndex = 9;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(23, 24, 29);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-6, -56);
            button5.Name = "button5";
            button5.Size = new Size(237, 165);
            button5.TabIndex = 2;
            button5.Text = "  RR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(376, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(0, 0);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 24, 29);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-9, -49);
            button3.Name = "button3";
            button3.Size = new Size(237, 165);
            button3.TabIndex = 2;
            button3.Text = "  About";
            button3.UseVisualStyleBackColor = false;
            // 
            // cpuTransition
            // 
            cpuTransition.Interval = 10;
            cpuTransition.Tick += timer1_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += timer1_Tick_1;
            // 
            // diskTransition
            // 
            diskTransition.Interval = 10;
            diskTransition.Tick += diskTransition_Tick;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(220, 39);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(659, 553);
            panelChildForm.TabIndex = 6;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 592);
            Controls.Add(panelChildForm);
            Controls.Add(panel4);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            diskSchedulingContainer.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            pnExit.ResumeLayout(false);
            cpuSchedulingContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button button1;
        private Panel pnDashboard;
        private Panel panel3;
        private Button cpuScheduling;
        private System.Windows.Forms.Timer cpuTransition;
        private FlowLayoutPanel cpuSchedulingContainer;
        private Panel panel4;
        private Button button3;
        private Panel panel7;
        private Panel panel8;
        private Button button7;
        private Panel panel5;
        private Button button4;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel6;
        private Button button2;
        private Panel panel9;
        private Button button5;
        private FlowLayoutPanel diskSchedulingContainer;
        private Panel panel10;
        private Button diskScheduling;
        private Panel panel11;
        private Button button8;
        private Panel panel12;
        private Button button9;
        private Panel panel13;
        private Button button10;
        private Panel panel14;
        private Button button11;
        private Panel panel15;
        private Button button6;
        private Panel panel16;
        private Button button12;
        private System.Windows.Forms.Timer diskTransition;
        private Panel pnExit;
        private Button exitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelChildForm;
    }
}
