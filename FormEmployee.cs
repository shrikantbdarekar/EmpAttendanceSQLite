﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace EmpAttendanceSQLite
{
    public partial class FormEmployee : Form
    {
        private int EmployeeId;
        public FormEmployee(int EmployeeId)
        {
            InitializeComponent();

            this.EmployeeId = EmployeeId;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            if (EmployeeId > 0)
            {
                using (var context = new AppDbContext())
                {
                    var employee = context.Employees.Find(EmployeeId);
                    if (employee != null)
                    {
                        textBoxEmpCode.Text = employee.EmployeeCode;
                        textBoxBMEmpId.Text = employee.BMEmployeeId.ToString();
                        dtpJoinigDate.Value = employee.JoiningDate;
                        dtpBirthDate.Value = employee.BirthDate;
                        textBoxEmployeeName.Text = employee.EmployeeName;
                        textBoxAddress.Text = employee.Address;
                        textBoxEmailId.Text = employee.EmailId;
                        textBoxContactNo1.Text = employee.ContactNumber1;
                        textBoxContactNo2.Text = employee.ContactNumber2;

                        textBoxDepartmentName.Text = employee.Department;
                        textBoxDesignation.Text = employee.Designation;
                        textBoxMonthlySalary.Text = employee.MonthlySalary.ToString();
                        textBoxHourlySalary.Text = employee.HourlySalary.ToString();
                        dtpShiftStart.Value = DateTime.Today.Add(employee.ShiftStart);
                        dtpShiftEnd.Value = DateTime.Today.Add(employee.ShiftEnd);

                        checkBoxIsActive.Checked = employee.IsActive;
                    }
                }
            }
            else
            {
                dtpShiftStart.Value = DateTime.Today.Add(Program.companyInfo.ShiftStart);
                dtpShiftEnd.Value = DateTime.Today.Add(Program.companyInfo.ShiftEnd);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxBMEmpId.Text == string.Empty || textBoxEmployeeName.Text == string.Empty
                || textBoxContactNo1.Text == string.Empty || textBoxMonthlySalary.Text == string.Empty
                || textBoxHourlySalary.Text == string.Empty)
            {
                MessageBox.Show("Fill all *manadatory data");
                return;
            }

            using (var context = new AppDbContext())
            {
                if (EmployeeId > 0)
                {
                    var employee = context.Employees.Find(EmployeeId);
                    if (employee != null)
                    {
                        employee.EmployeeCode = textBoxEmpCode.Text;
                        employee.BMEmployeeId =Convert.ToInt32( textBoxBMEmpId.Text);
                        employee.JoiningDate = dtpJoinigDate.Value;
                        employee.BirthDate = dtpBirthDate.Value;
                        employee.EmployeeName = textBoxEmployeeName.Text;
                        employee.Address = textBoxAddress.Text;
                        employee.EmailId = textBoxEmailId.Text;
                        employee.ContactNumber1 = textBoxContactNo1.Text;
                        employee.ContactNumber2 = textBoxContactNo2.Text;

                        employee.Department = textBoxDepartmentName.Text;
                        employee.Designation = textBoxDesignation.Text;
                        employee.MonthlySalary =Convert.ToDecimal(textBoxMonthlySalary.Text);
                        employee.HourlySalary = Convert.ToDecimal(textBoxHourlySalary.Text);
                        employee.ShiftStart = dtpShiftStart.Value.TimeOfDay;
                        employee.ShiftEnd = dtpShiftEnd.Value.TimeOfDay;

                        employee.IsActive = checkBoxIsActive.Checked;

                        context.SaveChanges();
                    }
                }
                else
                {
                    var employee = new Employee
                    {
                        EmployeeCode = textBoxEmpCode.Text,
                        BMEmployeeId = Convert.ToInt32(textBoxBMEmpId.Text),
                        JoiningDate = dtpJoinigDate.Value,
                        BirthDate = dtpBirthDate.Value,
                        EmployeeName = textBoxEmployeeName.Text,
                        Address = textBoxAddress.Text,
                        EmailId = textBoxEmailId.Text,
                        ContactNumber1 = textBoxContactNo1.Text,
                        ContactNumber2 = textBoxContactNo2.Text,

                        Department = textBoxDepartmentName.Text,
                        Designation = textBoxDesignation.Text,
                        MonthlySalary = Convert.ToDecimal(textBoxMonthlySalary.Text),
                        HourlySalary = Convert.ToDecimal(textBoxHourlySalary.Text),
                        ShiftStart = dtpShiftStart.Value.TimeOfDay,
                        ShiftEnd = dtpShiftEnd.Value.TimeOfDay,
                        IsActive = true
                    };

                    context.Employees.Add(employee);
                    context.SaveChanges();
                }

                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
