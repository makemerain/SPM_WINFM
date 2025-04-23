namespace SPM_WINFM
{
    partial class FrmDataAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            Dtp_TrainDepartureTime = new DateTimePicker();
            Btn_IdentifyTrainDeparture = new Button();
            Dgv_Analysis = new DataGridView();
            RunDateAndTime = new DataGridViewTextBoxColumn();
            RotationalDistanceCounter = new DataGridViewTextBoxColumn();
            CumulativeDistanceCounter = new DataGridViewTextBoxColumn();
            HectometerNumber = new DataGridViewTextBoxColumn();
            TrainSpeed = new DataGridViewTextBoxColumn();
            SectionalSpeed = new DataGridViewTextBoxColumn();
            CautionSpotSpeed = new DataGridViewTextBoxColumn();
            TractiveEffort = new DataGridViewTextBoxColumn();
            BPpressureMetric = new DataGridViewTextBoxColumn();
            BCpressureMetric = new DataGridViewTextBoxColumn();
            Throttle = new DataGridViewTextBoxColumn();
            Horn = new DataGridViewTextBoxColumn();
            Observation = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Analysis).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 192);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1242, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Params";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4958458F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5041542F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(Dtp_TrainDepartureTime, 1, 0);
            tableLayoutPanel1.Controls.Add(Btn_IdentifyTrainDeparture, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 18);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.7611923F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.2388077F));
            tableLayoutPanel1.Size = new Size(442, 67);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "Identify Departure Time : ";
            // 
            // Dtp_TrainDepartureTime
            // 
            Dtp_TrainDepartureTime.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_TrainDepartureTime.Format = DateTimePickerFormat.Custom;
            Dtp_TrainDepartureTime.Location = new Point(274, 3);
            Dtp_TrainDepartureTime.Name = "Dtp_TrainDepartureTime";
            Dtp_TrainDepartureTime.Size = new Size(165, 27);
            Dtp_TrainDepartureTime.TabIndex = 1;
            // 
            // Btn_IdentifyTrainDeparture
            // 
            Btn_IdentifyTrainDeparture.Location = new Point(274, 35);
            Btn_IdentifyTrainDeparture.Name = "Btn_IdentifyTrainDeparture";
            Btn_IdentifyTrainDeparture.Size = new Size(75, 23);
            Btn_IdentifyTrainDeparture.TabIndex = 2;
            Btn_IdentifyTrainDeparture.Text = "Find Train Departure";
            Btn_IdentifyTrainDeparture.UseVisualStyleBackColor = true;
            // 
            // Dgv_Analysis
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgv_Analysis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgv_Analysis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Analysis.Columns.AddRange(new DataGridViewColumn[] { RunDateAndTime, RotationalDistanceCounter, CumulativeDistanceCounter, HectometerNumber, TrainSpeed, SectionalSpeed, CautionSpotSpeed, TractiveEffort, BPpressureMetric, BCpressureMetric, Throttle, Horn, Observation });
            Dgv_Analysis.Dock = DockStyle.Fill;
            Dgv_Analysis.EnableHeadersVisualStyles = false;
            Dgv_Analysis.Location = new Point(0, 91);
            Dgv_Analysis.Name = "Dgv_Analysis";
            Dgv_Analysis.RowHeadersWidth = 51;
            Dgv_Analysis.Size = new Size(1242, 487);
            Dgv_Analysis.TabIndex = 1;
            // 
            // RunDateAndTime
            // 
            RunDateAndTime.DataPropertyName = "RunDateAndTime";
            RunDateAndTime.HeaderText = "RUN TIME";
            RunDateAndTime.MinimumWidth = 6;
            RunDateAndTime.Name = "RunDateAndTime";
            RunDateAndTime.ReadOnly = true;
            RunDateAndTime.Width = 125;
            // 
            // RotationalDistanceCounter
            // 
            RotationalDistanceCounter.DataPropertyName = "RotationalDistanceCounter";
            RotationalDistanceCounter.HeaderText = "DISTANCE";
            RotationalDistanceCounter.MinimumWidth = 6;
            RotationalDistanceCounter.Name = "RotationalDistanceCounter";
            RotationalDistanceCounter.ReadOnly = true;
            RotationalDistanceCounter.Width = 125;
            // 
            // CumulativeDistanceCounter
            // 
            CumulativeDistanceCounter.DataPropertyName = "CumulativeDistanceCounter";
            CumulativeDistanceCounter.HeaderText = "CUM-DIST";
            CumulativeDistanceCounter.MinimumWidth = 6;
            CumulativeDistanceCounter.Name = "CumulativeDistanceCounter";
            CumulativeDistanceCounter.ReadOnly = true;
            CumulativeDistanceCounter.Width = 125;
            // 
            // HectometerNumber
            // 
            HectometerNumber.DataPropertyName = "HectometerNumber";
            HectometerNumber.HeaderText = "HECTO";
            HectometerNumber.MinimumWidth = 6;
            HectometerNumber.Name = "HectometerNumber";
            HectometerNumber.ReadOnly = true;
            HectometerNumber.Width = 125;
            // 
            // TrainSpeed
            // 
            TrainSpeed.DataPropertyName = "TrainSpeed";
            TrainSpeed.HeaderText = "SPEED";
            TrainSpeed.MinimumWidth = 6;
            TrainSpeed.Name = "TrainSpeed";
            TrainSpeed.ReadOnly = true;
            TrainSpeed.Width = 125;
            // 
            // SectionalSpeed
            // 
            SectionalSpeed.HeaderText = "SEC-SP";
            SectionalSpeed.MinimumWidth = 6;
            SectionalSpeed.Name = "SectionalSpeed";
            SectionalSpeed.ReadOnly = true;
            SectionalSpeed.Width = 125;
            // 
            // CautionSpotSpeed
            // 
            CautionSpotSpeed.HeaderText = "CD-SP";
            CautionSpotSpeed.MinimumWidth = 6;
            CautionSpotSpeed.Name = "CautionSpotSpeed";
            CautionSpotSpeed.ReadOnly = true;
            CautionSpotSpeed.Width = 125;
            // 
            // TractiveEffort
            // 
            TractiveEffort.DataPropertyName = "TractiveEffort";
            TractiveEffort.HeaderText = "TE / BE";
            TractiveEffort.MinimumWidth = 6;
            TractiveEffort.Name = "TractiveEffort";
            TractiveEffort.ReadOnly = true;
            TractiveEffort.Width = 125;
            // 
            // BPpressureMetric
            // 
            BPpressureMetric.DataPropertyName = "BPpressureMetric";
            BPpressureMetric.HeaderText = "BPP";
            BPpressureMetric.MinimumWidth = 6;
            BPpressureMetric.Name = "BPpressureMetric";
            BPpressureMetric.ReadOnly = true;
            BPpressureMetric.Width = 125;
            // 
            // BCpressureMetric
            // 
            BCpressureMetric.DataPropertyName = "BCpressureMetric";
            BCpressureMetric.HeaderText = "BCP";
            BCpressureMetric.MinimumWidth = 6;
            BCpressureMetric.Name = "BCpressureMetric";
            BCpressureMetric.ReadOnly = true;
            BCpressureMetric.Width = 125;
            // 
            // Throttle
            // 
            Throttle.DataPropertyName = "Throttle";
            Throttle.HeaderText = "THROT";
            Throttle.MinimumWidth = 6;
            Throttle.Name = "Throttle";
            Throttle.ReadOnly = true;
            Throttle.Width = 125;
            // 
            // Horn
            // 
            Horn.DataPropertyName = "Horn";
            Horn.HeaderText = "HORN";
            Horn.MinimumWidth = 6;
            Horn.Name = "Horn";
            Horn.ReadOnly = true;
            Horn.Width = 125;
            // 
            // Observation
            // 
            Observation.HeaderText = "OBSERVATION";
            Observation.MinimumWidth = 6;
            Observation.Name = "Observation";
            Observation.Width = 125;
            // 
            // FrmDataAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 578);
            Controls.Add(Dgv_Analysis);
            Controls.Add(groupBox1);
            Name = "FrmDataAnalysis";
            Text = "FrmDataAnalysis";
            Load += FrmDataAnalysis_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Analysis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView Dgv_Analysis;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker Dtp_TrainDepartureTime;
        private Button Btn_IdentifyTrainDeparture;
        private DataGridViewTextBoxColumn RunDateAndTime;
        private DataGridViewTextBoxColumn RotationalDistanceCounter;
        private DataGridViewTextBoxColumn CumulativeDistanceCounter;
        private DataGridViewTextBoxColumn HectometerNumber;
        private DataGridViewTextBoxColumn TrainSpeed;
        private DataGridViewTextBoxColumn SectionalSpeed;
        private DataGridViewTextBoxColumn CautionSpotSpeed;
        private DataGridViewTextBoxColumn TractiveEffort;
        private DataGridViewTextBoxColumn BPpressureMetric;
        private DataGridViewTextBoxColumn BCpressureMetric;
        private DataGridViewTextBoxColumn Throttle;
        private DataGridViewTextBoxColumn Horn;
        private DataGridViewTextBoxColumn Observation;
    }
}