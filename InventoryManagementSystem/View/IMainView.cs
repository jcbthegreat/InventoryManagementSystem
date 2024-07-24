using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IMainView
    {

        string RoleType { get; set; }
        string StaffNo { get; set; }
        int ModuleId { get; set; }
        event EventHandler ShowSettings;
        event EventHandler ShowProfile;
        event EventHandler ShowProduct;

        void Show();
        void ShowSettingsUserControl(ISettingsUserControl settingsUserControl);
        void ShowProductControl(IShowProductControl showProductControl);

        void HideSettingsBtn();
        void HidePurchaseOrderBtn();
        void HideProductsBtn();
        void HideReportsBtn();

        void ShowSettingsBtn();
        void ShowPurchaseOrderBtn();
        void ShowProductsBtn();
        void ShowReportsBtn();




        //void HideProductBtn();
        //void ShowSettingsBtn();

    }
}
