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

        void Show();
        void ShowSettingsUserControl(ISettingsUserControl settingsUserControl);
       

     
    }
}
