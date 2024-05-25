using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class MeasurementPresenter
    {
        private IMeasurementView _measurementView;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public MeasurementPresenter(IMeasurementView measureView, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _measurementView = measureView;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            _measurementView.Measure += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string measureName = _measurementView.MeasurementName;
            string code = _measurementView.Code;
     
            if (string.IsNullOrEmpty(measureName))
            {
                MessageBox.Show("Measurement Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Code cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            InsertCategory(measureName, code);

            _measurementView.RefreshDataGridView();
        }

        private void InsertCategory(string measureName, string code)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO IV_Measurement (MeasurementName, Code, CreatedBy,CreatedDate) VALUES (@MeasurementName, @Code, @CreatedBy, @CreatedDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MeasurementName", measureName);
                        command.Parameters.AddWithValue("@Code", code);
             
                        command.Parameters.AddWithValue("@CreatedBy", $"{_createdByFirstName} {_createdByLastName}");
                        command.Parameters.AddWithValue("@CreatedDate", createdDate);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Measurement added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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