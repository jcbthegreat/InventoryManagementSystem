using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.Model;
using InventoryManagementSystem.Repositories;
using InventoryManagementSystem.View;
using Microsoft.VisualBasic;
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
            this._settingsUserControl.ShowType += ShowType;
            this._settingsUserControl.ShowVariant += VariantType;
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

        private void ShowType(Object? sender, EventArgs e)
        {
            ITypeView typeView = new AddType();
            new TypePresenter(typeView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addTypeForm = (Form)typeView;
            addTypeForm.Show();


        }
        private void VariantType(Object? sender, EventArgs e)
        {
            IVariantView variantView = new AddVariant();
            new VariantPrenster(variantView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addVariantForm = (Form)variantView;
            addVariantForm.Show();


        }
    }
}
