using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class TypeModel
    {
        private int id;
        private string typename;
        private string description;
        private string subcategoryid;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string TypeName
        {
            get { return typename; }
            set { typename = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string SubCategoryID
        {
            get { return subcategoryid; }
            set { subcategoryid = value; }
        }
    }
}
