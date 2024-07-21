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

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class AddBrandName : Form, IBrandView
    {
        private const string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public ComboBox CategoryComboBox { get; set; }
        public Panel PanelBg { get; set; }
        public static AddBrandName Instance { get; private set; }

        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public string BrandName
        {
            get { return txtBrand.Text; }
            set { txtBrand.Text = value; }
        }

        public string Description
        {
            get { return txtDesc.Text; }
            set { txtDesc.Text = value; }
        }

        public string VariantID
        {
            get { return comboBox4.SelectedValue?.ToString(); }
            set { comboBox4.SelectedValue = value; }
        }

        public AddBrandName()
        {
            InitializeComponent();
            CategoryComboBox = comboBox1;
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            LoadCategoriesFromDatabase();
            comboBox1.SelectedIndexChanged += (sender, e) => LoadSubcategoriesFromDatabase();
            comboBox2.SelectedIndexChanged += (sender, e) => LoadTypeFromDatabase();
            comboBox3.SelectedIndexChanged += (sender, e) => LoadVariantFromDatabase();
            Categories();
            showdata();
            SaveDataToDatabase();
            LoadVariantFromDatabase();
        }
        public void Categories()
        {
            addBtn.Click += delegate { Brands?.Invoke(this, EventArgs.Empty); };
            showdata();
        }

        public event EventHandler Brands;

        public void LoadCategoriesFromDatabase()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT ID, CategoryName FROM [IV].[Categories]", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CategoryComboBox.DataSource = dataTable;
                    CategoryComboBox.DisplayMember = "CategoryName";
                    CategoryComboBox.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading categories: " + ex.Message);
                }
            }
        }

        public void LoadSubcategoriesFromDatabase()
        {
            try
            {
                string categoryId = CategoryComboBox.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(categoryId))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("SELECT ID, SubCategoryName FROM [IV].[SubCategories] ", con);
                        //command.Parameters.AddWithValue("@categoryId", categoryId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        comboBox2.DataSource = dataTable;
                        comboBox2.DisplayMember = "SubCategoryName";
                        comboBox2.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading subcategories: " + ex.Message);
            }
        }

        public void LoadTypeFromDatabase()
        {
            try
            {
                string subCategoryId = comboBox2.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(subCategoryId))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("SELECT ID, TypeName FROM [IV].[Types]", con);
                        //command.Parameters.AddWithValue("@subCategoryId", subCategoryId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        comboBox3.DataSource = dataTable;
                        comboBox3.DisplayMember = "TypeName";
                        comboBox3.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading types: " + ex.Message);
            }
        }

        public void LoadVariantFromDatabase()
        {
            try
            {
                string typeId = comboBox3.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(typeId))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("SELECT ID, VariantName FROM [IV].[Variant] ", con);
                        //command.Parameters.AddWithValue("@typeid", typeId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        comboBox4.DataSource = dataTable;
                        comboBox4.DisplayMember = "VariantName";
                        comboBox4.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading variant: " + ex.Message);
            }
        }
        public void SetBindingBrandSource(BindingSource login)
        {
            throw new NotImplementedException();
        }
        public void showdata()
        {
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter("SELECT v.VariantName as [Variant Name], b.BrandName as [Brand Name],b.Description" +
                     " FROM [IV].[Brand] b" +
                     " left join [IV].[Variant] v on b.variantid = v.id " +
                    " order by b.ID asc", connection);
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

                // Optionally, adjust the last column to fill the remaining space
                //dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void RefreshDataGridView()
        {
            showdata();
        }
        public void SaveDataToDatabase()
        {
            try
            {
                // Code para mag-save ng data sa database

                // Pagkatapos ng pag-save, tawagin ang LoadSubcategoriesFromDatabase para i-refresh ang comboBox2
                LoadSubcategoriesFromDatabase();
                LoadCategoriesFromDatabase();
                LoadVariantFromDatabase();
                LoadTypeFromDatabase();
                // Pagkatapos mag-save, linisin ang comboBox2
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                // Linisin ang mga text sa mga textBox
                txtBrand.Clear();
                txtDesc.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving data: " + ex.Message);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        public void ChangePanelColor2(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void AddBrandName_Load(object sender, EventArgs e)
        {

        }
    }
}
