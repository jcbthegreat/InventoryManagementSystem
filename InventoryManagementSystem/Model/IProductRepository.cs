using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetByValue(string Product_Code, string Product_Name, string Brand_Id, string Category_Id, string Subcategory_Id, string Type_Id, string Unit_Id, string Variant_Id, string Unit_Count);
    }
}
