﻿namespace EmpAttendanceSQLite
{
    partial class FormAddManualLog
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
            labelMissingFlag = new Label();
            labelPunchDate = new Label();
            comboBoxMachines = new ComboBox();
            labelDeviceId = new Label();
            comboBoxPunchType = new ComboBox();
            dtpPunchTime = new DateTimePicker();
            textBoxEmployeeCode = new TextBox();
            label1 = new Label();
            textBoxEmployeeName = new TextBox();
            labelEmployeeName = new Label();
            labelAddress = new Label();
            labelPunchTime = new Label();
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
            panel1.Controls.Add(labelMissingFlag);
            panel1.Controls.Add(labelPunchDate);
            panel1.Controls.Add(comboBoxMachines);
            panel1.Controls.Add(labelDeviceId);
            panel1.Controls.Add(comboBoxPunchType);
            panel1.Controls.Add(dtpPunchTime);
            panel1.Controls.Add(textBoxEmployeeCode);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxEmployeeName);
            panel1.Controls.Add(labelEmployeeName);
            panel1.Controls.Add(labelAddress);
            panel1.Controls.Add(labelPunchTime);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(textBoxBMEmployeeCode);
            panel1.Controls.Add(labelCompanyName);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 288);
            panel1.TabIndex = 0;
            // 
            // labelMissingFlag
            // 
            labelMissingFlag.BackColor = Color.WhiteSmoke;
            labelMissingFlag.Font = new Font("Segoe UI", 11F);
            labelMissingFlag.ForeColor = Color.Red;
            labelMissingFlag.Location = new Point(405, 154);
            labelMissingFlag.Name = "labelMissingFlag";
            labelMissingFlag.Size = new Size(221, 73);
            labelMissingFlag.TabIndex = 59;
            labelMissingFlag.Text = "BM Emp.Id";
            labelMissingFlag.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPunchDate
            // 
            labelPunchDate.AutoSize = true;
            labelPunchDate.Location = new Point(362, 115);
            labelPunchDate.Name = "labelPunchDate";
            labelPunchDate.Size = new Size(99, 25);
            labelPunchDate.TabIndex = 58;
            labelPunchDate.Text = "BM Emp.Id";
            // 
            // comboBoxMachines
            // 
            comboBoxMachines.FormattingEnabled = true;
            comboBoxMachines.Location = new Point(196, 194);
            comboBoxMachines.Name = "comboBoxMachines";
            comboBoxMachines.Size = new Size(160, 33);
            comboBoxMachines.TabIndex = 57;
            // 
            // labelDeviceId
            // 
            labelDeviceId.AutoSize = true;
            labelDeviceId.Location = new Point(36, 197);
            labelDeviceId.Name = "labelDeviceId";
            labelDeviceId.Size = new Size(64, 25);
            labelDeviceId.TabIndex = 56;
            labelDeviceId.Text = "Device";
            // 
            // comboBoxPunchType
            // 
            comboBoxPunchType.FormattingEnabled = true;
            comboBoxPunchType.Location = new Point(196, 151);
            comboBoxPunchType.Name = "comboBoxPunchType";
            comboBoxPunchType.Size = new Size(160, 33);
            comboBoxPunchType.TabIndex = 55;
            // 
            // dtpPunchTime
            // 
            dtpPunchTime.CustomFormat = "hh:mm tt";
            dtpPunchTime.Format = DateTimePickerFormat.Custom;
            dtpPunchTime.Location = new Point(196, 110);
            dtpPunchTime.Name = "dtpPunchTime";
            dtpPunchTime.Size = new Size(160, 31);
            dtpPunchTime.TabIndex = 54;
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
            labelAddress.Location = new Point(36, 115);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(103, 25);
            labelAddress.TabIndex = 24;
            labelAddress.Text = "Punch Time";
            // 
            // labelPunchTime
            // 
            labelPunchTime.AutoSize = true;
            labelPunchTime.Location = new Point(36, 154);
            labelPunchTime.Name = "labelPunchTime";
            labelPunchTime.Size = new Size(102, 25);
            labelPunchTime.TabIndex = 19;
            labelPunchTime.Text = "Punch Type";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(308, 247);
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
            buttonSave.Location = new Point(196, 247);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormAddManualLog
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(687, 315);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddManualLog";
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
        private Label labelPunchTime;
        private Label labelAddress;
        private TextBox textBoxEmployeeCode;
        private Label label1;
        private TextBox textBoxEmployeeName;
        private Label labelEmployeeName;
        private DateTimePicker dtpPunchTime;
        private ComboBox comboBoxPunchType;
        private ComboBox comboBoxMachines;
        private Label labelDeviceId;
        private Label labelPunchDate;
        private Label labelMissingFlag;
    }
}