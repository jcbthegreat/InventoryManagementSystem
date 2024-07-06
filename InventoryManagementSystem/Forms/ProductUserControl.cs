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

            // Initialize connection
            connection = new SqlConnection(connectionString);

            // Set DataGridView properties
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellClick += DataGridView1_CellClick;

            // Load data into DataGridView
            showdata();

            // Handle event to refresh DataGridView
            ShowItem += (sender, args) => RefreshDataGridView();
        }

        private void addBtnFrm_Click(object sender, EventArgs e)
        {
            //AddProductForm addProductForm = new AddProductForm();
            //addProductForm.ShowDialog();
        }

        public event EventHandler ShowItem;
        public event EventHandler ShowProduct;

        public void showdata()
        {
            try
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

                connection.Open();

                adapter = new SqlDataAdapter("SELECT p.ID as ID, wh.[Name] as [Warehouse Name], p.product_code as [Product Code], p.product_name as [Product Name], b.BrandName as [Brand Name], c.CategoryName as [Category Name], " +
                    " s.subcategoryname as [Sub Category Name], t.typename as [Type Name], v.variantname as [Variant Name], m.measurementname as [Measurement Name], " +
                    " w.current_stock as [Current Stock], w.min_stock as [Minimun Stock], w.max_stock as [Maximum Stock], w.original_price as [Original Price], w.retail_price as [Retail Price] " +
                    " FROM [IV].[Product] p LEFT JOIN [IV].[brand] b ON p.brand_id = b.id " +
                    " LEFT JOIN [IV].[Categories] c on p.category_id = c.id LEFT JOIN [IV].[SubCategories] s on p.subcategory_id = s.ID " +
                    " LEFT JOIN [IV].[Types] t on p.[type_id] = t.id LEFT JOIN [IV].[Variant] v on p.variant_id = v.id " +
                    " LEFT JOIN [IV].[Measurement] m on p.unit_id = m.id " +
                    " LEFT JOIN [IV].[WarehouseItems] w on p.id = w.product_id " +
                    " LEFT JOIN [IV].[Warehouse] wh on w.warehouse_id = wh.id " +
                    " ORDER BY p.ID ASC", connection);

                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Customize DataGridView appearance and behavior
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    column.DefaultCellStyle.Padding = new Padding(0);

                    // Hide ID column
                    if (column.HeaderText == "ID")
                    {
                        column.Visible = false;
                    }

                    // Set columns to be editable based on editableColumns list
                    if (editableColumns.Contains(column.HeaderText))
                    {
                        column.ReadOnly = false;
                    }
                    else
                    {
                        column.ReadOnly = true;
                    }
                }

                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
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

        public void RefreshDataGridView()
        {
            showdata();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void additem_Click(object sender, EventArgs e)
        {
            //AddWarehouseItem additemForm = new AddWarehouseItem();
            //additemForm.ShowDialog();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText.Trim();

                if (editableColumns.Contains(columnName))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                }
            }
        }

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

                        connection.Open();
                        transaction = connection.BeginTransaction();

                        string deleteWarehouseItemsQuery = "DELETE FROM [IV].[WarehouseItems] WHERE product_id = @ProductId";
                        SqlCommand warehouseItemsCommand = new SqlCommand(deleteWarehouseItemsQuery, connection, transaction);
                        warehouseItemsCommand.Parameters.AddWithValue("@ProductId", productId);
                        warehouseItemsCommand.ExecuteNonQuery();

                        string deleteProductQuery = "DELETE FROM [IV].[Product] WHERE id = @ProductId";
                        SqlCommand productCommand = new SqlCommand(deleteProductQuery, connection, transaction);
                        productCommand.Parameters.AddWithValue("@ProductId", productId);
                        productCommand.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Product deleted successfully.");

                        showdata();
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText.Trim();

                if (editableColumns.Contains(columnName))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText.Trim();
            if (!editableColumns.Contains(columnName))
            {
                e.Cancel = true; // Cancel edit based on condition
            }
        }
    }
}