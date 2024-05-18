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
    public partial class AddSubCategory : Form, ISubCategoryView
    {
        private const string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public ComboBox CategoryComboBox { get; set; }
        public Panel PanelBg { get; set; }
        public static AddSubCategory Instance { get; private set; }
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        private string maincategoryid;
        public string SubCategoryName
        {
            get { return SubCategName.Text; }
            set { SubCategName.Text = value; }
        }

        public string Description
        {
            get { return DescTxt.Text; }
            set { DescTxt.Text = value; }
        }

        public string MainCategoryId
        {
            get { return comboBox1.SelectedValue?.ToString(); }
            set { comboBox1.SelectedValue = value; }
        }

        public AddSubCategory()
        {
            InitializeComponent();
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            LoadCategoriesFromDatabase();
            Categories();
            showdata();
        }

        public void Categories()
        {
            addBtn.Click += delegate { SubCateg?.Invoke(this, EventArgs.Empty); };
            //showdata();
        }

        public event EventHandler SubCateg;

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        public void ChangePanelColor10(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSubCategory_Load(object sender, EventArgs e)
        {

        }

        public void SetBindingCategorySource(BindingSource login)
        {
            throw new NotImplementedException();
        }
        public void LoadCategoriesFromDatabase()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                using (SqlCommand command = new SqlCommand("SELECT ID, CategoryName FROM [IV].[Categories]", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);


                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);


                    comboBox1.DataSource = dataTable;


                    comboBox1.DisplayMember = "CategoryName";


                    comboBox1.ValueMember = "ID";
                }
            }
        }

        public void showdata()
        {
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter("SELECT ct.CategoryName as [Category Name], sb.SubCategoryName as [Sub Category Name], sb.Description " +
                     " FROM [IV].[SubCategories] sb INNER JOIN [IV].[Categories] ct ON sb.MainCategoryID = ct.ID " +
                    " ORDER BY sb.ID ASC", connection);
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
    }
}