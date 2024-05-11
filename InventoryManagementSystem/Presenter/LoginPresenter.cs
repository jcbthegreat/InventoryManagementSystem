using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Repositories;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string staffno = "";

            try
            {
                using (var repository = new LoginRepository(sqlConnectionString))
                {
                    var user = repository.GetByValue(userName, password).FirstOrDefault();

                    if (user.UserName == _loginView.UserName && user.PassWord == _loginView.PassWord)
                    {
                        // Successful login
                        //staffId = user.StaffID;
                        _loginView.Hide();
                        IMainView mainView = new MainForm();
                        new MainPresenter(mainView, sqlConnectionString);
                        mainView.Show();

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                //view.ShowMessage("An error occurred while processing the login: " + ex.Message);
            }
        }
    }
}
