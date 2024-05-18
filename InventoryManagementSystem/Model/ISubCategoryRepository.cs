using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface ISubCategoryRepository
    {
        IEnumerable<SubCategoryModel> GetByValue(string SubCategoryName, string Description, string MainCategoryID);
    }
}
