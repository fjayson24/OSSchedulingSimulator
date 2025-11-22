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
            childForm.BringToFront();                   // make sure it’s on top
            childForm.Show();                           // display it
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                if (cpuSchedulingContainer.Height >= 292)
                {
                    cpuTransition.Stop();
                    cpuExpand = true;
                }
            }
            else
            {
                cpuSchedulingContainer.Height -= 10;
                if (cpuSchedulingContainer.Height <= 53)
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
                if (sidebar.Width <= 60)
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
                if (diskSchedulingContainer.Height >= 410)
                {
                    diskTransition.Stop();
                    diskExpand = true;
                }
            }
            else
            {
                diskSchedulingContainer.Height -= 10;
                if (diskSchedulingContainer.Height <= 53)
                {
                    diskTransition.Stop();
                    diskExpand = false;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

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
    }
}
