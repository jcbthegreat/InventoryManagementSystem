using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class UpdateProductPresenter
    {

        private IUpdateWarehouseProduct _warehouseitemView;

        private readonly string _sqlConnectionString;

        public UpdateProductPresenter(IUpdateWarehouseProduct warehouseView, string sqlConnectionString)
        {
            _warehouseitemView = warehouseView;

            _sqlConnectionString = sqlConnectionString;
            _warehouseitemView.UpdateItems += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string productId = _warehouseitemView.Product_Id;
            string currstock = _warehouseitemView.Current_Stock;
            string minstock = _warehouseitemView.Min_Stock;
            string maxstock = _warehouseitemView.Max_Stock;
            string origprice = _warehouseitemView.Original_Price;
            string retprice = _warehouseitemView.Retail_Price;


            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Please select a product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(currstock))
            {
                MessageBox.Show("Current Stock cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(minstock))
            {
                MessageBox.Show("Minimum Stock cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maxstock))
            {
                MessageBox.Show("Maximum Stock cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(origprice))
            {
                MessageBox.Show("Original Price cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(retprice))
            {
                MessageBox.Show("Retail Price cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            InsertCategory(productId,currstock, minstock, maxstock, origprice, retprice);

            _warehouseitemView.RefreshDataGridView();
        }

        private void InsertCategory(string productId, string currstock, string minstock, string maxstock, string origprice, string retprice)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE [IV].[WarehouseItems] SET Current_Stock = @Current_Stock,Min_Stock = @Min_Stock,Max_Stock = @Max_Stock, Original_Price = @Original_Price, Retail_Price= @Retail_Price" +
                        " WHERE product_id = @ProductId ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);
                        command.Parameters.AddWithValue("@Current_Stock", currstock);
                        command.Parameters.AddWithValue("@Min_Stock", minstock);
                        command.Parameters.AddWithValue("@Max_Stock", maxstock);
                        command.Parameters.AddWithValue("@Original_Price", origprice);
                        command.Parameters.AddWithValue("@Retail_Price", retprice);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Update Product Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Error adding Warehouse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
