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
        private int paymentBtn = 1;
        private int manageCategoryBtn = 2;
        private int subCategoryBtn = 3;
        private int typeBtn = 4;
        private int variantBtn = 5;
        private int measurementBtn = 6;
        private int brandNameBtn = 7;
        private int addWareHouseBtn = 8;
        private int manageUserBtn = 9;
        private int manageStaffBtn = 10;
        private int roleAccessBtn = 11;

        public SettingsUserControlPresenter(ISettingsUserControl settingsUserControl, string createdByFirstName, string createdByLastName, string sqlConnectionString, string roleType, int moduleId)
        {
            _settingsUserControl = settingsUserControl;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;


            try
            {
                using (var repository = new SettingsUserControlRepository(_sqlConnectionString))
                {
                    var accessModules = repository.GetSubModuleAccess(roleType, moduleId);

                    //_mainView.HidePurchaseOrderBtn();
                    //_mainView.HideProductsBtn();
                    //_mainView.HideReportsBtn();
                    //_mainView.HideSettingsBtn();

                    //_mainView.SetButtonVisibility(purchaseOrderBtn, false);
                    _settingsUserControl.SetButtonVisibility(paymentBtn, false);
                    _settingsUserControl.SetButtonVisibility(manageCategoryBtn, false);
                    _settingsUserControl.SetButtonVisibility(subCategoryBtn, false);
                    _settingsUserControl.SetButtonVisibility(typeBtn, false);
                    _settingsUserControl.SetButtonVisibility(variantBtn, false);
                    _settingsUserControl.SetButtonVisibility(measurementBtn, false);
                    _settingsUserControl.SetButtonVisibility(brandNameBtn, false);
                    _settingsUserControl.SetButtonVisibility(addWareHouseBtn, false);
                    _settingsUserControl.SetButtonVisibility(manageUserBtn, false);
                    _settingsUserControl.SetButtonVisibility(manageStaffBtn, false);
                    _settingsUserControl.SetButtonVisibility(roleAccessBtn, false);

                    foreach (var submodule in accessModules)
                    {
                        _settingsUserControl.SetButtonVisibility(submodule.SubModuleId, true);
                    }
                }
            }
            catch
            {

            }
            this._settingsUserControl.ShowCategory += ShowCategory;
            this._settingsUserControl.ShowSubCategory += ShowSubCategory;
            this._settingsUserControl.ShowType += ShowType;
            this._settingsUserControl.ShowVariant += VariantType;
            this._settingsUserControl.ShowBrand += BrandType;
            this._settingsUserControl.ShowMeasure += MeasureType;
            this._settingsUserControl.ShowStaff += StaffType;
            this._settingsUserControl.ShowWarehouse += WarehouseType;
            this._settingsUserControl.ShowCustomer += CustomerType;
         
           
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
        private void BrandType(Object? sender, EventArgs e)
        {
            IBrandView brandView = new AddBrandName();
            new BrandPresenter(brandView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addBrandForm = (Form)brandView;
            addBrandForm.Show();


        }
        private void MeasureType(Object? sender, EventArgs e)
        {
            IMeasurementView measurementView = new AddMeasurement();
            new MeasurementPresenter(measurementView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addmeasureForm = (Form)measurementView;
            addmeasureForm.Show();


        }
        private void StaffType(Object? sender, EventArgs e)
        {
            IStaffView staffView = new StaffDetails();
            new StaffPresenter(staffView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addstaffForm = (Form)staffView;
            addstaffForm.Show();


        }
        private void WarehouseType(Object? sender, EventArgs e)
        {
            IWarehouseView warehouseView = new AddLocation();
            new WarehousePresenter(warehouseView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addwarehouseForm = (Form)warehouseView;
            addwarehouseForm.Show();


        }
        private void CustomerType(Object? sender, EventArgs e)
        {
            ICustomerView customerView = new AddCustomers();
            new CustomerPresenter(customerView, _createdByFirstName, _createdByLastName, _sqlConnectionString);

            // Show the AddCategory form
            var addcustomerForm = (Form)customerView;
            addcustomerForm.Show();


        }
    }
}
