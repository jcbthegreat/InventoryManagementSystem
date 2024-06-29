using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.View;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class ShowProductPresenter
    {
        private IShowProductControl _showProductControl;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public ShowProductPresenter(IShowProductControl settingsUserControl, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _showProductControl = settingsUserControl;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            this._showProductControl.ShowItem += ShowItem;


        }

        private void ShowItem(Object? sender, EventArgs e)
        {
            IWarehouseItemView warehouseItemView = new AddWarehouseItem();
            new WarehouseItemPresenter(warehouseItemView, _sqlConnectionString);

            // Show the AddCategory form
            var additemForm = (Form)warehouseItemView;
            additemForm.Show();


        }
    }
}

