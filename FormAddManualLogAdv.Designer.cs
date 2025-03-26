namespace EmpAttendanceSQLite
{
    partial class FormAddManualLogAdv
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
            panel1 = new Panel();
            textBoxPunchDate = new TextBox();
            labelPunchDate1 = new Label();
            labelPunchDateToAdd = new Label();
            dtpPunchTimeToAdd = new DateTimePicker();
            textBoxEmployeeCode = new TextBox();
            label1 = new Label();
            textBoxEmployeeName = new TextBox();
            labelEmployeeName = new Label();
            labelAddress = new Label();
            buttonCancel = new Button();
            textBoxBMEmployeeCode = new TextBox();
            labelCompanyName = new Label();
            buttonSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(textBoxPunchDate);
            panel1.Controls.Add(labelPunchDate1);
            panel1.Controls.Add(labelPunchDateToAdd);
            panel1.Controls.Add(dtpPunchTimeToAdd);
            panel1.Controls.Add(textBoxEmployeeCode);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxEmployeeName);
            panel1.Controls.Add(labelEmployeeName);
            panel1.Controls.Add(labelAddress);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(textBoxBMEmployeeCode);
            panel1.Controls.Add(labelCompanyName);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 265);
            panel1.TabIndex = 0;
            // 
            // textBoxPunchDate
            // 
            textBoxPunchDate.BackColor = Color.LightSteelBlue;
            textBoxPunchDate.BorderStyle = BorderStyle.FixedSingle;
            textBoxPunchDate.Location = new Point(196, 96);
            textBoxPunchDate.Name = "textBoxPunchDate";
            textBoxPunchDate.ReadOnly = true;
            textBoxPunchDate.Size = new Size(430, 31);
            textBoxPunchDate.TabIndex = 61;
            // 
            // labelPunchDate1
            // 
            labelPunchDate1.AutoSize = true;
            labelPunchDate1.Location = new Point(36, 99);
            labelPunchDate1.Name = "labelPunchDate1";
            labelPunchDate1.Size = new Size(102, 25);
            labelPunchDate1.TabIndex = 60;
            labelPunchDate1.Text = "Punch Date";
            // 
            // labelPunchDateToAdd
            // 
            labelPunchDateToAdd.AutoSize = true;
            labelPunchDateToAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPunchDateToAdd.Location = new Point(362, 168);
            labelPunchDateToAdd.Name = "labelPunchDateToAdd";
            labelPunchDateToAdd.Size = new Size(105, 25);
            labelPunchDateToAdd.TabIndex = 58;
            labelPunchDateToAdd.Text = "BM Emp.Id";
            // 
            // dtpPunchTimeToAdd
            // 
            dtpPunchTimeToAdd.CustomFormat = "hh:mm tt";
            dtpPunchTimeToAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpPunchTimeToAdd.Format = DateTimePickerFormat.Custom;
            dtpPunchTimeToAdd.Location = new Point(196, 163);
            dtpPunchTimeToAdd.Name = "dtpPunchTimeToAdd";
            dtpPunchTimeToAdd.Size = new Size(160, 31);
            dtpPunchTimeToAdd.TabIndex = 54;
            // 
            // textBoxEmployeeCode
            // 
            textBoxEmployeeCode.BackColor = Color.LightSteelBlue;
            textBoxEmployeeCode.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmployeeCode.Location = new Point(196, 55);
            textBoxEmployeeCode.Name = "textBoxEmployeeCode";
            textBoxEmployeeCode.ReadOnly = true;
            textBoxEmployeeCode.Size = new Size(160, 31);
            textBoxEmployeeCode.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 52;
            label1.Text = "Emp. Code";
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.BackColor = Color.LightSteelBlue;
            textBoxEmployeeName.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmployeeName.Location = new Point(196, 14);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.ReadOnly = true;
            textBoxEmployeeName.Size = new Size(430, 31);
            textBoxEmployeeName.TabIndex = 51;
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Location = new Point(36, 17);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(142, 25);
            labelEmployeeName.TabIndex = 50;
            labelEmployeeName.Text = "Employee Name";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(36, 168);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(103, 25);
            labelAddress.TabIndex = 24;
            labelAddress.Text = "Punch Time";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(308, 222);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(106, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxBMEmployeeCode
            // 
            textBoxBMEmployeeCode.BackColor = Color.LightSteelBlue;
            textBoxBMEmployeeCode.BorderStyle = BorderStyle.FixedSingle;
            textBoxBMEmployeeCode.Location = new Point(466, 55);
            textBoxBMEmployeeCode.Name = "textBoxBMEmployeeCode";
            textBoxBMEmployeeCode.ReadOnly = true;
            textBoxBMEmployeeCode.Size = new Size(160, 31);
            textBoxBMEmployeeCode.TabIndex = 10;
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new Point(361, 58);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(99, 25);
            labelCompanyName.TabIndex = 9;
            labelCompanyName.Text = "BM Emp.Id";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(196, 222);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormAddManualLogAdv
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(687, 292);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddManualLogAdv";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Missing Log";
            Load += FormCompanyInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancel;
        private TextBox textBoxBMEmployeeCode;
        private Label labelCompanyName;
        private Button buttonSave;
        private Label labelAddress;
        private TextBox textBoxEmployeeCode;
        private Label label1;
        private TextBox textBoxEmployeeName;
        private Label labelEmployeeName;
        private DateTimePicker dtpPunchTimeToAdd;
        private Label labelPunchDateToAdd;
        private TextBox textBoxPunchDate;
        private Label labelPunchDate1;
    }
}