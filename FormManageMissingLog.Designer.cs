namespace EmpAttendanceSQLite
{
    partial class FormManageMissingLog
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
            labelBatchCode = new Label();
            dataGridViewImportedLogs = new DataGridView();
            dgcLogId = new DataGridViewTextBoxColumn();
            dgcBMEmployeeId = new DataGridViewTextBoxColumn();
            dgcPunchTime = new DataGridViewTextBoxColumn();
            dgcEmployeeName = new DataGridViewTextBoxColumn();
            dgcDeviceId = new DataGridViewTextBoxColumn();
            dgcPunchTypeFlag = new DataGridViewTextBoxColumn();
            dgcVerificationMode = new DataGridViewTextBoxColumn();
            dgcStatusCode = new DataGridViewTextBoxColumn();
            dgcCreatedAt = new DataGridViewTextBoxColumn();
            dgcBatchCode = new DataGridViewTextBoxColumn();
            dgcRecordType = new DataGridViewTextBoxColumn();
            openAttendanceLogFileDialog = new OpenFileDialog();
            tabControl1 = new TabControl();
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
            tabPageImportedLog = new TabPage();
            tabPageGroupByEmployee = new TabPage();
            dataGridViewGroupByEmployee = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            comboBoxBatchCode = new ComboBox();
            buttonLoadData = new Button();
            buttonDeleteBatchData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImportedLogs).BeginInit();
            tabControl1.SuspendLayout();
            tabPageMissingLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMissingLogs).BeginInit();
            tabPageImportedLog.SuspendLayout();
            tabPageGroupByEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroupByEmployee).BeginInit();
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
            dataGridViewImportedLogs.Columns.AddRange(new DataGridViewColumn[] { dgcLogId, dgcBMEmployeeId, dgcPunchTime, dgcEmployeeName, dgcDeviceId, dgcPunchTypeFlag, dgcVerificationMode, dgcStatusCode, dgcCreatedAt, dgcBatchCode, dgcRecordType });
            dataGridViewImportedLogs.Dock = DockStyle.Fill;
            dataGridViewImportedLogs.Location = new Point(3, 3);
            dataGridViewImportedLogs.Name = "dataGridViewImportedLogs";
            dataGridViewImportedLogs.ReadOnly = true;
            dataGridViewImportedLogs.RowHeadersWidth = 62;
            dataGridViewImportedLogs.Size = new Size(1164, 648);
            dataGridViewImportedLogs.TabIndex = 6;
            dataGridViewImportedLogs.RowPrePaint += dataGridViewImportedLogs_RowPrePaint;
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
            // dgcPunchTime
            // 
            dgcPunchTime.DataPropertyName = "PunchTime";
            dgcPunchTime.HeaderText = "PunchTime";
            dgcPunchTime.MinimumWidth = 8;
            dgcPunchTime.Name = "dgcPunchTime";
            dgcPunchTime.ReadOnly = true;
            dgcPunchTime.Width = 220;
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
            // openAttendanceLogFileDialog
            // 
            openAttendanceLogFileDialog.Filter = "Backup File | *.dat";
            openAttendanceLogFileDialog.Title = "Attendance Log";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageMissingLogs);
            tabControl1.Controls.Add(tabPageImportedLog);
            tabControl1.Controls.Add(tabPageGroupByEmployee);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI", 9F);
            tabControl1.Location = new Point(0, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1178, 692);
            tabControl1.TabIndex = 7;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMissingLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // tabPageImportedLog
            // 
            tabPageImportedLog.Controls.Add(dataGridViewImportedLogs);
            tabPageImportedLog.Location = new Point(4, 34);
            tabPageImportedLog.Name = "tabPageImportedLog";
            tabPageImportedLog.Padding = new Padding(3);
            tabPageImportedLog.Size = new Size(1170, 654);
            tabPageImportedLog.TabIndex = 0;
            tabPageImportedLog.Text = "#Imported Logs     ";
            tabPageImportedLog.UseVisualStyleBackColor = true;
            // 
            // tabPageGroupByEmployee
            // 
            tabPageGroupByEmployee.Controls.Add(dataGridViewGroupByEmployee);
            tabPageGroupByEmployee.Location = new Point(4, 34);
            tabPageGroupByEmployee.Name = "tabPageGroupByEmployee";
            tabPageGroupByEmployee.Size = new Size(1170, 654);
            tabPageGroupByEmployee.TabIndex = 2;
            tabPageGroupByEmployee.Text = "#Group By Employee     ";
            tabPageGroupByEmployee.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGroupByEmployee
            // 
            dataGridViewGroupByEmployee.AllowUserToAddRows = false;
            dataGridViewGroupByEmployee.AllowUserToDeleteRows = false;
            dataGridViewGroupByEmployee.BackgroundColor = Color.Gainsboro;
            dataGridViewGroupByEmployee.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewGroupByEmployee.ColumnHeadersHeight = 40;
            dataGridViewGroupByEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewGroupByEmployee.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dataGridViewGroupByEmployee.Dock = DockStyle.Fill;
            dataGridViewGroupByEmployee.Location = new Point(0, 0);
            dataGridViewGroupByEmployee.Name = "dataGridViewGroupByEmployee";
            dataGridViewGroupByEmployee.ReadOnly = true;
            dataGridViewGroupByEmployee.RowHeadersWidth = 62;
            dataGridViewGroupByEmployee.Size = new Size(1170, 654);
            dataGridViewGroupByEmployee.TabIndex = 7;
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
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PunchTime";
            dataGridViewTextBoxColumn3.HeaderText = "PunchTime";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 220;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "EmployeeName";
            dataGridViewTextBoxColumn4.HeaderText = "Employee Name";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "DeviceId";
            dataGridViewTextBoxColumn5.HeaderText = "DeviceId";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "PunchTypeFlag";
            dataGridViewTextBoxColumn6.HeaderText = "I/O";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
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
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // comboBoxBatchCode
            // 
            comboBoxBatchCode.FormattingEnabled = true;
            comboBoxBatchCode.Location = new Point(174, 8);
            comboBoxBatchCode.Name = "comboBoxBatchCode";
            comboBoxBatchCode.Size = new Size(318, 33);
            comboBoxBatchCode.TabIndex = 8;
            // 
            // buttonLoadData
            // 
            buttonLoadData.Location = new Point(498, 5);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(226, 38);
            buttonLoadData.TabIndex = 9;
            buttonLoadData.Text = "Load Data";
            buttonLoadData.UseVisualStyleBackColor = true;
            buttonLoadData.Click += buttonLoadData_Click;
            // 
            // buttonDeleteBatchData
            // 
            buttonDeleteBatchData.Location = new Point(730, 6);
            buttonDeleteBatchData.Name = "buttonDeleteBatchData";
            buttonDeleteBatchData.Size = new Size(226, 38);
            buttonDeleteBatchData.TabIndex = 10;
            buttonDeleteBatchData.Text = "Delete Batch Data";
            buttonDeleteBatchData.UseVisualStyleBackColor = true;
            buttonDeleteBatchData.Click += buttonDeleteBatchData_Click;
            // 
            // FormManageMissingLog
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1178, 744);
            Controls.Add(buttonDeleteBatchData);
            Controls.Add(buttonLoadData);
            Controls.Add(comboBoxBatchCode);
            Controls.Add(tabControl1);
            Controls.Add(labelBatchCode);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormManageMissingLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Missing Log";
            Load += FormImportAttendanceLog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewImportedLogs).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageMissingLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMissingLogs).EndInit();
            tabPageImportedLog.ResumeLayout(false);
            tabPageGroupByEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroupByEmployee).EndInit();
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
        private Button buttonDeleteBatchData;
        private DataGridViewLinkColumn dgcMissingAddLog;
        private DataGridViewTextBoxColumn dgcMissingLogId;
        private DataGridViewTextBoxColumn dgcMIssingBMEmployeeId;
        private DataGridViewTextBoxColumn dgcMissingEmployeeName;
        private DataGridViewTextBoxColumn dgcMissingEmployeeId;
        private DataGridViewTextBoxColumn dgcMissingPunchDate;
        private DataGridViewTextBoxColumn dgcMIssingMissingType;
        private DataGridViewTextBoxColumn dgcMissingCreatedAt;
        private DataGridViewTextBoxColumn dgcMissingBatchCode;
        private DataGridViewTextBoxColumn dgcLogId;
        private DataGridViewTextBoxColumn dgcBMEmployeeId;
        private DataGridViewTextBoxColumn dgcPunchTime;
        private DataGridViewTextBoxColumn dgcEmployeeName;
        private DataGridViewTextBoxColumn dgcDeviceId;
        private DataGridViewTextBoxColumn dgcPunchTypeFlag;
        private DataGridViewTextBoxColumn dgcVerificationMode;
        private DataGridViewTextBoxColumn dgcStatusCode;
        private DataGridViewTextBoxColumn dgcCreatedAt;
        private DataGridViewTextBoxColumn dgcBatchCode;
        private DataGridViewTextBoxColumn dgcRecordType;
        private TabPage tabPageGroupByEmployee;
        private DataGridView dataGridViewGroupByEmployee;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}
