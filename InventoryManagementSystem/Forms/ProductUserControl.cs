using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
        }
        private DataTable dataTable;

        private void addBtnFrm_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            // Sample data
            dataTable = new DataTable();
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("Brand Name", typeof(string));
            dataTable.Columns.Add("Product Code", typeof(string));
            dataTable.Columns.Add("Product Name", typeof(string));
            dataTable.Columns.Add("Original Price", typeof(string));
            dataTable.Columns.Add("Retail Price", typeof(string));
            dataTable.Columns.Add("Stock", typeof(string));
            dataTable.Columns.Add("Minimum", typeof(string));
            dataTable.Columns.Add("Maximum", typeof(string));
            dataTable.Columns.Add("Availability", typeof(string));

            // Add some sample rows
            dataTable.Rows.Add("Category1", "BrandName1", "Code1", "Product Name Here", "1000.00", "1500.00", "500", "70", "1500", "Yes");
           dataTable.Rows.Add("Category2", "BrandName2", "Code2", "Product Name Here1", "699.00", "800.00", "500", "70", "1500", "Yes");
           dataTable.Rows.Add("Category3", "BrandName3", "Code3", "Product Name Here2", "347.00", "500.00", "500", "70", "1500", "Yes");
           dataTable.Rows.Add("Category4", "BrandName4", "Code4", "Product Name Here3", "897.00", "950.00", "345", "70", "1500", "Yes");
           dataTable.Rows.Add("Category3", "BrandName5", "Code5", "Product Name Here4", "456.00", "650.00", "645", "70", "1500", "Yes");
           dataTable.Rows.Add("Category4", "BrandName5", "Code6", "Product Name Here5", "555", "650.00", "234", "70", "1500", "Yes");
           dataTable.Rows.Add("Category5", "BrandName5", "Code7", "Product Name Here6", "660.00", "750.00", "435", "70", "1500", "Yes");
           dataTable.Rows.Add("Category5", "BrandName5", "Code8", "Product Name Here7", "700.00", "850.00", "56", "70", "1500", "No");
           dataTable.Rows.Add("Category1", "BrandName5", "Code9", "Product Name Here8", "900.00", "1050.00", "56", "70", "1500", "No");
           dataTable.Rows.Add("Category1", "BrandName5", "Code10", "Product Name Here9", "500.00", "650.00", "867", "70", "1500", "Yes");
           dataTable.Rows.Add("Category2", "BrandName5", "Code11", "Product Name Here10", "900.00", "1150.00", "456", "70", "1500", "Yes");
           dataTable.Rows.Add("Category2", "BrandName5", "Code12", "Product Name Here11", "320.00", "450.00", "654", "70", "1500", "Yes");
           dataTable.Rows.Add("Category3", "BrandName5", "Code13", "Product Name Here12", "200.00", "450.00", "876", "70", "1500", "Yes");
           dataTable.Rows.Add("Category3", "BrandName5", "Code14", "Product Name Here13", "100.00", "250.00", "456", "70", "1500", "Yes");
           dataTable.Rows.Add("Category4", "BrandName5", "Code15", "Product Name Here14", "120.00", "350.00", "567", "70", "1500", "Yes");
           dataTable.Rows.Add("Category4", "BrandName5", "Code16", "Product Name Here15", "600.00", "850.00", "446", "70", "1500", "Yes");
           dataTable.Rows.Add("Category4", "BrandName5", "Code17", "Product Name Here16", "600.00", "850.00", "45", "70", "1500", "No");
           dataTable.Rows.Add("Category5", "BrandName5", "Code18", "Product Name Here17", "400.00", "650.00", "66", "70", "1500", "Yes");
           dataTable.Rows.Add("Category5", "BrandName5", "Code19", "Product Name Here18", "400.00", "650.00", "6", "70", "1500", "No");
            // Bind data to DataGridView
            dataGridView1.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.ToLower();

            if (!string.IsNullOrEmpty(searchValue))
            {
 
                var filteredRows = dataTable.AsEnumerable()
                    .Where(row =>
                        row.ItemArray.Any(field =>
                            field.ToString().ToLower().Contains(searchValue)))
                    .ToList();

                if (filteredRows.Any())
                {
                    // If there are filtered rows, bind them to the DataGridView
                    dataGridView1.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    // If no rows match the filter criteria, clear the DataGridView
                    dataGridView1.DataSource = null;
                }
            }
            else
            {
                // If search box is empty, show all rows
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
