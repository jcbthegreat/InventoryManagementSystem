using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryManagementSystem.Model
{
    public interface ILoginRepository
    {
        IEnumerable<LoginModel> GetByValue(string UserName, string PassWord);
    }
}
