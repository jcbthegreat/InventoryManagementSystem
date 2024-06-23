using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IStaffView
    {
        string StaffNo { get; set; }
        string RoleType { get; set; }

        string Position { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string Lastname { get; set; }
        string Email { get; set; }
        string ContactNo { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        byte[] ImgPath { get; set; }


        event EventHandler Staff;

        void SetBindingStaffSource(BindingSource staff);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
