using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class LoginModel
    {
        private int id;
        private string staffno;
        private string username, password;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }

        public string StaffNo
        {
            get { return staffno; }
            set { staffno = value; }
        }
    }
}
