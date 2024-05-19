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
    public class TypeRepository : BaseRepository, ITypeRepository
    {
        private readonly SqlConnection connection;
        public TypeRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }



        public IEnumerable<TypeModel> GetByValue(string typeName, string description, string subcategoryid)
        {
            var type = new List<TypeModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT ct.CategoryName,sb.SubCategoryName,ty.TypeName,ty.[Description] ";
                cmd.CommandText += " FROM [IV].[SubCategories] sb" +
                    " inner join[IV].[Categories] ct on sb.MainCategoryID = ct.ID" +
                    " inner join[IV].[Types] ty on sb.ID = ty.SubCategoryID WHERE ty.TypeName = @TypeName AND ty.Description = @Description";
                cmd.Parameters.Add("@TypeName", SqlDbType.VarChar).Value = typeName;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@SubCategoryID", SqlDbType.VarChar).Value = subcategoryid;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var types = new TypeModel();
                        types.TypeName = reader["TypeName"].ToString();
                        types.Description = reader["Description"].ToString();
                        types.SubCategoryID = reader["SubCategoryID"].ToString();
                        type.Add(types);
                    }
                }
            }

            connection.Close();
            return type;
        }
    }
}
   