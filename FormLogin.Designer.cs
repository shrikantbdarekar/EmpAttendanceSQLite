namespace EmpAttendanceSQLite
{
    partial class FormLogin
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
            buttonLogin = new Button();
            label1 = new Label();
            textBoxUserId = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(82, 131);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(106, 38);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 31);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 1;
            label1.Text = "User Id";
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(150, 28);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(196, 31);
            textBoxUserId.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(150, 74);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(196, 31);
            textBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 77);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(200, 131);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(106, 38);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(389, 189);
            Controls.Add(buttonExit);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUserId);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label1;
        private TextBox textBoxUserId;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonExit;
    }
}
