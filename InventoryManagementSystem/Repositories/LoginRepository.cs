using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem.Repositories
{
    public class LoginRepository : BaseRepository, IDisposable, ILoginRepository
    {
        private readonly SqlConnection connection;

        public LoginRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }

        public IEnumerable<LoginModel> GetByValue(string userName, string password)
        {
            var _loginList = new List<LoginModel>();

            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"
                    SELECT ID, StaffNo, Username, Password, FirstName, LastName, Position, RoleType, isactive 
                    FROM IV.StaffAssignment 
                    WHERE Username = @UserName AND Password = @PassWord";
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                cmd.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = password;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var loginModel = new LoginModel
                        {
                            ID = (int)reader["ID"],
                            StaffNo = reader["StaffNo"].ToString(),
                            UserName = reader["Username"].ToString(),
                            PassWord = reader["Password"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Position = reader["Position"].ToString(),
                            RoleType = reader["RoleType"].ToString(),
                            isactive = (bool)reader["IsActive"]  // Read the IsActive property
                        };

                        _loginList.Add(loginModel);
                    }
                }
            }

            connection.Close();
            return _loginList;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
        }
    }
}