namespace EmpAttendanceSQLite
{
    partial class FormMachineSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewMain = new DataGridView();
            buttonAdd = new Button();
            dgcMachineId = new DataGridViewTextBoxColumn();
            dgcMachineName = new DataGridViewTextBoxColumn();
            dgcBMMachineId = new DataGridViewTextBoxColumn();
            dgcEdit = new DataGridViewLinkColumn();
            dgcDelete = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.AllowUserToDeleteRows = false;
            dataGridViewMain.BackgroundColor = Color.Gainsboro;
            dataGridViewMain.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMain.ColumnHeadersHeight = 40;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { dgcMachineId, dgcMachineName, dgcBMMachineId, dgcEdit, dgcDelete });
            dataGridViewMain.Dock = DockStyle.Bottom;
            dataGridViewMain.Location = new Point(0, 56);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.ReadOnly = true;
            dataGridViewMain.RowHeadersWidth = 62;
            dataGridViewMain.Size = new Size(829, 505);
            dataGridViewMain.TabIndex = 0;
            dataGridViewMain.CellContentClick += dataGridViewMain_CellContentClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(134, 38);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add Machine";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dgcMachineId
            // 
            dgcMachineId.DataPropertyName = "MachineId";
            dgcMachineId.HeaderText = "MachineId";
            dgcMachineId.MinimumWidth = 8;
            dgcMachineId.Name = "dgcMachineId";
            dgcMachineId.ReadOnly = true;
            dgcMachineId.Visible = false;
            dgcMachineId.Width = 150;
            // 
            // dgcMachineName
            // 
            dgcMachineName.DataPropertyName = "MachineName";
            dgcMachineName.HeaderText = "Machine Name";
            dgcMachineName.MinimumWidth = 8;
            dgcMachineName.Name = "dgcMachineName";
            dgcMachineName.ReadOnly = true;
            dgcMachineName.Width = 250;
            // 
            // dgcBMMachineId
            // 
            dgcBMMachineId.DataPropertyName = "BMMachineId";
            dgcBMMachineId.HeaderText = "BM Machine Id";
            dgcBMMachineId.MinimumWidth = 8;
            dgcBMMachineId.Name = "dgcBMMachineId";
            dgcBMMachineId.ReadOnly = true;
            dgcBMMachineId.Width = 300;
            // 
            // dgcEdit
            // 
            dgcEdit.HeaderText = "Edit";
            dgcEdit.MinimumWidth = 8;
            dgcEdit.Name = "dgcEdit";
            dgcEdit.ReadOnly = true;
            dgcEdit.Text = "Edit";
            dgcEdit.UseColumnTextForLinkValue = true;
            dgcEdit.Width = 80;
            // 
            // dgcDelete
            // 
            dgcDelete.HeaderText = "Delete";
            dgcDelete.MinimumWidth = 8;
            dgcDelete.Name = "dgcDelete";
            dgcDelete.ReadOnly = true;
            dgcDelete.Text = "Delete";
            dgcDelete.UseColumnTextForLinkValue = true;
            dgcDelete.Width = 80;
            // 
            // FormMachineSearch
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(829, 561);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMachineSearch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Biometric Machines";
            Load += FormUserSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMain;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn dgcMachineId;
        private DataGridViewTextBoxColumn dgcMachineName;
        private DataGridViewTextBoxColumn dgcBMMachineId;
        private DataGridViewLinkColumn dgcEdit;
        private DataGridViewLinkColumn dgcDelete;
    }
}