namespace EmpAttendanceSQLite
{
    public partial class FormImportAttendanceLog : Form
    {
        public FormImportAttendanceLog()
        {
            InitializeComponent();
        }

        private void FormImportAttendanceLog_Load(object sender, EventArgs e)
        {

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            openAttendanceLogFileDialog.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
