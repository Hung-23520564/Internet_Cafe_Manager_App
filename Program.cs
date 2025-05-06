using Internet_Cafe_Manager_App.UI;
using Internet_Cafe_Manager_App.UI.Admin;
using Internet_Cafe_Manager_App.UI.User;

namespace Internet_Cafe_Manager_App
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

            Application.Run(new Form_AdminMainDashboard());

        }
    }
}