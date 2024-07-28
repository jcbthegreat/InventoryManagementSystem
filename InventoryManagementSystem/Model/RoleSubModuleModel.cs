using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class RoleSubModuleModel
    {
        private string roletype;
        private int moduleid;
        private int submoduleid;
        private string submodulename;
        private bool isactive;

        public string Roletype
        {
            get { return roletype; }
            set { roletype = value; }
        }

        public int ModuleId
        {
            get { return moduleid; }
            set { moduleid = value; }
        }

        public int SubModuleId
        {
            get { return submoduleid; }
            set { submoduleid = value; }
        }

        public string SubModuleName
        {
            get { return submodulename; }
            set { submodulename = value; }
        }

        public bool IsActive
        {
            get { return isactive; }
            set { isactive = value; }
        }
    }
}
