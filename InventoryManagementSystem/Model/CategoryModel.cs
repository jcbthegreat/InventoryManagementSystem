using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class CategoryModel
    {
        private int id;
        private string categoryname;
        private string description;
        private string createdby;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string CategoryName
        {
            get { return categoryname; }
            set { categoryname = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }

    }

}
