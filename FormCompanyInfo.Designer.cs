namespace EmpAttendanceSQLite
{
    partial class FormCompanyInfo
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
            labelWebsite = new Label();
            textBoxWebsite = new TextBox();
            textBoxEmailId = new TextBox();
            labelEmailId = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            labelContactNo = new Label();
            textBoxContactNo = new TextBox();
            buttonCancel = new Button();
            textBoxCompanyName = new TextBox();
            labelCompanyName = new Label();
            buttonSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(labelWebsite);
            panel1.Controls.Add(textBoxWebsite);
            panel1.Controls.Add(textBoxEmailId);
            panel1.Controls.Add(labelEmailId);
            panel1.Controls.Add(textBoxAddress);
            panel1.Controls.Add(labelAddress);
            panel1.Controls.Add(labelContactNo);
            panel1.Controls.Add(textBoxContactNo);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(textBoxCompanyName);
            panel1.Controls.Add(labelCompanyName);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 294);
            panel1.TabIndex = 0;
            // 
            // labelWebsite
            // 
            labelWebsite.AutoSize = true;
            labelWebsite.Location = new Point(43, 191);
            labelWebsite.Name = "labelWebsite";
            labelWebsite.Size = new Size(75, 25);
            labelWebsite.TabIndex = 43;
            labelWebsite.Text = "Website";
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(203, 188);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(536, 31);
            textBoxWebsite.TabIndex = 42;
            // 
            // textBoxEmailId
            // 
            textBoxEmailId.Location = new Point(203, 106);
            textBoxEmailId.Name = "textBoxEmailId";
            textBoxEmailId.Size = new Size(536, 31);
            textBoxEmailId.TabIndex = 36;
            // 
            // labelEmailId
            // 
            labelEmailId.AutoSize = true;
            labelEmailId.Location = new Point(43, 109);
            labelEmailId.Name = "labelEmailId";
            labelEmailId.Size = new Size(75, 25);
            labelEmailId.TabIndex = 35;
            labelEmailId.Text = "Email Id";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(203, 65);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(536, 31);
            textBoxAddress.TabIndex = 25;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(43, 68);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(77, 25);
            labelAddress.TabIndex = 24;
            labelAddress.Text = "Address";
            // 
            // labelContactNo
            // 
            labelContactNo.AutoSize = true;
            labelContactNo.Location = new Point(43, 150);
            labelContactNo.Name = "labelContactNo";
            labelContactNo.Size = new Size(111, 25);
            labelContactNo.TabIndex = 19;
            labelContactNo.Text = "Contact No. ";
            // 
            // textBoxContactNo
            // 
            textBoxContactNo.Location = new Point(203, 147);
            textBoxContactNo.Name = "textBoxContactNo";
            textBoxContactNo.Size = new Size(536, 31);
            textBoxContactNo.TabIndex = 16;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(394, 240);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(106, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(203, 24);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(536, 31);
            textBoxCompanyName.TabIndex = 10;
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new Point(43, 27);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(141, 25);
            labelCompanyName.TabIndex = 9;
            labelCompanyName.Text = "Company Name";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(282, 240);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormCompanyInfo
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(806, 321);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCompanyInfo";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Company Info";
            Load += FormCompanyInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancel;
        private TextBox textBoxCompanyName;
        private Label labelCompanyName;
        private Button buttonSave;
        private TextBox textBoxContactNo;
        private Label labelContactNo;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private TextBox textBoxEmailId;
        private Label labelEmailId;
        private Label labelWebsite;
        private TextBox textBoxWebsite;
    }
}