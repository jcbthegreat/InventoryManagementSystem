using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface ICustomerView
    {
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Contact { get; set; }
        string Discount { get; set; }
        string Is_Supplier { get; set; }


        event EventHandler Customer;

        void SetBindingCustomerSource(BindingSource customer);
        void Show();
        void Hide();
        void RefreshDataGridView();

    }
}
