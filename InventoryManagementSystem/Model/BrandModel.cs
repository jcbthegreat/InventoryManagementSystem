using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class BrandModel
    {
        private int id;
        private string brandname;
        private string description;
        private string createdby;
        private string variantid;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string BrandName
        {
            get { return brandname; }
            set { brandname = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string VariantID
        {
            get { return variantid; }
            set { variantid = value; }
        }
        public string CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
    }
}
