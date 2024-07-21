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
                MessageBox.Show("Username and password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        IMainView mainView = new MainForm(firstName, lastName, position, userName, user.RoleType);
                        new MainPresenter(mainView, sqlConnectionString);

                        mainView.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Clear the fields after a failed attempt
                        _loginView.UserName = string.Empty;
                        _loginView.PassWord = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}