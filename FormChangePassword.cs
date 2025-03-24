using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;

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

namespace EmpAttendanceSQLite
{
    public partial class FormChangePassword : Form
    {
        private int userId;
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // Current login credentials
            userId = Program.loginUser.UserId;

            comboBoxRole.DataSource = Enum.GetValues(typeof(UserRoles))
                .Cast<UserRoles>()
                .Select(role => new { Value = (int)role, Display = role.ToString() })
                .ToList();

            comboBoxRole.DisplayMember = "Display"; // Show text
            comboBoxRole.ValueMember = "Value"; // Store integer value
            Application.DoEvents();

            if (userId > 0)
            {
                using (var context = new AppDbContext())
                {
                    var user = context.LoginUsers.Find(userId);
                    if (user != null)
                    {
                        textBoxUserId.Text = user.UserName;
                        comboBoxRole.SelectedValue = (int)user.Role;
                        //textBoxPassword.Text = user.PasswordHash;
                    }
                }
            }
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {

            using (var context = new AppDbContext())
            {
                if (userId > 0)
                {
                    var user = context.LoginUsers.Find(userId);
                    if (user != null)
                    {
                        if (user.PasswordHash.Equals(textBoxPassword.Text))
                        {
                            if (textBoxNewPassword.Text!=string.Empty && textBoxNewPassword.Text.Equals(textBoxConfirmPassword.Text))
                            {
                                user.UserName = textBoxUserId.Text;
                                user.Role = (int)comboBoxRole.SelectedValue;
                                user.PasswordHash = textBoxNewPassword.Text;

                                context.SaveChanges();

                                MessageBox.Show("Password changed successfully! \n\n Application will restart now!");
                                Application.Restart();
                            }
                            else
                            {
                                MessageBox.Show("New password and confirm password doesn't match!","Application Restart");
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Invalid existing password entered!");
                        }
                    }

                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
