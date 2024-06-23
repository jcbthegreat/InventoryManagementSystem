using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerModel> GetByValue(string Name,string Email, string Address, string Discount, string Is_Supplier);
    }
}
