namespace EmpAttendanceSQLite
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new FormLogin());

            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (formLogin.DialogResult == DialogResult.OK)
            {
                FormMDI formMDI = new FormMDI();
                formMDI.ShowDialog();
            }
        }
    }
}