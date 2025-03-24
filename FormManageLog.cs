using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormManageLog : Form
    {
        public FormManageLog()
        {
            InitializeComponent();

            dataGridViewMain.AutoGenerateColumns = false;
        }

        private void FormImportAttendanceLog_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var employeeList = context.Employees
                    .OrderBy(e => e.BMEmployeeId) // Order by BMEmployeeId
                    .Select(e => new
                    {
                        e.EmployeeId,
                        e.EmployeeCode,
                        e.BMEmployeeId,
                        e.EmployeeName
                    })
                    .ToList();

                // Insert default item at index 0
                employeeList.Insert(0, new { EmployeeId = 0, EmployeeCode = "NA", BMEmployeeId = 0, EmployeeName = "Select Employee" });

                comboBoxEmployee.DataSource = employeeList;
                comboBoxEmployee.DisplayMember = "EmployeeName";  // Shown in dropdown
                comboBoxEmployee.ValueMember = "EmployeeId";      // Stored value
            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            //DateTime toDate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1); // End of To Date

            DateTime fromDate = dtpFromDate.Value.Date;  // Get selected From Date
            DateTime toDate = dtpToDate.Value.Date; // Get selected To Date

            //int employeeId = comboBoxEmployee.SelectedValue == null ? 0 : (int)comboBoxEmployee.SelectedValue;
            int bmEmployeeId = 0;

            var selectedItem = comboBoxEmployee.SelectedItem;
            if (selectedItem != null)
            {
                bmEmployeeId = (int)selectedItem.GetType().GetProperty("BMEmployeeId").GetValue(selectedItem, null);
            }

            using (var context = new AppDbContext())
            {
                if (bmEmployeeId == 0)
                {
                    var filteredData = context.BiometricLogs
                        .Where(b => b.PunchTime >= fromDate && b.PunchTime <= toDate)
                        .ToList();

                    dataGridViewMain.DataSource = filteredData;
                }
                else
                {
                    var filteredData = context.BiometricLogs
                        .Where(b => b.PunchTime >= fromDate && b.PunchTime <= toDate && b.BMEmployeeId == bmEmployeeId)
                        .ToList();

                    dataGridViewMain.DataSource = filteredData;
                }
            }
        }
    }
}
