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
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;
        public ProductUserControl()
        {
           
            InitializeComponent();
            additem.Click += delegate { ShowItem?.Invoke(this, EventArgs.Empty);};
            addBtnFrm.Click += delegate { ShowProduct?.Invoke(this, EventArgs.Empty);};
            connection = new SqlConnection(connectionString);
            showdata();
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
                // Open the connection
                connection.Open();
                adapter = new SqlDataAdapter("SELECT wh.[Name] as [Warehouse Name], p.product_code as [Product Code], p.product_name as [Product Name],b.BrandName as [Brand Name], c.CategoryName as [Category Name], " +
                    " s.subcategoryname as [Sub Category Name], t.typename as [Type Name], v.variantname as [Variant Name],m.measurementname as [Measurement Name], " +
                    " w.current_stock as [Current Stock], w.min_stock as [Minimun Stock], w.max_stock as [Maximum Stock], w.original_price as [Original Price], w.retail_price as [Retail_Price] " +
                     " FROM [IV].[Product] p LEFT JOIN [IV].[brand] b ON p.brand_id = b.id " +
                     " LEFT JOIN [IV].[Categories] c on p.category_id = c.id LEFT JOIN [IV].[SubCategories] s on p.subcategory_id = s.ID " +
                     " LEFT JOIN [IV].[Types] t on p.[type_id] = t.id LEFT JOIN [IV].[Variant] v on p.variant_id = v.id " +
                     " LEFT JOIN [IV].[Measurement] m on p.unit_id = m.id " +
                     " LEFT JOIN [IV].[WarehouseItems] w on p.id = w.product_id " +
                     " LEFT JOIN [IV].[Warehouse] wh on w.warehouse_id = wh.id " +
                    " order by p.ID asc", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Resize the columns based on the content
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                dataGridView1.AutoResizeColumns();

                // Remove padding from the cells
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.DefaultCellStyle.Padding = new Padding(0);
                }

                // Resize the column headers
                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Ensure all rows are visible
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                connection.Close();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void additem_Click(object sender, EventArgs e)
        {
            //AddWarehouseItem additemForm = new AddWarehouseItem();
            //additemForm.ShowDialog();
        }
    }
}
