using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace EmpAttendanceSQLite
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxAppDataPath.Text= EmpAttendanceSQLite.Properties.Settings.Default.AppDataPath; 
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxAppDataPath.Text))
            {
                EmpAttendanceSQLite.Properties.Settings.Default.AppDataPath = textBoxAppDataPath.Text;
                EmpAttendanceSQLite.Properties.Settings.Default.Save();

                MessageBox.Show("Setting changed successfully!");
            }
            else 
            {
                MessageBox.Show("Enter valid path!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
