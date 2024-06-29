using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface IWarehousItem
    {
        IEnumerable<WarehouseItemModel> GetByValue(string Warehouse_Id, string Product_Id, string Current_Stock, string Min_Stock, string Max_Stock, string Original_Price, string Retail_Price);
    }
}
