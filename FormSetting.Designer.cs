namespace EmpAttendanceSQLite
{
    partial class FormSetting
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
            buttonSave = new Button();
            labelUserId = new Label();
            textBoxAppDataPath = new TextBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(175, 77);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 38);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Location = new Point(42, 31);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(127, 25);
            labelUserId.TabIndex = 1;
            labelUserId.Text = "App Data Path";
            // 
            // textBoxAppDataPath
            // 
            textBoxAppDataPath.Location = new Point(175, 28);
            textBoxAppDataPath.Name = "textBoxAppDataPath";
            textBoxAppDataPath.Size = new Size(600, 31);
            textBoxAppDataPath.TabIndex = 2;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(293, 77);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(106, 38);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(827, 135);
            Controls.Add(buttonExit);
            Controls.Add(textBoxAppDataPath);
            Controls.Add(labelUserId);
            Controls.Add(buttonSave);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label labelUserId;
        private TextBox textBoxAppDataPath;
        private Button buttonExit;
    }
}
