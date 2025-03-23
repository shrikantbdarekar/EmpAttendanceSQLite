namespace EmpAttendanceSQLite
{
    partial class FormUser
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
            comboBoxRole = new ComboBox();
            label12 = new Label();
            textBoxPassword = new TextBox();
            label8 = new Label();
            buttonCancel = new Button();
            textBoxUserId = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(comboBoxRole);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(textBoxUserId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 205);
            panel1.TabIndex = 0;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(218, 65);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(185, 33);
            comboBoxRole.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(52, 111);
            label12.Name = "label12";
            label12.Size = new Size(87, 25);
            label12.TabIndex = 33;
            label12.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(218, 108);
            textBoxPassword.Name = "textBoxPassword";
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
            buttonCancel.Location = new Point(229, 161);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(106, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxUserId
            // 
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
            // buttonSave
            // 
            buttonSave.Location = new Point(117, 161);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(477, 233);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User";
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
        private Button buttonSave;
        private Label label8;
        private TextBox textBoxPassword;
        private Label label12;
        private ComboBox comboBoxRole;
    }
}