using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSProject
{
    public partial class FormDASHBOARD : Form
    {
        public FormDASHBOARD()
        {
            InitializeComponent();
        }

        private void FormDASHBOARD_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to Operating System Scheduling Simulator";
            lblDescription.Text = "This application provides comprehensive simulation of CPU and Disk Scheduling algorithms.";
            
            // CPU Scheduling Algorithms
            lblCPUAlgorithms.Text = "CPU Scheduling Algorithms:";
            lblCPUList.Text = "• FIFO (First Come First Served)\n" +
                            "• SJF (Shortest Job First)\n" +
                            "• SRT (Shortest Remaining Time)\n" +
                            "• Round Robin (RR)\n" +
                            "• Priority Scheduling";

            // Disk Scheduling Algorithms
            lblDiskAlgorithms.Text = "Disk Scheduling Algorithms:";
            lblDiskList.Text = "• FCFS (First Come First Served)\n" +
                             "• SSTF (Shortest Seek Time First)\n" +
                             "• SCAN\n" +
                             "• C-SCAN\n" +
                             "• LOOK\n" +
                             "• C-LOOK";

            lblFeatures.Text = "Features:";
            lblFeaturesList.Text = "✓ Interactive Gantt Charts\n" +
                                  "✓ Visual Disk Movement\n" +
                                  "✓ Performance Metrics\n" +
                                  "✓ Average Waiting/Turnaround Times\n" +
                                  "✓ Seek Time Calculations";
        }
    }
}
