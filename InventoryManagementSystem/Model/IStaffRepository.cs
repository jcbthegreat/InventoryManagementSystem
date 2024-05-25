using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface IStaffRepository
    {
        IEnumerable<StaffModel> GetByValue(string StaffNo, string RoleType, string Position, string FirstName, string MiddleName, string Lastname, string Email,
            string ContactNo, string Username, string Password, string ImgPath);
    }
}
