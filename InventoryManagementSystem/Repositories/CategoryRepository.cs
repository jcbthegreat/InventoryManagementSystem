using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        private readonly SqlConnection connection;
        public CategoryRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }



        public IEnumerable<CategoryModel> GetByValue(string categoryName, string description)
        {
            var categories = new List<CategoryModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT CategoryName, Description ";
                cmd.CommandText += " FROM [IV].[Categories] WHERE CategoryName = @CategoryName AND Description = @Description";
                cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = categoryName;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new CategoryModel();
                        category.CategoryName = reader["CategoryName"].ToString();
                        category.Description = reader["Description"].ToString();
                        categories.Add(category);
                    }
                }
            }

            connection.Close();
            return categories;
        }
    }
}
