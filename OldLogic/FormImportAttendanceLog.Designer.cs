namespace EmpAttendanceSQLite
{
    partial class FormImportAttendanceLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonImportData = new Button();
            label1 = new Label();
            textBoxFileName = new TextBox();
            buttonExit = new Button();
            openAttendanceLogFileDialog = new OpenFileDialog();
            buttonBrowseFile = new Button();
            label2 = new Label();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            labelDate = new Label();
            SuspendLayout();
            // 
            // buttonImportData
            // 
            buttonImportData.Location = new Point(157, 112);
            buttonImportData.Name = "buttonImportData";
            buttonImportData.Size = new Size(106, 38);
            buttonImportData.TabIndex = 0;
            buttonImportData.Text = "Import";
            buttonImportData.UseVisualStyleBackColor = true;
            buttonImportData.Click += buttonImportData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 33);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "File Name";
            // 
            // textBoxFileName
            // 
            textBoxFileName.Enabled = false;
            textBoxFileName.Location = new Point(157, 30);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(442, 31);
            textBoxFileName.TabIndex = 2;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(269, 112);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(106, 38);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // openAttendanceLogFileDialog
            // 
            openAttendanceLogFileDialog.Filter = "Backup File | *.dat";
            openAttendanceLogFileDialog.Title = "Attendance Log";
            // 
            // buttonBrowseFile
            // 
            buttonBrowseFile.Location = new Point(605, 26);
            buttonBrowseFile.Name = "buttonBrowseFile";
            buttonBrowseFile.Size = new Size(106, 38);
            buttonBrowseFile.TabIndex = 6;
            buttonBrowseFile.Text = "Browse";
            buttonBrowseFile.UseVisualStyleBackColor = true;
            buttonBrowseFile.Click += buttonBrowseFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(321, 74);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 33;
            label2.Text = "To";
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(359, 71);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(158, 31);
            dtpToDate.TabIndex = 32;
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(157, 71);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(158, 31);
            dtpFromDate.TabIndex = 31;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F);
            labelDate.Location = new Point(49, 74);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(96, 25);
            labelDate.TabIndex = 30;
            labelDate.Text = "Date From";
            // 
            // FormImportAttendanceLog
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(766, 177);
            Controls.Add(label2);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(labelDate);
            Controls.Add(buttonBrowseFile);
            Controls.Add(buttonExit);
            Controls.Add(textBoxFileName);
            Controls.Add(label1);
            Controls.Add(buttonImportData);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormImportAttendanceLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import Attendance Log";
            Load += FormImportAttendanceLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label1;
        private TextBox textBoxFileName;
        private Button buttonExit;
        private OpenFileDialog openAttendanceLogFileDialog;
        private Button buttonImportData;
        private Button buttonBrowseFile;
        private Label label2;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Label labelDate;
    }
}
