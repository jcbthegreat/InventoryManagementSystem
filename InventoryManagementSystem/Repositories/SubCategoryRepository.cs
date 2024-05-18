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
    public class SubCategoryRepository : BaseRepository, ISubCategoryRepository
    {
        private readonly SqlConnection connection;
        public SubCategoryRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }



        public IEnumerable<SubCategoryModel> GetByValue(string categoryName, string description,string maincategoryid)
        {
            var categories = new List<SubCategoryModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT ct.CategoryName,sb.SubCategoryName,sb.[Description],sb.MainCategoryID ";
                cmd.CommandText += " FROM [IV].[Categories] ct" +
                    " Inner Join[IV].[SubCategories] sb on sb.MainCategoryID = ct.ID WHERE sb.SubCategoryName = @SubCategoryName AND sb.Description = @Description";
                cmd.Parameters.Add("@SubCategoryName", SqlDbType.VarChar).Value = categoryName;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@MainCategoryID", SqlDbType.VarChar).Value = maincategoryid;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var subcategory = new SubCategoryModel();
                        subcategory.SubCategoryName = reader["SubCategoryName"].ToString();
                        subcategory.Description = reader["Description"].ToString();
                        subcategory.MainCategoryID = reader["MainCategoryID"].ToString();
                        categories.Add(subcategory);
                    }
                }
            }

            connection.Close();
            return categories;
        }
    }
}

