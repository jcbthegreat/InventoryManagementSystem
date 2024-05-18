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

        void Show();
        void ShowSettingsUserControl(ISettingsUserControl settingsUserControl);

        void Hide();
    }
}
