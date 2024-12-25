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
            TL24voltage = new DataGridViewTextBoxColumn();
            PCS = new DataGridViewTextBoxColumn();
            Horn = new DataGridViewTextBoxColumn();
            Observation = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Dgv_Analysis).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1121, 60);
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
            Dgv_Analysis.Columns.AddRange(new DataGridViewColumn[] { RunDateAndTime, DistanceCounter, CumulativeDistance, HectometerNumber, TrainSpeed, SectionalSpeed, CautionSpotSpeed, TractiveEffort, BPpressureMetric, BCpressureMetric, Throttle, TL24voltage, PCS, Horn, Observation });
            Dgv_Analysis.Dock = DockStyle.Fill;
            Dgv_Analysis.EnableHeadersVisualStyles = false;
            Dgv_Analysis.Location = new Point(0, 60);
            Dgv_Analysis.Name = "Dgv_Analysis";
            Dgv_Analysis.Size = new Size(1121, 390);
            Dgv_Analysis.TabIndex = 1;
            // 
            // RunDateAndTime
            // 
            RunDateAndTime.DataPropertyName = "RunDateAndTime";
            RunDateAndTime.HeaderText = "RUN TIME";
            RunDateAndTime.Name = "RunDateAndTime";
            RunDateAndTime.ReadOnly = true;
            // 
            // DistanceCounter
            // 
            DistanceCounter.DataPropertyName = "DistanceCounter";
            DistanceCounter.HeaderText = "DISTANCE";
            DistanceCounter.Name = "DistanceCounter";
            DistanceCounter.ReadOnly = true;
            // 
            // CumulativeDistance
            // 
            CumulativeDistance.DataPropertyName = "CumulativeDistance";
            CumulativeDistance.HeaderText = "CUM-DIST";
            CumulativeDistance.Name = "CumulativeDistance";
            CumulativeDistance.ReadOnly = true;
            // 
            // HectometerNumber
            // 
            HectometerNumber.DataPropertyName = "HectometerNumber";
            HectometerNumber.HeaderText = "HECTO";
            HectometerNumber.Name = "HectometerNumber";
            HectometerNumber.ReadOnly = true;
            // 
            // TrainSpeed
            // 
            TrainSpeed.HeaderText = "SPEED";
            TrainSpeed.Name = "TrainSpeed";
            TrainSpeed.ReadOnly = true;
            // 
            // SectionalSpeed
            // 
            SectionalSpeed.HeaderText = "SEC-SP";
            SectionalSpeed.Name = "SectionalSpeed";
            SectionalSpeed.ReadOnly = true;
            // 
            // CautionSpotSpeed
            // 
            CautionSpotSpeed.HeaderText = "CD-SP";
            CautionSpotSpeed.Name = "CautionSpotSpeed";
            CautionSpotSpeed.ReadOnly = true;
            // 
            // TractiveEffort
            // 
            TractiveEffort.DataPropertyName = "TractiveEffort";
            TractiveEffort.HeaderText = "TE / BE";
            TractiveEffort.Name = "TractiveEffort";
            TractiveEffort.ReadOnly = true;
            // 
            // BPpressureMetric
            // 
            BPpressureMetric.DataPropertyName = "BPpressureMetric";
            BPpressureMetric.HeaderText = "BPP";
            BPpressureMetric.Name = "BPpressureMetric";
            BPpressureMetric.ReadOnly = true;
            // 
            // BCpressureMetric
            // 
            BCpressureMetric.DataPropertyName = "BCpressureMetric";
            BCpressureMetric.HeaderText = "BCP";
            BCpressureMetric.Name = "BCpressureMetric";
            BCpressureMetric.ReadOnly = true;
            // 
            // Throttle
            // 
            Throttle.DataPropertyName = "Throttle";
            Throttle.HeaderText = "THROT";
            Throttle.Name = "Throttle";
            Throttle.ReadOnly = true;
            // 
            // TL24voltage
            // 
            TL24voltage.DataPropertyName = "TL24voltage";
            TL24voltage.HeaderText = "TL24";
            TL24voltage.Name = "TL24voltage";
            TL24voltage.ReadOnly = true;
            // 
            // PCS
            // 
            PCS.DataPropertyName = "PCS";
            PCS.HeaderText = "PCS";
            PCS.Name = "PCS";
            PCS.ReadOnly = true;
            // 
            // Horn
            // 
            Horn.DataPropertyName = "Horn";
            Horn.HeaderText = "HORN";
            Horn.Name = "Horn";
            Horn.ReadOnly = true;
            // 
            // Observation
            // 
            Observation.HeaderText = "OBSERVATION";
            Observation.Name = "Observation";
            // 
            // FrmDataAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 450);
            Controls.Add(Dgv_Analysis);
            Controls.Add(groupBox1);
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
        private DataGridViewTextBoxColumn TL24voltage;
        private DataGridViewTextBoxColumn PCS;
        private DataGridViewTextBoxColumn Horn;
        private DataGridViewTextBoxColumn Observation;
    }
}