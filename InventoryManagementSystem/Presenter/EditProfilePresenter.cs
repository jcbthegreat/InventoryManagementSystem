using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
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


            // Update password only
            ChangePassword(username, password);
        }

        private void ChangePassword(string username, string newPassword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE IV.StaffAssignment SET Password = @NewPassword,ModifiedDate = GETDATE() WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@NewPassword", newPassword);


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