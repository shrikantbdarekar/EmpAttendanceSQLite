namespace EmpAttendanceSQLite
{
    partial class FormEmployeeSearch
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewMain = new DataGridView();
            dgcEmployeeId = new DataGridViewTextBoxColumn();
            dgcEmployeeName = new DataGridViewTextBoxColumn();
            dgcContactNo = new DataGridViewTextBoxColumn();
            dgcDesignation = new DataGridViewTextBoxColumn();
            dgcMonthlySalary = new DataGridViewTextBoxColumn();
            dgcEdit = new DataGridViewLinkColumn();
            dgcDelete = new DataGridViewLinkColumn();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.AllowUserToDeleteRows = false;
            dataGridViewMain.BackgroundColor = Color.Gainsboro;
            dataGridViewMain.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMain.ColumnHeadersHeight = 40;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { dgcEmployeeId, dgcEmployeeName, dgcContactNo, dgcDesignation, dgcMonthlySalary, dgcEdit, dgcDelete });
            dataGridViewMain.Dock = DockStyle.Bottom;
            dataGridViewMain.Location = new Point(0, 68);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.ReadOnly = true;
            dataGridViewMain.RowHeadersWidth = 62;
            dataGridViewMain.Size = new Size(1178, 676);
            dataGridViewMain.TabIndex = 0;
            dataGridViewMain.CellContentClick += dataGridViewMain_CellContentClick;
            // 
            // dgcEmployeeId
            // 
            dgcEmployeeId.DataPropertyName = "EmployeeId";
            dgcEmployeeId.HeaderText = "Id";
            dgcEmployeeId.MinimumWidth = 8;
            dgcEmployeeId.Name = "dgcEmployeeId";
            dgcEmployeeId.ReadOnly = true;
            dgcEmployeeId.Visible = false;
            dgcEmployeeId.Width = 150;
            // 
            // dgcEmployeeName
            // 
            dgcEmployeeName.DataPropertyName = "EmployeeName";
            dgcEmployeeName.HeaderText = "Employee Name";
            dgcEmployeeName.MinimumWidth = 8;
            dgcEmployeeName.Name = "dgcEmployeeName";
            dgcEmployeeName.ReadOnly = true;
            dgcEmployeeName.Width = 300;
            // 
            // dgcContactNo
            // 
            dgcContactNo.DataPropertyName = "ContactNumber1";
            dgcContactNo.HeaderText = "ContactNo";
            dgcContactNo.MinimumWidth = 8;
            dgcContactNo.Name = "dgcContactNo";
            dgcContactNo.ReadOnly = true;
            dgcContactNo.Width = 150;
            // 
            // dgcDesignation
            // 
            dgcDesignation.DataPropertyName = "Designation";
            dgcDesignation.HeaderText = "Designation";
            dgcDesignation.MinimumWidth = 8;
            dgcDesignation.Name = "dgcDesignation";
            dgcDesignation.ReadOnly = true;
            dgcDesignation.Width = 150;
            // 
            // dgcMonthlySalary
            // 
            dgcMonthlySalary.DataPropertyName = "MonthlySalary";
            dgcMonthlySalary.HeaderText = "Salary";
            dgcMonthlySalary.MinimumWidth = 8;
            dgcMonthlySalary.Name = "dgcMonthlySalary";
            dgcMonthlySalary.ReadOnly = true;
            dgcMonthlySalary.Width = 150;
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
            // buttonAdd
            // 
            buttonAdd.Location = new Point(994, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(172, 38);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add Employee";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormEmployeeSearch
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1178, 744);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEmployeeSearch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Employees";
            Load += FormEmployeeSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMain;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn dgcEmployeeId;
        private DataGridViewTextBoxColumn dgcEmployeeName;
        private DataGridViewTextBoxColumn dgcContactNo;
        private DataGridViewTextBoxColumn dgcDesignation;
        private DataGridViewTextBoxColumn dgcMonthlySalary;
        private DataGridViewLinkColumn dgcEdit;
        private DataGridViewLinkColumn dgcDelete;
    }
}