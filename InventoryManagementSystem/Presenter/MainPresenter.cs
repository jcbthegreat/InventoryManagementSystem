using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
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
            //this._mainView.ShowSettings += ShowSettings;

        }
    }
}
