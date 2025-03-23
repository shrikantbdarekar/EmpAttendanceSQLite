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
    public partial class FormUserSearch : Form
    {
        public FormUserSearch()
        {
            InitializeComponent();

            dataGridViewMain.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            dgcRole.DataSource = Enum.GetValues(typeof(UserRoles))
                .Cast<UserRoles>()
                .Select(role => new { Value = (int)role, Display = role.ToString() })
                .ToList();

            dgcRole.DisplayMember = "Display"; // Show text
            dgcRole.ValueMember = "Value"; // Store integer value
            Application.DoEvents();

            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var context = new AppDbContext())
            {
                dataGridViewMain.DataSource = context.LoginUsers.ToList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser(0);
            formUser.ShowDialog();

            LoadUsers();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int editUserId = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[dgcUserId.Name].Value);
            if (editUserId > 0)
            {
                if (e.ColumnIndex == dgcEdit.Index)
                {
                    FormUser formUser = new FormUser(editUserId);
                    formUser.ShowDialog();

                    LoadUsers();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {

                    if (MessageBox.Show("Do you want to delete User ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[dgcUserId.Name].Value);

                        using (var context = new AppDbContext())
                        {
                            var loginUser = context.LoginUsers.Find(id);
                            if (loginUser != null)
                            {
                                context.LoginUsers.Remove(loginUser);
                                context.SaveChanges();
                                
                                LoadUsers();
                            }
                        }
                    }
                }
            }
        }
    }
}
