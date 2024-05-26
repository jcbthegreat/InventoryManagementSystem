using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private readonly string _sqlConnectionString;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            _sqlConnectionString = sqlConnectionString;
      
            _mainView.ShowSettings += ShowSettings;
            _mainView.ShowProfile += ShowProfile;
        }

        private void ShowSettings(object? sender, EventArgs e)
        {
            ISettingsUserControl settingsView = new SettingsUserControl();
            new SettingsUserControlPresenter(settingsView, MainForm.Instance.FirstName, MainForm.Instance.Lastname, _sqlConnectionString);
            _mainView.ShowSettingsUserControl(settingsView);
        }

        private void ShowProfile(Object? sender, EventArgs e)
        {
            IStaffView staffView = new EditProfile(); 
            new EditProfilePresenter(staffView,  _sqlConnectionString);     
            var editProfileForm = (Form)staffView;
            editProfileForm.Show();
        }
    }
}
    