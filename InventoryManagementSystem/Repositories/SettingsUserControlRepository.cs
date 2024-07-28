using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem.Repositories
{
    public class SettingsUserControlRepository: BaseRepository, IDisposable, ISettingsUserControlRepository
    {
        private readonly SqlConnection connection;
        public SettingsUserControlRepository(string connectionString )
        {
            this.connection = new SqlConnection(connectionString);
        }

        public IEnumerable<RoleSubModuleModel> GetSubModuleAccess(string roleType, int moduleId)
        {
            var _roleSubModuleModel = new List<RoleSubModuleModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT RoleType,ModuleId,SubModuleId,SubModuleName,IsActive";
                cmd.CommandText += " FROM IV.RoleSubModules WHERE RoleType = @roleType AND moduleId = @ModuleId AND isActive = 1";
                cmd.Parameters.Add("@roleType", SqlDbType.VarChar).Value = roleType;
                cmd.Parameters.Add("@moduleId", SqlDbType.Int).Value = moduleId;

                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var roleSubModuleModel = new RoleSubModuleModel();
                        roleSubModuleModel.Roletype = reader[0].ToString();
                        roleSubModuleModel.ModuleId = (int)reader[1];
                        roleSubModuleModel.SubModuleId = (int)reader[2];
                        roleSubModuleModel.SubModuleName = reader[3].ToString();
                        roleSubModuleModel.IsActive = (bool)reader[4];
                        _roleSubModuleModel.Add(roleSubModuleModel);
                    }
                }

            }

            connection.Close();
            return  _roleSubModuleModel ?? new List<RoleSubModuleModel>();

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
