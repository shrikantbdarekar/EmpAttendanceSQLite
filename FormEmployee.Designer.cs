namespace EmpAttendanceSQLite
{
    partial class FormEmployee
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
            checkBoxIsActive = new CheckBox();
            label16 = new Label();
            dtpShiftEnd = new DateTimePicker();
            labelShiftEnd = new Label();
            dtpShiftStart = new DateTimePicker();
            labelShiftStart = new Label();
            textBoxEmailId = new TextBox();
            labelEmailId = new Label();
            textBoxBMEmpId = new TextBox();
            labelBMEmpId = new Label();
            dtpBirthDate = new DateTimePicker();
            labelBirthDate = new Label();
            labelDepartmentName = new Label();
            textBoxDesignation = new TextBox();
            textBoxDepartmentName = new TextBox();
            labelDesignation = new Label();
            dtpJoinigDate = new DateTimePicker();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            labelJoiningDate = new Label();
            labelContactNo2 = new Label();
            textBoxHourlySalary = new TextBox();
            textBoxContactNo2 = new TextBox();
            labelContactNo1 = new Label();
            labelHourlySalary = new Label();
            textBoxMonthlySalary = new TextBox();
            textBoxContactNo1 = new TextBox();
            labelMonthlySalary = new Label();
            buttonCancel = new Button();
            textBoxEmployeeName = new TextBox();
            labelEmployeeName = new Label();
            textBoxEmpCode = new TextBox();
            labelEmpCoode = new Label();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBoxIsActive);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(dtpShiftEnd);
            panel1.Controls.Add(labelShiftEnd);
            panel1.Controls.Add(dtpShiftStart);
            panel1.Controls.Add(labelShiftStart);
            panel1.Controls.Add(textBoxEmailId);
            panel1.Controls.Add(labelEmailId);
            panel1.Controls.Add(textBoxBMEmpId);
            panel1.Controls.Add(labelBMEmpId);
            panel1.Controls.Add(dtpBirthDate);
            panel1.Controls.Add(labelBirthDate);
            panel1.Controls.Add(labelDepartmentName);
            panel1.Controls.Add(textBoxDesignation);
            panel1.Controls.Add(textBoxDepartmentName);
            panel1.Controls.Add(labelDesignation);
            panel1.Controls.Add(dtpJoinigDate);
            panel1.Controls.Add(textBoxAddress);
            panel1.Controls.Add(labelAddress);
            panel1.Controls.Add(labelJoiningDate);
            panel1.Controls.Add(labelContactNo2);
            panel1.Controls.Add(textBoxHourlySalary);
            panel1.Controls.Add(textBoxContactNo2);
            panel1.Controls.Add(labelContactNo1);
            panel1.Controls.Add(labelHourlySalary);
            panel1.Controls.Add(textBoxMonthlySalary);
            panel1.Controls.Add(textBoxContactNo1);
            panel1.Controls.Add(labelMonthlySalary);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(textBoxEmployeeName);
            panel1.Controls.Add(labelEmployeeName);
            panel1.Controls.Add(textBoxEmpCode);
            panel1.Controls.Add(labelEmpCoode);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 344);
            panel1.TabIndex = 0;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Checked = true;
            checkBoxIsActive.CheckState = CheckState.Checked;
            checkBoxIsActive.Location = new Point(187, 294);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(104, 29);
            checkBoxIsActive.TabIndex = 42;
            checkBoxIsActive.Text = "Is Active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Location = new Point(766, 48);
            label16.Name = "label16";
            label16.Size = new Size(1, 192);
            label16.TabIndex = 41;
            // 
            // dtpShiftEnd
            // 
            dtpShiftEnd.CustomFormat = "hh:mm:ss tt";
            dtpShiftEnd.Format = DateTimePickerFormat.Time;
            dtpShiftEnd.Location = new Point(933, 229);
            dtpShiftEnd.Name = "dtpShiftEnd";
            dtpShiftEnd.Size = new Size(185, 31);
            dtpShiftEnd.TabIndex = 40;
            // 
            // labelShiftEnd
            // 
            labelShiftEnd.AutoSize = true;
            labelShiftEnd.Location = new Point(795, 232);
            labelShiftEnd.Name = "labelShiftEnd";
            labelShiftEnd.Size = new Size(83, 25);
            labelShiftEnd.TabIndex = 39;
            labelShiftEnd.Text = "Shift End";
            // 
            // dtpShiftStart
            // 
            dtpShiftStart.CustomFormat = "hh:mm:ss tt";
            dtpShiftStart.Format = DateTimePickerFormat.Time;
            dtpShiftStart.Location = new Point(933, 188);
            dtpShiftStart.Name = "dtpShiftStart";
            dtpShiftStart.Size = new Size(185, 31);
            dtpShiftStart.TabIndex = 38;
            // 
            // labelShiftStart
            // 
            labelShiftStart.AutoSize = true;
            labelShiftStart.Location = new Point(795, 191);
            labelShiftStart.Name = "labelShiftStart";
            labelShiftStart.Size = new Size(89, 25);
            labelShiftStart.TabIndex = 37;
            labelShiftStart.Text = "Shift Start";
            // 
            // textBoxEmailId
            // 
            textBoxEmailId.Location = new Point(187, 188);
            textBoxEmailId.Name = "textBoxEmailId";
            textBoxEmailId.Size = new Size(536, 31);
            textBoxEmailId.TabIndex = 36;
            // 
            // labelEmailId
            // 
            labelEmailId.AutoSize = true;
            labelEmailId.Location = new Point(27, 191);
            labelEmailId.Name = "labelEmailId";
            labelEmailId.Size = new Size(75, 25);
            labelEmailId.TabIndex = 35;
            labelEmailId.Text = "Email Id";
            // 
            // textBoxBMEmpId
            // 
            textBoxBMEmpId.Location = new Point(187, 65);
            textBoxBMEmpId.Name = "textBoxBMEmpId";
            textBoxBMEmpId.Size = new Size(185, 31);
            textBoxBMEmpId.TabIndex = 34;
            // 
            // labelBMEmpId
            // 
            labelBMEmpId.AutoSize = true;
            labelBMEmpId.Location = new Point(27, 68);
            labelBMEmpId.Name = "labelBMEmpId";
            labelBMEmpId.Size = new Size(100, 25);
            labelBMEmpId.TabIndex = 33;
            labelBMEmpId.Text = "BM Emp Id";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(538, 65);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(185, 31);
            dtpBirthDate.TabIndex = 32;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(411, 68);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(90, 25);
            labelBirthDate.TabIndex = 31;
            labelBirthDate.Text = "Birth Date";
            // 
            // labelDepartmentName
            // 
            labelDepartmentName.AutoSize = true;
            labelDepartmentName.Location = new Point(795, 27);
            labelDepartmentName.Name = "labelDepartmentName";
            labelDepartmentName.Size = new Size(107, 25);
            labelDepartmentName.TabIndex = 30;
            labelDepartmentName.Text = "Department";
            // 
            // textBoxDesignation
            // 
            textBoxDesignation.Location = new Point(933, 65);
            textBoxDesignation.Name = "textBoxDesignation";
            textBoxDesignation.Size = new Size(185, 31);
            textBoxDesignation.TabIndex = 29;
            // 
            // textBoxDepartmentName
            // 
            textBoxDepartmentName.Location = new Point(933, 24);
            textBoxDepartmentName.Name = "textBoxDepartmentName";
            textBoxDepartmentName.Size = new Size(185, 31);
            textBoxDepartmentName.TabIndex = 28;
            // 
            // labelDesignation
            // 
            labelDesignation.AutoSize = true;
            labelDesignation.Location = new Point(795, 68);
            labelDesignation.Name = "labelDesignation";
            labelDesignation.Size = new Size(107, 25);
            labelDesignation.TabIndex = 27;
            labelDesignation.Text = "Designation";
            // 
            // dtpJoinigDate
            // 
            dtpJoinigDate.CustomFormat = "dd/MM/yyyy";
            dtpJoinigDate.Format = DateTimePickerFormat.Short;
            dtpJoinigDate.Location = new Point(538, 24);
            dtpJoinigDate.Name = "dtpJoinigDate";
            dtpJoinigDate.Size = new Size(185, 31);
            dtpJoinigDate.TabIndex = 26;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(187, 147);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(536, 31);
            textBoxAddress.TabIndex = 25;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(27, 150);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(77, 25);
            labelAddress.TabIndex = 24;
            labelAddress.Text = "Address";
            // 
            // labelJoiningDate
            // 
            labelJoiningDate.AutoSize = true;
            labelJoiningDate.Location = new Point(411, 27);
            labelJoiningDate.Name = "labelJoiningDate";
            labelJoiningDate.Size = new Size(110, 25);
            labelJoiningDate.TabIndex = 23;
            labelJoiningDate.Text = "Joining Date";
            // 
            // labelContactNo2
            // 
            labelContactNo2.AutoSize = true;
            labelContactNo2.Location = new Point(408, 232);
            labelContactNo2.Name = "labelContactNo2";
            labelContactNo2.Size = new Size(121, 25);
            labelContactNo2.TabIndex = 22;
            labelContactNo2.Text = "Contact No. 2";
            // 
            // textBoxHourlySalary
            // 
            textBoxHourlySalary.Location = new Point(933, 147);
            textBoxHourlySalary.Name = "textBoxHourlySalary";
            textBoxHourlySalary.Size = new Size(185, 31);
            textBoxHourlySalary.TabIndex = 21;
            // 
            // textBoxContactNo2
            // 
            textBoxContactNo2.Location = new Point(538, 229);
            textBoxContactNo2.Name = "textBoxContactNo2";
            textBoxContactNo2.Size = new Size(185, 31);
            textBoxContactNo2.TabIndex = 20;
            // 
            // labelContactNo1
            // 
            labelContactNo1.AutoSize = true;
            labelContactNo1.Location = new Point(27, 232);
            labelContactNo1.Name = "labelContactNo1";
            labelContactNo1.Size = new Size(121, 25);
            labelContactNo1.TabIndex = 19;
            labelContactNo1.Text = "Contact No. 1";
            // 
            // labelHourlySalary
            // 
            labelHourlySalary.AutoSize = true;
            labelHourlySalary.Location = new Point(795, 150);
            labelHourlySalary.Name = "labelHourlySalary";
            labelHourlySalary.Size = new Size(117, 25);
            labelHourlySalary.TabIndex = 18;
            labelHourlySalary.Text = "Hourly Salary";
            // 
            // textBoxMonthlySalary
            // 
            textBoxMonthlySalary.Location = new Point(933, 106);
            textBoxMonthlySalary.Name = "textBoxMonthlySalary";
            textBoxMonthlySalary.Size = new Size(185, 31);
            textBoxMonthlySalary.TabIndex = 17;
            // 
            // textBoxContactNo1
            // 
            textBoxContactNo1.Location = new Point(187, 229);
            textBoxContactNo1.Name = "textBoxContactNo1";
            textBoxContactNo1.Size = new Size(185, 31);
            textBoxContactNo1.TabIndex = 16;
            // 
            // labelMonthlySalary
            // 
            labelMonthlySalary.AutoSize = true;
            labelMonthlySalary.Location = new Point(795, 109);
            labelMonthlySalary.Name = "labelMonthlySalary";
            labelMonthlySalary.Size = new Size(130, 25);
            labelMonthlySalary.TabIndex = 15;
            labelMonthlySalary.Text = "Monthly Salary";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(575, 288);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(106, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.Location = new Point(187, 106);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(536, 31);
            textBoxEmployeeName.TabIndex = 10;
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Location = new Point(27, 109);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(142, 25);
            labelEmployeeName.TabIndex = 9;
            labelEmployeeName.Text = "Employee Name";
            // 
            // textBoxEmpCode
            // 
            textBoxEmpCode.Location = new Point(187, 24);
            textBoxEmpCode.Name = "textBoxEmpCode";
            textBoxEmpCode.Size = new Size(185, 31);
            textBoxEmpCode.TabIndex = 8;
            // 
            // labelEmpCoode
            // 
            labelEmpCoode.AutoSize = true;
            labelEmpCoode.Location = new Point(27, 27);
            labelEmpCoode.Name = "labelEmpCoode";
            labelEmpCoode.Size = new Size(95, 25);
            labelEmpCoode.TabIndex = 7;
            labelEmpCoode.Text = "Emp Code";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(463, 288);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(781, 109);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 43;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(781, 153);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 44;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(781, 193);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 45;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(781, 234);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 46;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(13, 68);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 47;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(13, 109);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 48;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(13, 234);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 49;
            label7.Text = "*";
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1168, 373);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Employee";
            Load += FormEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancel;
        private TextBox textBoxEmployeeName;
        private Label labelEmployeeName;
        private TextBox textBoxEmpCode;
        private Label labelEmpCoode;
        private Button buttonSave;
        private Label labelHourlySalary;
        private TextBox textBoxMonthlySalary;
        private TextBox textBoxContactNo1;
        private Label labelMonthlySalary;
        private Label labelJoiningDate;
        private Label labelContactNo2;
        private TextBox textBoxHourlySalary;
        private TextBox textBoxContactNo2;
        private Label labelContactNo1;
        private DateTimePicker dtpJoinigDate;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private Label labelDepartmentName;
        private TextBox textBoxDesignation;
        private TextBox textBoxDepartmentName;
        private Label labelDesignation;
        private TextBox textBoxBMEmpId;
        private Label labelBMEmpId;
        private DateTimePicker dtpBirthDate;
        private Label labelBirthDate;
        private TextBox textBoxEmailId;
        private Label labelEmailId;
        private DateTimePicker dtpShiftEnd;
        private Label labelShiftEnd;
        private DateTimePicker dtpShiftStart;
        private Label labelShiftStart;
        private Label label16;
        private CheckBox checkBoxIsActive;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}