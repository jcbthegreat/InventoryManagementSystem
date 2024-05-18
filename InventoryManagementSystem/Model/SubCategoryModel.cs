using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class SubCategoryModel
    {
        private int id;
        private string subcategoryname;
        private string description;
        private string maincategoryid;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string SubCategoryName
        {
            get { return subcategoryname; }
            set { subcategoryname = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string MainCategoryID
        {
            get { return maincategoryid; }
            set { maincategoryid = value; }
        }

    }
}
