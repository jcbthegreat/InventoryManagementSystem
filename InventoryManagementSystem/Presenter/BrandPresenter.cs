using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class BrandPresenter
    {
        private IBrandView _ibrandView;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public BrandPresenter(IBrandView brandView, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _ibrandView = brandView;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            _ibrandView.Brands += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string brandName = _ibrandView.BrandName;
            string description = _ibrandView.Description;
            string variantid = _ibrandView.VariantID;

            if (string.IsNullOrEmpty(brandName))
            {
                MessageBox.Show("Brand Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            InsertCategory(brandName, description, variantid);

            _ibrandView.RefreshDataGridView();
        }

        private void InsertCategory(string brandName, string description, string variantid)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [IV].[Brand] (BrandName, Description, VariantID, CreatedBy,CreatedDate) VALUES (@BrandName, @Description,@VariantID, @CreatedBy, @CreatedDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BrandName", brandName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@VariantID", variantid);
                        command.Parameters.AddWithValue("@CreatedBy", $"{_createdByFirstName} {_createdByLastName}");
                        command.Parameters.AddWithValue("@CreatedDate", createdDate);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Brand added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

