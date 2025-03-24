namespace EmpAttendanceSQLite
{
    partial class FormChangePassword
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
            label4 = new Label();
            labelConfirmPassword = new Label();
            textBoxConfirmPassword = new TextBox();
            labelNewPassword = new Label();
            textBoxNewPassword = new TextBox();
            comboBoxRole = new ComboBox();
            label12 = new Label();
            textBoxPassword = new TextBox();
            label8 = new Label();
            buttonCancel = new Button();
            textBoxUserId = new TextBox();
            label1 = new Label();
            buttonUpdatePassword = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(labelConfirmPassword);
            panel1.Controls.Add(textBoxConfirmPassword);
            panel1.Controls.Add(labelNewPassword);
            panel1.Controls.Add(textBoxNewPassword);
            panel1.Controls.Add(comboBoxRole);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(textBoxUserId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonUpdatePassword);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 322);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(116, 121);
            label4.Name = "label4";
            label4.Size = new Size(220, 1);
            label4.TabIndex = 47;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Location = new Point(52, 229);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(156, 25);
            labelConfirmPassword.TabIndex = 46;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(218, 226);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.Size = new Size(185, 31);
            textBoxConfirmPassword.TabIndex = 45;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Location = new Point(52, 188);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(127, 25);
            labelNewPassword.TabIndex = 44;
            labelNewPassword.Text = "New Password";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(218, 185);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.Size = new Size(185, 31);
            textBoxNewPassword.TabIndex = 43;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Enabled = false;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(218, 65);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(185, 33);
            comboBoxRole.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(52, 147);
            label12.Name = "label12";
            label12.Size = new Size(87, 25);
            label12.TabIndex = 33;
            label12.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(218, 144);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(185, 31);
            textBoxPassword.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 68);
            label8.Name = "label8";
            label8.Size = new Size(46, 25);
            label8.TabIndex = 24;
            label8.Text = "Role";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(229, 277);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(106, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Enabled = false;
            textBoxUserId.Location = new Point(218, 24);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(185, 31);
            textBoxUserId.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 27);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            // 
            // buttonUpdatePassword
            // 
            buttonUpdatePassword.Location = new Point(117, 277);
            buttonUpdatePassword.Name = "buttonUpdatePassword";
            buttonUpdatePassword.Size = new Size(106, 38);
            buttonUpdatePassword.TabIndex = 6;
            buttonUpdatePassword.Text = "Update";
            buttonUpdatePassword.UseVisualStyleBackColor = true;
            buttonUpdatePassword.Click += buttonUpdatePassword_Click;
            // 
            // FormChangePassword
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(477, 350);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            Load += FormUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancel;
        private TextBox textBoxUserId;
        private Label label1;
        private Button buttonUpdatePassword;
        private Label label8;
        private TextBox textBoxPassword;
        private Label label12;
        private ComboBox comboBoxRole;
        private Label label4;
        private Label labelConfirmPassword;
        private TextBox textBoxConfirmPassword;
        private Label labelNewPassword;
        private TextBox textBoxNewPassword;
    }
}