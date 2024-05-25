using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class StaffModel
    {
        private int id;
        private string staffno;
        private string roletype;
        private string position;
        private string firstname;
        private string middlename;
        private string lastname;
        private string email;
        private string contactno;
        private string username;
        private string password;
        private string imagepath;
        private string createdby;
   

        public int ID
        {
            get { return id; }
            set { id = value; }
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
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string MiddleName
        {
            get { return middlename; }
            set { middlename = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ContanctNo
        {
            get { return contactno; }
            set { contactno = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string ImgPath
        {
            get { return imagepath; }
            set { imagepath = value; }
        }
        public string CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
    }
}

