using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface IVariantRepository
    {
        IEnumerable<VariantModel> GetByValue(string VariantName, string Description, string TypeID);
    }
}
