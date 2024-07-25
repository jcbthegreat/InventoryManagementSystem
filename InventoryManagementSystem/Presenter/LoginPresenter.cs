using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Repositories;
using InventoryManagementSystem.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem.Presenter
{
    public class LoginPresenter
    {
        private ILoginView _loginView;
        private readonly string sqlConnectionString;

        public LoginPresenter(ILoginView loginView, string sqlConnectionString)
        {
            this._loginView = loginView;
            this.sqlConnectionString = sqlConnectionString;
            this._loginView.Login += LoginEvent;
        }

        private void LoginEvent(object? sender, EventArgs e)
        {
            string userName = _loginView.UserName;
            string password = _loginView.PassWord;

            // Check if username or password fields are empty
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                ShowToast("ERROR", "Username and password cannot be empty.");
                return;
            }

            try
            {
                using (var repository = new LoginRepository(sqlConnectionString))
                {
                    var user = repository.GetByValue(userName, password).FirstOrDefault();

                    // Check if user is found and credentials match
                    if (user != null && user.UserName == userName && user.PassWord == password)
                    {
                        // Successful login
                        _loginView.Hide();

                        // Retrieve first name, last name, and position
                        string firstName = user.FirstName;
                        string lastName = user.LastName;
                        string position = user.Position;

                        // Create and show the main view
                        IMainView mainView = new MainForm(firstName, lastName, position, userName, user.StaffNo, user.RoleType);
                        new MainPresenter(mainView, sqlConnectionString);

                        mainView.Show();

                        ShowToast("SUCCESS", "Login successful!");
                    }
                    else
                    {
                        ShowToast("ERROR", "Incorrect username or password.");
                        // Clear the fields after a failed attempt
                        _loginView.UserName = string.Empty;
                        _loginView.PassWord = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowToast("ERROR", $"An error occurred: {ex.Message}");
            }
        }

        private void ShowToast(string type, string message)
        {
            // Assuming you have a method to show toast messages
            // This could be implemented as a static method or a service
            Toast toast = new Toast(type, message);
            toast.Show();
        }
    }
}