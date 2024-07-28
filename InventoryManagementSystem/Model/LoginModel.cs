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
        private string roletype;
        private string username, password;
        private string firstname, lastname;
        private string position;
      

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

        public string RoleType
        {
            get { return roletype; }
            set { roletype = value; }
        }

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public bool isactive { get; set; }
    }
}
