namespace OSProject
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        bool cpuExpand = false;
        bool diskExpand = false;
        private Form activeForm = null;
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private void OpenChildForm(Form childForm)
        {
            // Close the current child form if there is one
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;                 // makes it a "control" instead of a top-level window
            childForm.FormBorderStyle = FormBorderStyle.None; // remove window borders
            childForm.Dock = DockStyle.Fill;            // fill the panel
            panelChildForm.Controls.Add(childForm);    // add to panel
            panelChildForm.Tag = childForm;
            childForm.BringToFront();                   // make sure it�s on top
            childForm.Show();                           // display it
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Enable window dragging
            panel1.MouseDown += Panel_MouseDown;
            panel1.MouseMove += Panel_MouseMove;
            panel1.MouseUp += Panel_MouseUp;
            label1.MouseDown += Panel_MouseDown;
            label1.MouseMove += Panel_MouseMove;
            label1.MouseUp += Panel_MouseUp;

            // Improve UI styling
            ApplyModernStyling();

            // Setup close button hover effects
            btnClose.MouseEnter += BtnClose_MouseEnter;
            btnClose.MouseLeave += BtnClose_MouseLeave;

            // Open Dashboard by default
            OpenChildForm(new FormDASHBOARD());
        }

        private void BtnClose_MouseEnter(object? sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void BtnClose_MouseLeave(object? sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void ApplyModernStyling()
        {
            // Set modern color scheme
            this.BackColor = Color.FromArgb(245, 245, 250);

            // Style all buttons with hover effects
            StyleButton(button1);
            StyleButton(cpuScheduling);
            StyleButton(diskScheduling);
            StyleButton(exitButton);

            // Style submenu buttons with different hover color
            StyleSubButton(button7);
            StyleSubButton(button4);
            StyleSubButton(button2);
            StyleSubButton(button5);
            StyleSubButton(button13);
            StyleSubButton(button8);
            StyleSubButton(button9);
            StyleSubButton(button10);
            StyleSubButton(button11);
            StyleSubButton(button6);
            StyleSubButton(button12);
        }

        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(35, 36, 42);
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(23, 24, 29);
            };
        }

        private void StyleSubButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(40, 40, 50);
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(30, 30, 40);
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDASHBOARD());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cpuExpand == false)
            {
                cpuSchedulingContainer.Height += 10;
                if (cpuSchedulingContainer.Height >= 313)
                {
                    cpuTransition.Stop();
                    cpuExpand = true;
                }
            }
            else
            {
                cpuSchedulingContainer.Height -= 10;
                if (cpuSchedulingContainer.Height <= 54)
                {
                    cpuTransition.Stop();
                    cpuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            cpuTransition.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnExit.Width = sidebar.Width;
                    cpuSchedulingContainer.Width = sidebar.Width;
                    diskSchedulingContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 220)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnExit.Width = sidebar.Width;
                    cpuSchedulingContainer.Width = sidebar.Width;
                    diskSchedulingContainer.Width = sidebar.Width;


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCSCAN());
        }

        private void diskScheduling_Click(object sender, EventArgs e)
        {
            diskTransition.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void diskTransition_Tick(object sender, EventArgs e)
        {
            if (diskExpand == false)
            {
                diskSchedulingContainer.Height += 10;
                if (diskSchedulingContainer.Height >= 361)
                {
                    diskTransition.Stop();
                    diskExpand = true;
                }
            }
            else
            {
                diskSchedulingContainer.Height -= 10;
                if (diskSchedulingContainer.Height <= 52)
                {
                    diskTransition.Stop();
                    diskExpand = false;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPriority());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFIFO());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormSJF());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormSRT());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRR());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFCFS());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSSTF());
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormSCAN());
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new FormLOOK());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCLOOK());
        }

        private void diskSchedulingContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
