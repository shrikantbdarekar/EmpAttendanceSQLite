namespace EmpAttendanceSQLite
{
    partial class FormUserSearch
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
            buttonAdd = new Button();
            dgcUserId = new DataGridViewTextBoxColumn();
            dgcUserName = new DataGridViewTextBoxColumn();
            dgcRole = new DataGridViewComboBoxColumn();
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
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { dgcUserId, dgcUserName, dgcRole, dgcEdit, dgcDelete });
            dataGridViewMain.Dock = DockStyle.Bottom;
            dataGridViewMain.Location = new Point(0, 56);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.ReadOnly = true;
            dataGridViewMain.RowHeadersWidth = 62;
            dataGridViewMain.Size = new Size(563, 505);
            dataGridViewMain.TabIndex = 0;
            dataGridViewMain.CellContentClick += dataGridViewMain_CellContentClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(134, 38);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add User";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dgcUserId
            // 
            dgcUserId.DataPropertyName = "UserId";
            dgcUserId.HeaderText = "UserId";
            dgcUserId.MinimumWidth = 8;
            dgcUserId.Name = "dgcUserId";
            dgcUserId.ReadOnly = true;
            dgcUserId.Visible = false;
            dgcUserId.Width = 150;
            // 
            // dgcUserName
            // 
            dgcUserName.DataPropertyName = "UserName";
            dgcUserName.HeaderText = "User Name";
            dgcUserName.MinimumWidth = 8;
            dgcUserName.Name = "dgcUserName";
            dgcUserName.ReadOnly = true;
            dgcUserName.Width = 150;
            // 
            // dgcRole
            // 
            dgcRole.DataPropertyName = "Role";
            dgcRole.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgcRole.HeaderText = "Role";
            dgcRole.MinimumWidth = 8;
            dgcRole.Name = "dgcRole";
            dgcRole.ReadOnly = true;
            dgcRole.Resizable = DataGridViewTriState.True;
            dgcRole.SortMode = DataGridViewColumnSortMode.Automatic;
            dgcRole.Width = 150;
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
            // FormUserSearch
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(563, 561);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUserSearch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Users";
            Load += FormUserSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMain;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn dgcUserId;
        private DataGridViewTextBoxColumn dgcUserName;
        private DataGridViewComboBoxColumn dgcRole;
        private DataGridViewLinkColumn dgcEdit;
        private DataGridViewLinkColumn dgcDelete;
    }
}