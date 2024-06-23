using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        private readonly SqlConnection connection;
        public CustomerRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }



        public IEnumerable<CustomerModel> GetByValue(string name,string email, string address,string discount,string issupplier)
        {
            var customers = new List<CustomerModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * ";
                cmd.CommandText += " FROM [IV].[Customer] c " +
                    " WHERE c.Name = @Name AND c.Address = @Address AND c.Email = @Email AND c.Discount = @Discount AND c.Is_Supplier = @Is_Supplier";
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@Discount", SqlDbType.VarChar).Value = discount;
                cmd.Parameters.Add("@Is_Supplier", SqlDbType.VarChar).Value = issupplier;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new CustomerModel();
                        customer.Name = reader["Name"].ToString();
                        customer.Address = reader["Address"].ToString();

                        customers.Add(customer);
                    }
                }
            }

            connection.Close();
            return customers;
        }
    }
}