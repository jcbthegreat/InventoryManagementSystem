using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InventoryManagementSystem.Forms
{
    public partial class DashBoardUserControl : UserControl
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private readonly SqlConnection sqlConnection;

        public DashBoardUserControl()
        {
            InitializeComponent(); // Ensure controls are initialized

            SetupChart();
            sqlConnection = new SqlConnection(connectionString);
            LoadData();
            PopulateLowStockDataGridView();
        }

        private void SetupChart()
        {
            if (chart1 != null)
            {
                chart1.Series.Clear();
                Series series = chart1.Series.Add("Top Products");
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;
                chart1.Click += new EventHandler(this.chart1_Click);
            }
        }

        private void LoadData()
        {
            timer1.Start();
            GetCategoriesCount();
            GetProductCount();
            ShowCategoriesCount();
            ShowProductCount();
            ShowStaffCount();
            ShowCustomerCount();
            ShowSupplierCount();
            ShowWarehouseCount();
            ShowLowStockCount();
            ShowTopProducts();
            GetStaffCount();
            GetLowStockCount();
            GetCustomerCount();
            GetSupplierCount();
            GetWarehouseCount();
        }

        private void PopulateLowStockDataGridView()
        {
            DataTable lowStockProductsTable = GetLowStockProductsForGrid();

            if (dataGridView1 != null)
            {
                dataGridView1.DataSource = lowStockProductsTable;

                // Optionally, adjust column headers
                dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
                dataGridView1.Columns["StockCount"].HeaderText = "Remaining Stock";
            }
        }

        private DataTable GetLowStockProductsForGrid()
        {
            DataTable lowStockProductsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT p.product_name AS ProductName, wi.Current_Stock AS StockCount " +
                                   "FROM IV.WarehouseItems wi " +
                                   "INNER JOIN IV.Product p ON wi.product_id = p.id " +
                                   "WHERE wi.Current_Stock <= 5"; // Filter for low stock items

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lowStockProductsTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving low stock products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lowStockProductsTable;
        }

        private Dictionary<string, Tuple<string, int>> GetTopProducts()
        {
            Dictionary<string, Tuple<string, int>> topProducts = new Dictionary<string, Tuple<string, int>>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get top 5 products based on quantity
                    string query = "SELECT TOP 5 p.product_name AS ProductName, p.product_code AS ProductCode, wi.Current_Stock AS StockCount " +
                                   "FROM IV.WarehouseItems wi " +
                                   "INNER JOIN IV.Product p ON wi.product_id = p.id " +
                                   "ORDER BY wi.Current_Stock DESC"; // Adjust the order clause as per your criteria

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
                                topProducts.Add($"{productName} ({productCode})", Tuple.Create(productCode, stockCount));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving top products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return topProducts;
        }

        private void ShowTopProducts()
        {
            if (chart1 != null)
            {
                // Clear existing series and points
                chart1.Series.Clear();

                // Add series
                Series series = chart1.Series.Add("Top Products");
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true; // Show values as labels
                series.BorderWidth = 5; // Set border width
                series.BorderColor = Color.Black; // Set border color

                // Get data
                Dictionary<string, Tuple<string, int>> topProducts = GetTopProducts();

                // Add data points
                foreach (var kvp in topProducts)
                {
                    string productCode = kvp.Value.Item1; // Get product code from Tuple
                    int stockCount = kvp.Value.Item2; // Get stock count from Tuple

                    // Add data point with product code as X value and stock count as Y value
                    DataPoint point = series.Points.Add(stockCount);
                    point.AxisLabel = productCode;
                    point.LabelToolTip = $"Stock Count: {stockCount}";
                    point.BorderWidth = 5; // Set border width for each point
                    point.BorderColor = SystemColors.Control; // Set border color for each point
                }

                // Set chart properties
                chart1.ChartAreas[0].AxisY.Title = "Stock Count of Top 5 Products";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // Handle painting if needed
        }

        private int GetCategoriesCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Open connection

                string query = "SELECT COUNT(*) FROM [IV].[Categories]"; // Use 'Categories' table

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar to get count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving categories count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Ensure connection is closed
            }

            return count;
        }

        private int GetProductCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Open connection

                string query = "SELECT COUNT(*) FROM [IV].[Product] p LEFT JOIN [IV].[brand] b ON p.brand_id = b.id " +
                    " LEFT JOIN [IV].[Categories] c on p.category_id = c.id " +
                    " LEFT JOIN [IV].[SubCategories] s on p.subcategory_id = s.ID " +
                    " LEFT JOIN [IV].[Types] t on p.[type_id] = t.id LEFT JOIN [IV].[Variant] v on p.variant_id = v.id " +
                    " LEFT JOIN [IV].[Measurement] m on p.unit_id = m.id LEFT JOIN [IV].[WarehouseItems] w on p.id = w.product_id " +
                    " LEFT JOIN [IV].[Warehouse] wh on w.warehouse_id = wh.id  where (p.isdeleted is null or p.isdeleted = 0)";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar to get count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving product count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Ensure connection is closed
            }

            return count;
        }

        private int GetStaffCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Open connection

                string query = "SELECT COUNT(*) FROM [IV].[StaffAssignment]"; // Use 'Staff' table

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar to get count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving staff count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Ensure connection is closed
            }

            return count;
        }

        private int GetCustomerCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Open connection

                string query = "SELECT COUNT(*) FROM [IV].[Customer] WHERE is_supplier = 1"; // Use 'Customer' table

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar to get count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving customer count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Ensure connection is closed
            }

            return count;
        }

        private int GetSupplierCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Open connection

                string query = "SELECT COUNT(*) FROM [IV].[Customer] WHERE is_supplier = 2"; // Use 'Supplier' table

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar to get count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving supplier count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Ensure connection is closed
            }

            return count;
        }

        private int GetWarehouseCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Open connection

                string query = "SELECT COUNT(*) FROM [IV].[Warehouse]"; // Use 'Warehouse' table

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar to get count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving warehouse count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Ensure connection is closed
            }

            return count;
        }

        private int GetLowStockCount()
        {
            int count = 0;

            try
            {
                sqlConnection.Open(); // Open connection

                string query = "SELECT COUNT(*) FROM [IV].[WarehouseItems] WHERE Current_Stock <= 5"; // Use 'WarehouseItems' table with stock filter

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    count = (int)command.ExecuteScalar(); // ExecuteScalar to get count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving low stock count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); // Ensure connection is closed
            }

            return count;
        }

        private void ShowCategoriesCount()
        {
            int categoryCount = GetCategoriesCount();
            if (label1 != null)
            {
                label1.Text = $" {categoryCount}";
            }
        }

        private void ShowProductCount()
        {
            int productCount = GetProductCount();
            if (label4 != null)
            {
                label4.Text = $" {productCount}";
            }
        }

        private void ShowStaffCount()
        {
            int staffCount = GetStaffCount();
            if (label8 != null)
            {
                label8.Text = $" {staffCount}";
            }
        }
        private void ShowCustomerCount()
        {
            int customerCount = GetCustomerCount();
            if (totalCus != null)
            {
                totalCus.Text = $" {customerCount}";
            }
        }
        private void ShowSupplierCount()
        {
            int supCount = GetSupplierCount();
            if (totalSup != null)
            {
                totalSup.Text = $" {supCount}";
            }
        }
        private void ShowWarehouseCount()
        {
            int warehouseCount = GetWarehouseCount();
            if (lblwarehouse != null)
            {
                lblwarehouse.Text = $" {warehouseCount}";
            }
        }

        private void ShowLowStockCount()
        {
            int lowStockCount = GetLowStockCount();

            if (label6 != null)
            {
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
            if (chart1 != null)
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
                    point.AxisLabel = $"{productCode} ({stockCount})";
                    point.LabelToolTip = $"Stock Count: {stockCount}";
                }

                // Set chart properties
                chart1.ChartAreas[0].AxisY.Title = "Stock Count of Low Stock Items";
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Handle chart click if needed
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
            // Handle chart click if needed
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle panel painting if needed
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle list view selection if needed
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}