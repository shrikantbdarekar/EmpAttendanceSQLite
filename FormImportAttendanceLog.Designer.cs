namespace EmpAttendanceSQLite
{
    partial class FormImportAttendanceLog
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
            buttonLogin = new Button();
            label1 = new Label();
            textBoxUserId = new TextBox();
            buttonExit = new Button();
            dataGridViewMain = new DataGridView();
            dgcUserId = new DataGridViewTextBoxColumn();
            dgcUserName = new DataGridViewTextBoxColumn();
            dgcContactNo = new DataGridViewTextBoxColumn();
            dgcDesignation = new DataGridViewTextBoxColumn();
            dgcMonthlySalary = new DataGridViewTextBoxColumn();
            openAttendanceLogFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(609, 24);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(106, 38);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Import";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonImport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "File Name";
            // 
            // textBoxUserId
            // 
            textBoxUserId.Enabled = false;
            textBoxUserId.Location = new Point(150, 28);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(442, 31);
            textBoxUserId.TabIndex = 2;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(721, 24);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(106, 38);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
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
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { dgcUserId, dgcUserName, dgcContactNo, dgcDesignation, dgcMonthlySalary });
            dataGridViewMain.Dock = DockStyle.Bottom;
            dataGridViewMain.Location = new Point(0, 85);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowHeadersWidth = 62;
            dataGridViewMain.Size = new Size(1178, 659);
            dataGridViewMain.TabIndex = 6;
            // 
            // dgcUserId
            // 
            dgcUserId.HeaderText = "Id";
            dgcUserId.MinimumWidth = 8;
            dgcUserId.Name = "dgcUserId";
            dgcUserId.Visible = false;
            dgcUserId.Width = 150;
            // 
            // dgcUserName
            // 
            dgcUserName.HeaderText = "Employee Name";
            dgcUserName.MinimumWidth = 8;
            dgcUserName.Name = "dgcUserName";
            dgcUserName.Width = 300;
            // 
            // dgcContactNo
            // 
            dgcContactNo.HeaderText = "ContactNo";
            dgcContactNo.MinimumWidth = 8;
            dgcContactNo.Name = "dgcContactNo";
            dgcContactNo.Width = 150;
            // 
            // dgcDesignation
            // 
            dgcDesignation.HeaderText = "Designation";
            dgcDesignation.MinimumWidth = 8;
            dgcDesignation.Name = "dgcDesignation";
            dgcDesignation.Width = 150;
            // 
            // dgcMonthlySalary
            // 
            dgcMonthlySalary.HeaderText = "Salary";
            dgcMonthlySalary.MinimumWidth = 8;
            dgcMonthlySalary.Name = "dgcMonthlySalary";
            dgcMonthlySalary.Width = 150;
            // 
            // openAttendanceLogFileDialog
            // 
            openAttendanceLogFileDialog.FileName = "*.csv";
            openAttendanceLogFileDialog.Title = "Attendance Log";
            // 
            // FormImportAttendanceLog
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1178, 744);
            Controls.Add(dataGridViewMain);
            Controls.Add(buttonExit);
            Controls.Add(textBoxUserId);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormImportAttendanceLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import Attendance Log";
            Load += FormImportAttendanceLog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label1;
        private TextBox textBoxUserId;
        private Button buttonExit;
        private DataGridView dataGridViewMain;
        private DataGridViewTextBoxColumn dgcUserId;
        private DataGridViewTextBoxColumn dgcUserName;
        private DataGridViewTextBoxColumn dgcContactNo;
        private DataGridViewTextBoxColumn dgcDesignation;
        private DataGridViewTextBoxColumn dgcMonthlySalary;
        private OpenFileDialog openAttendanceLogFileDialog;
    }
}
