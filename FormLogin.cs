using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace EmpAttendanceSQLite
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            textBoxUserId.Text = "admin";
            textBoxPassword.Text = "admin";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(EmpAttendanceSQLite.Properties.Settings.Default.AppDataPath))
            {
                FormSetting formSetting = new FormSetting();
                formSetting.ShowDialog();

                return;
            }
            if (Program.companyInfo == null)
            {
                MessageBox.Show("Invalid company data! \n Contact system admin.");
                return;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (context.LoginUsers.Count() > 0)
                {
                    var user = context.LoginUsers.FirstOrDefault(
                        x => x.UserName == textBoxUserId.Text
                        &&
                        x.PasswordHash == textBoxPassword.Text
                        &&
                        x.IsActive==true);

                    if (user != null)
                    {
                        Program.loginUser = new LoginUser 
                        {
                            UserId=user.UserId,
                            UserName=user.UserName,
                            Role=user.Role,
                        };
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Id or Passsword!");
                    }
                }
                else 
                {
                    MessageBox.Show("Contact admin for login credentials!");
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
