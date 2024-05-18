using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.Model;
using InventoryManagementSystem.Repositories;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class SettingsUserControlPresenter
    {
        private ISettingsUserControl _settingsUserControl;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public SettingsUserControlPresenter(ISettingsUserControl settingsUserControl, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _settingsUserControl = settingsUserControl;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            this._settingsUserControl.ShowCategory += ShowCategory;
            this._settingsUserControl.ShowSubCategory += ShowSubCategory;
        }

        private void ShowCategory(Object? sender, EventArgs e)
        {
            ICategoryView categoryView = new AddCategory();
            new CategoryPresenter(categoryView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addCategoryForm = (Form)categoryView;
            addCategoryForm.Show();


        }

        private void ShowSubCategory(Object? sender, EventArgs e)
        {
            ISubCategoryView subcategoryView = new AddSubCategory();
            new SubCategoryPresenter(subcategoryView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addSubCategoryForm = (Form)subcategoryView;
            addSubCategoryForm.Show();


        }
    }
}
