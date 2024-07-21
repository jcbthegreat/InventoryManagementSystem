using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface IMainRepository
    {
        IEnumerable<MainModel> GetByValue(string StaffNo);

        IEnumerable<MainModel> GetRoleModuleAccess(string RoleType);
    }
}
