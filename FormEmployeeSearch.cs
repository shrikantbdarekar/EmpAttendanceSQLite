using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
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
    public partial class FormEmployeeSearch : Form
    {
        private List<Employee> employeeList = new List<Employee>();
        public FormEmployeeSearch()
        {
            InitializeComponent();

            dataGridViewMain.AutoGenerateColumns = false;
        }

        private void FormEmployeeSearch_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (var context = new AppDbContext())
            {
                employeeList = context.Employees.ToList();
                dataGridViewMain.DataSource = employeeList;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee(0);
            formEmployee.ShowDialog();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int editEmployeeId = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[dgcEmployeeId.Name].Value);

            if (e.ColumnIndex == dgcEdit.Index)
            {
                FormEmployee formEmployee = new FormEmployee(editEmployeeId);
                formEmployee.ShowDialog();

                LoadEmployees();
            }
            else if (e.ColumnIndex == dgcDelete.Index)
            {

                if (MessageBox.Show("Do you want to delete Employee ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[dgcEmployeeId.Name].Value);

                    using (var context = new AppDbContext())
                    {
                        var employee = context.Employees.Find(id);
                        if (employee != null)
                        {
                            context.Employees.Remove(employee);
                            context.SaveChanges();

                            LoadEmployees();
                        }
                    }
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();

            var filteredData = employeeList.Where(emp =>
                emp.EmployeeCode.ToLower().Contains(searchText) ||
                emp.BMEmployeeId.ToString().Contains(searchText) ||
                emp.EmployeeName.ToLower().Contains(searchText) ||
                emp.EmailId.ToLower().Contains(searchText) ||
                emp.ContactNumber1.Contains(searchText) ||
                emp.ContactNumber2.Contains(searchText) ||
                emp.Department.ToLower().Contains(searchText) ||
                emp.Designation.ToLower().Contains(searchText)
            ).ToList();

            dataGridViewMain.DataSource = filteredData;
        }
    }
}
