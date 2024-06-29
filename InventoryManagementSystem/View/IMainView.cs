using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IMainView
    {


        event EventHandler ShowSettings;
        event EventHandler ShowProfile;
        event EventHandler ShowProduct;

        void Show();
        void ShowSettingsUserControl(ISettingsUserControl settingsUserControl);
        void ShowProductControl(IShowProductControl showProductControl);
       

   
    }
}
