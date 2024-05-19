using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class TypePresenter
    {
        private ITypeView _itypeView;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public TypePresenter(ITypeView typeView, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _itypeView = typeView;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            _itypeView.Types += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string typeName = _itypeView.TypeName;
            string description = _itypeView.Description;
            string subcategoryid = _itypeView.SubCategoryID;

            if (string.IsNullOrEmpty(typeName))
            {
                MessageBox.Show("Type Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            InsertCategory(typeName, description, subcategoryid);

            _itypeView.RefreshDataGridView();
        }

        private void InsertCategory(string typeName, string description, string subcategoryid)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [IV].[Types] (TypeName, Description, SubCategoryID, CreatedBy,CreatedDate) VALUES (@TypeName, @Description,@SubCategoryID, @CreatedBy, @CreatedDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TypeName", typeName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@SubCategoryID", subcategoryid);
                        command.Parameters.AddWithValue("@CreatedBy", $"{_createdByFirstName} {_createdByLastName}");
                        command.Parameters.AddWithValue("@CreatedDate", createdDate);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Type added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

