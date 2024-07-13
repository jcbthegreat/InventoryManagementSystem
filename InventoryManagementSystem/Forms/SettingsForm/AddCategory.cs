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
    public partial class AddCategory : Form, ICategoryView
    {
        public Panel PanelBg { get; set; }
        public static AddCategory Instance { get; private set; }

        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public string CategoryName
        {
            get { return CategName.Text; }
            set { CategName.Text = value; }
        }

        public string Description
        {
            get { return DescTxt.Text; }
            set { DescTxt.Text = value; }
        }

        public AddCategory()
        {
            InitializeComponent();
            string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
            connection = new SqlConnection(connectionString);
            Categorie();
            PanelBg = panelBg;
            PanelBg.BackColor = Color.DimGray;
            Instance = this;
            showdata();

        }

        public void Categorie()
        {
            addBtnCategory.Click += delegate { Categ?.Invoke(this, EventArgs.Empty); };
            showdata();
        }

        public event EventHandler Categ;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
        }

        public void SetBindingCategorySource(BindingSource login)
        {
            throw new NotImplementedException();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        public void ChangePanelColor1(Color color)
        {
            PanelBg.BackColor = color;
        }

        public void showdata()
        {
            try
            {
                // Open the connection
                connection.Open();
                adapter = new SqlDataAdapter("SELECT CategoryName as [Category Name],Description" +
                     " FROM IV.Categories  " +
                    " order by ID asc", connection);
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
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
