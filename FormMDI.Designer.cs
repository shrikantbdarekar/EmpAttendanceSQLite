﻿namespace EmpAttendanceSQLite
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
            mnuBiometricMachine = new ToolStripMenuItem();
            mnuEmployee = new ToolStripMenuItem();
            mnuAttendance = new ToolStripMenuItem();
            mnuImportAttendanceAdv = new ToolStripMenuItem();
            mnuMissingLogAdv = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuManageAttendanceLog = new ToolStripMenuItem();
            mniImportAttendance = new ToolStripMenuItem();
            mnuManageMissingLog = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuReport = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuManageAttendanceAdv = new ToolStripMenuItem();
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
            mnuSetting.DropDownItems.AddRange(new ToolStripItem[] { mnuCompanyInfo, mnuUser, mnuChangePassword, mnuBiometricMachine });
            mnuSetting.Name = "mnuSetting";
            mnuSetting.Size = new Size(97, 41);
            mnuSetting.Text = "Setting";
            // 
            // mnuCompanyInfo
            // 
            mnuCompanyInfo.Name = "mnuCompanyInfo";
            mnuCompanyInfo.Size = new Size(296, 38);
            mnuCompanyInfo.Text = "Company Info";
            mnuCompanyInfo.Visible = false;
            mnuCompanyInfo.Click += mnuCompanyInfo_Click;
            // 
            // mnuUser
            // 
            mnuUser.Name = "mnuUser";
            mnuUser.Size = new Size(296, 38);
            mnuUser.Text = "User";
            mnuUser.Visible = false;
            mnuUser.Click += mnuUser_Click;
            // 
            // mnuChangePassword
            // 
            mnuChangePassword.Name = "mnuChangePassword";
            mnuChangePassword.Size = new Size(296, 38);
            mnuChangePassword.Text = "Change Password";
            mnuChangePassword.Click += mnuChangePassword_Click;
            // 
            // mnuBiometricMachine
            // 
            mnuBiometricMachine.Name = "mnuBiometricMachine";
            mnuBiometricMachine.Size = new Size(296, 38);
            mnuBiometricMachine.Text = "Biometric Machine";
            mnuBiometricMachine.Visible = false;
            mnuBiometricMachine.Click += mnuBiometricMachine_Click;
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
            mnuAttendance.DropDownItems.AddRange(new ToolStripItem[] { mnuImportAttendanceAdv, mnuMissingLogAdv, mnuManageAttendanceAdv, toolStripSeparator1, mnuManageAttendanceLog, mniImportAttendance, mnuManageMissingLog, toolStripSeparator2 });
            mnuAttendance.Name = "mnuAttendance";
            mnuAttendance.Size = new Size(139, 41);
            mnuAttendance.Text = "Attendance";
            // 
            // mnuImportAttendanceAdv
            // 
            mnuImportAttendanceAdv.Name = "mnuImportAttendanceAdv";
            mnuImportAttendanceAdv.Size = new Size(355, 38);
            mnuImportAttendanceAdv.Text = "Import Attendance Adv";
            mnuImportAttendanceAdv.Click += mnuImportAttendanceAdv_Click;
            // 
            // mnuMissingLogAdv
            // 
            mnuMissingLogAdv.Name = "mnuMissingLogAdv";
            mnuMissingLogAdv.Size = new Size(355, 38);
            mnuMissingLogAdv.Text = "Missing Log Adv";
            mnuMissingLogAdv.Click += mnuMissingLogAdv_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(352, 6);
            // 
            // mnuManageAttendanceLog
            // 
            mnuManageAttendanceLog.ForeColor = Color.Red;
            mnuManageAttendanceLog.Name = "mnuManageAttendanceLog";
            mnuManageAttendanceLog.Size = new Size(355, 38);
            mnuManageAttendanceLog.Text = "Manage Attendance";
            mnuManageAttendanceLog.Click += mnuManageAttendanceLog_Click;
            // 
            // mniImportAttendance
            // 
            mniImportAttendance.Name = "mniImportAttendance";
            mniImportAttendance.Size = new Size(355, 38);
            mniImportAttendance.Text = "Import Attendance";
            mniImportAttendance.Click += mniImportAttendance_Click;
            // 
            // mnuManageMissingLog
            // 
            mnuManageMissingLog.Name = "mnuManageMissingLog";
            mnuManageMissingLog.Size = new Size(355, 38);
            mnuManageMissingLog.Text = "Manage Missing Log";
            mnuManageMissingLog.Click += mnuManageMissingLog_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(352, 6);
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
            // mnuManageAttendanceAdv
            // 
            mnuManageAttendanceAdv.Name = "mnuManageAttendanceAdv";
            mnuManageAttendanceAdv.Size = new Size(355, 38);
            mnuManageAttendanceAdv.Text = "Manage Attendance Adv";
            mnuManageAttendanceAdv.Click += mnuManageAttendanceAdv_Click;
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
        private ToolStripMenuItem mnuManageMissingLog;
        private ToolStripMenuItem mnuBiometricMachine;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuImportAttendanceAdv;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuMissingLogAdv;
        private ToolStripMenuItem mnuManageAttendanceAdv;
    }
}