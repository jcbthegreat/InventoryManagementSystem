using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IProductView
    {
        string Product_Code { get; set; }
        string Product_Name { get; set; }

        string Brand_Id { get; set; }
        string Category_Id { get; set; }
        string Subcategory_Id { get; set; }
        string Type_Id { get; set; }
        string Unit_Id { get; set; }
        string Variant_Id { get; set; }


        event EventHandler Products;

        void SetBindingProductSource(BindingSource products);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
