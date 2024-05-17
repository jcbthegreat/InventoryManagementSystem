using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IMainView
    {

        string StaffNo { get; set; }
        string RoleType { get; set; }
        string Position { get; set; }
        string Lastname { get; set; }
        string FirstName { get; set; }

        event EventHandler ShowSettings;

        void Show();

        void Hide();
    }
}
