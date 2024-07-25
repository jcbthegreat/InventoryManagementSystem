using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Presenter
{
    public class StaffPresenter
    {
        private IStaffView _staffView;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public StaffPresenter(IStaffView staffView, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _staffView = staffView;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            _staffView.Staff += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string staffNo = _staffView.StaffNo;
            string roletype = _staffView.RoleType;
            string position = _staffView.Position;
            string firstname = _staffView.FirstName;
            string middlename = _staffView.MiddleName;
            string lastname = _staffView.Lastname;
            string email = _staffView.Email;
            string contactno = _staffView.ContactNo;
            string username = _staffView.Username;
            string password = _staffView.Password;
            string imgpath = _staffView.ImgPath != null ? Convert.ToBase64String(_staffView.ImgPath) : null;

            // Input validation
            if (string.IsNullOrEmpty(staffNo))
            {
                MessageBox.Show("Staff No cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(roletype))
            {
                MessageBox.Show("Role Type cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Position cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("Firstname cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(middlename))
            {
                MessageBox.Show("Middlename cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Lastname cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(contactno))
            {
                MessageBox.Show("Contact No cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

            // Check if the staff already exists
            if (CheckIfStaffExists(staffNo))
            {
                MessageBox.Show("Staff No already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert data into the database
            InsertCategory(staffNo, roletype, position, firstname, middlename, lastname, email, contactno, username, password, imgpath);

            _staffView.RefreshDataGridView();
        }

        private bool CheckIfStaffExists(string staffNo)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM IV.StaffAssignment WHERE StaffNo = @StaffNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffNo", staffNo);

                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
            }

            return exists;
        }

        private void InsertCategory(string staffNo, string roletype, string position, string firstname, string middlename, string lastname, string email, string contactno, string username, string password, string imgpath)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO IV.StaffAssignment (StaffNo, RoleType, Position, FirstName, MiddleName, Lastname, Email, ContactNo, Username, Password, ImgPath, CreatedBy, CreatedDate) VALUES (@StaffNo, @RoleType, @Position, @FirstName, @MiddleName, @Lastname, @Email, @ContactNo, @Username, @Password, CONVERT(varbinary(max), @ImgPath), @CreatedBy, @CreatedDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffNo", staffNo);
                        command.Parameters.AddWithValue("@RoleType", roletype);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@FirstName", firstname);
                        command.Parameters.AddWithValue("@MiddleName", middlename);
                        command.Parameters.AddWithValue("@Lastname", lastname);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@ContactNo", contactno);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        if (imgpath != null)
                        {
                            command.Parameters.AddWithValue("@ImgPath", imgpath);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ImgPath", DBNull.Value);
                        }
                        command.Parameters.AddWithValue("@CreatedBy", $"{_createdByFirstName} {_createdByLastName}");
                        command.Parameters.AddWithValue("@CreatedDate", createdDate);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Staff added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error adding staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


