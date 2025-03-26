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
    public partial class FormMachineSearch : Form
    {
        public FormMachineSearch()
        {
            InitializeComponent();

            dataGridViewMain.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            LoadMachines();
        }

        private void LoadMachines()
        {
            using (var context = new AppDbContext())
            {
                dataGridViewMain.DataSource = context.BiometricMachines.ToList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMachine formMachine = new FormMachine(0);
            formMachine.ShowDialog();

            LoadMachines();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int editMachineId = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[dgcMachineId.Name].Value);
            if (editMachineId > 0)
            {
                if (e.ColumnIndex == dgcEdit.Index)
                {
                    FormMachine formMachine = new FormMachine(editMachineId);
                    formMachine.ShowDialog();

                    LoadMachines();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {

                    if (MessageBox.Show("Do you want to delete User ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells[dgcMachineId.Name].Value);

                        using (var context = new AppDbContext())
                        {
                            var machine = context.BiometricMachines.Find(id);
                            if (machine != null)
                            {
                                context.BiometricMachines.Remove(machine);
                                context.SaveChanges();

                                LoadMachines();
                            }
                        }
                    }
                }
            }
        }
    }
}
