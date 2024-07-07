using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class ProductModel
    {
        private int id;
        private string product_Code;
        private string product_name;
        private string brand_id;
        private string category_id;
        private string subcategory_id;
        private string type_id;
        private string unit_id;
        private string variant_id;
        private string unit_count;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Product_Code
        {
            get { return product_Code; }
            set { product_Code = value; }
        }

        public string Product_Name
        {
            get { return product_name; }
            set { product_name = value; }
        }
        public string Brand_Id
        {
            get { return brand_id; }
            set { brand_id = value; }
        }
        public string Category_Id
        {
            get { return category_id; }
            set { category_id = value; }
        }
        public string Subcategory_Id
        {
            get { return subcategory_id; }
            set { subcategory_id = value; }
        }
        public string Type_Id
        {
            get { return type_id; }
            set { type_id = value; }
        }
        public string Unit_Id
        {
            get { return unit_id; }
            set { unit_id = value; }
        }
        public string Variant_Id
        {
            get { return variant_id; }
            set { variant_id = value; }
        }
        public string Unit_Count
        {
            get { return unit_count; }
            set { unit_count = value; }
        }
    }
}
