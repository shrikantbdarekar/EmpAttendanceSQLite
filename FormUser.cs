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
    public partial class FormUser : Form
    {
        private int UserId;
        public FormUser(int UserId)
        {
            InitializeComponent();

            this.UserId = UserId;

            //comboBoxRole.Items.AddRange(new object[] { UserRoles.Admin, UserRoles.Employee });
            //Application.DoEvents();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            comboBoxRole.DataSource = Enum.GetValues(typeof(UserRoles))
                .Cast<UserRoles>()
                .Select(role => new { Value = (int)role, Display = role.ToString() })
                .ToList();

            comboBoxRole.DisplayMember = "Display"; // Show text
            comboBoxRole.ValueMember = "Value"; // Store integer value
            Application.DoEvents();

            if (UserId > 0)
            {
                using (var context = new AppDbContext())
                {
                    var user = context.LoginUsers.Find(UserId);
                    if (user != null)
                    {
                        textBoxUserId.Text =user.UserName;
                        comboBoxRole.SelectedItem = (UserRoles)user.Role;
                        textBoxPassword.Text = user.PasswordHash;
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            using (var context = new AppDbContext())
            {
                if (UserId > 0)
                {
                    var user = context.LoginUsers.Find(UserId);
                    if (user != null)
                    {
                        user.UserName = textBoxUserId.Text;
                        user.Role = (int)comboBoxRole.SelectedValue;
                        user.PasswordHash = textBoxPassword.Text;

                        context.SaveChanges();
                    }
                }
                else
                {
                    var user = new LoginUser
                    {
                        UserName = textBoxUserId.Text,
                        Role = (int)comboBoxRole.SelectedValue,
                        PasswordHash = textBoxPassword.Text
                    };

                    context.LoginUsers.Add(user);
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
