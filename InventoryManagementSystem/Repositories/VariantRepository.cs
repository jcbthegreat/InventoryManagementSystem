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
    public class VariantRepository : BaseRepository, IVariantRepository
    {
        private readonly SqlConnection connection;
        public VariantRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }



        public IEnumerable<VariantModel> GetByValue(string variantName, string description, string typeid)
        {
            var type = new List<VariantModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT ct.CategoryName,sb.SubCategoryName,ty.TypeName,vr.VariantName,vr.[Description] ";
                cmd.CommandText += " FROM [IV].[SubCategories] sb" +
                    " inner join[IV].[Categories] ct on sb.MainCategoryID = ct.ID" +
                    " inner join[IV].[Types] ty on sb.ID = ty.SubCategoryID " +
                    " inner join[IV].[Variant] vr on vr.TypeID = ty.ID WHERE vr.VariantName = @VariantName AND vr.Description = @Description";
                cmd.Parameters.Add("@VariantName", SqlDbType.VarChar).Value = variantName;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@TypeID", SqlDbType.VarChar).Value = typeid;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var types = new VariantModel();
                        types.VariantName = reader["VariantName"].ToString();
                        types.Description = reader["Description"].ToString();
                        types.TypeID = reader["TypeID"].ToString();
                        type.Add(types);
                    }
                }
            }

            connection.Close();
            return type;
        }
    }
}
