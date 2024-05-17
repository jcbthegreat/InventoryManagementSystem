using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface ILoginView
    {
        int ID { get; set; }
        string StaffNo { get; set; }
        string RoleType { get; set; }
        string Position { get; set; }
        string Lastname { get; set; }
        string FirstName { get; set; }
        string UserName { get; set; }
        string PassWord { get; set; }


        event EventHandler Login;

        void SetBindingLoginSource(BindingSource login);
        void Show();
        void Hide();
    }
}
