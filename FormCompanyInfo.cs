using EmpAttendanceSQLite.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;

namespace EmpAttendanceSQLite
{
    public partial class FormCompanyInfo : Form
    {
        public FormCompanyInfo()
        {
            InitializeComponent();
        }

        private void FormCompanyInfo_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (context.CompanyInfos.Count() == 1)
                {
                    var companyInfo = context.CompanyInfos.FirstOrDefault();

                    if (companyInfo != null)
                    {
                        textBoxCompanyName.Text = companyInfo.CompanyName;
                        textBoxAddress.Text = companyInfo.CompanyAddress;
                        textBoxEmailId.Text = companyInfo.EmailId;
                        textBoxContactNo.Text = companyInfo.ContactNo;
                        textBoxWebsite.Text = companyInfo.Website;
                        dtpShiftStart.Value = DateTime.Today.Add(companyInfo.ShiftStart);
                        dtpShiftEnd.Value = DateTime.Today.Add(companyInfo.ShiftEnd);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var companyInfo = context.CompanyInfos.FirstOrDefault();

                if (companyInfo != null)
                {
                    companyInfo.CompanyName = textBoxCompanyName.Text;
                    companyInfo.CompanyAddress = textBoxAddress.Text;
                    companyInfo.EmailId = textBoxEmailId.Text;
                    companyInfo.ContactNo = textBoxContactNo.Text;
                    companyInfo.Website = textBoxWebsite.Text;
                    companyInfo.ShiftStart = dtpShiftStart.Value.TimeOfDay;
                    companyInfo.ShiftEnd = dtpShiftEnd.Value.TimeOfDay;

                    context.SaveChanges();
                    MessageBox.Show("Updated Successfully!");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
