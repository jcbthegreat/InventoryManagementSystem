using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Repositories
{
    public class MainRepository: BaseRepository, IMainRepository
    {
        private readonly SqlConnection connection;
        public MainRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }

        public IEnumerable<MainModel> GetByValue(string StaffNo)
        {
            var _mainModel = new List<MainModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT StaffNo, RoleType, Position, Lastname,Firstname";
                cmd.CommandText += " FROM IV.StaffAssignment WHERE StaffNo = @StaffNo";
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = StaffNo;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var MainModel = new MainModel();
                        MainModel.StaffNo = reader[0].ToString();
                        MainModel.RoleType = reader[1].ToString();
                        MainModel.Position = reader[2].ToString();
                        MainModel.Lastname = reader[3].ToString();
                        MainModel.Firstname = reader[4].ToString();
                        _mainModel.Add(MainModel);
                    }
                }
            }

            connection.Close();
            return _mainModel;
        }
    }
}
