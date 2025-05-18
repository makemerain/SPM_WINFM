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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataAnalysis));
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            Btn_BlockRunMapping = new Button();
            btn_StopaageMarking = new Button();
            groupBox2 = new GroupBox();
            Dtp_BftEndTime = new DateTimePicker();
            label4 = new Label();
            Chk_IdentifyBFT = new CheckBox();
            Dtp_BftStartTime = new DateTimePicker();
            label1 = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Dtp_BptendTime = new DateTimePicker();
            Dtp_BptStartTime = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            Chk_IdentifyBPT = new CheckBox();
            Dgv_Analysis = new DataGridView();
            RunDateAndTime = new DataGridViewTextBoxColumn();
            BlockSection = new DataGridViewTextBoxColumn();
            RotationalDistanceCounter = new DataGridViewTextBoxColumn();
            CumulativeDistanceCounter = new DataGridViewTextBoxColumn();
            Hectometer = new DataGridViewTextBoxColumn();
            SectionalSpeed = new DataGridViewTextBoxColumn();
            CautionSpeed = new DataGridViewTextBoxColumn();
            TrainSpeed = new DataGridViewTextBoxColumn();
            TractiveEffort = new DataGridViewTextBoxColumn();
            RunStatus = new DataGridViewTextBoxColumn();
            BPpressureMetric = new DataGridViewTextBoxColumn();
            BCpressureMetric = new DataGridViewTextBoxColumn();
            ThrottleInt = new DataGridViewTextBoxColumn();
            Horn = new DataGridViewTextBoxColumn();
            Observation = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            Lbl_StoppagesMapping = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            Lbl_BFTmapping = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            Lable5 = new ToolStripLabel();
            Lbl_BptMapping = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            Lbl_BlockSectionMapping = new ToolStripLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripLabel4 = new ToolStripLabel();
            Lbl_OutputDirectoryAddress = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            Btn_GenerateOutPut = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Analysis).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 192);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1494, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Btn_GenerateOutPut);
            groupBox4.Controls.Add(Btn_BlockRunMapping);
            groupBox4.Controls.Add(btn_StopaageMarking);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(987, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(420, 112);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Data Selection (Mandatory)";
            // 
            // Btn_BlockRunMapping
            // 
            Btn_BlockRunMapping.Location = new Point(209, 21);
            Btn_BlockRunMapping.Name = "Btn_BlockRunMapping";
            Btn_BlockRunMapping.Size = new Size(191, 38);
            Btn_BlockRunMapping.TabIndex = 1;
            Btn_BlockRunMapping.Text = "Run Plotting Initialization";
            Btn_BlockRunMapping.UseVisualStyleBackColor = true;
            Btn_BlockRunMapping.Click += Btn_BlockSectionMapping_Click;
            // 
            // btn_StopaageMarking
            // 
            btn_StopaageMarking.Location = new Point(9, 21);
            btn_StopaageMarking.Name = "btn_StopaageMarking";
            btn_StopaageMarking.Size = new Size(191, 38);
            btn_StopaageMarking.TabIndex = 0;
            btn_StopaageMarking.Text = "Stoppages Mapping";
            btn_StopaageMarking.UseVisualStyleBackColor = true;
            btn_StopaageMarking.Click += btn_StopaageMarking_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Dtp_BftEndTime);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Chk_IdentifyBFT);
            groupBox2.Controls.Add(Dtp_BftStartTime);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(491, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 112);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Indentify BFT (Min 60 Sec)";
            // 
            // Dtp_BftEndTime
            // 
            Dtp_BftEndTime.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_BftEndTime.Format = DateTimePickerFormat.Custom;
            Dtp_BftEndTime.Location = new Point(132, 59);
            Dtp_BftEndTime.Name = "Dtp_BftEndTime";
            Dtp_BftEndTime.Size = new Size(177, 27);
            Dtp_BftEndTime.TabIndex = 4;
            Dtp_BftEndTime.ValueChanged += Dtp_BftEndTime_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 59);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "BFT end time : ";
            // 
            // Chk_IdentifyBFT
            // 
            Chk_IdentifyBFT.AutoSize = true;
            Chk_IdentifyBFT.Location = new Point(338, 59);
            Chk_IdentifyBFT.Name = "Chk_IdentifyBFT";
            Chk_IdentifyBFT.Size = new Size(120, 24);
            Chk_IdentifyBFT.TabIndex = 2;
            Chk_IdentifyBFT.Text = "Identify BFT ?";
            Chk_IdentifyBFT.UseVisualStyleBackColor = true;
            Chk_IdentifyBFT.CheckStateChanged += Chk_IdentifyBFT_CheckStateChanged;
            // 
            // Dtp_BftStartTime
            // 
            Dtp_BftStartTime.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_BftStartTime.Format = DateTimePickerFormat.Custom;
            Dtp_BftStartTime.Location = new Point(132, 26);
            Dtp_BftStartTime.Name = "Dtp_BftStartTime";
            Dtp_BftStartTime.Size = new Size(177, 27);
            Dtp_BftStartTime.TabIndex = 1;
            Dtp_BftStartTime.ValueChanged += Dtp_BftStartTime_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "BFT Start time : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(3, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(488, 112);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Indentify BPT frame (Min 120 Sec)";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(Dtp_BptendTime, 1, 1);
            tableLayoutPanel1.Controls.Add(Dtp_BptStartTime, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(Chk_IdentifyBPT, 2, 1);
            tableLayoutPanel1.Location = new Point(6, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(456, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Dtp_BptendTime
            // 
            Dtp_BptendTime.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_BptendTime.Format = DateTimePickerFormat.Custom;
            Dtp_BptendTime.Location = new Point(121, 33);
            Dtp_BptendTime.Name = "Dtp_BptendTime";
            Dtp_BptendTime.Size = new Size(163, 27);
            Dtp_BptendTime.TabIndex = 3;
            Dtp_BptendTime.ValueChanged += Dtp_BptendTime_ValueChanged;
            // 
            // Dtp_BptStartTime
            // 
            Dtp_BptStartTime.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_BptStartTime.Format = DateTimePickerFormat.Custom;
            Dtp_BptStartTime.Location = new Point(121, 3);
            Dtp_BptStartTime.Name = "Dtp_BptStartTime";
            Dtp_BptStartTime.Size = new Size(163, 27);
            Dtp_BptStartTime.TabIndex = 2;
            Dtp_BptStartTime.ValueChanged += Dtp_BptStartTime_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "BFT Start time :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 1;
            label3.Text = "BFT end  time :";
            // 
            // Chk_IdentifyBPT
            // 
            Chk_IdentifyBPT.AutoSize = true;
            Chk_IdentifyBPT.Location = new Point(290, 33);
            Chk_IdentifyBPT.Name = "Chk_IdentifyBPT";
            Chk_IdentifyBPT.Size = new Size(147, 24);
            Chk_IdentifyBPT.TabIndex = 4;
            Chk_IdentifyBPT.Text = "Identify the BPT ?";
            Chk_IdentifyBPT.UseVisualStyleBackColor = true;
            Chk_IdentifyBPT.CheckStateChanged += Chk_IdentifyBPT_CheckStateChanged;
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
            Dgv_Analysis.Columns.AddRange(new DataGridViewColumn[] { RunDateAndTime, BlockSection, RotationalDistanceCounter, CumulativeDistanceCounter, Hectometer, SectionalSpeed, CautionSpeed, TrainSpeed, TractiveEffort, RunStatus, BPpressureMetric, BCpressureMetric, ThrottleInt, Horn, Observation });
            Dgv_Analysis.Dock = DockStyle.Fill;
            Dgv_Analysis.EnableHeadersVisualStyles = false;
            Dgv_Analysis.Location = new Point(0, 138);
            Dgv_Analysis.Name = "Dgv_Analysis";
            Dgv_Analysis.RowHeadersWidth = 51;
            Dgv_Analysis.Size = new Size(1494, 440);
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
            // BlockSection
            // 
            BlockSection.DataPropertyName = "BlockSection";
            BlockSection.HeaderText = "SECTION";
            BlockSection.Name = "BlockSection";
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
            // Hectometer
            // 
            Hectometer.DataPropertyName = "Hectometer";
            Hectometer.HeaderText = "HECTO";
            Hectometer.MinimumWidth = 6;
            Hectometer.Name = "Hectometer";
            Hectometer.ReadOnly = true;
            Hectometer.Width = 125;
            // 
            // SectionalSpeed
            // 
            SectionalSpeed.DataPropertyName = "SectionalSpeed";
            SectionalSpeed.HeaderText = "SEC-SP";
            SectionalSpeed.MinimumWidth = 6;
            SectionalSpeed.Name = "SectionalSpeed";
            SectionalSpeed.ReadOnly = true;
            SectionalSpeed.Width = 125;
            // 
            // CautionSpeed
            // 
            CautionSpeed.DataPropertyName = "CautionSpeed";
            CautionSpeed.HeaderText = "CD";
            CautionSpeed.Name = "CautionSpeed";
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
            // TractiveEffort
            // 
            TractiveEffort.DataPropertyName = "TractiveEffort";
            TractiveEffort.HeaderText = "TE / BE";
            TractiveEffort.MinimumWidth = 6;
            TractiveEffort.Name = "TractiveEffort";
            TractiveEffort.ReadOnly = true;
            TractiveEffort.Width = 125;
            // 
            // RunStatus
            // 
            RunStatus.DataPropertyName = "RunStatus";
            RunStatus.HeaderText = "STATE";
            RunStatus.Name = "RunStatus";
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
            // ThrottleInt
            // 
            ThrottleInt.DataPropertyName = "ThrottleInt";
            ThrottleInt.HeaderText = "THROT";
            ThrottleInt.MinimumWidth = 6;
            ThrottleInt.Name = "ThrottleInt";
            ThrottleInt.ReadOnly = true;
            ThrottleInt.Width = 125;
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
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, Lbl_StoppagesMapping, toolStripSeparator1, toolStripLabel2, Lbl_BFTmapping, toolStripSeparator2, Lable5, Lbl_BptMapping, toolStripSeparator3, toolStripLabel3, Lbl_BlockSectionMapping, toolStripSeparator4, toolStripLabel4, Lbl_OutputDirectoryAddress, toolStripSeparator5, toolStripButton1 });
            toolStrip1.Location = new Point(0, 553);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1494, 25);
            toolStrip1.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(122, 22);
            toolStripLabel1.Text = "Stoppages Mapping : ";
            // 
            // Lbl_StoppagesMapping
            // 
            Lbl_StoppagesMapping.BackColor = Color.Yellow;
            Lbl_StoppagesMapping.Name = "Lbl_StoppagesMapping";
            Lbl_StoppagesMapping.Size = new Size(33, 22);
            Lbl_StoppagesMapping.Text = "False";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(87, 22);
            toolStripLabel2.Text = "BFT Mapping : ";
            // 
            // Lbl_BFTmapping
            // 
            Lbl_BFTmapping.Name = "Lbl_BFTmapping";
            Lbl_BFTmapping.Size = new Size(33, 22);
            Lbl_BFTmapping.Text = "Flase";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // Lable5
            // 
            Lable5.Name = "Lable5";
            Lable5.Size = new Size(88, 22);
            Lable5.Text = "BPT Mapping : ";
            // 
            // Lbl_BptMapping
            // 
            Lbl_BptMapping.Name = "Lbl_BptMapping";
            Lbl_BptMapping.Size = new Size(33, 22);
            Lbl_BptMapping.Text = "False";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(112, 22);
            toolStripLabel3.Text = "Run plot Mapping : ";
            // 
            // Lbl_BlockSectionMapping
            // 
            Lbl_BlockSectionMapping.Name = "Lbl_BlockSectionMapping";
            Lbl_BlockSectionMapping.Size = new Size(33, 22);
            Lbl_BlockSectionMapping.Text = "False";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(108, 22);
            toolStripLabel4.Text = "Out Put Directory : ";
            // 
            // Lbl_OutputDirectoryAddress
            // 
            Lbl_OutputDirectoryAddress.Name = "Lbl_OutputDirectoryAddress";
            Lbl_OutputDirectoryAddress.Size = new Size(33, 22);
            Lbl_OutputDirectoryAddress.Text = "False";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(138, 22);
            toolStripButton1.Text = "Set Out put Directory";
            // 
            // Btn_GenerateOutPut
            // 
            Btn_GenerateOutPut.Location = new Point(9, 67);
            Btn_GenerateOutPut.Name = "Btn_GenerateOutPut";
            Btn_GenerateOutPut.Size = new Size(391, 38);
            Btn_GenerateOutPut.TabIndex = 2;
            Btn_GenerateOutPut.Text = "Generate Out Put";
            Btn_GenerateOutPut.UseVisualStyleBackColor = true;
            // 
            // FrmDataAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 578);
            Controls.Add(toolStrip1);
            Controls.Add(Dgv_Analysis);
            Controls.Add(groupBox1);
            Name = "FrmDataAnalysis";
            Text = "FrmDataAnalysis";
            Load += FrmDataAnalysis_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Analysis).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView Dgv_Analysis;
        private DataGridViewTextBoxColumn RunDateAndTime;
        private DataGridViewTextBoxColumn BlockSection;
        private DataGridViewTextBoxColumn RotationalDistanceCounter;
        private DataGridViewTextBoxColumn CumulativeDistanceCounter;
        private DataGridViewTextBoxColumn Hectometer;
        private DataGridViewTextBoxColumn SectionalSpeed;
        private DataGridViewTextBoxColumn CautionSpeed;
        private DataGridViewTextBoxColumn TrainSpeed;
        private DataGridViewTextBoxColumn TractiveEffort;
        private DataGridViewTextBoxColumn RunStatus;
        private DataGridViewTextBoxColumn BPpressureMetric;
        private DataGridViewTextBoxColumn BCpressureMetric;
        private DataGridViewTextBoxColumn Throttle;
        private DataGridViewTextBoxColumn Horn;
        private DataGridViewTextBoxColumn Observation;
        private DataGridViewTextBoxColumn ThrottleInt;
        private GroupBox groupBox2;
        private DateTimePicker Dtp_BftStartTime;
        private Label label1;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker Dtp_BptendTime;
        private DateTimePicker Dtp_BptStartTime;
        private Label label2;
        private Label label3;
        private GroupBox groupBox4;
        private CheckBox Chk_IdentifyBPT;
        private CheckBox Chk_IdentifyBFT;
        private DateTimePicker Dtp_BftEndTime;
        private Label label4;
        private Button btn_StopaageMarking;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel Lbl_StoppagesMapping;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel Lbl_BFTmapping;
        private ToolStripLabel Lable5;
        private ToolStripLabel Lbl_BptMapping;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel Lbl_BlockSectionMapping;
        private ToolStripSeparator toolStripSeparator4;
        private Button Btn_BlockRunMapping;
        private ToolStripLabel toolStripLabel4;
        private ToolStripLabel Lbl_OutputDirectoryAddress;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton1;
        private Button Btn_GenerateOutPut;
    }
}