namespace EmpAttendanceSQLite
{
    partial class FormImportAttendanceLogAdv
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
            buttonImportData = new Button();
            label1 = new Label();
            textBoxFileName = new TextBox();
            openAttendanceLogFileDialog = new OpenFileDialog();
            buttonBrowseFile = new Button();
            label2 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            labelDate = new Label();
            dataGridViewBiometricLogs = new DataGridView();
            dgcLogId = new DataGridViewTextBoxColumn();
            dgcBMEmployeeId = new DataGridViewTextBoxColumn();
            dgcEmployeeName = new DataGridViewTextBoxColumn();
            dgcPunchTime = new DataGridViewTextBoxColumn();
            dgcDeviceId = new DataGridViewTextBoxColumn();
            dgcPunchTypeFlag = new DataGridViewTextBoxColumn();
            dgcVerificationMode = new DataGridViewTextBoxColumn();
            dgcStatusCode = new DataGridViewTextBoxColumn();
            dgcCreatedAt = new DataGridViewTextBoxColumn();
            dgcBatchCode = new DataGridViewTextBoxColumn();
            dgcRecordType = new DataGridViewTextBoxColumn();
            tabControlMain = new TabControl();
            tabPageRawLogs = new TabPage();
            tabPageBatchHistory = new TabPage();
            dataGridViewBatchHistory = new DataGridView();
            dgcHistoryBatchCode = new DataGridViewTextBoxColumn();
            dgcHistoryStartDate = new DataGridViewTextBoxColumn();
            dgcHistoryEndDate = new DataGridViewTextBoxColumn();
            dgcHistoryView = new DataGridViewLinkColumn();
            dgcHistoryDelete = new DataGridViewLinkColumn();
            labelBatchCode = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBiometricLogs).BeginInit();
            tabControlMain.SuspendLayout();
            tabPageRawLogs.SuspendLayout();
            tabPageBatchHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBatchHistory).BeginInit();
            SuspendLayout();
            // 
            // buttonImportData
            // 
            buttonImportData.Location = new Point(513, 64);
            buttonImportData.Name = "buttonImportData";
            buttonImportData.Size = new Size(174, 38);
            buttonImportData.TabIndex = 0;
            buttonImportData.Text = "Import";
            buttonImportData.UseVisualStyleBackColor = true;
            buttonImportData.Click += buttonImportData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "File Name";
            // 
            // textBoxFileName
            // 
            textBoxFileName.Enabled = false;
            textBoxFileName.Location = new Point(133, 25);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(442, 31);
            textBoxFileName.TabIndex = 2;
            // 
            // openAttendanceLogFileDialog
            // 
            openAttendanceLogFileDialog.Filter = "Backup File | *.dat";
            openAttendanceLogFileDialog.Title = "Attendance Log";
            // 
            // buttonBrowseFile
            // 
            buttonBrowseFile.Location = new Point(581, 21);
            buttonBrowseFile.Name = "buttonBrowseFile";
            buttonBrowseFile.Size = new Size(106, 38);
            buttonBrowseFile.TabIndex = 6;
            buttonBrowseFile.Text = "Browse";
            buttonBrowseFile.UseVisualStyleBackColor = true;
            buttonBrowseFile.Click += buttonBrowseFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(297, 69);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 33;
            label2.Text = "To";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(335, 66);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(158, 31);
            dtpEndDate.TabIndex = 32;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(133, 66);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(158, 31);
            dtpStartDate.TabIndex = 31;
            dtpStartDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F);
            labelDate.Location = new Point(25, 69);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(90, 25);
            labelDate.TabIndex = 30;
            labelDate.Text = "Start Date";
            // 
            // dataGridViewBiometricLogs
            // 
            dataGridViewBiometricLogs.AllowUserToAddRows = false;
            dataGridViewBiometricLogs.AllowUserToDeleteRows = false;
            dataGridViewBiometricLogs.BackgroundColor = Color.Gainsboro;
            dataGridViewBiometricLogs.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewBiometricLogs.ColumnHeadersHeight = 40;
            dataGridViewBiometricLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewBiometricLogs.Columns.AddRange(new DataGridViewColumn[] { dgcLogId, dgcBMEmployeeId, dgcEmployeeName, dgcPunchTime, dgcDeviceId, dgcPunchTypeFlag, dgcVerificationMode, dgcStatusCode, dgcCreatedAt, dgcBatchCode, dgcRecordType });
            dataGridViewBiometricLogs.Dock = DockStyle.Fill;
            dataGridViewBiometricLogs.Location = new Point(3, 3);
            dataGridViewBiometricLogs.Name = "dataGridViewBiometricLogs";
            dataGridViewBiometricLogs.ReadOnly = true;
            dataGridViewBiometricLogs.RowHeadersWidth = 62;
            dataGridViewBiometricLogs.Size = new Size(1085, 578);
            dataGridViewBiometricLogs.TabIndex = 34;
            // 
            // dgcLogId
            // 
            dgcLogId.DataPropertyName = "LogId";
            dgcLogId.HeaderText = "LogId";
            dgcLogId.MinimumWidth = 8;
            dgcLogId.Name = "dgcLogId";
            dgcLogId.ReadOnly = true;
            dgcLogId.Visible = false;
            dgcLogId.Width = 150;
            // 
            // dgcBMEmployeeId
            // 
            dgcBMEmployeeId.DataPropertyName = "BMEmployeeId";
            dgcBMEmployeeId.HeaderText = "BMEmp.Id";
            dgcBMEmployeeId.MinimumWidth = 8;
            dgcBMEmployeeId.Name = "dgcBMEmployeeId";
            dgcBMEmployeeId.ReadOnly = true;
            dgcBMEmployeeId.Width = 150;
            // 
            // dgcEmployeeName
            // 
            dgcEmployeeName.DataPropertyName = "EmployeeName";
            dgcEmployeeName.HeaderText = "Employee Name";
            dgcEmployeeName.MinimumWidth = 8;
            dgcEmployeeName.Name = "dgcEmployeeName";
            dgcEmployeeName.ReadOnly = true;
            dgcEmployeeName.Width = 150;
            // 
            // dgcPunchTime
            // 
            dgcPunchTime.DataPropertyName = "PunchTime";
            dgcPunchTime.HeaderText = "PunchTime";
            dgcPunchTime.MinimumWidth = 8;
            dgcPunchTime.Name = "dgcPunchTime";
            dgcPunchTime.ReadOnly = true;
            dgcPunchTime.Width = 220;
            // 
            // dgcDeviceId
            // 
            dgcDeviceId.DataPropertyName = "DeviceId";
            dgcDeviceId.HeaderText = "DeviceId";
            dgcDeviceId.MinimumWidth = 8;
            dgcDeviceId.Name = "dgcDeviceId";
            dgcDeviceId.ReadOnly = true;
            dgcDeviceId.Width = 150;
            // 
            // dgcPunchTypeFlag
            // 
            dgcPunchTypeFlag.DataPropertyName = "PunchTypeFlag";
            dgcPunchTypeFlag.HeaderText = "I/O";
            dgcPunchTypeFlag.MinimumWidth = 8;
            dgcPunchTypeFlag.Name = "dgcPunchTypeFlag";
            dgcPunchTypeFlag.ReadOnly = true;
            dgcPunchTypeFlag.Width = 150;
            // 
            // dgcVerificationMode
            // 
            dgcVerificationMode.DataPropertyName = "VerificationMode";
            dgcVerificationMode.HeaderText = "Mode";
            dgcVerificationMode.MinimumWidth = 8;
            dgcVerificationMode.Name = "dgcVerificationMode";
            dgcVerificationMode.ReadOnly = true;
            dgcVerificationMode.Visible = false;
            dgcVerificationMode.Width = 80;
            // 
            // dgcStatusCode
            // 
            dgcStatusCode.DataPropertyName = "StatusCode";
            dgcStatusCode.HeaderText = "Status";
            dgcStatusCode.MinimumWidth = 8;
            dgcStatusCode.Name = "dgcStatusCode";
            dgcStatusCode.ReadOnly = true;
            dgcStatusCode.Visible = false;
            dgcStatusCode.Width = 80;
            // 
            // dgcCreatedAt
            // 
            dgcCreatedAt.DataPropertyName = "CreatedAt";
            dgcCreatedAt.HeaderText = "CreatedAt";
            dgcCreatedAt.MinimumWidth = 8;
            dgcCreatedAt.Name = "dgcCreatedAt";
            dgcCreatedAt.ReadOnly = true;
            dgcCreatedAt.Visible = false;
            dgcCreatedAt.Width = 150;
            // 
            // dgcBatchCode
            // 
            dgcBatchCode.DataPropertyName = "BatchCode";
            dgcBatchCode.HeaderText = "Batch Code";
            dgcBatchCode.MinimumWidth = 8;
            dgcBatchCode.Name = "dgcBatchCode";
            dgcBatchCode.ReadOnly = true;
            dgcBatchCode.Visible = false;
            dgcBatchCode.Width = 150;
            // 
            // dgcRecordType
            // 
            dgcRecordType.DataPropertyName = "RecordType";
            dgcRecordType.HeaderText = "RType";
            dgcRecordType.MinimumWidth = 8;
            dgcRecordType.Name = "dgcRecordType";
            dgcRecordType.ReadOnly = true;
            dgcRecordType.Width = 150;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageRawLogs);
            tabControlMain.Controls.Add(tabPageBatchHistory);
            tabControlMain.Dock = DockStyle.Bottom;
            tabControlMain.Location = new Point(0, 122);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1099, 622);
            tabControlMain.TabIndex = 35;
            // 
            // tabPageRawLogs
            // 
            tabPageRawLogs.Controls.Add(dataGridViewBiometricLogs);
            tabPageRawLogs.Location = new Point(4, 34);
            tabPageRawLogs.Name = "tabPageRawLogs";
            tabPageRawLogs.Padding = new Padding(3);
            tabPageRawLogs.Size = new Size(1091, 584);
            tabPageRawLogs.TabIndex = 0;
            tabPageRawLogs.Text = "#Raw Log Data    ";
            tabPageRawLogs.UseVisualStyleBackColor = true;
            // 
            // tabPageBatchHistory
            // 
            tabPageBatchHistory.Controls.Add(dataGridViewBatchHistory);
            tabPageBatchHistory.Location = new Point(4, 34);
            tabPageBatchHistory.Name = "tabPageBatchHistory";
            tabPageBatchHistory.Padding = new Padding(3);
            tabPageBatchHistory.Size = new Size(1091, 584);
            tabPageBatchHistory.TabIndex = 1;
            tabPageBatchHistory.Text = "#Batch History    ";
            tabPageBatchHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBatchHistory
            // 
            dataGridViewBatchHistory.AllowUserToAddRows = false;
            dataGridViewBatchHistory.AllowUserToDeleteRows = false;
            dataGridViewBatchHistory.BackgroundColor = Color.Gainsboro;
            dataGridViewBatchHistory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewBatchHistory.ColumnHeadersHeight = 40;
            dataGridViewBatchHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewBatchHistory.Columns.AddRange(new DataGridViewColumn[] { dgcHistoryBatchCode, dgcHistoryStartDate, dgcHistoryEndDate, dgcHistoryView, dgcHistoryDelete });
            dataGridViewBatchHistory.Dock = DockStyle.Fill;
            dataGridViewBatchHistory.Location = new Point(3, 3);
            dataGridViewBatchHistory.Name = "dataGridViewBatchHistory";
            dataGridViewBatchHistory.ReadOnly = true;
            dataGridViewBatchHistory.RowHeadersWidth = 62;
            dataGridViewBatchHistory.Size = new Size(1085, 578);
            dataGridViewBatchHistory.TabIndex = 35;
            dataGridViewBatchHistory.CellContentClick += dataGridViewBatchHistory_CellContentClick;
            // 
            // dgcHistoryBatchCode
            // 
            dgcHistoryBatchCode.DataPropertyName = "BatchCode";
            dgcHistoryBatchCode.HeaderText = "Batch Code";
            dgcHistoryBatchCode.MinimumWidth = 8;
            dgcHistoryBatchCode.Name = "dgcHistoryBatchCode";
            dgcHistoryBatchCode.ReadOnly = true;
            dgcHistoryBatchCode.Width = 300;
            // 
            // dgcHistoryStartDate
            // 
            dgcHistoryStartDate.DataPropertyName = "StartDate";
            dgcHistoryStartDate.HeaderText = "Start Date";
            dgcHistoryStartDate.MinimumWidth = 8;
            dgcHistoryStartDate.Name = "dgcHistoryStartDate";
            dgcHistoryStartDate.ReadOnly = true;
            dgcHistoryStartDate.Width = 200;
            // 
            // dgcHistoryEndDate
            // 
            dgcHistoryEndDate.DataPropertyName = "EndDate";
            dgcHistoryEndDate.HeaderText = "End Date";
            dgcHistoryEndDate.MinimumWidth = 8;
            dgcHistoryEndDate.Name = "dgcHistoryEndDate";
            dgcHistoryEndDate.ReadOnly = true;
            dgcHistoryEndDate.Width = 200;
            // 
            // dgcHistoryView
            // 
            dgcHistoryView.HeaderText = "View Details";
            dgcHistoryView.MinimumWidth = 8;
            dgcHistoryView.Name = "dgcHistoryView";
            dgcHistoryView.ReadOnly = true;
            dgcHistoryView.Resizable = DataGridViewTriState.True;
            dgcHistoryView.SortMode = DataGridViewColumnSortMode.Automatic;
            dgcHistoryView.Text = "View Details";
            dgcHistoryView.UseColumnTextForLinkValue = true;
            dgcHistoryView.Width = 120;
            // 
            // dgcHistoryDelete
            // 
            dgcHistoryDelete.HeaderText = "Delete ";
            dgcHistoryDelete.MinimumWidth = 8;
            dgcHistoryDelete.Name = "dgcHistoryDelete";
            dgcHistoryDelete.ReadOnly = true;
            dgcHistoryDelete.Text = "Delete Log";
            dgcHistoryDelete.UseColumnTextForLinkValue = true;
            dgcHistoryDelete.Width = 150;
            // 
            // labelBatchCode
            // 
            labelBatchCode.BorderStyle = BorderStyle.FixedSingle;
            labelBatchCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBatchCode.Location = new Point(703, 28);
            labelBatchCode.Name = "labelBatchCode";
            labelBatchCode.Size = new Size(372, 74);
            labelBatchCode.TabIndex = 36;
            labelBatchCode.Text = "Batch Code\r\nxxxxxxxxxxxx";
            labelBatchCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(625, 120);
            label3.Name = "label3";
            label3.Size = new Size(462, 28);
            label3.TabIndex = 37;
            label3.Text = "* Select proper log file and dates before processing.";
            // 
            // FormImportAttendanceLogAdv
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1099, 744);
            Controls.Add(label3);
            Controls.Add(labelBatchCode);
            Controls.Add(label2);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(labelDate);
            Controls.Add(buttonBrowseFile);
            Controls.Add(textBoxFileName);
            Controls.Add(label1);
            Controls.Add(buttonImportData);
            Controls.Add(tabControlMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormImportAttendanceLogAdv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import Attendance Log";
            Load += FormImportAttendanceLog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBiometricLogs).EndInit();
            tabControlMain.ResumeLayout(false);
            tabPageRawLogs.ResumeLayout(false);
            tabPageBatchHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBatchHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label1;
        private TextBox textBoxFileName;
        private OpenFileDialog openAttendanceLogFileDialog;
        private Button buttonImportData;
        private Button buttonBrowseFile;
        private Label label2;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label labelDate;
        private DataGridView dataGridViewBiometricLogs;
        private TabControl tabControlMain;
        private TabPage tabPageRawLogs;
        private TabPage tabPage2;
        private Label labelBatchCode;
        private TabPage tabPageBatchHistory;
        private DataGridView dataGridViewBatchHistory;
        private Label label3;
        private DataGridViewTextBoxColumn dgcLogId;
        private DataGridViewTextBoxColumn dgcBMEmployeeId;
        private DataGridViewTextBoxColumn dgcEmployeeName;
        private DataGridViewTextBoxColumn dgcPunchTime;
        private DataGridViewTextBoxColumn dgcDeviceId;
        private DataGridViewTextBoxColumn dgcPunchTypeFlag;
        private DataGridViewTextBoxColumn dgcVerificationMode;
        private DataGridViewTextBoxColumn dgcStatusCode;
        private DataGridViewTextBoxColumn dgcCreatedAt;
        private DataGridViewTextBoxColumn dgcBatchCode;
        private DataGridViewTextBoxColumn dgcRecordType;
        private DataGridViewTextBoxColumn dgcHistoryBatchCode;
        private DataGridViewTextBoxColumn dgcHistoryStartDate;
        private DataGridViewTextBoxColumn dgcHistoryEndDate;
        private DataGridViewLinkColumn dgcHistoryView;
        private DataGridViewLinkColumn dgcHistoryDelete;
    }
}
