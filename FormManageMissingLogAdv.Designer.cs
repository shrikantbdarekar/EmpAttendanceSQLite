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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelBatchCode = new Label();
            dataGridViewImportedLogs = new DataGridView();
            openAttendanceLogFileDialog = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPageImportedLog = new TabPage();
            tabPageOneEntry = new TabPage();
            dataGridViewOneEntry = new DataGridView();
            tabPageTwoPlusEntry = new TabPage();
            dataGridViewTwoPlusEntry = new DataGridView();
            tabPageMissingLogs = new TabPage();
            dataGridViewMissingLogs = new DataGridView();
            dgcMissingAddLog = new DataGridViewLinkColumn();
            dgcMissingLogId = new DataGridViewTextBoxColumn();
            dgcMIssingBMEmployeeId = new DataGridViewTextBoxColumn();
            dgcMissingEmployeeName = new DataGridViewTextBoxColumn();
            dgcMissingEmployeeId = new DataGridViewTextBoxColumn();
            dgcMissingPunchDate = new DataGridViewTextBoxColumn();
            dgcMIssingMissingType = new DataGridViewTextBoxColumn();
            dgcMissingCreatedAt = new DataGridViewTextBoxColumn();
            dgcMissingBatchCode = new DataGridViewTextBoxColumn();
            comboBoxBatchCode = new ComboBox();
            buttonLoadData = new Button();
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dgcDuplicatesAdd = new DataGridViewLinkColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            dataGridViewLinkColumn2 = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImportedLogs).BeginInit();
            tabControl1.SuspendLayout();
            tabPageImportedLog.SuspendLayout();
            tabPageOneEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOneEntry).BeginInit();
            tabPageTwoPlusEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTwoPlusEntry).BeginInit();
            tabPageMissingLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMissingLogs).BeginInit();
            SuspendLayout();
            // 
            // labelBatchCode
            // 
            labelBatchCode.AutoSize = true;
            labelBatchCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBatchCode.Location = new Point(12, 9);
            labelBatchCode.Name = "labelBatchCode";
            labelBatchCode.Size = new Size(124, 30);
            labelBatchCode.TabIndex = 1;
            labelBatchCode.Text = "Batch Code";
            // 
            // dataGridViewImportedLogs
            // 
            dataGridViewImportedLogs.AllowUserToAddRows = false;
            dataGridViewImportedLogs.AllowUserToDeleteRows = false;
            dataGridViewImportedLogs.BackgroundColor = Color.Gainsboro;
            dataGridViewImportedLogs.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewImportedLogs.ColumnHeadersHeight = 40;
            dataGridViewImportedLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewImportedLogs.Columns.AddRange(new DataGridViewColumn[] { dgcLogId, dgcBMEmployeeId, dgcEmployeeName, dgcPunchTime, dgcDeviceId, dgcPunchTypeFlag, dgcVerificationMode, dgcStatusCode, dgcCreatedAt, dgcBatchCode, dgcRecordType });
            dataGridViewImportedLogs.Dock = DockStyle.Fill;
            dataGridViewImportedLogs.Location = new Point(3, 3);
            dataGridViewImportedLogs.Name = "dataGridViewImportedLogs";
            dataGridViewImportedLogs.ReadOnly = true;
            dataGridViewImportedLogs.RowHeadersWidth = 62;
            dataGridViewImportedLogs.Size = new Size(1164, 648);
            dataGridViewImportedLogs.TabIndex = 6;
            dataGridViewImportedLogs.RowPrePaint += dataGridViewImportedLogs_RowPrePaint;
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
            tabControl1.Controls.Add(tabPageMissingLogs);
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
            tabPageImportedLog.Controls.Add(dataGridViewImportedLogs);
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
            dataGridViewOneEntry.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn3, dgcDuplicatesAdd, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dataGridViewOneEntry.Dock = DockStyle.Fill;
            dataGridViewOneEntry.Location = new Point(0, 0);
            dataGridViewOneEntry.Name = "dataGridViewOneEntry";
            dataGridViewOneEntry.ReadOnly = true;
            dataGridViewOneEntry.RowHeadersWidth = 62;
            dataGridViewOneEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOneEntry.Size = new Size(1170, 654);
            dataGridViewOneEntry.TabIndex = 7;
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
            dataGridViewTwoPlusEntry.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21, dataGridViewTextBoxColumn22, dataGridViewLinkColumn2 });
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
            dataGridViewTwoPlusEntry.Size = new Size(1164, 648);
            dataGridViewTwoPlusEntry.TabIndex = 8;
            // 
            // tabPageMissingLogs
            // 
            tabPageMissingLogs.Controls.Add(dataGridViewMissingLogs);
            tabPageMissingLogs.Font = new Font("Segoe UI", 9F);
            tabPageMissingLogs.Location = new Point(4, 34);
            tabPageMissingLogs.Margin = new Padding(3, 3, 10, 3);
            tabPageMissingLogs.Name = "tabPageMissingLogs";
            tabPageMissingLogs.Padding = new Padding(3);
            tabPageMissingLogs.Size = new Size(1170, 654);
            tabPageMissingLogs.TabIndex = 1;
            tabPageMissingLogs.Text = "#Missing Logs     ";
            tabPageMissingLogs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMissingLogs
            // 
            dataGridViewMissingLogs.AllowUserToAddRows = false;
            dataGridViewMissingLogs.AllowUserToDeleteRows = false;
            dataGridViewMissingLogs.BackgroundColor = Color.Gainsboro;
            dataGridViewMissingLogs.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewMissingLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewMissingLogs.ColumnHeadersHeight = 40;
            dataGridViewMissingLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMissingLogs.Columns.AddRange(new DataGridViewColumn[] { dgcMissingAddLog, dgcMissingLogId, dgcMIssingBMEmployeeId, dgcMissingEmployeeName, dgcMissingEmployeeId, dgcMissingPunchDate, dgcMIssingMissingType, dgcMissingCreatedAt, dgcMissingBatchCode });
            dataGridViewMissingLogs.Dock = DockStyle.Fill;
            dataGridViewMissingLogs.Location = new Point(3, 3);
            dataGridViewMissingLogs.Name = "dataGridViewMissingLogs";
            dataGridViewMissingLogs.ReadOnly = true;
            dataGridViewMissingLogs.RowHeadersWidth = 62;
            dataGridViewMissingLogs.Size = new Size(1164, 648);
            dataGridViewMissingLogs.TabIndex = 7;
            dataGridViewMissingLogs.CellContentClick += dataGridViewMissingLogs_CellContentClick;
            // 
            // dgcMissingAddLog
            // 
            dgcMissingAddLog.HeaderText = "Add Log";
            dgcMissingAddLog.MinimumWidth = 8;
            dgcMissingAddLog.Name = "dgcMissingAddLog";
            dgcMissingAddLog.ReadOnly = true;
            dgcMissingAddLog.Text = "Add Log";
            dgcMissingAddLog.UseColumnTextForLinkValue = true;
            dgcMissingAddLog.Width = 150;
            // 
            // dgcMissingLogId
            // 
            dgcMissingLogId.DataPropertyName = "MissingLogId";
            dgcMissingLogId.HeaderText = "Log Id";
            dgcMissingLogId.MinimumWidth = 8;
            dgcMissingLogId.Name = "dgcMissingLogId";
            dgcMissingLogId.ReadOnly = true;
            dgcMissingLogId.Visible = false;
            dgcMissingLogId.Width = 150;
            // 
            // dgcMIssingBMEmployeeId
            // 
            dgcMIssingBMEmployeeId.DataPropertyName = "BMEmployeeId";
            dgcMIssingBMEmployeeId.HeaderText = "BM Emp.Id";
            dgcMIssingBMEmployeeId.MinimumWidth = 8;
            dgcMIssingBMEmployeeId.Name = "dgcMIssingBMEmployeeId";
            dgcMIssingBMEmployeeId.ReadOnly = true;
            dgcMIssingBMEmployeeId.Width = 150;
            // 
            // dgcMissingEmployeeName
            // 
            dgcMissingEmployeeName.DataPropertyName = "EmployeeName";
            dgcMissingEmployeeName.HeaderText = "EmployeeName";
            dgcMissingEmployeeName.MinimumWidth = 8;
            dgcMissingEmployeeName.Name = "dgcMissingEmployeeName";
            dgcMissingEmployeeName.ReadOnly = true;
            dgcMissingEmployeeName.Width = 220;
            // 
            // dgcMissingEmployeeId
            // 
            dgcMissingEmployeeId.DataPropertyName = "EmployeeId";
            dgcMissingEmployeeId.HeaderText = "Employee Id";
            dgcMissingEmployeeId.MinimumWidth = 8;
            dgcMissingEmployeeId.Name = "dgcMissingEmployeeId";
            dgcMissingEmployeeId.ReadOnly = true;
            dgcMissingEmployeeId.Visible = false;
            dgcMissingEmployeeId.Width = 150;
            // 
            // dgcMissingPunchDate
            // 
            dgcMissingPunchDate.DataPropertyName = "PunchDate";
            dgcMissingPunchDate.HeaderText = "Punch Date";
            dgcMissingPunchDate.MinimumWidth = 8;
            dgcMissingPunchDate.Name = "dgcMissingPunchDate";
            dgcMissingPunchDate.ReadOnly = true;
            dgcMissingPunchDate.Width = 150;
            // 
            // dgcMIssingMissingType
            // 
            dgcMIssingMissingType.DataPropertyName = "MissingType";
            dgcMIssingMissingType.HeaderText = "Missing Type";
            dgcMIssingMissingType.MinimumWidth = 8;
            dgcMIssingMissingType.Name = "dgcMIssingMissingType";
            dgcMIssingMissingType.ReadOnly = true;
            dgcMIssingMissingType.Width = 150;
            // 
            // dgcMissingCreatedAt
            // 
            dgcMissingCreatedAt.DataPropertyName = "CreatedAt";
            dgcMissingCreatedAt.HeaderText = "Created At";
            dgcMissingCreatedAt.MinimumWidth = 8;
            dgcMissingCreatedAt.Name = "dgcMissingCreatedAt";
            dgcMissingCreatedAt.ReadOnly = true;
            dgcMissingCreatedAt.Visible = false;
            dgcMissingCreatedAt.Width = 150;
            // 
            // dgcMissingBatchCode
            // 
            dgcMissingBatchCode.DataPropertyName = "BatchCode";
            dgcMissingBatchCode.HeaderText = "Batch Code";
            dgcMissingBatchCode.MinimumWidth = 8;
            dgcMissingBatchCode.Name = "dgcMissingBatchCode";
            dgcMissingBatchCode.ReadOnly = true;
            dgcMissingBatchCode.Visible = false;
            dgcMissingBatchCode.Width = 250;
            // 
            // comboBoxBatchCode
            // 
            comboBoxBatchCode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBatchCode.FormattingEnabled = true;
            comboBoxBatchCode.Location = new Point(174, 8);
            comboBoxBatchCode.Name = "comboBoxBatchCode";
            comboBoxBatchCode.Size = new Size(760, 33);
            comboBoxBatchCode.TabIndex = 8;
            // 
            // buttonLoadData
            // 
            buttonLoadData.Location = new Point(940, 5);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(226, 38);
            buttonLoadData.TabIndex = 9;
            buttonLoadData.Text = "Load Data";
            buttonLoadData.UseVisualStyleBackColor = true;
            buttonLoadData.Click += buttonLoadData_Click;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "LogId";
            dataGridViewTextBoxColumn1.HeaderText = "LogId";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "BMEmployeeId";
            dataGridViewTextBoxColumn2.HeaderText = "BMEmp.Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "EmployeeName";
            dataGridViewTextBoxColumn4.HeaderText = "Employee Name";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PunchTime";
            dataGridViewTextBoxColumn3.HeaderText = "PunchTime";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 220;
            // 
            // dgcDuplicatesAdd
            // 
            dgcDuplicatesAdd.HeaderText = "Add Log";
            dgcDuplicatesAdd.MinimumWidth = 8;
            dgcDuplicatesAdd.Name = "dgcDuplicatesAdd";
            dgcDuplicatesAdd.ReadOnly = true;
            dgcDuplicatesAdd.Text = "Add Log";
            dgcDuplicatesAdd.UseColumnTextForLinkValue = true;
            dgcDuplicatesAdd.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "DeviceId";
            dataGridViewTextBoxColumn5.HeaderText = "DeviceId";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "PunchTypeFlag";
            dataGridViewTextBoxColumn6.HeaderText = "I/O";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Visible = false;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "VerificationMode";
            dataGridViewTextBoxColumn7.HeaderText = "Mode";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Visible = false;
            dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "StatusCode";
            dataGridViewTextBoxColumn8.HeaderText = "Status";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Visible = false;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "CreatedAt";
            dataGridViewTextBoxColumn9.HeaderText = "CreatedAt";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "BatchCode";
            dataGridViewTextBoxColumn10.HeaderText = "Batch Code";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "RecordType";
            dataGridViewTextBoxColumn11.HeaderText = "RType";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Visible = false;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "LogId";
            dataGridViewTextBoxColumn12.HeaderText = "LogId";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Visible = false;
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "BMEmployeeId";
            dataGridViewTextBoxColumn13.HeaderText = "BMEmp.Id";
            dataGridViewTextBoxColumn13.MinimumWidth = 8;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "EmployeeName";
            dataGridViewTextBoxColumn15.HeaderText = "Employee Name";
            dataGridViewTextBoxColumn15.MinimumWidth = 8;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Width = 300;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "PunchTime";
            dataGridViewTextBoxColumn14.HeaderText = "PunchTime";
            dataGridViewTextBoxColumn14.MinimumWidth = 8;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Width = 220;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "DeviceId";
            dataGridViewTextBoxColumn16.HeaderText = "DeviceId";
            dataGridViewTextBoxColumn16.MinimumWidth = 8;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            dataGridViewTextBoxColumn16.Visible = false;
            dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "PunchTypeFlag";
            dataGridViewTextBoxColumn17.HeaderText = "I/O";
            dataGridViewTextBoxColumn17.MinimumWidth = 8;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            dataGridViewTextBoxColumn17.Visible = false;
            dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "VerificationMode";
            dataGridViewTextBoxColumn18.HeaderText = "Mode";
            dataGridViewTextBoxColumn18.MinimumWidth = 8;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            dataGridViewTextBoxColumn18.Visible = false;
            dataGridViewTextBoxColumn18.Width = 80;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "StatusCode";
            dataGridViewTextBoxColumn19.HeaderText = "Status";
            dataGridViewTextBoxColumn19.MinimumWidth = 8;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.Visible = false;
            dataGridViewTextBoxColumn19.Width = 80;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "CreatedAt";
            dataGridViewTextBoxColumn20.HeaderText = "CreatedAt";
            dataGridViewTextBoxColumn20.MinimumWidth = 8;
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            dataGridViewTextBoxColumn20.Visible = false;
            dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "BatchCode";
            dataGridViewTextBoxColumn21.HeaderText = "Batch Code";
            dataGridViewTextBoxColumn21.MinimumWidth = 8;
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            dataGridViewTextBoxColumn21.Visible = false;
            dataGridViewTextBoxColumn21.Width = 150;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.DataPropertyName = "RecordType";
            dataGridViewTextBoxColumn22.HeaderText = "RType";
            dataGridViewTextBoxColumn22.MinimumWidth = 8;
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            dataGridViewTextBoxColumn22.Visible = false;
            dataGridViewTextBoxColumn22.Width = 150;
            // 
            // dataGridViewLinkColumn2
            // 
            dataGridViewLinkColumn2.HeaderText = "Delete";
            dataGridViewLinkColumn2.MinimumWidth = 8;
            dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            dataGridViewLinkColumn2.ReadOnly = true;
            dataGridViewLinkColumn2.Text = "Delete";
            dataGridViewLinkColumn2.UseColumnTextForLinkValue = true;
            dataGridViewLinkColumn2.Width = 150;
            // 
            // FormManageMissingLogAdv
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1178, 744);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewImportedLogs).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageImportedLog.ResumeLayout(false);
            tabPageOneEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOneEntry).EndInit();
            tabPageTwoPlusEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTwoPlusEntry).EndInit();
            tabPageMissingLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMissingLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelBatchCode;
        private TextBox textBoxUserId;
        private Button buttonExit;
        private DataGridView dataGridViewImportedLogs;
        private OpenFileDialog openAttendanceLogFileDialog;
        private TabControl tabControl1;
        private TabPage tabPageImportedLog;
        private TabPage tabPageMissingLogs;
        private DataGridView dataGridViewMissingLogs;
        private ComboBox comboBoxBatchCode;
        private Button buttonLoadData;
        private DataGridViewLinkColumn dgcMissingAddLog;
        private DataGridViewTextBoxColumn dgcMissingLogId;
        private DataGridViewTextBoxColumn dgcMIssingBMEmployeeId;
        private DataGridViewTextBoxColumn dgcMissingEmployeeName;
        private DataGridViewTextBoxColumn dgcMissingEmployeeId;
        private DataGridViewTextBoxColumn dgcMissingPunchDate;
        private DataGridViewTextBoxColumn dgcMIssingMissingType;
        private DataGridViewTextBoxColumn dgcMissingCreatedAt;
        private DataGridViewTextBoxColumn dgcMissingBatchCode;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewLinkColumn dgcDuplicatesAdd;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewLinkColumn dataGridViewLinkColumn2;
    }
}
