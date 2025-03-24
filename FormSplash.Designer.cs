namespace EmpAttendanceSQLite
{
    partial class FormSplash
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
            labelMessage = new Label();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.White;
            labelMessage.Location = new Point(12, 12);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(301, 127);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "Wait while processing";
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSplash
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(325, 150);
            ControlBox = false;
            Controls.Add(labelMessage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSplash";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Label labelMessage;
    }
}