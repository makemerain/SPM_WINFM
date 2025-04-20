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
            Dgv_Analysis = new DataGridView();
            RunDateAndTime = new DataGridViewTextBoxColumn();
            DistanceCounter = new DataGridViewTextBoxColumn();
            CumulativeDistance = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)Dgv_Analysis).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1281, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            Dgv_Analysis.Columns.AddRange(new DataGridViewColumn[] { RunDateAndTime, DistanceCounter, CumulativeDistance, HectometerNumber, TrainSpeed, SectionalSpeed, CautionSpotSpeed, TractiveEffort, BPpressureMetric, BCpressureMetric, Throttle, Horn, Observation });
            Dgv_Analysis.Dock = DockStyle.Fill;
            Dgv_Analysis.EnableHeadersVisualStyles = false;
            Dgv_Analysis.Location = new Point(0, 80);
            Dgv_Analysis.Margin = new Padding(3, 4, 3, 4);
            Dgv_Analysis.Name = "Dgv_Analysis";
            Dgv_Analysis.RowHeadersWidth = 51;
            Dgv_Analysis.Size = new Size(1281, 520);
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
            // DistanceCounter
            // 
            DistanceCounter.DataPropertyName = "DistanceCounter";
            DistanceCounter.HeaderText = "DISTANCE";
            DistanceCounter.MinimumWidth = 6;
            DistanceCounter.Name = "DistanceCounter";
            DistanceCounter.ReadOnly = true;
            DistanceCounter.Width = 125;
            // 
            // CumulativeDistance
            // 
            CumulativeDistance.DataPropertyName = "CumulativeDistance";
            CumulativeDistance.HeaderText = "CUM-DIST";
            CumulativeDistance.MinimumWidth = 6;
            CumulativeDistance.Name = "CumulativeDistance";
            CumulativeDistance.ReadOnly = true;
            CumulativeDistance.Width = 125;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 600);
            Controls.Add(Dgv_Analysis);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDataAnalysis";
            Text = "FrmDataAnalysis";
            Load += FrmDataAnalysis_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Analysis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView Dgv_Analysis;
        private DataGridViewTextBoxColumn RunDateAndTime;
        private DataGridViewTextBoxColumn DistanceCounter;
        private DataGridViewTextBoxColumn CumulativeDistance;
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