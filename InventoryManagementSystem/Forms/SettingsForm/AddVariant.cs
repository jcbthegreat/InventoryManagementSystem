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
    public partial class AddVariant : Form, IVariantView
    {
        private const string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public ComboBox CategoryComboBox { get; set; }
        public Panel PanelBg { get; set; }
        public static AddVariant Instance { get; private set; }
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public string VariantName
        {
            get { return VarName.Text; }
            set { VarName.Text = value; }
        }

        public string Description
        {
            get { return DescTxt.Text; }
            set { DescTxt.Text = value; }
        }

        public string TypeID
        {
            get { return comboBox3.SelectedValue?.ToString(); }
            set { comboBox3.SelectedValue = value; }
        }
        public AddVariant()
        {
            InitializeComponent();
            CategoryComboBox = comboBox1;
            PanelBg = panelBg;
            //panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            LoadCategoriesFromDatabase();
            comboBox1.SelectedIndexChanged += (sender, e) => LoadSubcategoriesFromDatabase();
            comboBox2.SelectedIndexChanged += (sender, e) => LoadTypeFromDatabase();
            Categories();
            showdata();
            SaveDataToDatabase();
        }
        public void Categories()
        {
            addBtn.Click += delegate { Variant?.Invoke(this, EventArgs.Empty); };
            showdata();
        }
        public event EventHandler Variant;

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
                        SqlCommand command = new SqlCommand("SELECT ID, SubCategoryName FROM [IV].[SubCategories]", con);
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
                        SqlCommand command = new SqlCommand("SELECT ID, TypeName FROM [IV].[Types] ", con);
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
        public void SetBindingVariantSource(BindingSource login)
        {
            throw new NotImplementedException();
        }

        public void showdata()
        {
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter("SELECT ty.TypeName as [Type Name],vr.VariantName as [Variant Name],vr.Description " +
                     " FROM " +
                     " [IV].[Variant] vr " +
                     " LEFT JOIN [IV].[Types] ty on vr.TypeId = ty.ID" +
                    " ORDER BY vr.ID ASC", connection);
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

                // Pagkatapos mag-save, linisin ang comboBox2
                comboBox2.Items.Clear();

                // Linisin ang mga text sa mga textBox
                VarName.Clear();
                DescTxt.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving data: " + ex.Message);
            }
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
            if (PanelBg != null)
            {
                Color panelColor = Properties.Settings.Default.MyColor;
                if (panelColor == Color.Empty)
                {
                    panelColor = Color.DimGray; // Fallback color
                }
                PanelBg.BackColor = panelColor;
            }
            else
            {
                MessageBox.Show("PanelBg is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChangePanelColor13(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void AddVariant_Load(object sender, EventArgs e)
        {

        }
    }
}
