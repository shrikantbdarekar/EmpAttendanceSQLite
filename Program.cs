using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System.Runtime.CompilerServices;

namespace EmpAttendanceSQLite
{
    internal static class Program
    {
        // Handle current login credentials
        public static LoginUser loginUser = new LoginUser();
        public static CompanyInfo companyInfo = new CompanyInfo();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

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