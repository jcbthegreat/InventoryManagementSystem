using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IWarehouseView
    {
        string Name { get; set; }
        string Address { get; set; }


        event EventHandler Warehouse;

        void SetBindingWarehouseSource(BindingSource warehouse);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
