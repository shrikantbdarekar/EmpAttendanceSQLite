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
    public partial class FormMachine : Form
    {
        private int machineId;
        public FormMachine(int machineId)
        {
            InitializeComponent();

            this.machineId = machineId;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            if (machineId > 0)
            {
                using (var context = new AppDbContext())
                {
                    var biometricMachine = context.BiometricMachines.Find(machineId);
                    if (biometricMachine != null)
                    {
                        textBoxMachineName.Text =biometricMachine.MachineName;
                        textBoxBMMachineId.Text = biometricMachine.BMMachineId.ToString();
                        textBoxMachineDescription.Text = biometricMachine.MachineDescription;
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            using (var context = new AppDbContext())
            {
                int BMId = 1; int.TryParse(textBoxBMMachineId.Text, out BMId);

                if (machineId > 0)
                {
                    var biometricMachine = context.BiometricMachines.Find(machineId);

                    if (biometricMachine != null)
                    {
                        biometricMachine.MachineName = textBoxMachineName.Text;
                        biometricMachine.BMMachineId = BMId;
                        biometricMachine.MachineDescription = textBoxMachineDescription.Text;

                        context.SaveChanges();
                    }
                }
                else
                {
                    var biometricMachine = new BiometricMachine
                    {
                        MachineName = textBoxMachineName.Text,
                        BMMachineId = BMId,
                        MachineDescription = textBoxMachineDescription.Text
                    };

                    context.BiometricMachines.Add(biometricMachine);
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
