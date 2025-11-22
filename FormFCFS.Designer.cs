namespace OSProject
{
    partial class FormFCFS
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblHeadPosition;
        private Label lblTrack;
        private TextBox txtHeadPosition;
        private TextBox txtTrack;
        private Button btnAddRequest;
        private Button btnCalculate;
        private Button btnClear;
        private DataGridView dgvRequests;
        private DataGridView dgvSequence;
        private Panel panelVisualization;
        private Label lblTotalSeek;
        private Label lblAvgSeek;

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
            lblTitle = new Label();
            lblHeadPosition = new Label();
            lblTrack = new Label();
            txtHeadPosition = new TextBox();
            txtTrack = new TextBox();
            btnAddRequest = new Button();
            btnCalculate = new Button();
            btnClear = new Button();
            dgvRequests = new DataGridView();
            dgvSequence = new DataGridView();
            panelVisualization = new Panel();
            lblTotalSeek = new Label();
            lblAvgSeek = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSequence).BeginInit();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 30);
            lblTitle.Text = "FCFS Disk Scheduling";

            lblHeadPosition.AutoSize = true;
            lblHeadPosition.Location = new Point(20, 70);
            lblHeadPosition.Name = "lblHeadPosition";
            lblHeadPosition.Text = "Head Position:";

            txtHeadPosition.Location = new Point(120, 67);
            txtHeadPosition.Size = new Size(100, 23);
            txtHeadPosition.Text = "50";

            lblTrack.AutoSize = true;
            lblTrack.Location = new Point(240, 70);
            lblTrack.Name = "lblTrack";
            lblTrack.Text = "Track Number:";

            txtTrack.Location = new Point(340, 67);
            txtTrack.Size = new Size(100, 23);

            btnAddRequest.BackColor = Color.FromArgb(0, 120, 215);
            btnAddRequest.ForeColor = Color.White;
            btnAddRequest.Location = new Point(20, 110);
            btnAddRequest.Size = new Size(100, 30);
            btnAddRequest.Text = "Add Request";
            btnAddRequest.UseVisualStyleBackColor = false;
            btnAddRequest.Click += btnAddRequest_Click;

            btnCalculate.BackColor = Color.FromArgb(16, 124, 16);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(130, 110);
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;

            btnClear.BackColor = Color.FromArgb(196, 43, 28);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(240, 110);
            btnClear.Size = new Size(100, 30);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(20, 160);
            dgvRequests.Size = new Size(200, 150);
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.Columns.Add("Track", "Track");
            dgvRequests.ReadOnly = true;

            dgvSequence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSequence.Location = new Point(240, 160);
            dgvSequence.Size = new Size(530, 150);
            dgvSequence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSequence.Columns.Add("Step", "Step");
            dgvSequence.Columns.Add("Track", "Track");
            dgvSequence.Columns.Add("Seek", "Seek Time");
            dgvSequence.ReadOnly = true;

            lblTotalSeek.AutoSize = true;
            lblTotalSeek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalSeek.Location = new Point(20, 320);
            lblTotalSeek.Name = "lblTotalSeek";
            lblTotalSeek.Text = "Total Seek Time: 0";

            lblAvgSeek.AutoSize = true;
            lblAvgSeek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvgSeek.Location = new Point(20, 345);
            lblAvgSeek.Name = "lblAvgSeek";
            lblAvgSeek.Text = "Average Seek Time: 0.00";

            panelVisualization.AutoScroll = true;
            panelVisualization.BorderStyle = BorderStyle.FixedSingle;
            panelVisualization.Location = new Point(20, 375);
            panelVisualization.Size = new Size(750, 150);
            panelVisualization.BackColor = Color.White;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(lblTitle);
            Controls.Add(lblHeadPosition);
            Controls.Add(lblTrack);
            Controls.Add(txtHeadPosition);
            Controls.Add(txtTrack);
            Controls.Add(btnAddRequest);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(dgvRequests);
            Controls.Add(dgvSequence);
            Controls.Add(lblTotalSeek);
            Controls.Add(lblAvgSeek);
            Controls.Add(panelVisualization);
            Name = "FormFCFS";
            Text = "FCFS Disk Scheduling";
            BackColor = Color.White;

            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSequence).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
