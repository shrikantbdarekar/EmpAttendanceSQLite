using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System.Diagnostics.SymbolStore;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormImportView : Form
    {
        private string batchCode;
        private string importMessage;
        public FormImportView(string batchCode,string importMessage)
        {
            InitializeComponent();

            this.batchCode = batchCode;
            this.importMessage = importMessage;
        }

        private void FormImportAttendanceLog_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                dataGridViewMain.DataSource = context.BiometricLogs
                    .Where(x => x.BatchCode == batchCode)
                    .ToList();

                dataGridViewMissingLogs.DataSource = context.MissingLogs
                    .Where(x => x.BatchCode == batchCode)
                    .ToList();
            }

            labelMessage.Text = importMessage;
            labelMessage.Text += " | Missing Entries " + dataGridViewMissingLogs.RowCount;

            Application.DoEvents();
        }

    }
}
