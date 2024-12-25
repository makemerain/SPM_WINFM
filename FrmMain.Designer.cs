namespace SPM_WINFM
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            tableLayoutPanel1 = new TableLayoutPanel();
            Txt_TrainStartKMnumber = new TextBox();
            label17 = new Label();
            Txt_TrainStartTolerance = new TextBox();
            label14 = new Label();
            Dtp_QueryTo = new DateTimePicker();
            label11 = new Label();
            Txt_TrainLoad = new TextBox();
            Txt_TrainNumber = new TextBox();
            Txt_LocoPilotName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Txt_LpDegn_Depot = new TextBox();
            Txt_LpGrade_Experiance = new TextBox();
            NliName_Depot = new TextBox();
            label10 = new Label();
            Txt_MajorSection = new TextBox();
            Txt_AnalysedSection = new TextBox();
            txt_StockType = new TextBox();
            Txt_BrakePower = new TextBox();
            label12 = new Label();
            label13 = new Label();
            Dtp_QueryFrom = new DateTimePicker();
            Cbo_SpeedometerType = new ComboBox();
            label15 = new Label();
            Txt_TotalLoopLines = new TextBox();
            label16 = new Label();
            Txt_ExcelPath = new TextBox();
            label18 = new Label();
            Txt_LocoConsist = new TextBox();
            groupBox1 = new GroupBox();
            DGV_CautionOrders = new DataGridView();
            CDfrom = new DataGridViewTextBoxColumn();
            CDto = new DataGridViewTextBoxColumn();
            CDspeed = new DataGridViewTextBoxColumn();
            DropCDrow = new DataGridViewButtonColumn();
            Btn_LoadForAnlysis = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_CautionOrders).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlDarkDark;
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1692, 25);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.LavenderBlush;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(Txt_TrainStartKMnumber, 1, 4);
            tableLayoutPanel1.Controls.Add(label17, 0, 4);
            tableLayoutPanel1.Controls.Add(Txt_TrainStartTolerance, 5, 3);
            tableLayoutPanel1.Controls.Add(label14, 4, 3);
            tableLayoutPanel1.Controls.Add(Dtp_QueryTo, 5, 1);
            tableLayoutPanel1.Controls.Add(label11, 4, 0);
            tableLayoutPanel1.Controls.Add(Txt_TrainLoad, 3, 1);
            tableLayoutPanel1.Controls.Add(Txt_TrainNumber, 3, 0);
            tableLayoutPanel1.Controls.Add(Txt_LocoPilotName, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 2);
            tableLayoutPanel1.Controls.Add(label8, 2, 3);
            tableLayoutPanel1.Controls.Add(label9, 2, 4);
            tableLayoutPanel1.Controls.Add(Txt_LpDegn_Depot, 1, 1);
            tableLayoutPanel1.Controls.Add(Txt_LpGrade_Experiance, 1, 2);
            tableLayoutPanel1.Controls.Add(NliName_Depot, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 2, 5);
            tableLayoutPanel1.Controls.Add(Txt_MajorSection, 3, 2);
            tableLayoutPanel1.Controls.Add(Txt_AnalysedSection, 3, 3);
            tableLayoutPanel1.Controls.Add(txt_StockType, 3, 4);
            tableLayoutPanel1.Controls.Add(Txt_BrakePower, 3, 5);
            tableLayoutPanel1.Controls.Add(label12, 4, 1);
            tableLayoutPanel1.Controls.Add(label13, 4, 2);
            tableLayoutPanel1.Controls.Add(Dtp_QueryFrom, 5, 0);
            tableLayoutPanel1.Controls.Add(Cbo_SpeedometerType, 5, 2);
            tableLayoutPanel1.Controls.Add(label15, 4, 4);
            tableLayoutPanel1.Controls.Add(Txt_TotalLoopLines, 5, 4);
            tableLayoutPanel1.Controls.Add(label16, 4, 5);
            tableLayoutPanel1.Controls.Add(Txt_ExcelPath, 5, 5);
            tableLayoutPanel1.Controls.Add(label18, 0, 5);
            tableLayoutPanel1.Controls.Add(Txt_LocoConsist, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1692, 260);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Txt_TrainStartKMnumber
            // 
            Txt_TrainStartKMnumber.BorderStyle = BorderStyle.FixedSingle;
            Txt_TrainStartKMnumber.Dock = DockStyle.Fill;
            Txt_TrainStartKMnumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_TrainStartKMnumber.ForeColor = Color.Blue;
            Txt_TrainStartKMnumber.Location = new Point(350, 146);
            Txt_TrainStartKMnumber.Name = "Txt_TrainStartKMnumber";
            Txt_TrainStartKMnumber.Size = new Size(187, 27);
            Txt_TrainStartKMnumber.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.FlatStyle = FlatStyle.Flat;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Navy;
            label17.Location = new Point(8, 143);
            label17.Name = "label17";
            label17.Size = new Size(336, 33);
            label17.TabIndex = 32;
            label17.Text = "TRAIN START KM NO :";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_TrainStartTolerance
            // 
            Txt_TrainStartTolerance.BorderStyle = BorderStyle.FixedSingle;
            Txt_TrainStartTolerance.Dock = DockStyle.Fill;
            Txt_TrainStartTolerance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_TrainStartTolerance.ForeColor = Color.Blue;
            Txt_TrainStartTolerance.Location = new Point(1289, 113);
            Txt_TrainStartTolerance.Margin = new Padding(10, 3, 3, 3);
            Txt_TrainStartTolerance.Name = "Txt_TrainStartTolerance";
            Txt_TrainStartTolerance.Size = new Size(217, 27);
            Txt_TrainStartTolerance.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(921, 110);
            label14.Margin = new Padding(10, 0, 3, 0);
            label14.Name = "label14";
            label14.Size = new Size(355, 33);
            label14.TabIndex = 26;
            label14.Text = "TRAIN START DISTANCE TOLERANCE (+/-) Mts :";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Dtp_QueryTo
            // 
            Dtp_QueryTo.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_QueryTo.Dock = DockStyle.Fill;
            Dtp_QueryTo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dtp_QueryTo.Format = DateTimePickerFormat.Custom;
            Dtp_QueryTo.Location = new Point(1289, 43);
            Dtp_QueryTo.Margin = new Padding(10, 3, 3, 3);
            Dtp_QueryTo.Name = "Dtp_QueryTo";
            Dtp_QueryTo.Size = new Size(217, 29);
            Dtp_QueryTo.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(921, 5);
            label11.Margin = new Padding(10, 0, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(355, 35);
            label11.TabIndex = 20;
            label11.Text = "QUERY TIME FROM :";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_TrainLoad
            // 
            Txt_TrainLoad.BorderStyle = BorderStyle.FixedSingle;
            Txt_TrainLoad.Dock = DockStyle.Fill;
            Txt_TrainLoad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_TrainLoad.ForeColor = Color.Blue;
            Txt_TrainLoad.Location = new Point(721, 43);
            Txt_TrainLoad.Name = "Txt_TrainLoad";
            Txt_TrainLoad.Size = new Size(187, 27);
            Txt_TrainLoad.TabIndex = 15;
            // 
            // Txt_TrainNumber
            // 
            Txt_TrainNumber.BorderStyle = BorderStyle.FixedSingle;
            Txt_TrainNumber.Dock = DockStyle.Fill;
            Txt_TrainNumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_TrainNumber.ForeColor = Color.Blue;
            Txt_TrainNumber.Location = new Point(721, 8);
            Txt_TrainNumber.Name = "Txt_TrainNumber";
            Txt_TrainNumber.Size = new Size(187, 27);
            Txt_TrainNumber.TabIndex = 14;
            // 
            // Txt_LocoPilotName
            // 
            Txt_LocoPilotName.BorderStyle = BorderStyle.FixedSingle;
            Txt_LocoPilotName.Dock = DockStyle.Fill;
            Txt_LocoPilotName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_LocoPilotName.ForeColor = Color.Blue;
            Txt_LocoPilotName.Location = new Point(350, 8);
            Txt_LocoPilotName.Name = "Txt_LocoPilotName";
            Txt_LocoPilotName.Size = new Size(187, 27);
            Txt_LocoPilotName.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(8, 110);
            label4.Name = "label4";
            label4.Size = new Size(336, 33);
            label4.TabIndex = 3;
            label4.Text = "NLI / DEPOT :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(336, 35);
            label1.TabIndex = 0;
            label1.Text = "LP NAME :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(8, 40);
            label2.Name = "label2";
            label2.Size = new Size(336, 35);
            label2.TabIndex = 1;
            label2.Text = "DEGN / DEPOT :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(8, 75);
            label3.Name = "label3";
            label3.Size = new Size(336, 35);
            label3.TabIndex = 2;
            label3.Text = "GRADAE / EXPERIANCE IN CURRENT GRADE :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(550, 5);
            label5.Margin = new Padding(10, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(165, 35);
            label5.TabIndex = 4;
            label5.Text = "TRAIN NUMBER :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(550, 40);
            label6.Margin = new Padding(10, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(165, 35);
            label6.TabIndex = 5;
            label6.Text = "TRAIN LOAD :";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(550, 75);
            label7.Margin = new Padding(10, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(165, 35);
            label7.TabIndex = 6;
            label7.Text = "MAJOR SECTION :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(550, 110);
            label8.Margin = new Padding(10, 0, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(165, 33);
            label8.TabIndex = 7;
            label8.Text = "ANALYZED SECTION :";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(550, 143);
            label9.Margin = new Padding(10, 0, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(165, 33);
            label9.TabIndex = 8;
            label9.Text = "STOCK TYPE :";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_LpDegn_Depot
            // 
            Txt_LpDegn_Depot.BorderStyle = BorderStyle.FixedSingle;
            Txt_LpDegn_Depot.Dock = DockStyle.Fill;
            Txt_LpDegn_Depot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_LpDegn_Depot.ForeColor = Color.Blue;
            Txt_LpDegn_Depot.Location = new Point(350, 43);
            Txt_LpDegn_Depot.Name = "Txt_LpDegn_Depot";
            Txt_LpDegn_Depot.Size = new Size(187, 27);
            Txt_LpDegn_Depot.TabIndex = 10;
            // 
            // Txt_LpGrade_Experiance
            // 
            Txt_LpGrade_Experiance.BorderStyle = BorderStyle.FixedSingle;
            Txt_LpGrade_Experiance.Dock = DockStyle.Fill;
            Txt_LpGrade_Experiance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_LpGrade_Experiance.ForeColor = Color.Blue;
            Txt_LpGrade_Experiance.Location = new Point(350, 78);
            Txt_LpGrade_Experiance.Name = "Txt_LpGrade_Experiance";
            Txt_LpGrade_Experiance.Size = new Size(187, 27);
            Txt_LpGrade_Experiance.TabIndex = 12;
            // 
            // NliName_Depot
            // 
            NliName_Depot.BorderStyle = BorderStyle.FixedSingle;
            NliName_Depot.Dock = DockStyle.Fill;
            NliName_Depot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NliName_Depot.ForeColor = Color.Blue;
            NliName_Depot.Location = new Point(350, 113);
            NliName_Depot.Name = "NliName_Depot";
            NliName_Depot.Size = new Size(187, 27);
            NliName_Depot.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(550, 176);
            label10.Margin = new Padding(10, 0, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(165, 33);
            label10.TabIndex = 9;
            label10.Text = "BP % :";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_MajorSection
            // 
            Txt_MajorSection.BorderStyle = BorderStyle.FixedSingle;
            Txt_MajorSection.Dock = DockStyle.Fill;
            Txt_MajorSection.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_MajorSection.ForeColor = Color.Blue;
            Txt_MajorSection.Location = new Point(721, 78);
            Txt_MajorSection.Name = "Txt_MajorSection";
            Txt_MajorSection.Size = new Size(187, 27);
            Txt_MajorSection.TabIndex = 16;
            // 
            // Txt_AnalysedSection
            // 
            Txt_AnalysedSection.BorderStyle = BorderStyle.FixedSingle;
            Txt_AnalysedSection.Dock = DockStyle.Fill;
            Txt_AnalysedSection.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_AnalysedSection.ForeColor = Color.Blue;
            Txt_AnalysedSection.Location = new Point(721, 113);
            Txt_AnalysedSection.Name = "Txt_AnalysedSection";
            Txt_AnalysedSection.Size = new Size(187, 27);
            Txt_AnalysedSection.TabIndex = 17;
            // 
            // txt_StockType
            // 
            txt_StockType.BorderStyle = BorderStyle.FixedSingle;
            txt_StockType.Dock = DockStyle.Fill;
            txt_StockType.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_StockType.ForeColor = Color.Blue;
            txt_StockType.Location = new Point(721, 146);
            txt_StockType.Name = "txt_StockType";
            txt_StockType.Size = new Size(187, 27);
            txt_StockType.TabIndex = 18;
            // 
            // Txt_BrakePower
            // 
            Txt_BrakePower.BorderStyle = BorderStyle.FixedSingle;
            Txt_BrakePower.Dock = DockStyle.Fill;
            Txt_BrakePower.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_BrakePower.ForeColor = Color.Blue;
            Txt_BrakePower.Location = new Point(721, 179);
            Txt_BrakePower.Name = "Txt_BrakePower";
            Txt_BrakePower.Size = new Size(187, 27);
            Txt_BrakePower.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(921, 40);
            label12.Margin = new Padding(10, 0, 3, 0);
            label12.Name = "label12";
            label12.Size = new Size(355, 35);
            label12.TabIndex = 21;
            label12.Text = "QUERY TIME TO :";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(921, 75);
            label13.Margin = new Padding(10, 0, 3, 0);
            label13.Name = "label13";
            label13.Size = new Size(355, 35);
            label13.TabIndex = 22;
            label13.Text = "SPM TYPE :";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Dtp_QueryFrom
            // 
            Dtp_QueryFrom.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_QueryFrom.Dock = DockStyle.Fill;
            Dtp_QueryFrom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dtp_QueryFrom.Format = DateTimePickerFormat.Custom;
            Dtp_QueryFrom.Location = new Point(1289, 8);
            Dtp_QueryFrom.Margin = new Padding(10, 3, 3, 3);
            Dtp_QueryFrom.Name = "Dtp_QueryFrom";
            Dtp_QueryFrom.Size = new Size(217, 29);
            Dtp_QueryFrom.TabIndex = 23;
            // 
            // Cbo_SpeedometerType
            // 
            Cbo_SpeedometerType.AutoCompleteCustomSource.AddRange(new string[] { "LAXVEN", "MEDHA" });
            Cbo_SpeedometerType.Dock = DockStyle.Fill;
            Cbo_SpeedometerType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cbo_SpeedometerType.FormattingEnabled = true;
            Cbo_SpeedometerType.Location = new Point(1289, 78);
            Cbo_SpeedometerType.Margin = new Padding(10, 3, 3, 3);
            Cbo_SpeedometerType.Name = "Cbo_SpeedometerType";
            Cbo_SpeedometerType.Size = new Size(217, 29);
            Cbo_SpeedometerType.TabIndex = 25;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.FlatStyle = FlatStyle.Flat;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Navy;
            label15.Location = new Point(921, 143);
            label15.Margin = new Padding(10, 0, 3, 0);
            label15.Name = "label15";
            label15.Size = new Size(355, 33);
            label15.TabIndex = 28;
            label15.Text = "TOTAL LOOP LINES (ENTRY + EXIT) :";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_TotalLoopLines
            // 
            Txt_TotalLoopLines.BorderStyle = BorderStyle.FixedSingle;
            Txt_TotalLoopLines.Dock = DockStyle.Fill;
            Txt_TotalLoopLines.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_TotalLoopLines.ForeColor = Color.Blue;
            Txt_TotalLoopLines.Location = new Point(1289, 146);
            Txt_TotalLoopLines.Margin = new Padding(10, 3, 3, 3);
            Txt_TotalLoopLines.Name = "Txt_TotalLoopLines";
            Txt_TotalLoopLines.Size = new Size(217, 27);
            Txt_TotalLoopLines.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Navy;
            label16.Location = new Point(921, 176);
            label16.Margin = new Padding(10, 0, 3, 0);
            label16.Name = "label16";
            label16.Size = new Size(355, 33);
            label16.TabIndex = 30;
            label16.Text = "EVENT FILE PATH :";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_ExcelPath
            // 
            Txt_ExcelPath.BorderStyle = BorderStyle.FixedSingle;
            Txt_ExcelPath.Dock = DockStyle.Fill;
            Txt_ExcelPath.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_ExcelPath.ForeColor = Color.Blue;
            Txt_ExcelPath.Location = new Point(1289, 179);
            Txt_ExcelPath.Margin = new Padding(10, 3, 3, 3);
            Txt_ExcelPath.Name = "Txt_ExcelPath";
            Txt_ExcelPath.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(Txt_ExcelPath, 2);
            Txt_ExcelPath.Size = new Size(217, 27);
            Txt_ExcelPath.TabIndex = 31;
            Txt_ExcelPath.Click += Txt_ExcelPath_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.FlatStyle = FlatStyle.Flat;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(8, 176);
            label18.Name = "label18";
            label18.Size = new Size(336, 33);
            label18.TabIndex = 34;
            label18.Text = "LOCO NUMBER :";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Txt_LocoConsist
            // 
            Txt_LocoConsist.BorderStyle = BorderStyle.FixedSingle;
            Txt_LocoConsist.Dock = DockStyle.Fill;
            Txt_LocoConsist.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_LocoConsist.ForeColor = Color.Blue;
            Txt_LocoConsist.Location = new Point(350, 179);
            Txt_LocoConsist.Name = "Txt_LocoConsist";
            Txt_LocoConsist.Size = new Size(187, 27);
            Txt_LocoConsist.TabIndex = 35;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Honeydew;
            groupBox1.Controls.Add(DGV_CautionOrders);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 271);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "CAUTION ORDER LIST";
            // 
            // DGV_CautionOrders
            // 
            DGV_CautionOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_CautionOrders.BorderStyle = BorderStyle.None;
            DGV_CautionOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_CautionOrders.Columns.AddRange(new DataGridViewColumn[] { CDfrom, CDto, CDspeed, DropCDrow });
            DGV_CautionOrders.Dock = DockStyle.Fill;
            DGV_CautionOrders.Location = new Point(3, 25);
            DGV_CautionOrders.Margin = new Padding(10);
            DGV_CautionOrders.Name = "DGV_CautionOrders";
            DGV_CautionOrders.Size = new Size(709, 243);
            DGV_CautionOrders.TabIndex = 0;
            // 
            // CDfrom
            // 
            CDfrom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CDfrom.HeaderText = "CD FROM KM";
            CDfrom.Name = "CDfrom";
            // 
            // CDto
            // 
            CDto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CDto.HeaderText = "CD TO KM";
            CDto.Name = "CDto";
            // 
            // CDspeed
            // 
            CDspeed.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CDspeed.HeaderText = "CD SPEED";
            CDspeed.Name = "CDspeed";
            // 
            // DropCDrow
            // 
            DropCDrow.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DropCDrow.HeaderText = "DROP";
            DropCDrow.Name = "DropCDrow";
            // 
            // Btn_LoadForAnlysis
            // 
            Btn_LoadForAnlysis.BackColor = Color.DarkSlateGray;
            Btn_LoadForAnlysis.Cursor = Cursors.Hand;
            Btn_LoadForAnlysis.FlatAppearance.BorderColor = Color.Yellow;
            Btn_LoadForAnlysis.FlatAppearance.BorderSize = 0;
            Btn_LoadForAnlysis.FlatStyle = FlatStyle.Flat;
            Btn_LoadForAnlysis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_LoadForAnlysis.ForeColor = Color.White;
            Btn_LoadForAnlysis.Location = new Point(755, 303);
            Btn_LoadForAnlysis.Name = "Btn_LoadForAnlysis";
            Btn_LoadForAnlysis.Size = new Size(296, 76);
            Btn_LoadForAnlysis.TabIndex = 3;
            Btn_LoadForAnlysis.Text = "&Load Data File For Analysis";
            Btn_LoadForAnlysis.UseVisualStyleBackColor = false;
            Btn_LoadForAnlysis.Click += Btn_LoadForAnlysis_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1692, 556);
            Controls.Add(Btn_LoadForAnlysis);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_CautionOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Txt_LocoPilotName;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Txt_LpDegn_Depot;
        private TextBox Txt_TrainLoad;
        private TextBox Txt_TrainNumber;
        private TextBox Txt_LpGrade_Experiance;
        private TextBox NliName_Depot;
        private TextBox Txt_MajorSection;
        private TextBox Txt_AnalysedSection;
        private TextBox txt_StockType;
        private TextBox Txt_BrakePower;
        private Label label11;
        private Label label12;
        private Label label13;
        private DateTimePicker Dtp_QueryFrom;
        private TextBox Txt_TrainStartTolerance;
        private Label label14;
        private DateTimePicker Dtp_QueryTo;
        private ComboBox Cbo_SpeedometerType;
        private Label label15;
        private TextBox Txt_TotalLoopLines;
        private Label label16;
        private TextBox Txt_ExcelPath;
        private TextBox Txt_TrainStartKMnumber;
        private Label label17;
        private Label label18;
        private TextBox Txt_LocoConsist;
        private GroupBox groupBox1;
        private DataGridView DGV_CautionOrders;
        private DataGridViewTextBoxColumn CDfrom;
        private DataGridViewTextBoxColumn CDto;
        private DataGridViewTextBoxColumn CDspeed;
        private DataGridViewButtonColumn DropCDrow;
        private Button Btn_LoadForAnlysis;
    }
}
