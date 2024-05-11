using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Model;
using InventoryManagementSystem.Presenter;
using InventoryManagementSystem.Repositories;
using InventoryManagementSystem.View;
using System.Configuration;

namespace InventoryManagementSystem
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ILoginView loginView = new LoginForm();
            new LoginPresenter(loginView, sqlConnectionString);

            Application.Run((Form)loginView);
        }
    }
}