using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class VariantPrenster
    {
        private IVariantView _ivariantView;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public VariantPrenster(IVariantView variantView, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _ivariantView = variantView;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            _ivariantView.Variant += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string variantName = _ivariantView.VariantName;
            string description = _ivariantView.Description;
            string typeid = _ivariantView.TypeID;

            if (string.IsNullOrEmpty(variantName))
            {
                MessageBox.Show("Variant Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            InsertCategory(variantName, description, typeid);

            _ivariantView.RefreshDataGridView();
        }

        private void InsertCategory(string variantName, string description, string typeid)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [IV].[Variant] (VariantName, Description, TypeID, CreatedBy,CreatedDate) VALUES (@VariantName, @Description,@TypeID, @CreatedBy, @CreatedDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VariantName", variantName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@TypeID", typeid);
                        command.Parameters.AddWithValue("@CreatedBy", $"{_createdByFirstName} {_createdByLastName}");
                        command.Parameters.AddWithValue("@CreatedDate", createdDate);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Variant added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
