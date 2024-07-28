using DocumentFormat.OpenXml.Spreadsheet;
using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryManagementSystem.LoginForm;

namespace InventoryManagementSystem.Forms
{
    public partial class ProductUserControl : UserControl, IShowProductControl
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private List<string> editableColumns = new List<string> { "Current Stock", "Minimun Stock", "Maximum Stock", "Original Price", "Retail Price" };
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public ProductUserControl()
        {
            InitializeComponent();

            // Attach events
            additem.Click += delegate { ShowItem?.Invoke(this, EventArgs.Empty); };
            addBtnFrm.Click += delegate { ShowProduct?.Invoke(this, EventArgs.Empty); };
            updateProd.Click += delegate { ShowUpdateProduct?.Invoke(this, EventArgs.Empty); };

            // Initialize connection
            connection = new SqlConnection(connectionString);

            // Set DataGridView properties
            //dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            //dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            //dataGridView1.CellClick += DataGridView1_CellClick;

            // Load data into DataGridView
            ShowDataAsync();

            // Handle event to refresh DataGridView
            ShowItem += (sender, args) => RefreshDataGridView();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button3, "Upload Product");
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(button1, "Refresh");
        }

        private void addBtnFrm_Click(object sender, EventArgs e)
        {
            //AddProductForm addProductForm = new AddProductForm();
            //addProductForm.ShowDialog();
        }

        public event EventHandler ShowItem;
        public event EventHandler ShowProduct;
        public event EventHandler ShowUpdateProduct;





        public async Task ShowDataAsync()
        {
            dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection("Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;"))
                {
                    await connection.OpenAsync(); // Open connection asynchronously

                    using (var command = new SqlCommand(
                        "SELECT p.ID as ID, wh.[Name] as [Warehouse Name], p.product_code as [Product Code], p.product_name as [Product Name], " +
                        "b.BrandName as [Brand Name], c.CategoryName as [Category Name], s.subcategoryname as [Sub Category Name], " +
                        "t.typename as [Type Name], v.variantname as [Variant Name], m.measurementname as [Unit], " +
                        "p.unit_count as [Qty], w.current_stock as [Current Stock], w.min_stock as [Minimun Stock], " +
                        "w.max_stock as [Maximum Stock], w.original_price as [Original Price], w.retail_price as [Retail Price] " +
                        "FROM [IV].[Product] p " +
                        "LEFT JOIN [IV].[brand] b ON p.brand_id = b.id " +
                        "LEFT JOIN [IV].[Categories] c on p.category_id = c.id " +
                        "LEFT JOIN [IV].[SubCategories] s on p.subcategory_id = s.ID " +
                        "LEFT JOIN [IV].[Types] t on p.[type_id] = t.id " +
                        "LEFT JOIN [IV].[Variant] v on p.variant_id = v.id " +
                        "LEFT JOIN [IV].[Measurement] m on p.unit_id = m.id " +
                        "LEFT JOIN [IV].[WarehouseItems] w on p.id = w.product_id " +
                        "LEFT JOIN [IV].[Warehouse] wh on w.warehouse_id = wh.id " +
                        " where (p.isdeleted IS NULL OR p.isdeleted = 0) " +
                        "ORDER BY p.ID ASC", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            dt.Load(reader); // Load data into DataTable
                        }
                    }
                }

                // Use Invoke to update UI controls on the UI thread
                dataGridView1.Invoke((MethodInvoker)delegate
                {
                    dataGridView1.DataSource = dt;

                    // Customize DataGridView appearance and behavior
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.AllowUserToOrderColumns = true;
                    dataGridView1.AllowUserToResizeColumns = true;
                    dataGridView1.AllowUserToResizeRows = true;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
                    dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
                    dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 210, 210);

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        // Hide ID column
                        if (column.HeaderText == "ID")
                        {
                            column.Visible = false;
                        }

                        // Set specific column widths
                        if (column.HeaderText == "Product Name")
                        {
                            column.Width = 150;
                        }
                        else if (column.HeaderText == "Warehouse Name")
                        {
                            column.Width = 120;
                        }
                        else if (column.HeaderText == "Current Stock")
                        {
                            column.Width = 100;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void RefreshDataGridView()
        {
            ShowDataAsync();
        }

        //private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        string columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText.Trim();

        //        if (editableColumns.Contains(columnName))
        //        {
        //            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
        //        }
        //        else
        //        {
        //            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
        //        }
        //    }
        //}

        private void deleteProdBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlTransaction transaction = null;
                    try
                    {
                        var selectedRow = dataGridView1.SelectedRows[0];
                        int productId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                        string staffNo = MainForm.Instance.StaffNo;
                        if (string.IsNullOrEmpty(staffNo))
                        {
                            MessageBox.Show("Staff number is not set. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        connection.Open();
                        transaction = connection.BeginTransaction();

                        // Update the isdeleted, modifiedby, and modifieddate columns in the WarehouseItems table
                        string updateWarehouseItemsQuery = "UPDATE [IV].[WarehouseItems] SET isdeleted = 1, modifiedby = @ModifiedBy, modifieddate = @ModifiedDate WHERE product_id = @ProductId";
                        SqlCommand warehouseItemsCommand = new SqlCommand(updateWarehouseItemsQuery, connection, transaction);
                        warehouseItemsCommand.Parameters.AddWithValue("@ProductId", productId);
                        warehouseItemsCommand.Parameters.AddWithValue("@ModifiedBy", staffNo);
                        warehouseItemsCommand.Parameters.AddWithValue("@ModifiedDate", DateTime.Now);
                        warehouseItemsCommand.ExecuteNonQuery();

                        // Update the isdeleted, modifiedby, and modifieddate columns in the Product table
                        string updateProductQuery = "UPDATE [IV].[Product] SET isdeleted = 1, modifiedby = @ModifiedBy, modifieddate = @ModifiedDate WHERE id = @ProductId";
                        SqlCommand productCommand = new SqlCommand(updateProductQuery, connection, transaction);
                        productCommand.Parameters.AddWithValue("@ProductId", productId);
                        productCommand.Parameters.AddWithValue("@ModifiedBy", staffNo);
                        productCommand.Parameters.AddWithValue("@ModifiedDate", DateTime.Now);
                        productCommand.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Product deleted successfully.");

                        // Refresh the data grid view to remove the deleted product
                        ShowDataAsync();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null)
                        {
                            transaction.Rollback();
                        }
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }


        //private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        string columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText.Trim();

        //        if (editableColumns.Contains(columnName))
        //        {
        //            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
        //        }
        //        else
        //        {
        //            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
        //        }
        //    }
        //}

        //private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    string columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText.Trim();
        //    if (!editableColumns.Contains(columnName))
        //    {
        //        e.Cancel = true; // Cancel edit based on condition
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void ProductUserControl_Load(object sender, EventArgs e)
        {
            await ShowDataAsync();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox1.Text;


            DataView productView = new DataView(dt);


            string filterExpression = string.Format(
                "[Product Name] LIKE '%{0}%' OR [Product Code] LIKE '%{0}%' OR [Warehouse Name] LIKE '%{0}%'",
                filterText
            );

            productView.RowFilter = filterExpression;

            dataGridView1.DataSource = productView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadProduct uploadproduct = new UploadProduct();
            uploadproduct.ShowDialog();
        }

        private void additem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}