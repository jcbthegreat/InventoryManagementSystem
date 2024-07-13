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
    public partial class ProductReport : Form
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public ProductReport()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            //Categorie();
            //PanelBg = panelBg;
            // PanelBg.BackColor = Color.DimGray;
            //Instance = this;
            showdata();
        }

        private void ProductReport_Load(object sender, EventArgs e)
        {

        }

        public async Task showdata()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection("Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;"))
                {
                    await connection.OpenAsync(); // Open connection asynchronously

                    using (var command = new SqlCommand(
                        "SELECT p.ID as ID, wh.[Name] as [Warehouse Name], p.product_code as [Product Code], p.product_name as [Product Name], " +
                        "b.BrandName as [Brand Name], c.CategoryName as [Category Name], s.subcategoryname as [Sub Category Name], " +
                        "t.typename as [Type Name], v.variantname as [Variant Name], m.measurementname as [Measurement Name], " +
                        "p.unit_count as [Measurement Count], w.current_stock as [Current Stock], w.min_stock as [Minimun Stock], " +
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
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        column.DefaultCellStyle.Padding = new Padding(0);

                        // Hide ID column
                        if (column.HeaderText == "ID")
                        {
                            column.Visible = false;
                        }

                    }

                    dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Warehouse Name", typeof(string));
            dt.Columns.Add("Product Code", typeof(string));
            dt.Columns.Add("Product Name", typeof(string));
            dt.Columns.Add("Brand Name", typeof(string));
            dt.Columns.Add("Category Name", typeof(string));
            dt.Columns.Add("Sub Category Name", typeof(string));
            dt.Columns.Add("Type Name", typeof(string));
            dt.Columns.Add("Variant Name", typeof(string));
            dt.Columns.Add("Measurement Name", typeof(string));
            dt.Columns.Add("Measurement Count", typeof(string));
            dt.Columns.Add("Current Stock", typeof(string));
            dt.Columns.Add("Minimun Stock", typeof(string));
            dt.Columns.Add("Maximum Stock", typeof(string));
            dt.Columns.Add("Original Price", typeof(string));
            dt.Columns.Add("Retail Price", typeof(string));

            foreach(DataGridViewRow dgv in dataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value
                    , dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value, dgv.Cells[10].Value, dgv.Cells[11].Value, dgv.Cells[12].Value
                    , dgv.Cells[13].Value, dgv.Cells[14].Value, dgv.Cells[15].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("product.xml");
        }
    }
}
