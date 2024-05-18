using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryModel> GetByValue(string CategoryName, string Description);
    }
}
