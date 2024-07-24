using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class WarehouseItemPresenter
    {
        private IWarehouseItemView _warehouseitemView;

        private readonly string _sqlConnectionString;
        private readonly string _staffNo; // Staff number of the user adding the product
        public WarehouseItemPresenter(IWarehouseItemView warehouseView, string sqlConnectionString)
        {
            _warehouseitemView = warehouseView;
            _staffNo = MainForm.Instance.StaffNo;
            _sqlConnectionString = sqlConnectionString;
            _warehouseitemView.Items += CategoryEvent;

            if (_warehouseitemView is Form form)
            {
                form.Load += OnFormLoad;
            }
        }
        private void OnFormLoad(object sender, EventArgs e)
        {
            if (_warehouseitemView is AddWarehouseItem addItemView)
            {
                addItemView.Items += (s, ea) =>
                {
                    // Handle the event and refresh the DataGridView
                    // Assuming you have a way to refresh the DataGridView in the context
                    _warehouseitemView.RefreshDataGridView();
                };
            }
        }
        private void CategoryEvent(object? sender, EventArgs e)
        {
            string warehouseid = _warehouseitemView.Warehouse_Id;
            string productid = _warehouseitemView.Product_Id;
            string currstock = _warehouseitemView.Current_Stock;
            string minstock = _warehouseitemView.Min_Stock;
            string maxstock = _warehouseitemView.Max_Stock;
            string origprice = _warehouseitemView.Original_Price;
            string retprice = _warehouseitemView.Retail_Price;


            if (string.IsNullOrEmpty(warehouseid))
            {
                MessageBox.Show("Warehouse Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(productid))
            {
                MessageBox.Show("Product Code cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            InsertCategory(warehouseid, productid, currstock, minstock, maxstock, origprice, retprice, _staffNo, DateTime.Now);

            _warehouseitemView.RefreshDataGridView();
        }

        private void InsertCategory(string warehouseid, string productid, string currstock, string minstock, string maxstock, string origprice, string retprice, string addedBy, DateTime addedDate)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [IV].[WarehouseItems] (Warehouse_Id, Product_Id,Current_Stock,Min_Stock,Max_Stock,Original_Price,Retail_Price,AddedBy, AddedDate) VALUES (@Warehouse_Id, @Product_Id, @Current_Stock, @Min_Stock, @Max_Stock, " +
                        " @Original_Price, @Retail_Price,@AddedBy, @AddedDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Warehouse_Id", warehouseid);
                        command.Parameters.AddWithValue("@Product_Id", productid);
                        command.Parameters.AddWithValue("@Current_Stock", currstock);
                        command.Parameters.AddWithValue("@Min_Stock", minstock);
                        command.Parameters.AddWithValue("@Max_Stock", maxstock);
                        command.Parameters.AddWithValue("@Original_Price", origprice);
                        command.Parameters.AddWithValue("@Retail_Price", retprice);
                        command.Parameters.AddWithValue("@AddedBy", addedBy);
                        command.Parameters.AddWithValue("@AddedDate", addedDate);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Warehouse Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
