using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IUpdateWarehouseProduct
    {
        string Product_Id { get; set; }

        string Current_Stock { get; set; }
        string Min_Stock { get; set; }
        string Max_Stock { get; set; }
        string Original_Price { get; set; }
        string Retail_Price { get; set; }


        event EventHandler UpdateItems;

        void SetBindingItemsSource(BindingSource item);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
