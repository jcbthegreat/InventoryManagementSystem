using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.View;
using InventoryManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Model;

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

            try
            {
                using (var repository = new MainRepository(_sqlConnectionString))
                {
                    var accessModules = repository.GetRoleModuleAccess(_mainView.RoleType);

                    _mainView.HidePurchaseOrderBtn();
                    _mainView.HideProductsBtn();
                    _mainView.HideReportsBtn();
                    _mainView.HideSettingsBtn();
                    foreach (var module in accessModules)
                    {
                        switch (module.ModuleID)
                        {
                            case 1:
                                _mainView.ShowPurchaseOrderBtn();
                                break;
                            case 2:
                                _mainView.ShowProductsBtn();
                                break;
                            case 3:
                                _mainView.ShowReportsBtn();
                                break;
                            case 4:
                                _mainView.ShowSettingsBtn();
                                break;
                            default:
                                // Handle default case or other module IDs if necessary
                                break;
                        }
                    }
                }
            }
            catch
            {

            }
      
            _mainView.ShowSettings += ShowSettings;
            _mainView.ShowProfile += ShowProfile;
            _mainView.ShowProduct += ShowProduct;

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

    

        private void ShowProduct(Object? sender, EventArgs e)
        {
            IShowProductControl showProductControl = new ProductUserControl();
            new ShowProductPresenter(showProductControl, MainForm.Instance.FirstName, MainForm.Instance.Lastname, _sqlConnectionString);
            _mainView.ShowProductControl(showProductControl);
        }

    }
}
    