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
    public class WarehouseRepository : BaseRepository, IWarehouseRepository
    {
        private readonly SqlConnection connection;
        public WarehouseRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }



        public IEnumerable<WarehouseModel> GetByValue(string name, string address)
        {
            var warehouses = new List<WarehouseModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * ";
                cmd.CommandText += " FROM [IV].[Warehouse] wh " +
                    " WHERE wh.Name = @Name AND wh.Address = @Address";
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var warehouse = new WarehouseModel();
                        warehouse.Name = reader["Name"].ToString();
                        warehouse.Address = reader["Address"].ToString();

                        warehouses.Add(warehouse);
                    }
                }
            }

            connection.Close();
            return warehouses;
        }
    }
}
