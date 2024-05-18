using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Model;
using InventoryManagementSystem.Repositories;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class CategoryPresenter
    {
        private ICategoryView _categoryView;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public CategoryPresenter(ICategoryView categoryView, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _categoryView = categoryView;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            _categoryView.Categ += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string categoryName = _categoryView.CategoryName;
            string description = _categoryView.Description;

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Category Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            InsertCategory(categoryName, description);

            _categoryView.RefreshDataGridView();
        }

        private void InsertCategory(string categoryName, string description)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [IV].[Categories] (CategoryName, Description, CreatedBy,CreatedDate) VALUES (@CategoryName, @Description, @CreatedBy, @CreatedDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@CreatedBy", $"{_createdByFirstName} {_createdByLastName}");
                        command.Parameters.AddWithValue("@CreatedDate", createdDate);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("Error adding category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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