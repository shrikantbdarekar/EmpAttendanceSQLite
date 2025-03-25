namespace EmpAttendanceSQLite
{
    partial class FormImportView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelMessage = new Label();
            dataGridViewMain = new DataGridView();
            dgcLogId = new DataGridViewTextBoxColumn();
            dgcBMEmployeeId = new DataGridViewTextBoxColumn();
            dgcPunchTime = new DataGridViewTextBoxColumn();
            dgcDeviceId = new DataGridViewTextBoxColumn();
            dgcPunchTypeFlag = new DataGridViewTextBoxColumn();
            dgcVerificationMode = new DataGridViewTextBoxColumn();
            dgcStatusCode = new DataGridViewTextBoxColumn();
            dgcCreatedAt = new DataGridViewTextBoxColumn();
            openAttendanceLogFileDialog = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPageImportedLog = new TabPage();
            tabPageMissingLogs = new TabPage();
            dataGridViewMissingLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            tabControl1.SuspendLayout();
            tabPageImportedLog.SuspendLayout();
            tabPageMissingLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMissingLogs).BeginInit();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.Location = new Point(12, 9);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(156, 30);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "Messege Place";
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.AllowUserToDeleteRows = false;
            dataGridViewMain.BackgroundColor = Color.Gainsboro;
            dataGridViewMain.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMain.ColumnHeadersHeight = 40;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { dgcLogId, dgcBMEmployeeId, dgcPunchTime, dgcDeviceId, dgcPunchTypeFlag, dgcVerificationMode, dgcStatusCode, dgcCreatedAt });
            dataGridViewMain.Dock = DockStyle.Fill;
            dataGridViewMain.Location = new Point(3, 3);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.ReadOnly = true;
            dataGridViewMain.RowHeadersWidth = 62;
            dataGridViewMain.Size = new Size(1164, 648);
            dataGridViewMain.TabIndex = 6;
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
            dgcPunchTime.Width = 150;
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
            dgcPunchTypeFlag.HeaderText = "PunchType";
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
            dgcVerificationMode.Width = 150;
            // 
            // dgcStatusCode
            // 
            dgcStatusCode.DataPropertyName = "StatusCode";
            dgcStatusCode.HeaderText = "I/O";
            dgcStatusCode.MinimumWidth = 8;
            dgcStatusCode.Name = "dgcStatusCode";
            dgcStatusCode.ReadOnly = true;
            dgcStatusCode.Width = 150;
            // 
            // dgcCreatedAt
            // 
            dgcCreatedAt.DataPropertyName = "CreatedAt";
            dgcCreatedAt.HeaderText = "CreatedAt";
            dgcCreatedAt.MinimumWidth = 8;
            dgcCreatedAt.Name = "dgcCreatedAt";
            dgcCreatedAt.ReadOnly = true;
            dgcCreatedAt.Width = 150;
            // 
            // openAttendanceLogFileDialog
            // 
            openAttendanceLogFileDialog.Filter = "Backup File | *.dat";
            openAttendanceLogFileDialog.Title = "Attendance Log";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageImportedLog);
            tabControl1.Controls.Add(tabPageMissingLogs);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1178, 692);
            tabControl1.TabIndex = 7;
            // 
            // tabPageImportedLog
            // 
            tabPageImportedLog.Controls.Add(dataGridViewMain);
            tabPageImportedLog.Location = new Point(4, 34);
            tabPageImportedLog.Name = "tabPageImportedLog";
            tabPageImportedLog.Padding = new Padding(3);
            tabPageImportedLog.Size = new Size(1170, 654);
            tabPageImportedLog.TabIndex = 0;
            tabPageImportedLog.Text = "Imported Logs";
            tabPageImportedLog.UseVisualStyleBackColor = true;
            // 
            // tabPageMissingLogs
            // 
            tabPageMissingLogs.Controls.Add(dataGridViewMissingLogs);
            tabPageMissingLogs.Location = new Point(4, 34);
            tabPageMissingLogs.Name = "tabPageMissingLogs";
            tabPageMissingLogs.Padding = new Padding(3);
            tabPageMissingLogs.Size = new Size(1170, 654);
            tabPageMissingLogs.TabIndex = 1;
            tabPageMissingLogs.Text = "Missing Logs";
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
            dataGridViewMissingLogs.Dock = DockStyle.Fill;
            dataGridViewMissingLogs.Location = new Point(3, 3);
            dataGridViewMissingLogs.Name = "dataGridViewMissingLogs";
            dataGridViewMissingLogs.ReadOnly = true;
            dataGridViewMissingLogs.RowHeadersWidth = 62;
            dataGridViewMissingLogs.Size = new Size(1164, 648);
            dataGridViewMissingLogs.TabIndex = 7;
            // 
            // FormImportView
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1178, 744);
            Controls.Add(tabControl1);
            Controls.Add(labelMessage);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormImportView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import Data";
            Load += FormImportAttendanceLog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageImportedLog.ResumeLayout(false);
            tabPageMissingLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMissingLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelMessage;
        private TextBox textBoxUserId;
        private Button buttonExit;
        private DataGridView dataGridViewMain;
        private OpenFileDialog openAttendanceLogFileDialog;
        private DataGridViewTextBoxColumn dgcLogId;
        private DataGridViewTextBoxColumn dgcBMEmployeeId;
        private DataGridViewTextBoxColumn dgcPunchTime;
        private DataGridViewTextBoxColumn dgcDeviceId;
        private DataGridViewTextBoxColumn dgcPunchTypeFlag;
        private DataGridViewTextBoxColumn dgcVerificationMode;
        private DataGridViewTextBoxColumn dgcStatusCode;
        private DataGridViewTextBoxColumn dgcCreatedAt;
        private TabControl tabControl1;
        private TabPage tabPageImportedLog;
        private TabPage tabPageMissingLogs;
        private DataGridView dataGridViewMissingLogs;
    }
}
