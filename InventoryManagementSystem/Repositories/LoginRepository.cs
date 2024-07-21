using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem.Repositories
{
    public class LoginRepository : BaseRepository, IDisposable, ILoginRepository
    {
        private readonly SqlConnection connection;
        //private string connectionString = "";
        public LoginRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }

        public IEnumerable<LoginModel> GetByValue(string UserName, string PassWord)
        {

            var _loginList = new List<LoginModel>();
            //using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT ID, StaffNo,Username, Password,FirstName,Lastname,Position,RoleType";
                cmd.CommandText += " FROM IV.StaffAssignment WHERE Username = @UserName AND Password =@PassWord";
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = PassWord;


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var LoginModel = new LoginModel();
                        LoginModel.ID = (int)reader[0];
                        LoginModel.StaffNo = reader[1].ToString();
                        LoginModel.UserName = reader[2].ToString();
                        LoginModel.PassWord = reader[3].ToString();
                        LoginModel.FirstName = reader[4].ToString();
                        LoginModel.LastName = reader[5].ToString();
                        LoginModel.Position = reader[6].ToString();
                        LoginModel.RoleType = reader[7].ToString();
                        _loginList.Add(LoginModel);
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
