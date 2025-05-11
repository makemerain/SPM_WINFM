namespace SPM_WINFM.UI
{
    partial class JournalTimeAppenderDialog
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Dtp_ArrivalTime = new DateTimePicker();
            Lbl_BlockSection = new Label();
            label2 = new Label();
            label1 = new Label();
            Dtp_DepartureTime = new DateTimePicker();
            Btn_Cancel = new Button();
            Btn_Save = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(Dtp_ArrivalTime, 1, 2);
            tableLayoutPanel1.Controls.Add(Lbl_BlockSection, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(Dtp_DepartureTime, 1, 1);
            tableLayoutPanel1.Controls.Add(Btn_Cancel, 0, 3);
            tableLayoutPanel1.Controls.Add(Btn_Save, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(620, 213);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Dtp_ArrivalTime
            // 
            Dtp_ArrivalTime.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_ArrivalTime.Dock = DockStyle.Fill;
            Dtp_ArrivalTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Dtp_ArrivalTime.Format = DateTimePickerFormat.Custom;
            Dtp_ArrivalTime.Location = new Point(249, 74);
            Dtp_ArrivalTime.Name = "Dtp_ArrivalTime";
            Dtp_ArrivalTime.Size = new Size(368, 34);
            Dtp_ArrivalTime.TabIndex = 5;
            // 
            // Lbl_BlockSection
            // 
            Lbl_BlockSection.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(Lbl_BlockSection, 2);
            Lbl_BlockSection.Dock = DockStyle.Fill;
            Lbl_BlockSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_BlockSection.ForeColor = SystemColors.ControlDarkDark;
            Lbl_BlockSection.Location = new Point(3, 0);
            Lbl_BlockSection.Name = "Lbl_BlockSection";
            Lbl_BlockSection.Size = new Size(614, 31);
            Lbl_BlockSection.TabIndex = 2;
            Lbl_BlockSection.Text = "Block section";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(240, 40);
            label2.TabIndex = 1;
            label2.Text = "DEP time :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 71);
            label1.Name = "label1";
            label1.Size = new Size(240, 40);
            label1.TabIndex = 0;
            label1.Text = "Arrival Time :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Dtp_DepartureTime
            // 
            Dtp_DepartureTime.CustomFormat = "dd/MM/yy HH:mm:ss";
            Dtp_DepartureTime.Dock = DockStyle.Fill;
            Dtp_DepartureTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Dtp_DepartureTime.Format = DateTimePickerFormat.Custom;
            Dtp_DepartureTime.Location = new Point(249, 34);
            Dtp_DepartureTime.Name = "Dtp_DepartureTime";
            Dtp_DepartureTime.Size = new Size(368, 34);
            Dtp_DepartureTime.TabIndex = 4;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.BackColor = Color.FromArgb(255, 255, 192);
            Btn_Cancel.FlatStyle = FlatStyle.Flat;
            Btn_Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_Cancel.Location = new Point(3, 114);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(240, 75);
            Btn_Cancel.TabIndex = 6;
            Btn_Cancel.Text = "&Cancel";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Btn_Save
            // 
            Btn_Save.BackColor = Color.FromArgb(192, 255, 192);
            Btn_Save.FlatStyle = FlatStyle.Flat;
            Btn_Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_Save.Location = new Point(249, 114);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(218, 75);
            Btn_Save.TabIndex = 3;
            Btn_Save.Text = "&Save";
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // JournalTimeAppenderDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(620, 213);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JournalTimeAppenderDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "APPEND LP JOURNAL DEP & ARRIVAL TIME";
            Load += JournalTimeAppenderDialog_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Lbl_BlockSection;
        private Label label2;
        private Label label1;
        private Button Btn_Save;
        private DateTimePicker Dtp_ArrivalTime;
        private DateTimePicker Dtp_DepartureTime;
        private Button Btn_Cancel;
    }
}