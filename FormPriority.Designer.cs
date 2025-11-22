namespace OSProject
{
    partial class FormPriority
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblProcessName;
        private Label lblArrivalTime;
        private Label lblBurstTime;
        private Label lblPriority;
        private TextBox txtProcessName;
        private TextBox txtArrivalTime;
        private TextBox txtBurstTime;
        private TextBox txtPriority;
        private Button btnAddProcess;
        private Button btnCalculate;
        private Button btnClear;
        private DataGridView dgvProcesses;
        private DataGridView dgvResults;
        private Panel panelGantt;
        private Label lblAvgWaiting;
        private Label lblAvgTurnaround;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblProcessName = new Label();
            lblArrivalTime = new Label();
            lblBurstTime = new Label();
            lblPriority = new Label();
            txtProcessName = new TextBox();
            txtArrivalTime = new TextBox();
            txtBurstTime = new TextBox();
            txtPriority = new TextBox();
            btnAddProcess = new Button();
            btnCalculate = new Button();
            btnClear = new Button();
            dgvProcesses = new DataGridView();
            dgvResults = new DataGridView();
            panelGantt = new Panel();
            lblAvgWaiting = new Label();
            lblAvgTurnaround = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProcesses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 30);
            lblTitle.Text = "Priority Scheduling";

            // lblProcessName
            lblProcessName.AutoSize = true;
            lblProcessName.Location = new Point(20, 70);
            lblProcessName.Name = "lblProcessName";
            lblProcessName.Text = "Process Name:";

            // txtProcessName
            txtProcessName.Location = new Point(120, 67);
            txtProcessName.Size = new Size(100, 23);

            // lblArrivalTime
            lblArrivalTime.AutoSize = true;
            lblArrivalTime.Location = new Point(240, 70);
            lblArrivalTime.Name = "lblArrivalTime";
            lblArrivalTime.Text = "Arrival Time:";

            // txtArrivalTime
            txtArrivalTime.Location = new Point(330, 67);
            txtArrivalTime.Size = new Size(100, 23);

            // lblBurstTime
            lblBurstTime.AutoSize = true;
            lblBurstTime.Location = new Point(450, 70);
            lblBurstTime.Name = "lblBurstTime";
            lblBurstTime.Text = "Burst Time:";

            // txtBurstTime
            txtBurstTime.Location = new Point(530, 67);
            txtBurstTime.Size = new Size(100, 23);

            // lblPriority
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(650, 70);
            lblPriority.Name = "lblPriority";
            lblPriority.Text = "Priority:";

            // txtPriority
            txtPriority.Location = new Point(710, 67);
            txtPriority.Size = new Size(60, 23);

            // btnAddProcess
            btnAddProcess.BackColor = Color.FromArgb(0, 120, 215);
            btnAddProcess.ForeColor = Color.White;
            btnAddProcess.Location = new Point(20, 110);
            btnAddProcess.Size = new Size(100, 30);
            btnAddProcess.Text = "Add Process";
            btnAddProcess.UseVisualStyleBackColor = false;
            btnAddProcess.Click += btnAddProcess_Click;

            // btnCalculate
            btnCalculate.BackColor = Color.FromArgb(16, 124, 16);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(130, 110);
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;

            // btnClear
            btnClear.BackColor = Color.FromArgb(196, 43, 28);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(240, 110);
            btnClear.Size = new Size(100, 30);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // dgvProcesses
            dgvProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcesses.Location = new Point(20, 160);
            dgvProcesses.Size = new Size(750, 120);
            dgvProcesses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProcesses.Columns.Add("Process", "Process");
            dgvProcesses.Columns.Add("Arrival", "Arrival Time");
            dgvProcesses.Columns.Add("Burst", "Burst Time");
            dgvProcesses.Columns.Add("Priority", "Priority");
            dgvProcesses.ReadOnly = true;

            // dgvResults
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(20, 300);
            dgvResults.Size = new Size(750, 120);
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.Columns.Add("Process", "Process");
            dgvResults.Columns.Add("Arrival", "Arrival Time");
            dgvResults.Columns.Add("Burst", "Burst Time");
            dgvResults.Columns.Add("Priority", "Priority");
            dgvResults.Columns.Add("Completion", "Completion Time");
            dgvResults.Columns.Add("Turnaround", "Turnaround Time");
            dgvResults.Columns.Add("Waiting", "Waiting Time");
            dgvResults.ReadOnly = true;

            // lblAvgWaiting
            lblAvgWaiting.AutoSize = true;
            lblAvgWaiting.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvgWaiting.Location = new Point(20, 430);
            lblAvgWaiting.Name = "lblAvgWaiting";
            lblAvgWaiting.Text = "Average Waiting Time: 0.00";

            // lblAvgTurnaround
            lblAvgTurnaround.AutoSize = true;
            lblAvgTurnaround.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvgTurnaround.Location = new Point(20, 455);
            lblAvgTurnaround.Name = "lblAvgTurnaround";
            lblAvgTurnaround.Text = "Average Turnaround Time: 0.00";

            // panelGantt
            panelGantt.AutoScroll = true;
            panelGantt.BorderStyle = BorderStyle.FixedSingle;
            panelGantt.Location = new Point(20, 485);
            panelGantt.Size = new Size(750, 60);
            panelGantt.BackColor = Color.White;

            // FormPriority
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(lblTitle);
            Controls.Add(lblProcessName);
            Controls.Add(lblArrivalTime);
            Controls.Add(lblBurstTime);
            Controls.Add(lblPriority);
            Controls.Add(txtProcessName);
            Controls.Add(txtArrivalTime);
            Controls.Add(txtBurstTime);
            Controls.Add(txtPriority);
            Controls.Add(btnAddProcess);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(dgvProcesses);
            Controls.Add(dgvResults);
            Controls.Add(lblAvgWaiting);
            Controls.Add(lblAvgTurnaround);
            Controls.Add(panelGantt);
            Name = "FormPriority";
            Text = "Priority Scheduling";
            BackColor = Color.White;

            ((System.ComponentModel.ISupportInitialize)dgvProcesses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

