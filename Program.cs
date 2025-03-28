using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace EmpAttendanceSQLite
{
    internal static class Program
    {
        // Handle current login credentials
        public static LoginUser loginUser = new LoginUser();
        public static CompanyInfo companyInfo = new CompanyInfo();
        public static string AppDataPath = string.Empty;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //EmpAttendanceSQLite.Properties.Settings.Default.AppDataPath = "xyz";
            //EmpAttendanceSQLite.Properties.Settings.Default.Save();
            AppDataPath = EmpAttendanceSQLite.Properties.Settings.Default.AppDataPath;
            

            using (var context = new AppDbContext())
            {
                if (context.CompanyInfos.Count() == 1)
                {
                    companyInfo = context.CompanyInfos.FirstOrDefault();
                }
            }

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