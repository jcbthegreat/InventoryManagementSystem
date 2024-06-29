using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class WarehouseItemModel
    {
        private int id;
        private string warehouse_id;
        private string product_id;
        private string current_stock;
        private string min_stock;
        private string max_stock;
        private string original_price;
        private string retail_price;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Warehouse_Id
        {
            get { return warehouse_id; }
            set { warehouse_id = value; }
        }

        public string Product_Id
        {
            get { return product_id; }
            set { product_id = value; }
        }
        public string Current_Stock
        {
            get { return current_stock; }
            set { current_stock = value; }
        }
        public string Min_Stock
        {
            get { return min_stock; }
            set { min_stock = value; }
        }
        public string Max_Stock
        {
            get { return max_stock; }
            set { max_stock = value; }
        }
        public string Original_Price
        {
            get { return original_price; }
            set { original_price = value; }
        }
        public string Retail_Price
        {
            get { return retail_price; }
            set { retail_price = value; }
        }
      
    }
}

