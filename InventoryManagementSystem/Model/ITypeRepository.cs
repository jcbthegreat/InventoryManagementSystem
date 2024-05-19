using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface ITypeRepository
    {
        IEnumerable<TypeModel> GetByValue(string TypeName, string Description, string SubCategoryID);
    }
}
