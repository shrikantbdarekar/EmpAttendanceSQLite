namespace EmpAttendanceSQLite
{
    partial class FormMachine
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
            labelMachineDescription = new Label();
            textBoxMachineDescription = new TextBox();
            labelBMMachineId = new Label();
            textBoxBMMachineId = new TextBox();
            buttonCancel = new Button();
            textBoxMachineName = new TextBox();
            labelMachineName = new Label();
            buttonSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(labelMachineDescription);
            panel1.Controls.Add(textBoxMachineDescription);
            panel1.Controls.Add(labelBMMachineId);
            panel1.Controls.Add(textBoxBMMachineId);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(textBoxMachineName);
            panel1.Controls.Add(labelMachineName);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 205);
            panel1.TabIndex = 0;
            // 
            // labelMachineDescription
            // 
            labelMachineDescription.AutoSize = true;
            labelMachineDescription.Location = new Point(46, 109);
            labelMachineDescription.Name = "labelMachineDescription";
            labelMachineDescription.Size = new Size(102, 25);
            labelMachineDescription.TabIndex = 35;
            labelMachineDescription.Text = "Description";
            // 
            // textBoxMachineDescription
            // 
            textBoxMachineDescription.Location = new Point(212, 106);
            textBoxMachineDescription.Name = "textBoxMachineDescription";
            textBoxMachineDescription.Size = new Size(354, 31);
            textBoxMachineDescription.TabIndex = 34;
            // 
            // labelBMMachineId
            // 
            labelBMMachineId.AutoSize = true;
            labelBMMachineId.Location = new Point(46, 68);
            labelBMMachineId.Name = "labelBMMachineId";
            labelBMMachineId.Size = new Size(59, 25);
            labelBMMachineId.TabIndex = 33;
            labelBMMachineId.Text = "BM Id";
            // 
            // textBoxBMMachineId
            // 
            textBoxBMMachineId.Location = new Point(212, 65);
            textBoxBMMachineId.Name = "textBoxBMMachineId";
            textBoxBMMachineId.Size = new Size(185, 31);
            textBoxBMMachineId.TabIndex = 28;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(309, 161);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(106, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxMachineName
            // 
            textBoxMachineName.Location = new Point(212, 24);
            textBoxMachineName.Name = "textBoxMachineName";
            textBoxMachineName.Size = new Size(354, 31);
            textBoxMachineName.TabIndex = 8;
            // 
            // labelMachineName
            // 
            labelMachineName.AutoSize = true;
            labelMachineName.Location = new Point(46, 27);
            labelMachineName.Name = "labelMachineName";
            labelMachineName.Size = new Size(130, 25);
            labelMachineName.TabIndex = 7;
            labelMachineName.Text = "Machine Name";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(197, 161);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormMachine
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(637, 233);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMachine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Biometric Machine";
            Load += FormUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancel;
        private TextBox textBoxMachineName;
        private Label labelMachineName;
        private Button buttonSave;
        private TextBox textBoxBMMachineId;
        private Label labelBMMachineId;
        private Label labelMachineDescription;
        private TextBox textBoxMachineDescription;
    }
}