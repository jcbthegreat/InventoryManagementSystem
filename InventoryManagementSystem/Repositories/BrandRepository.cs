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
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        private readonly SqlConnection connection;
        public BrandRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }



        public IEnumerable<BrandModel> GetByValue(string brandName, string description, string variantid)
        {
            var brands = new List<BrandModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT ct.CategoryName,sb.SubCategoryName,ty.TypeName,vr.VariantName,br.BrandName,br.[Description] ";
                cmd.CommandText += " FROM [IV].[SubCategories] sb" +
                    " inner join[IV].[Categories] ct on sb.MainCategoryID = ct.ID" +
                    " inner join[IV].[Types] ty on sb.ID = ty.SubCategoryID " +
                    " inner join[IV].[Variant] vr on vr.TypeID = ty.ID " +
                    " inner join[IV].[Brand] br on br.VariantID = vr.ID WHERE br.BrandName = @BrandName AND br.Description = @Description";
                cmd.Parameters.Add("@BrandName", SqlDbType.VarChar).Value = brandName;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@VariantID", SqlDbType.VarChar).Value = variantid;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var brand = new BrandModel();
                        brand.BrandName = reader["BrandName"].ToString();
                        brand.Description = reader["Description"].ToString();
                        brand.VariantID = reader["VariantID"].ToString();
                        brands.Add(brand);
                    }
                }
            }

            connection.Close();
            return brands;
        }
    }
}
