using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class SubCategoryPresenter
    {
        private ISubCategoryView _isubcategoryView;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public SubCategoryPresenter(ISubCategoryView subcategoryView, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _isubcategoryView = subcategoryView;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            _isubcategoryView.SubCateg += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string subcategoryName = _isubcategoryView.SubCategoryName;
            string description = _isubcategoryView.Description;
            string maincategoryid = _isubcategoryView.MainCategoryId;

            if (string.IsNullOrEmpty(subcategoryName))
            {
                MessageBox.Show("Sub Category Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            InsertCategory(subcategoryName, description, maincategoryid);

            _isubcategoryView.RefreshDataGridView();
        }

        private void InsertCategory(string subcategoryName, string description,string maincategoryid)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [IV].[SubCategories] (SubCategoryName, Description, MainCategoryID, CreatedBy,CreatedDate) VALUES (@SubCategoryName, @Description,@MainCategoryID, @CreatedBy, @CreatedDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SubCategoryName", subcategoryName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@MainCategoryID", maincategoryid);
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
