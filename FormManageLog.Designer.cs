namespace EmpAttendanceSQLite
{
    partial class FormManageLog
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelDate = new Label();
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
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            label1 = new Label();
            buttonLoadData = new Button();
            comboBoxEmployee = new ComboBox();
            label2 = new Label();
            labelTotal = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            buttonInOut = new Button();
            buttonAmPm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 10F);
            labelDate.Location = new Point(12, 13);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(53, 28);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.AllowUserToDeleteRows = false;
            dataGridViewMain.BackgroundColor = Color.Gainsboro;
            dataGridViewMain.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMain.ColumnHeadersHeight = 40;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { dgcLogId, dgcBMEmployeeId, dgcPunchTime, dgcDeviceId, dgcPunchTypeFlag, dgcVerificationMode, dgcStatusCode, dgcCreatedAt });
            dataGridViewMain.Dock = DockStyle.Fill;
            dataGridViewMain.Location = new Point(3, 3);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.ReadOnly = true;
            dataGridViewMain.RowHeadersWidth = 62;
            dataGridViewMain.Size = new Size(1157, 594);
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
            dgcPunchTime.Width = 300;
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
            dgcPunchTypeFlag.HeaderText = "PunchType";
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
            dgcCreatedAt.Visible = false;
            dgcCreatedAt.Width = 150;
            // 
            // openAttendanceLogFileDialog
            // 
            openAttendanceLogFileDialog.Filter = "Backup File | *.dat";
            openAttendanceLogFileDialog.Title = "Attendance Log";
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(115, 12);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(158, 31);
            dtpFromDate.TabIndex = 27;
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(317, 12);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(158, 31);
            dtpToDate.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(279, 13);
            label1.Name = "label1";
            label1.Size = new Size(32, 28);
            label1.TabIndex = 29;
            label1.Text = "To";
            // 
            // buttonLoadData
            // 
            buttonLoadData.Location = new Point(496, 10);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(120, 38);
            buttonLoadData.TabIndex = 30;
            buttonLoadData.Text = "Load Data";
            buttonLoadData.UseVisualStyleBackColor = true;
            buttonLoadData.Click += buttonLoadData_Click;
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(115, 53);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(360, 33);
            comboBoxEmployee.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(11, 55);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 44;
            label2.Text = "Employee";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 10F);
            labelTotal.Location = new Point(496, 55);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(113, 28);
            labelTotal.TabIndex = 45;
            labelTotal.Text = "Total Rows: ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1171, 638);
            tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewMain);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1163, 600);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1163, 600);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1157, 594);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1163, 600);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1157, 594);
            dataGridView2.TabIndex = 1;
            // 
            // buttonInOut
            // 
            buttonInOut.Location = new Point(738, 10);
            buttonInOut.Name = "buttonInOut";
            buttonInOut.Size = new Size(120, 38);
            buttonInOut.TabIndex = 47;
            buttonInOut.Text = "In Out";
            buttonInOut.UseVisualStyleBackColor = true;
            buttonInOut.Click += buttonInOut_Click;
            // 
            // buttonAmPm
            // 
            buttonAmPm.Location = new Point(886, 10);
            buttonAmPm.Name = "buttonAmPm";
            buttonAmPm.Size = new Size(120, 38);
            buttonAmPm.TabIndex = 48;
            buttonAmPm.Text = "Am Pm";
            buttonAmPm.UseVisualStyleBackColor = true;
            buttonAmPm.Click += buttonAmPm_Click;
            // 
            // FormManageLog
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1171, 744);
            Controls.Add(buttonAmPm);
            Controls.Add(buttonInOut);
            Controls.Add(tabControl1);
            Controls.Add(labelTotal);
            Controls.Add(label2);
            Controls.Add(comboBoxEmployee);
            Controls.Add(buttonLoadData);
            Controls.Add(label1);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(labelDate);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormManageLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Log Data";
            Load += FormImportAttendanceLog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelDate;
        private TextBox textBoxUserId;
        private Button buttonExit;
        private DataGridView dataGridViewMain;
        private OpenFileDialog openAttendanceLogFileDialog;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Label label1;
        private Button buttonLoadData;
        private ComboBox comboBoxEmployee;
        private Label label2;
        private DataGridViewTextBoxColumn dgcLogId;
        private DataGridViewTextBoxColumn dgcBMEmployeeId;
        private DataGridViewTextBoxColumn dgcPunchTime;
        private DataGridViewTextBoxColumn dgcDeviceId;
        private DataGridViewTextBoxColumn dgcPunchTypeFlag;
        private DataGridViewTextBoxColumn dgcVerificationMode;
        private DataGridViewTextBoxColumn dgcStatusCode;
        private DataGridViewTextBoxColumn dgcCreatedAt;
        private Label labelTotal;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private Button buttonInOut;
        private Button buttonAmPm;
    }
}
