using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{

    public class EditProfilePresenter
    {
        private IStaffView _staffView;
        private readonly string _sqlConnectionString;

        public EditProfilePresenter(IStaffView staffView, string sqlConnectionString)
        {
            _staffView = staffView;
            _sqlConnectionString = sqlConnectionString;
            _staffView.Staff += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string username = _staffView.Username;
            string password = _staffView.Password;
            byte[] imageBytes = _staffView.ImgPath;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (imageBytes == null || imageBytes.Length == 0)
            {
                MessageBox.Show("Please upload an image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Update password only
            ChangePassword(username, password, imageBytes);
        }

        private void ChangePassword(string username, string newPassword, byte[] imageBytes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE IV.StaffAssignment SET Password = @NewPassword,ModifiedDate = GETDATE(),  ImgPath = CONVERT(varbinary(max), @ImageData) WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        SqlParameter paramImageData = new SqlParameter("@ImageData", SqlDbType.VarBinary, -1); // Use -1 for max length
                        paramImageData.Value = imageBytes;
                        command.Parameters.Add(paramImageData);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Username not found or password not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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