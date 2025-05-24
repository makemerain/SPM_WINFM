namespace SPM_WINFM.UI
{
    partial class Frm_StoppageFilter
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Dgv_StoppagesMapper = new DataGridView();
            groupBox1 = new GroupBox();
            Btn_SaveStoppageList = new Button();
            DgvCol_Rowid = new DataGridViewTextBoxColumn();
            DgvCol_RunDateAndTime = new DataGridViewTextBoxColumn();
            DgvCol_BlockSection = new DataGridViewTextBoxColumn();
            DgvCol_Hectometer = new DataGridViewTextBoxColumn();
            DgvCol_RunStatus = new DataGridViewTextBoxColumn();
            DgvCol_StopLable = new DataGridViewTextBoxColumn();
            DgvCol_OptStoppage = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Dgv_StoppagesMapper).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Dgv_StoppagesMapper
            // 
            Dgv_StoppagesMapper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_StoppagesMapper.Columns.AddRange(new DataGridViewColumn[] { DgvCol_Rowid, DgvCol_RunDateAndTime, DgvCol_BlockSection, DgvCol_Hectometer, DgvCol_RunStatus, DgvCol_StopLable, DgvCol_OptStoppage });
            Dgv_StoppagesMapper.Dock = DockStyle.Fill;
            Dgv_StoppagesMapper.EnableHeadersVisualStyles = false;
            Dgv_StoppagesMapper.Location = new Point(0, 0);
            Dgv_StoppagesMapper.Name = "Dgv_StoppagesMapper";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Dgv_StoppagesMapper.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Dgv_StoppagesMapper.RowsDefaultCellStyle = dataGridViewCellStyle3;
            Dgv_StoppagesMapper.Size = new Size(800, 530);
            Dgv_StoppagesMapper.TabIndex = 0;
            Dgv_StoppagesMapper.RowEnter += Dgv_StoppagesMapper_RowEnter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_SaveStoppageList);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 423);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 107);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // Btn_SaveStoppageList
            // 
            Btn_SaveStoppageList.Cursor = Cursors.Hand;
            Btn_SaveStoppageList.Location = new Point(31, 36);
            Btn_SaveStoppageList.Name = "Btn_SaveStoppageList";
            Btn_SaveStoppageList.Size = new Size(170, 52);
            Btn_SaveStoppageList.TabIndex = 0;
            Btn_SaveStoppageList.Text = "&Save And Exit";
            Btn_SaveStoppageList.UseVisualStyleBackColor = true;
            Btn_SaveStoppageList.Click += Btn_SaveStoppageList_Click;
            // 
            // DgvCol_Rowid
            // 
            DgvCol_Rowid.DataPropertyName = "Rowid";
            DgvCol_Rowid.HeaderText = "Rowid";
            DgvCol_Rowid.Name = "DgvCol_Rowid";
            DgvCol_Rowid.ReadOnly = true;
            // 
            // DgvCol_RunDateAndTime
            // 
            DgvCol_RunDateAndTime.DataPropertyName = "RunDateAndTime";
            dataGridViewCellStyle1.Format = "dd/MM/yy HH:mm:ss";
            dataGridViewCellStyle1.NullValue = null;
            DgvCol_RunDateAndTime.DefaultCellStyle = dataGridViewCellStyle1;
            DgvCol_RunDateAndTime.HeaderText = "STOP TIME";
            DgvCol_RunDateAndTime.Name = "DgvCol_RunDateAndTime";
            DgvCol_RunDateAndTime.ReadOnly = true;
            // 
            // DgvCol_BlockSection
            // 
            DgvCol_BlockSection.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvCol_BlockSection.DataPropertyName = "BlockSection";
            DgvCol_BlockSection.HeaderText = "BLOCK SECTION";
            DgvCol_BlockSection.Name = "DgvCol_BlockSection";
            DgvCol_BlockSection.ReadOnly = true;
            DgvCol_BlockSection.Width = 110;
            // 
            // DgvCol_Hectometer
            // 
            DgvCol_Hectometer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvCol_Hectometer.DataPropertyName = "Hectometer";
            DgvCol_Hectometer.HeaderText = "HECTO METER";
            DgvCol_Hectometer.Name = "DgvCol_Hectometer";
            DgvCol_Hectometer.ReadOnly = true;
            DgvCol_Hectometer.Width = 101;
            // 
            // DgvCol_RunStatus
            // 
            DgvCol_RunStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvCol_RunStatus.DataPropertyName = "RunStatus";
            DgvCol_RunStatus.HeaderText = "STATUS";
            DgvCol_RunStatus.Name = "DgvCol_RunStatus";
            DgvCol_RunStatus.ReadOnly = true;
            DgvCol_RunStatus.Width = 72;
            // 
            // DgvCol_StopLable
            // 
            DgvCol_StopLable.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvCol_StopLable.HeaderText = "STOP LABLE";
            DgvCol_StopLable.Name = "DgvCol_StopLable";
            DgvCol_StopLable.Width = 88;
            // 
            // DgvCol_OptStoppage
            // 
            DgvCol_OptStoppage.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvCol_OptStoppage.HeaderText = "PICK";
            DgvCol_OptStoppage.Name = "DgvCol_OptStoppage";
            DgvCol_OptStoppage.Width = 38;
            // 
            // Frm_StoppageFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(groupBox1);
            Controls.Add(Dgv_StoppagesMapper);
            Name = "Frm_StoppageFilter";
            Text = "Frm_StoppageFilter";
            Load += Frm_StoppageFilter_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_StoppagesMapper).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Dgv_StoppagesMapper;
        private GroupBox groupBox1;
        private Button Btn_SaveStoppageList;
        private DataGridViewTextBoxColumn DgvCol_Rowid;
        private DataGridViewTextBoxColumn DgvCol_RunDateAndTime;
        private DataGridViewTextBoxColumn DgvCol_BlockSection;
        private DataGridViewTextBoxColumn DgvCol_Hectometer;
        private DataGridViewTextBoxColumn DgvCol_RunStatus;
        private DataGridViewTextBoxColumn DgvCol_StopLable;
        private DataGridViewCheckBoxColumn DgvCol_OptStoppage;
    }
}