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
            GetCustomerCount();
            GetRegisteredUsersByMonth();
            ShowRegisteredUsersByMonth();
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
        private Dictionary<string, int> GetRegisteredUsersByMonth()
        {
            Dictionary<string, int> registeredUsersByMonth = new Dictionary<string, int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DATENAME(MONTH, CreatedDate) AS MonthName, COUNT(*) AS Count " +
                                   "FROM IV.StaffAssignment " +
                                   "WHERE YEAR(CreatedDate) = YEAR(GETDATE()) " + // Kunin lamang ang data para sa kasalukuyang taon
                                   "GROUP BY DATENAME(MONTH, CreatedDate)"; // Group by month name

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string monthName = reader.GetString(reader.GetOrdinal("MonthName"));
                                int count = reader.GetInt32(reader.GetOrdinal("Count"));

                                registeredUsersByMonth.Add(monthName, count);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving registered users by month: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

               return registeredUsersByMonth;
            }
        private void ShowRegisteredUsersByMonth()
        {
            // Clear existing series and points
            chart1.Series.Clear();

            // Add series
            Series series = chart1.Series.Add("Registered Users by Month");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true; // Show values as labels

            // Get data
            Dictionary<string, int> registeredUsersByMonth = GetRegisteredUsersByMonth();

            // Calculate total count
            int totalCount = registeredUsersByMonth.Values.Sum();

            // Add data points
            foreach (var kvp in registeredUsersByMonth)
            {
                string monthName = kvp.Key;
                int userCount = kvp.Value;

                // Add data point with month name as X value and user count as Y value
                DataPoint point = series.Points.Add(userCount);
                point.AxisLabel = $"{monthName} ({((double)userCount / totalCount * 100).ToString("0.##")}%)";
                //point.Label = $"{monthName} ({((double)userCount / totalCount * 100).ToString("0.##")}%)";
                point.LabelToolTip = $"Count: {userCount}";
            }

            // Set chart properties
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Registered Users";
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
