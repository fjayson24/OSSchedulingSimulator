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
    public partial class FormCSCAN : Form
    {
        private List<int> requests = new List<int>();
        private List<int> sequence = new List<int>();

        public FormCSCAN()
        {
            InitializeComponent();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int track = int.Parse(txtTrack.Text);
                if (track < 0 || track > 199)
                {
                    MessageBox.Show("Track number must be between 0 and 199.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                requests.Add(track);
                UpdateRequestList();
                txtTrack.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRequestList()
        {
            dgvRequests.Rows.Clear();
            foreach (var req in requests)
            {
                dgvRequests.Rows.Add(new object[] { req });
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("Please add at least one request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int head;
            if (!int.TryParse(txtHeadPosition.Text, out head) || head < 0 || head > 199)
            {
                MessageBox.Show("Please enter a valid head position (0-199).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CalculateCSCAN(head);
            DisplayResults();
        }

        private void CalculateCSCAN(int head)
        {
            sequence.Clear();
            sequence.Add(head);
            int currentHead = head;
            var remainingRequests = new List<int>(requests);
            int totalSeek = 0;

            // Move right to end
            var rightRequests = remainingRequests.Where(r => r >= head).OrderBy(r => r).ToList();
            foreach (var req in rightRequests)
            {
                totalSeek += Math.Abs(req - currentHead);
                currentHead = req;
                sequence.Add(req);
                remainingRequests.Remove(req);
            }
            // Go to end
            if (currentHead < 199)
            {
                totalSeek += 199 - currentHead;
                currentHead = 199;
                sequence.Add(199);
            }
            // Jump to start (only if there are remaining requests)
            if (remainingRequests.Count > 0)
            {
                // In C-SCAN, we always go to end (199) then jump to start (0)
                // The seek time for jumping from 199 to 0 is 199
                totalSeek += 199;
                currentHead = 0;
                sequence.Add(0);
            }
            // Move right from start
            var leftRequests = remainingRequests.OrderBy(r => r).ToList();
            foreach (var req in leftRequests)
            {
                totalSeek += Math.Abs(req - currentHead);
                currentHead = req;
                sequence.Add(req);
            }

            lblTotalSeek.Text = $"Total Seek Time: {totalSeek}";
            lblAvgSeek.Text = $"Average Seek Time: {(double)totalSeek / requests.Count:F2}";
        }

        private void DisplayResults()
        {
            dgvSequence.Rows.Clear();
            for (int i = 0; i < sequence.Count; i++)
            {
                int seek = i > 0 ? Math.Abs(sequence[i] - sequence[i - 1]) : 0;
                dgvSequence.Rows.Add(i, sequence[i], seek);
            }
            DrawVisualization();
        }

        private void DrawVisualization()
        {
            panelVisualization.Controls.Clear();
            if (sequence.Count == 0) return;

            int panelHeight = panelVisualization.Height - 40;
            int maxTrack = 199;
            int scale = panelHeight / (maxTrack + 1);

            int x = 20;
            int spacing = (panelVisualization.Width - 40) / Math.Max(sequence.Count, 1);

            for (int i = 0; i < sequence.Count; i++)
            {
                int y = panelHeight - (sequence[i] * scale);
                Label lbl = new Label
                {
                    Text = sequence[i].ToString(),
                    Location = new Point(x, y - 10),
                    Size = new Size(40, 20),
                    BackColor = Color.Blue,
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold)
                };
                panelVisualization.Controls.Add(lbl);

                if (i < sequence.Count - 1)
                {
                    int nextY = panelHeight - (sequence[i + 1] * scale);
                    Panel line = new Panel
                    {
                        Location = new Point(x + 20, Math.Min(y, nextY)),
                        Size = new Size(spacing - 20, Math.Abs(y - nextY) + 1),
                        BackColor = Color.Red
                    };
                    panelVisualization.Controls.Add(line);
                    line.SendToBack();
                }

                x += spacing;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            requests.Clear();
            sequence.Clear();
            dgvRequests.Rows.Clear();
            dgvSequence.Rows.Clear();
            panelVisualization.Controls.Clear();
            txtHeadPosition.Clear();
            txtTrack.Clear();
            lblTotalSeek.Text = "Total Seek Time: 0";
            lblAvgSeek.Text = "Average Seek Time: 0.00";
        }
    }
}
