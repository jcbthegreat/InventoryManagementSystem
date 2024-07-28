using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface ISettingsUserControlRepository
    {
        IEnumerable<RoleSubModuleModel> GetSubModuleAccess(string roleType, int moduleId);
    }
}
