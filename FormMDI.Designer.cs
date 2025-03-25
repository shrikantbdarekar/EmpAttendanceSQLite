namespace EmpAttendanceSQLite
{
    partial class FormMDI
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
            menuStripMain = new MenuStrip();
            mnuSetting = new ToolStripMenuItem();
            mnuCompanyInfo = new ToolStripMenuItem();
            mnuUser = new ToolStripMenuItem();
            mnuChangePassword = new ToolStripMenuItem();
            mnuEmployee = new ToolStripMenuItem();
            mnuAttendance = new ToolStripMenuItem();
            mniImportAttendance = new ToolStripMenuItem();
            mnuManageAttendanceLog = new ToolStripMenuItem();
            mnuReport = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuMissingEntry = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.AutoSize = false;
            menuStripMain.BackColor = Color.LightSteelBlue;
            menuStripMain.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStripMain.ImageScalingSize = new Size(24, 24);
            menuStripMain.Items.AddRange(new ToolStripItem[] { mnuSetting, mnuEmployee, mnuAttendance, mnuReport, mnuExit });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(972, 45);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // mnuSetting
            // 
            mnuSetting.DropDownItems.AddRange(new ToolStripItem[] { mnuCompanyInfo, mnuUser, mnuChangePassword });
            mnuSetting.Name = "mnuSetting";
            mnuSetting.Size = new Size(97, 41);
            mnuSetting.Text = "Setting";
            // 
            // mnuCompanyInfo
            // 
            mnuCompanyInfo.Name = "mnuCompanyInfo";
            mnuCompanyInfo.Size = new Size(286, 38);
            mnuCompanyInfo.Text = "Company Info";
            mnuCompanyInfo.Visible = false;
            mnuCompanyInfo.Click += mnuCompanyInfo_Click;
            // 
            // mnuUser
            // 
            mnuUser.Name = "mnuUser";
            mnuUser.Size = new Size(286, 38);
            mnuUser.Text = "User";
            mnuUser.Visible = false;
            mnuUser.Click += mnuUser_Click;
            // 
            // mnuChangePassword
            // 
            mnuChangePassword.Name = "mnuChangePassword";
            mnuChangePassword.Size = new Size(286, 38);
            mnuChangePassword.Text = "Change Password";
            mnuChangePassword.Click += mnuChangePassword_Click;
            // 
            // mnuEmployee
            // 
            mnuEmployee.Name = "mnuEmployee";
            mnuEmployee.Size = new Size(125, 41);
            mnuEmployee.Text = "Employee";
            mnuEmployee.Click += mnuEmployee_Click;
            // 
            // mnuAttendance
            // 
            mnuAttendance.DropDownItems.AddRange(new ToolStripItem[] { mniImportAttendance, mnuManageAttendanceLog, mnuMissingEntry });
            mnuAttendance.Name = "mnuAttendance";
            mnuAttendance.Size = new Size(139, 41);
            mnuAttendance.Text = "Attendance";
            // 
            // mniImportAttendance
            // 
            mniImportAttendance.Name = "mniImportAttendance";
            mniImportAttendance.Size = new Size(353, 38);
            mniImportAttendance.Text = "Import Attendance";
            mniImportAttendance.Click += mniImportAttendance_Click;
            // 
            // mnuManageAttendanceLog
            // 
            mnuManageAttendanceLog.Name = "mnuManageAttendanceLog";
            mnuManageAttendanceLog.Size = new Size(353, 38);
            mnuManageAttendanceLog.Text = "Attendance Manage Log";
            mnuManageAttendanceLog.Click += mnuManageAttendanceLog_Click;
            // 
            // mnuReport
            // 
            mnuReport.Name = "mnuReport";
            mnuReport.Size = new Size(94, 41);
            mnuReport.Text = "Report";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(62, 41);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuMissingEntry
            // 
            mnuMissingEntry.Name = "mnuMissingEntry";
            mnuMissingEntry.Size = new Size(353, 38);
            mnuMissingEntry.Text = "Missing Entry";
            mnuMissingEntry.Click += mnuMissingEntry_Click;
            // 
            // FormMDI
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(972, 653);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "FormMDI";
            Text = "MDI - Attendance Management";
            WindowState = FormWindowState.Maximized;
            Load += FormMDI_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem mnuEmployee;
        private ToolStripMenuItem mnuReport;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuAttendance;
        private ToolStripMenuItem mniImportAttendance;
        private ToolStripMenuItem mnuManageAttendanceLog;
        private ToolStripMenuItem mnuSetting;
        private ToolStripMenuItem mnuCompanyInfo;
        private ToolStripMenuItem mnuUser;
        private ToolStripMenuItem mnuChangePassword;
        private ToolStripMenuItem mnuMissingEntry;
    }
}