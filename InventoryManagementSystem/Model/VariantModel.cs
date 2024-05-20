using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class VariantModel
    {
        private int id;
        private string variantname;
        private string description;
        private string typeid;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string VariantName
        {
            get { return variantname; }
            set { variantname = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string TypeID
        {
            get { return typeid; }
            set { typeid = value; }
        }
    }
}
