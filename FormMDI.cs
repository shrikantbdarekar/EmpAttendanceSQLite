using EmpAttendanceSQLite.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();

            if (Program.loginUser.Role == (int)UserRoles.SuperAdmin)
            {
                mnuCompanyInfo.Visible = true;
                mnuUser.Visible = true;
            }
            else if (Program.loginUser.Role == (int)UserRoles.Admin)
            {
                mnuUser.Visible = true;
            }

            Application.DoEvents();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void mnuCompanyInfo_Click(object sender, EventArgs e)
        {
            FormCompanyInfo formCompanyInfo = new FormCompanyInfo();
            formCompanyInfo.ShowDialog();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            FormUserSearch formUserSearch = new FormUserSearch();
            formUserSearch.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.ShowDialog();
        }

        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeSearch formEmployeeSearch = new FormEmployeeSearch();
            formEmployeeSearch.ShowDialog();
        }

        private void mniImportAttendance_Click(object sender, EventArgs e)
        {
            FormImportAttendanceLog formImportAttendanceLog = new FormImportAttendanceLog();
            formImportAttendanceLog.ShowDialog();
        }

        private void mnuManageAttendanceLog_Click(object sender, EventArgs e)
        {
            FormManageLog formManageLog = new FormManageLog();
            formManageLog.ShowDialog();
        }

        private void mnuMissingEntry_Click(object sender, EventArgs e)
        {

        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
