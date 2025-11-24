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
    public partial class FormFIFO : Form
    {
        private List<Process> processes = new List<Process>();
        private List<GanttChartItem> ganttChart = new List<GanttChartItem>();

        public FormFIFO()
        {
            InitializeComponent();
        }

        private class Process
        {
            public string Name { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }
            public int CompletionTime { get; set; }
            public int TurnaroundTime { get; set; }
            public int WaitingTime { get; set; }
        }

        private class GanttChartItem
        {
            public string ProcessName { get; set; }
            public int StartTime { get; set; }
            public int EndTime { get; set; }
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProcessName.Text.Trim();
                int arrival = int.Parse(txtArrivalTime.Text);
                int burst = int.Parse(txtBurstTime.Text);

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a process name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                processes.Add(new Process
                {
                    Name = name,
                    ArrivalTime = arrival,
                    BurstTime = burst
                });

                UpdateProcessList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProcessList()
        {
            dgvProcesses.Rows.Clear();
            foreach (var p in processes)
            {
                dgvProcesses.Rows.Add(p.Name, p.ArrivalTime, p.BurstTime);
            }
        }

        private void ClearInputs()
        {
            txtProcessName.Clear();
            txtArrivalTime.Clear();
            txtBurstTime.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (processes.Count == 0)
            {
                MessageBox.Show("Please add at least one process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CalculateFIFO();
            DisplayResults();
        }

        private void CalculateFIFO()
        {
            ganttChart.Clear();
            var sortedProcesses = processes.OrderBy(p => p.ArrivalTime).ToList();
            int currentTime = 0;

            foreach (var p in sortedProcesses)
            {
                if (currentTime < p.ArrivalTime)
                    currentTime = p.ArrivalTime;

                int startTime = currentTime;
                currentTime += p.BurstTime;
                p.CompletionTime = currentTime;
                p.TurnaroundTime = p.CompletionTime - p.ArrivalTime;
                p.WaitingTime = p.TurnaroundTime - p.BurstTime;

                ganttChart.Add(new GanttChartItem
                {
                    ProcessName = p.Name,
                    StartTime = startTime,
                    EndTime = currentTime
                });
            }
        }

        private void DisplayResults()
        {
            dgvResults.Rows.Clear();
            double totalWaiting = 0, totalTurnaround = 0;

            foreach (var p in processes.OrderBy(p => p.ArrivalTime))
            {
                dgvResults.Rows.Add(p.Name, p.ArrivalTime, p.BurstTime,
                    p.CompletionTime, p.TurnaroundTime, p.WaitingTime);
                totalWaiting += p.WaitingTime;
                totalTurnaround += p.TurnaroundTime;
            }

            lblAvgWaiting.Text = $"Average Waiting Time: {(totalWaiting / processes.Count):F2} ms";
            lblAvgTurnaround.Text = $"Average Turnaround Time: {(totalTurnaround / processes.Count):F2} ms";

            DrawGanttChart();
        }

        private void DrawGanttChart()
        {
            panelGantt.Controls.Clear();
            if (ganttChart.Count == 0) return;

            int x = 10;
            int y = 10;
            int height = 40;
            int maxTime = ganttChart.Max(g => g.EndTime);
            int panelWidth = panelGantt.Width - 20;
            int scale = Math.Max(1, panelWidth / (maxTime + 1));

            foreach (var item in ganttChart)
            {
                int width = (item.EndTime - item.StartTime) * scale;
                if (width < 30) width = 30;

                Label lbl = new Label
                {
                    Text = $"{item.ProcessName}\n({item.StartTime}-{item.EndTime} ms)",
                    Location = new Point(x, y),
                    Size = new Size(width, height),
                    BackColor = GetProcessColor(item.ProcessName),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    BorderStyle = BorderStyle.FixedSingle
                };
                panelGantt.Controls.Add(lbl);
                x += width + 2;
            }
        }

        private Color GetProcessColor(string processName)
        {
            int hash = processName.GetHashCode();
            Random rnd = new Random(Math.Abs(hash));
            return Color.FromArgb(100 + rnd.Next(100), 100 + rnd.Next(100), 200 + rnd.Next(56));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            processes.Clear();
            ganttChart.Clear();
            dgvProcesses.Rows.Clear();
            dgvResults.Rows.Clear();
            panelGantt.Controls.Clear();
            lblAvgWaiting.Text = "Average Waiting Time: 0.00 ms";
            lblAvgTurnaround.Text = "Average Turnaround Time: 0.00 ms";
            ClearInputs();
        }
    }
}
