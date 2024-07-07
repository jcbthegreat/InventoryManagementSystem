using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class AddProductPresenter
    {
        private IProductView _productView;

        private readonly string _sqlConnectionString;

        public AddProductPresenter(IProductView productView, string sqlConnectionString)
        {
            _productView = productView;

            _sqlConnectionString = sqlConnectionString;
            _productView.Products += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string product_code = _productView.Product_Code;
            string product_name = _productView.Product_Name;
            string brand_id = _productView.Brand_Id;
            string category_id = _productView.Category_Id;
            string subcategory_id = _productView.Subcategory_Id;
            string type_id = _productView.Type_Id;
            string unit_id = _productView.Unit_Id;
            string variant_id = _productView.Variant_Id;
            string unit_count = _productView.Unit_Count;


            if (string.IsNullOrEmpty(product_code))
            {
                MessageBox.Show("Product Code cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(product_name))
            {
                MessageBox.Show("Product Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(brand_id))
            {
                MessageBox.Show("Brand Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(category_id))
            {
                MessageBox.Show("Category Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(subcategory_id))
            {
                MessageBox.Show("Subcategory Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(type_id))
            {
                MessageBox.Show("Type Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(unit_id))
            {
                MessageBox.Show("Unit Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(variant_id))
            {
                MessageBox.Show("Variant Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(unit_count))
            {
                MessageBox.Show("Unit Count cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            InsertCategory(product_code, product_name, brand_id, category_id, subcategory_id, type_id, unit_id, variant_id,unit_count);

            _productView.RefreshDataGridView();
        }

        private void InsertCategory(string product_code, string product_name, string brand_id, string category_id, string subcategory_id, string type_id, string unit_id, string variant_id, string unit_count )
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [IV].[Product] (Product_Code, Product_Name,Brand_Id,Category_Id,Subcategory_Id,Type_Id,Unit_Id,Variant_Id,Unit_Count) VALUES (@Product_Code, @Product_Name, @Brand_Id, @Category_Id, @Subcategory_Id, " +
                        " @Type_Id, @Unit_Id, @Variant_Id, @Unit_Count)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Product_Code", product_code);
                        command.Parameters.AddWithValue("@Product_Name", product_name);
                        command.Parameters.AddWithValue("@Brand_Id", brand_id);
                        command.Parameters.AddWithValue("@Category_Id", category_id);
                        command.Parameters.AddWithValue("@Subcategory_Id", subcategory_id);
                        command.Parameters.AddWithValue("@Type_Id", type_id);
                        command.Parameters.AddWithValue("@Unit_Id", unit_id);
                        command.Parameters.AddWithValue("@Variant_Id", variant_id);
                        command.Parameters.AddWithValue("@Unit_Count", unit_count);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
