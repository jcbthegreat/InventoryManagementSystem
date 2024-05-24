using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface IBrandRepository
    {
        IEnumerable<BrandModel> GetByValue(string BrandName, string Description, string VariantID);
    }
}
