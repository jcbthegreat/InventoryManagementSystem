using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryManagementSystem.Presenter
{
    public class CustomerPresenter
    {
        private ICustomerView _customerView;
        private readonly string _createdByFirstName;
        private readonly string _createdByLastName;
        private readonly string _sqlConnectionString;

        public CustomerPresenter(ICustomerView customerView, string createdByFirstName, string createdByLastName, string sqlConnectionString)
        {
            _customerView = customerView;
            _createdByFirstName = createdByFirstName;
            _createdByLastName = createdByLastName;
            _sqlConnectionString = sqlConnectionString;
            _customerView.Customer += CategoryEvent;
        }

        private void CategoryEvent(object? sender, EventArgs e)
        {
            string customerName = _customerView.Name;
            string email = _customerView.Email;
            string address = _customerView.Address;
            string contact = _customerView.Contact;
            string discount = _customerView.Discount;
            string issupplier = _customerView.Is_Supplier;

            // Input validation
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer/Supplier Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Contact Number cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(issupplier))
            {
                MessageBox.Show("Is Supplier cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the customer already exists
            if (CheckIfCustomerExists(customerName, email))
            {
                MessageBox.Show("Customer with the same name or email already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert data into the database
            InsertCategory(customerName, email,contact, address, discount, issupplier);

            _customerView.RefreshDataGridView();
        }

        private bool CheckIfCustomerExists(string customerName, string email)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                // Check for duplicate by either Name or Email
                string query = "SELECT COUNT(*) FROM [IV].[Customer] WHERE Name = @Name OR Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", customerName);
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
            }

            return exists;
        }

        private void InsertCategory(string customerName, string email, string contact, string address, string discount, string issupplier)
        {
            try
            {
                DateTime createdDate = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [IV].[Customer] (Name, Email, Contact, Address, Discount, Is_Supplier) VALUES (@Name, @Email,@Contact, @Address, @Discount, @Is_Supplier)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", customerName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Discount", discount);
                        command.Parameters.AddWithValue("@Is_Supplier", issupplier);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Customer/Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error adding Customer/Supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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