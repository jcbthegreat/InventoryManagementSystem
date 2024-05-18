using InventoryManagementSystem.Forms;
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
        private readonly string sqlConnectionString;


        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this._mainView.ShowSettings += ShowSettings;

        }

        private void ShowSettings(object? sender, EventArgs e)
        {
            ISettingsUserControl settingsView = new SettingsUserControl();
            new SettingsUserControlPresenter(settingsView, MainForm.Instance.FirstName, MainForm.Instance.Lastname, sqlConnectionString);
            _mainView.ShowSettingsUserControl(settingsView);
        }
    }
}
    