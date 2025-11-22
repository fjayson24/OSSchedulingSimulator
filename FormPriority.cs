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
    public partial class FormPriority : Form
    {
        private List<Process> processes = new List<Process>();
        private List<GanttChartItem> ganttChart = new List<GanttChartItem>();

        public FormPriority()
        {
            InitializeComponent();
        }

        private class Process
        {
            public string Name { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }
            public int Priority { get; set; }
            public int RemainingTime { get; set; }
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
                int priority = int.Parse(txtPriority.Text);

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a process name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                processes.Add(new Process
                {
                    Name = name,
                    ArrivalTime = arrival,
                    BurstTime = burst,
                    Priority = priority,
                    RemainingTime = burst
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
                dgvProcesses.Rows.Add(p.Name, p.ArrivalTime, p.BurstTime, p.Priority);
            }
        }

        private void ClearInputs()
        {
            txtProcessName.Clear();
            txtArrivalTime.Clear();
            txtBurstTime.Clear();
            txtPriority.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (processes.Count == 0)
            {
                MessageBox.Show("Please add at least one process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CalculatePriorityScheduling();
            DisplayResults();
        }

        private void CalculatePriorityScheduling()
        {
            ganttChart.Clear();
            var sortedProcesses = processes.OrderBy(p => p.ArrivalTime).ToList();
            var readyQueue = new List<Process>();
            int currentTime = 0;
            int completed = 0;

            // Reset remaining times
            foreach (var p in sortedProcesses)
            {
                p.RemainingTime = p.BurstTime;
            }

            while (completed < sortedProcesses.Count)
            {
                // Add processes that have arrived
                foreach (var p in sortedProcesses)
                {
                    if (p.ArrivalTime <= currentTime && p.RemainingTime > 0 && !readyQueue.Contains(p))
                    {
                        readyQueue.Add(p);
                    }
                }

                if (readyQueue.Count == 0)
                {
                    currentTime++;
                    continue;
                }

                // Select process with highest priority (lower number = higher priority)
                var currentProcess = readyQueue.OrderBy(p => p.Priority).ThenBy(p => p.ArrivalTime).First();
                readyQueue.Remove(currentProcess);

                int startTime = currentTime;
                currentTime += currentProcess.BurstTime;
                currentProcess.RemainingTime = 0;
                currentProcess.CompletionTime = currentTime;
                completed++;

                ganttChart.Add(new GanttChartItem
                {
                    ProcessName = currentProcess.Name,
                    StartTime = startTime,
                    EndTime = currentTime
                });

                // Calculate turnaround and waiting time
                currentProcess.TurnaroundTime = currentProcess.CompletionTime - currentProcess.ArrivalTime;
                currentProcess.WaitingTime = currentProcess.TurnaroundTime - currentProcess.BurstTime;
            }
        }

        private void DisplayResults()
        {
            dgvResults.Rows.Clear();
            double totalWaiting = 0, totalTurnaround = 0;

            foreach (var p in processes.OrderBy(p => p.ArrivalTime))
            {
                dgvResults.Rows.Add(p.Name, p.ArrivalTime, p.BurstTime, p.Priority,
                    p.CompletionTime, p.TurnaroundTime, p.WaitingTime);
                totalWaiting += p.WaitingTime;
                totalTurnaround += p.TurnaroundTime;
            }

            lblAvgWaiting.Text = $"Average Waiting Time: {(totalWaiting / processes.Count):F2}";
            lblAvgTurnaround.Text = $"Average Turnaround Time: {(totalTurnaround / processes.Count):F2}";

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
                    Text = $"{item.ProcessName}\n({item.StartTime}-{item.EndTime})",
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
            lblAvgWaiting.Text = "Average Waiting Time: 0.00";
            lblAvgTurnaround.Text = "Average Turnaround Time: 0.00";
            ClearInputs();
        }
    }
}

