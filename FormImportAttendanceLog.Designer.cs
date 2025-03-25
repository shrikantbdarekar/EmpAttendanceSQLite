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
            SuspendLayout();
            // 
            // buttonImportData
            // 
            buttonImportData.Location = new Point(157, 77);
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
            buttonExit.Location = new Point(269, 77);
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
            // FormImportAttendanceLog
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(649, 145);
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
    }
}
