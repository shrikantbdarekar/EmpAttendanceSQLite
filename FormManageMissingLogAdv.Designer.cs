namespace EmpAttendanceSQLite
{
    partial class FormManageMissingLogAdv
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelBatchCode = new Label();
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
            dgcBiometricLogEmployeeId = new DataGridViewTextBoxColumn();
            openAttendanceLogFileDialog = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPageImportedLog = new TabPage();
            tabPageOneEntry = new TabPage();
            dataGridViewOneEntry = new DataGridView();
            dgcOneEntryLogId = new DataGridViewTextBoxColumn();
            dgcOneEntryBMEmpId = new DataGridViewTextBoxColumn();
            dgcOneEntryEmployeeName = new DataGridViewTextBoxColumn();
            dgcOneEntryPunchTime = new DataGridViewTextBoxColumn();
            dgcOneEntryAddLog = new DataGridViewLinkColumn();
            dgcOneEntryDeviceId = new DataGridViewTextBoxColumn();
            dgcOneEntryInOut = new DataGridViewTextBoxColumn();
            dgcOneEntryMode = new DataGridViewTextBoxColumn();
            dgcOneEntryStatus = new DataGridViewTextBoxColumn();
            dgcOneEntryCreatedAt = new DataGridViewTextBoxColumn();
            dgcOneEntryBatchCode = new DataGridViewTextBoxColumn();
            dgcOneEntryRType = new DataGridViewTextBoxColumn();
            dgcOneEntryEmployeeId = new DataGridViewTextBoxColumn();
            tabPageTwoPlusEntry = new TabPage();
            dataGridViewTwoPlusEntry = new DataGridView();
            dgcTwoPlusEntryLogId = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryBMEmpId = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryEmployeeName = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryPunchTime = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryDeviceId = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryInOut = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryMode = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryStatus = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryCreatedAt = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryBatchCode = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryRType = new DataGridViewTextBoxColumn();
            dgcTwoPlusEntryDeleteLog = new DataGridViewLinkColumn();
            dgcTwoPlusEntryEmployeeId = new DataGridViewTextBoxColumn();
            comboBoxBatchCode = new ComboBox();
            buttonLoadData = new Button();
            buttonApplyInOutFlag = new Button();
            buttonDeleteLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBiometricLogs).BeginInit();
            tabControl1.SuspendLayout();
            tabPageImportedLog.SuspendLayout();
            tabPageOneEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOneEntry).BeginInit();
            tabPageTwoPlusEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTwoPlusEntry).BeginInit();
            SuspendLayout();
            // 
            // labelBatchCode
            // 
            labelBatchCode.AutoSize = true;
            labelBatchCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBatchCode.Location = new Point(12, 12);
            labelBatchCode.Name = "labelBatchCode";
            labelBatchCode.Size = new Size(124, 30);
            labelBatchCode.TabIndex = 1;
            labelBatchCode.Text = "Batch Code";
            // 
            // dataGridViewBiometricLogs
            // 
            dataGridViewBiometricLogs.AllowUserToAddRows = false;
            dataGridViewBiometricLogs.AllowUserToDeleteRows = false;
            dataGridViewBiometricLogs.BackgroundColor = Color.Gainsboro;
            dataGridViewBiometricLogs.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewBiometricLogs.ColumnHeadersHeight = 40;
            dataGridViewBiometricLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewBiometricLogs.Columns.AddRange(new DataGridViewColumn[] { dgcLogId, dgcBMEmployeeId, dgcEmployeeName, dgcPunchTime, dgcDeviceId, dgcPunchTypeFlag, dgcVerificationMode, dgcStatusCode, dgcCreatedAt, dgcBatchCode, dgcRecordType, dgcBiometricLogEmployeeId });
            dataGridViewBiometricLogs.Dock = DockStyle.Fill;
            dataGridViewBiometricLogs.Location = new Point(3, 3);
            dataGridViewBiometricLogs.Name = "dataGridViewBiometricLogs";
            dataGridViewBiometricLogs.ReadOnly = true;
            dataGridViewBiometricLogs.RowHeadersWidth = 62;
            dataGridViewBiometricLogs.ShowCellToolTips = false;
            dataGridViewBiometricLogs.Size = new Size(1164, 648);
            dataGridViewBiometricLogs.TabIndex = 6;
            dataGridViewBiometricLogs.RowPrePaint += dataGridViewImportedLogs_RowPrePaint;
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
            dgcEmployeeName.Width = 300;
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
            dgcDeviceId.Visible = false;
            dgcDeviceId.Width = 150;
            // 
            // dgcPunchTypeFlag
            // 
            dgcPunchTypeFlag.DataPropertyName = "PunchTypeFlag";
            dgcPunchTypeFlag.HeaderText = "I/O";
            dgcPunchTypeFlag.MinimumWidth = 8;
            dgcPunchTypeFlag.Name = "dgcPunchTypeFlag";
            dgcPunchTypeFlag.ReadOnly = true;
            dgcPunchTypeFlag.Visible = false;
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
            dgcRecordType.Visible = false;
            dgcRecordType.Width = 150;
            // 
            // dgcBiometricLogEmployeeId
            // 
            dgcBiometricLogEmployeeId.DataPropertyName = "EmployeeId";
            dgcBiometricLogEmployeeId.HeaderText = "Emp.Id";
            dgcBiometricLogEmployeeId.MinimumWidth = 8;
            dgcBiometricLogEmployeeId.Name = "dgcBiometricLogEmployeeId";
            dgcBiometricLogEmployeeId.ReadOnly = true;
            dgcBiometricLogEmployeeId.Visible = false;
            dgcBiometricLogEmployeeId.Width = 150;
            // 
            // openAttendanceLogFileDialog
            // 
            openAttendanceLogFileDialog.Filter = "Backup File | *.dat";
            openAttendanceLogFileDialog.Title = "Attendance Log";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageImportedLog);
            tabControl1.Controls.Add(tabPageOneEntry);
            tabControl1.Controls.Add(tabPageTwoPlusEntry);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI", 9F);
            tabControl1.Location = new Point(0, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1178, 692);
            tabControl1.TabIndex = 7;
            // 
            // tabPageImportedLog
            // 
            tabPageImportedLog.Controls.Add(dataGridViewBiometricLogs);
            tabPageImportedLog.Location = new Point(4, 34);
            tabPageImportedLog.Name = "tabPageImportedLog";
            tabPageImportedLog.Padding = new Padding(3);
            tabPageImportedLog.Size = new Size(1170, 654);
            tabPageImportedLog.TabIndex = 0;
            tabPageImportedLog.Text = "#All Records     ";
            tabPageImportedLog.UseVisualStyleBackColor = true;
            // 
            // tabPageOneEntry
            // 
            tabPageOneEntry.Controls.Add(dataGridViewOneEntry);
            tabPageOneEntry.Location = new Point(4, 34);
            tabPageOneEntry.Name = "tabPageOneEntry";
            tabPageOneEntry.Size = new Size(1170, 654);
            tabPageOneEntry.TabIndex = 2;
            tabPageOneEntry.Text = "#One Entry     ";
            tabPageOneEntry.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOneEntry
            // 
            dataGridViewOneEntry.AllowUserToAddRows = false;
            dataGridViewOneEntry.AllowUserToDeleteRows = false;
            dataGridViewOneEntry.BackgroundColor = Color.Gainsboro;
            dataGridViewOneEntry.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewOneEntry.ColumnHeadersHeight = 40;
            dataGridViewOneEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewOneEntry.Columns.AddRange(new DataGridViewColumn[] { dgcOneEntryLogId, dgcOneEntryBMEmpId, dgcOneEntryEmployeeName, dgcOneEntryPunchTime, dgcOneEntryAddLog, dgcOneEntryDeviceId, dgcOneEntryInOut, dgcOneEntryMode, dgcOneEntryStatus, dgcOneEntryCreatedAt, dgcOneEntryBatchCode, dgcOneEntryRType, dgcOneEntryEmployeeId });
            dataGridViewOneEntry.Dock = DockStyle.Fill;
            dataGridViewOneEntry.Location = new Point(0, 0);
            dataGridViewOneEntry.Name = "dataGridViewOneEntry";
            dataGridViewOneEntry.ReadOnly = true;
            dataGridViewOneEntry.RowHeadersWidth = 62;
            dataGridViewOneEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOneEntry.ShowCellToolTips = false;
            dataGridViewOneEntry.Size = new Size(1170, 654);
            dataGridViewOneEntry.TabIndex = 7;
            dataGridViewOneEntry.CellContentClick += dataGridViewOneEntry_CellContentClick;
            // 
            // dgcOneEntryLogId
            // 
            dgcOneEntryLogId.DataPropertyName = "LogId";
            dgcOneEntryLogId.HeaderText = "LogId";
            dgcOneEntryLogId.MinimumWidth = 8;
            dgcOneEntryLogId.Name = "dgcOneEntryLogId";
            dgcOneEntryLogId.ReadOnly = true;
            dgcOneEntryLogId.Visible = false;
            dgcOneEntryLogId.Width = 150;
            // 
            // dgcOneEntryBMEmpId
            // 
            dgcOneEntryBMEmpId.DataPropertyName = "BMEmployeeId";
            dgcOneEntryBMEmpId.HeaderText = "BMEmp.Id";
            dgcOneEntryBMEmpId.MinimumWidth = 8;
            dgcOneEntryBMEmpId.Name = "dgcOneEntryBMEmpId";
            dgcOneEntryBMEmpId.ReadOnly = true;
            dgcOneEntryBMEmpId.Width = 150;
            // 
            // dgcOneEntryEmployeeName
            // 
            dgcOneEntryEmployeeName.DataPropertyName = "EmployeeName";
            dgcOneEntryEmployeeName.HeaderText = "Employee Name";
            dgcOneEntryEmployeeName.MinimumWidth = 8;
            dgcOneEntryEmployeeName.Name = "dgcOneEntryEmployeeName";
            dgcOneEntryEmployeeName.ReadOnly = true;
            dgcOneEntryEmployeeName.Width = 300;
            // 
            // dgcOneEntryPunchTime
            // 
            dgcOneEntryPunchTime.DataPropertyName = "PunchTime";
            dgcOneEntryPunchTime.HeaderText = "PunchTime";
            dgcOneEntryPunchTime.MinimumWidth = 8;
            dgcOneEntryPunchTime.Name = "dgcOneEntryPunchTime";
            dgcOneEntryPunchTime.ReadOnly = true;
            dgcOneEntryPunchTime.Width = 220;
            // 
            // dgcOneEntryAddLog
            // 
            dgcOneEntryAddLog.HeaderText = "Add Log";
            dgcOneEntryAddLog.MinimumWidth = 8;
            dgcOneEntryAddLog.Name = "dgcOneEntryAddLog";
            dgcOneEntryAddLog.ReadOnly = true;
            dgcOneEntryAddLog.Text = "Add Log";
            dgcOneEntryAddLog.UseColumnTextForLinkValue = true;
            dgcOneEntryAddLog.Width = 150;
            // 
            // dgcOneEntryDeviceId
            // 
            dgcOneEntryDeviceId.DataPropertyName = "DeviceId";
            dgcOneEntryDeviceId.HeaderText = "DeviceId";
            dgcOneEntryDeviceId.MinimumWidth = 8;
            dgcOneEntryDeviceId.Name = "dgcOneEntryDeviceId";
            dgcOneEntryDeviceId.ReadOnly = true;
            dgcOneEntryDeviceId.Visible = false;
            dgcOneEntryDeviceId.Width = 150;
            // 
            // dgcOneEntryInOut
            // 
            dgcOneEntryInOut.DataPropertyName = "PunchTypeFlag";
            dgcOneEntryInOut.HeaderText = "I/O";
            dgcOneEntryInOut.MinimumWidth = 8;
            dgcOneEntryInOut.Name = "dgcOneEntryInOut";
            dgcOneEntryInOut.ReadOnly = true;
            dgcOneEntryInOut.Visible = false;
            dgcOneEntryInOut.Width = 150;
            // 
            // dgcOneEntryMode
            // 
            dgcOneEntryMode.DataPropertyName = "VerificationMode";
            dgcOneEntryMode.HeaderText = "Mode";
            dgcOneEntryMode.MinimumWidth = 8;
            dgcOneEntryMode.Name = "dgcOneEntryMode";
            dgcOneEntryMode.ReadOnly = true;
            dgcOneEntryMode.Visible = false;
            dgcOneEntryMode.Width = 80;
            // 
            // dgcOneEntryStatus
            // 
            dgcOneEntryStatus.DataPropertyName = "StatusCode";
            dgcOneEntryStatus.HeaderText = "Status";
            dgcOneEntryStatus.MinimumWidth = 8;
            dgcOneEntryStatus.Name = "dgcOneEntryStatus";
            dgcOneEntryStatus.ReadOnly = true;
            dgcOneEntryStatus.Visible = false;
            dgcOneEntryStatus.Width = 80;
            // 
            // dgcOneEntryCreatedAt
            // 
            dgcOneEntryCreatedAt.DataPropertyName = "CreatedAt";
            dgcOneEntryCreatedAt.HeaderText = "CreatedAt";
            dgcOneEntryCreatedAt.MinimumWidth = 8;
            dgcOneEntryCreatedAt.Name = "dgcOneEntryCreatedAt";
            dgcOneEntryCreatedAt.ReadOnly = true;
            dgcOneEntryCreatedAt.Visible = false;
            dgcOneEntryCreatedAt.Width = 150;
            // 
            // dgcOneEntryBatchCode
            // 
            dgcOneEntryBatchCode.DataPropertyName = "BatchCode";
            dgcOneEntryBatchCode.HeaderText = "Batch Code";
            dgcOneEntryBatchCode.MinimumWidth = 8;
            dgcOneEntryBatchCode.Name = "dgcOneEntryBatchCode";
            dgcOneEntryBatchCode.ReadOnly = true;
            dgcOneEntryBatchCode.Visible = false;
            dgcOneEntryBatchCode.Width = 150;
            // 
            // dgcOneEntryRType
            // 
            dgcOneEntryRType.DataPropertyName = "RecordType";
            dgcOneEntryRType.HeaderText = "RType";
            dgcOneEntryRType.MinimumWidth = 8;
            dgcOneEntryRType.Name = "dgcOneEntryRType";
            dgcOneEntryRType.ReadOnly = true;
            dgcOneEntryRType.Visible = false;
            dgcOneEntryRType.Width = 150;
            // 
            // dgcOneEntryEmployeeId
            // 
            dgcOneEntryEmployeeId.DataPropertyName = "EmployeeId";
            dgcOneEntryEmployeeId.HeaderText = "Emp.Id";
            dgcOneEntryEmployeeId.MinimumWidth = 8;
            dgcOneEntryEmployeeId.Name = "dgcOneEntryEmployeeId";
            dgcOneEntryEmployeeId.ReadOnly = true;
            dgcOneEntryEmployeeId.Visible = false;
            dgcOneEntryEmployeeId.Width = 150;
            // 
            // tabPageTwoPlusEntry
            // 
            tabPageTwoPlusEntry.Controls.Add(dataGridViewTwoPlusEntry);
            tabPageTwoPlusEntry.Location = new Point(4, 34);
            tabPageTwoPlusEntry.Name = "tabPageTwoPlusEntry";
            tabPageTwoPlusEntry.Padding = new Padding(3);
            tabPageTwoPlusEntry.Size = new Size(1170, 654);
            tabPageTwoPlusEntry.TabIndex = 3;
            tabPageTwoPlusEntry.Text = "#Two Plus Entry     ";
            tabPageTwoPlusEntry.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTwoPlusEntry
            // 
            dataGridViewTwoPlusEntry.AllowUserToAddRows = false;
            dataGridViewTwoPlusEntry.AllowUserToDeleteRows = false;
            dataGridViewTwoPlusEntry.BackgroundColor = Color.Gainsboro;
            dataGridViewTwoPlusEntry.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTwoPlusEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTwoPlusEntry.ColumnHeadersHeight = 40;
            dataGridViewTwoPlusEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewTwoPlusEntry.Columns.AddRange(new DataGridViewColumn[] { dgcTwoPlusEntryLogId, dgcTwoPlusEntryBMEmpId, dgcTwoPlusEntryEmployeeName, dgcTwoPlusEntryPunchTime, dgcTwoPlusEntryDeviceId, dgcTwoPlusEntryInOut, dgcTwoPlusEntryMode, dgcTwoPlusEntryStatus, dgcTwoPlusEntryCreatedAt, dgcTwoPlusEntryBatchCode, dgcTwoPlusEntryRType, dgcTwoPlusEntryDeleteLog, dgcTwoPlusEntryEmployeeId });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTwoPlusEntry.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTwoPlusEntry.Dock = DockStyle.Fill;
            dataGridViewTwoPlusEntry.Location = new Point(3, 3);
            dataGridViewTwoPlusEntry.Name = "dataGridViewTwoPlusEntry";
            dataGridViewTwoPlusEntry.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTwoPlusEntry.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTwoPlusEntry.RowHeadersWidth = 62;
            dataGridViewTwoPlusEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTwoPlusEntry.ShowCellToolTips = false;
            dataGridViewTwoPlusEntry.Size = new Size(1164, 648);
            dataGridViewTwoPlusEntry.TabIndex = 8;
            dataGridViewTwoPlusEntry.CellContentClick += dataGridViewTwoPlusEntry_CellContentClick;
            // 
            // dgcTwoPlusEntryLogId
            // 
            dgcTwoPlusEntryLogId.DataPropertyName = "LogId";
            dgcTwoPlusEntryLogId.HeaderText = "LogId";
            dgcTwoPlusEntryLogId.MinimumWidth = 8;
            dgcTwoPlusEntryLogId.Name = "dgcTwoPlusEntryLogId";
            dgcTwoPlusEntryLogId.ReadOnly = true;
            dgcTwoPlusEntryLogId.Visible = false;
            dgcTwoPlusEntryLogId.Width = 150;
            // 
            // dgcTwoPlusEntryBMEmpId
            // 
            dgcTwoPlusEntryBMEmpId.DataPropertyName = "BMEmployeeId";
            dgcTwoPlusEntryBMEmpId.HeaderText = "BMEmp.Id";
            dgcTwoPlusEntryBMEmpId.MinimumWidth = 8;
            dgcTwoPlusEntryBMEmpId.Name = "dgcTwoPlusEntryBMEmpId";
            dgcTwoPlusEntryBMEmpId.ReadOnly = true;
            dgcTwoPlusEntryBMEmpId.Width = 150;
            // 
            // dgcTwoPlusEntryEmployeeName
            // 
            dgcTwoPlusEntryEmployeeName.DataPropertyName = "EmployeeName";
            dgcTwoPlusEntryEmployeeName.HeaderText = "Employee Name";
            dgcTwoPlusEntryEmployeeName.MinimumWidth = 8;
            dgcTwoPlusEntryEmployeeName.Name = "dgcTwoPlusEntryEmployeeName";
            dgcTwoPlusEntryEmployeeName.ReadOnly = true;
            dgcTwoPlusEntryEmployeeName.Width = 300;
            // 
            // dgcTwoPlusEntryPunchTime
            // 
            dgcTwoPlusEntryPunchTime.DataPropertyName = "PunchTime";
            dgcTwoPlusEntryPunchTime.HeaderText = "PunchTime";
            dgcTwoPlusEntryPunchTime.MinimumWidth = 8;
            dgcTwoPlusEntryPunchTime.Name = "dgcTwoPlusEntryPunchTime";
            dgcTwoPlusEntryPunchTime.ReadOnly = true;
            dgcTwoPlusEntryPunchTime.Width = 220;
            // 
            // dgcTwoPlusEntryDeviceId
            // 
            dgcTwoPlusEntryDeviceId.DataPropertyName = "DeviceId";
            dgcTwoPlusEntryDeviceId.HeaderText = "DeviceId";
            dgcTwoPlusEntryDeviceId.MinimumWidth = 8;
            dgcTwoPlusEntryDeviceId.Name = "dgcTwoPlusEntryDeviceId";
            dgcTwoPlusEntryDeviceId.ReadOnly = true;
            dgcTwoPlusEntryDeviceId.Visible = false;
            dgcTwoPlusEntryDeviceId.Width = 150;
            // 
            // dgcTwoPlusEntryInOut
            // 
            dgcTwoPlusEntryInOut.DataPropertyName = "PunchTypeFlag";
            dgcTwoPlusEntryInOut.HeaderText = "I/O";
            dgcTwoPlusEntryInOut.MinimumWidth = 8;
            dgcTwoPlusEntryInOut.Name = "dgcTwoPlusEntryInOut";
            dgcTwoPlusEntryInOut.ReadOnly = true;
            dgcTwoPlusEntryInOut.Visible = false;
            dgcTwoPlusEntryInOut.Width = 150;
            // 
            // dgcTwoPlusEntryMode
            // 
            dgcTwoPlusEntryMode.DataPropertyName = "VerificationMode";
            dgcTwoPlusEntryMode.HeaderText = "Mode";
            dgcTwoPlusEntryMode.MinimumWidth = 8;
            dgcTwoPlusEntryMode.Name = "dgcTwoPlusEntryMode";
            dgcTwoPlusEntryMode.ReadOnly = true;
            dgcTwoPlusEntryMode.Visible = false;
            dgcTwoPlusEntryMode.Width = 80;
            // 
            // dgcTwoPlusEntryStatus
            // 
            dgcTwoPlusEntryStatus.DataPropertyName = "StatusCode";
            dgcTwoPlusEntryStatus.HeaderText = "Status";
            dgcTwoPlusEntryStatus.MinimumWidth = 8;
            dgcTwoPlusEntryStatus.Name = "dgcTwoPlusEntryStatus";
            dgcTwoPlusEntryStatus.ReadOnly = true;
            dgcTwoPlusEntryStatus.Visible = false;
            dgcTwoPlusEntryStatus.Width = 80;
            // 
            // dgcTwoPlusEntryCreatedAt
            // 
            dgcTwoPlusEntryCreatedAt.DataPropertyName = "CreatedAt";
            dgcTwoPlusEntryCreatedAt.HeaderText = "CreatedAt";
            dgcTwoPlusEntryCreatedAt.MinimumWidth = 8;
            dgcTwoPlusEntryCreatedAt.Name = "dgcTwoPlusEntryCreatedAt";
            dgcTwoPlusEntryCreatedAt.ReadOnly = true;
            dgcTwoPlusEntryCreatedAt.Visible = false;
            dgcTwoPlusEntryCreatedAt.Width = 150;
            // 
            // dgcTwoPlusEntryBatchCode
            // 
            dgcTwoPlusEntryBatchCode.DataPropertyName = "BatchCode";
            dgcTwoPlusEntryBatchCode.HeaderText = "Batch Code";
            dgcTwoPlusEntryBatchCode.MinimumWidth = 8;
            dgcTwoPlusEntryBatchCode.Name = "dgcTwoPlusEntryBatchCode";
            dgcTwoPlusEntryBatchCode.ReadOnly = true;
            dgcTwoPlusEntryBatchCode.Visible = false;
            dgcTwoPlusEntryBatchCode.Width = 150;
            // 
            // dgcTwoPlusEntryRType
            // 
            dgcTwoPlusEntryRType.DataPropertyName = "RecordType";
            dgcTwoPlusEntryRType.HeaderText = "RType";
            dgcTwoPlusEntryRType.MinimumWidth = 8;
            dgcTwoPlusEntryRType.Name = "dgcTwoPlusEntryRType";
            dgcTwoPlusEntryRType.ReadOnly = true;
            dgcTwoPlusEntryRType.Visible = false;
            dgcTwoPlusEntryRType.Width = 150;
            // 
            // dgcTwoPlusEntryDeleteLog
            // 
            dgcTwoPlusEntryDeleteLog.HeaderText = "Delete";
            dgcTwoPlusEntryDeleteLog.MinimumWidth = 8;
            dgcTwoPlusEntryDeleteLog.Name = "dgcTwoPlusEntryDeleteLog";
            dgcTwoPlusEntryDeleteLog.ReadOnly = true;
            dgcTwoPlusEntryDeleteLog.Text = "Delete";
            dgcTwoPlusEntryDeleteLog.UseColumnTextForLinkValue = true;
            dgcTwoPlusEntryDeleteLog.Width = 150;
            // 
            // dgcTwoPlusEntryEmployeeId
            // 
            dgcTwoPlusEntryEmployeeId.DataPropertyName = "EmployeeId";
            dgcTwoPlusEntryEmployeeId.HeaderText = "Emp.Id";
            dgcTwoPlusEntryEmployeeId.MinimumWidth = 8;
            dgcTwoPlusEntryEmployeeId.Name = "dgcTwoPlusEntryEmployeeId";
            dgcTwoPlusEntryEmployeeId.ReadOnly = true;
            dgcTwoPlusEntryEmployeeId.Visible = false;
            dgcTwoPlusEntryEmployeeId.Width = 150;
            // 
            // comboBoxBatchCode
            // 
            comboBoxBatchCode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBatchCode.FormattingEnabled = true;
            comboBoxBatchCode.Location = new Point(174, 11);
            comboBoxBatchCode.Name = "comboBoxBatchCode";
            comboBoxBatchCode.Size = new Size(585, 33);
            comboBoxBatchCode.TabIndex = 8;
            // 
            // buttonLoadData
            // 
            buttonLoadData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLoadData.ForeColor = Color.RoyalBlue;
            buttonLoadData.Location = new Point(765, 8);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(168, 38);
            buttonLoadData.TabIndex = 9;
            buttonLoadData.Text = "Load Data";
            buttonLoadData.UseVisualStyleBackColor = true;
            buttonLoadData.Click += buttonLoadData_Click;
            // 
            // buttonApplyInOutFlag
            // 
            buttonApplyInOutFlag.Enabled = false;
            buttonApplyInOutFlag.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonApplyInOutFlag.ForeColor = Color.RoyalBlue;
            buttonApplyInOutFlag.Location = new Point(939, 8);
            buttonApplyInOutFlag.Name = "buttonApplyInOutFlag";
            buttonApplyInOutFlag.Size = new Size(206, 38);
            buttonApplyInOutFlag.TabIndex = 10;
            buttonApplyInOutFlag.Text = "Apply IN/OUT Flag";
            buttonApplyInOutFlag.UseVisualStyleBackColor = true;
            buttonApplyInOutFlag.Click += ButtonApplyInOutFlag_Click;
            // 
            // buttonDeleteLog
            // 
            buttonDeleteLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDeleteLog.ForeColor = Color.Brown;
            buttonDeleteLog.Location = new Point(0, 8);
            buttonDeleteLog.Name = "buttonDeleteLog";
            buttonDeleteLog.Size = new Size(168, 38);
            buttonDeleteLog.TabIndex = 11;
            buttonDeleteLog.Text = "Delete Log";
            buttonDeleteLog.UseVisualStyleBackColor = true;
            buttonDeleteLog.Visible = false;
            buttonDeleteLog.Click += buttonDeleteLog_Click;
            // 
            // FormManageMissingLogAdv
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1178, 744);
            Controls.Add(buttonDeleteLog);
            Controls.Add(buttonApplyInOutFlag);
            Controls.Add(buttonLoadData);
            Controls.Add(comboBoxBatchCode);
            Controls.Add(tabControl1);
            Controls.Add(labelBatchCode);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormManageMissingLogAdv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Missing Log";
            Load += FormImportAttendanceLog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBiometricLogs).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageImportedLog.ResumeLayout(false);
            tabPageOneEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOneEntry).EndInit();
            tabPageTwoPlusEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTwoPlusEntry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelBatchCode;
        private TextBox textBoxUserId;
        private Button buttonExit;
        private DataGridView dataGridViewBiometricLogs;
        private OpenFileDialog openAttendanceLogFileDialog;
        private TabControl tabControl1;
        private TabPage tabPageImportedLog;
        private ComboBox comboBoxBatchCode;
        private Button buttonLoadData;
        private TabPage tabPageOneEntry;
        private DataGridView dataGridViewOneEntry;
        private TabPage tabPageTwoPlusEntry;
        private DataGridView dataGridViewTwoPlusEntry;
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
        private DataGridViewTextBoxColumn dgcBiometricLogEmployeeId;
        private DataGridViewTextBoxColumn dgcOneEntryLogId;
        private DataGridViewTextBoxColumn dgcOneEntryBMEmpId;
        private DataGridViewTextBoxColumn dgcOneEntryEmployeeName;
        private DataGridViewTextBoxColumn dgcOneEntryPunchTime;
        private DataGridViewLinkColumn dgcOneEntryAddLog;
        private DataGridViewTextBoxColumn dgcOneEntryDeviceId;
        private DataGridViewTextBoxColumn dgcOneEntryInOut;
        private DataGridViewTextBoxColumn dgcOneEntryMode;
        private DataGridViewTextBoxColumn dgcOneEntryStatus;
        private DataGridViewTextBoxColumn dgcOneEntryCreatedAt;
        private DataGridViewTextBoxColumn dgcOneEntryBatchCode;
        private DataGridViewTextBoxColumn dgcOneEntryRType;
        private DataGridViewTextBoxColumn dgcOneEntryEmployeeId;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryLogId;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryBMEmpId;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryEmployeeName;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryPunchTime;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryDeviceId;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryInOut;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryMode;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryStatus;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryCreatedAt;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryBatchCode;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryRType;
        private DataGridViewLinkColumn dgcTwoPlusEntryDeleteLog;
        private DataGridViewTextBoxColumn dgcTwoPlusEntryEmployeeId;
        private Button buttonApplyInOutFlag;
        private Button buttonDeleteLog;
    }
}
