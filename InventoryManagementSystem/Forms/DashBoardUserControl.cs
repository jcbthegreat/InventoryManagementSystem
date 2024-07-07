using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace InventoryManagementSystem.Forms
{
    public partial class DashBoardUserControl : UserControl
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private readonly SqlConnection sqlConnection;
        public DashBoardUserControl()
        {
            InitializeComponent();
            timer1.Start();
            sqlConnection = new SqlConnection(connectionString); // Pag-initialize ng SqlConnection
            GetCategoriesCount();
            GetProductCount();
            ShowCategoriesCount();
            ShowProductCount();
            ShowCustomerCount();
            ShowLowStockCount();
            ShowLowStockCount1();
            GetCustomerCount();
            GetLowStockCount();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        //Category
        private int GetCategoriesCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Buksan ang connection

                string query = "SELECT COUNT(*) FROM [IV].[Categories]"; // Palitan ang 'Products' kung kinakailangan

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar para makuha ang count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving product count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Siguraduhing isara ang connection
            }

            return count;
        }

        //Product
        private int GetProductCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Buksan ang connection

                string query = "SELECT COUNT(*) FROM [IV].[Product] p LEFT JOIN [IV].[brand] b ON p.brand_id = b.id " +
                    " LEFT JOIN [IV].[Categories] c on p.category_id = c.id " +
                    " LEFT JOIN [IV].[SubCategories] s on p.subcategory_id = s.ID " +
                    " LEFT JOIN [IV].[Types] t on p.[type_id] = t.id LEFT JOIN [IV].[Variant] v on p.variant_id = v.id " +
                    " LEFT JOIN [IV].[Measurement] m on p.unit_id = m.id LEFT JOIN [IV].[WarehouseItems] w on p.id = w.product_id " +
                    " LEFT JOIN [IV].[Warehouse] wh on w.warehouse_id = wh.id "; 

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar para makuha ang count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving product count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Siguraduhing isara ang connection
            }

            return count;
        }

        //Customer
        private int GetCustomerCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Buksan ang connection

                string query = "SELECT COUNT(*) FROM [IV].[Customer]"; // Palitan ang 'Products' kung kinakailangan

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar para makuha ang count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving product count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Siguraduhing isara ang connection
            }

            return count;
        }
        private int GetLowStockCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Buksan ang connection

                string query = "SELECT COUNT(*) FROM [IV].[WarehouseItems] WHERE Current_Stock <= 5;"; // Palitan ang 'Products' kung kinakailangan

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar para makuha ang count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving product count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Siguraduhing isara ang connection
            }

            return count;
        }
        private void ShowCategoriesCount()
        {
            int categoryCount = GetCategoriesCount();
            label1.Text = $" {categoryCount}";
        }

        private void ShowProductCount()
        {
            int productCount = GetProductCount();
            label4.Text = $" {productCount}";
        }
        private void ShowCustomerCount()
        {
            int customerCount = GetCustomerCount();
            label8.Text = $" {customerCount}";
        }

        private void ShowLowStockCount()
        {
            int lowStockCount = GetLowStockCount();

            // Check if there are items with low stock
            if (lowStockCount > 0)
            {
                // If there are low stock items, set label6's color to red
                label6.Text = $"{lowStockCount}";
                label6.ForeColor = Color.Red; // Set text color to red
            }
            else
            {
                // If there are no low stock items, set label6's color to white
                label6.Text = "0";
                label6.ForeColor = Color.White; // Set text color to white
            }
        }


        private Dictionary<string, Tuple<string, int>> GetLowStockProducts()
        {
            Dictionary<string, Tuple<string, int>> lowStockProducts = new Dictionary<string, Tuple<string, int>>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT p.product_name AS ProductName, p.product_code AS ProductCode, wi.Current_Stock AS StockCount " +
                                   "FROM IV.WarehouseItems wi " +
                                   "INNER JOIN IV.Product p ON wi.product_id = p.id " +
                                   "WHERE wi.Current_Stock <= 5 " + // Filter for low stock items
                                   "GROUP BY p.product_name, p.product_code, wi.Current_Stock"; // Group by product name, product code, and stock count

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader.GetString(reader.GetOrdinal("ProductName"));
                                string productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
                                int stockCount = reader.GetInt32(reader.GetOrdinal("StockCount"));

                                // Add product name, product code, and stock count to dictionary
                                lowStockProducts.Add($"{productName} ({productCode})", Tuple.Create(productCode, stockCount));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving low stock products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lowStockProducts;
        }
        private void ShowLowStockCount1()
        {
            // Clear existing series and points
            chart1.Series.Clear();

            // Add series
            Series series = chart1.Series.Add("Low Stock Products");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true; // Show values as labels

            // Get data
            Dictionary<string, Tuple<string, int>> lowStockProducts = GetLowStockProducts();

            // Calculate total count
            int totalCount = lowStockProducts.Count; // Total count is number of products

            // Add data points
            foreach (var kvp in lowStockProducts)
            {
                string productNameWithCode = kvp.Key;
                string productCode = kvp.Value.Item1; // Get product code from Tuple
                int stockCount = kvp.Value.Item2; // Get stock count from Tuple

                // Add data point with product name and product code as X value and stock count as Y value
                DataPoint point = series.Points.Add(stockCount);
                point.AxisLabel = $"{productNameWithCode} ({stockCount})";
                point.LabelToolTip = $"Stock Count: {stockCount}";

                // Add custom label for identification
                point.Label = $"{productNameWithCode} ({stockCount})"; // Display product name, code, and stock count
            }

            // Set chart properties
            chart1.ChartAreas[0].AxisX.Title = "Product";
            chart1.ChartAreas[0].AxisY.Title = "Stock Count of Low Stock Items";
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
