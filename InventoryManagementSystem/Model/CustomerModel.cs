using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagementSystem.Model
{
    public class CustomerModel
    {
        private int id;
        private string name;
        private string email;
        private string contact;
        private string address;
        private string discount;
        private string is_suplier;

   

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public string Is_Supplier
        {
            get { return is_suplier; }
            set { is_suplier = value; }
        }
    }
}
