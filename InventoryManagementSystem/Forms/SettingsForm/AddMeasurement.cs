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
    public partial class AddMeasurement : Form, IMeasurementView
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public Panel PanelBg { get; set; }
        public static AddMeasurement Instance { get; private set; }
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public string MeasurementName
        {
            get { return MeasureName.Text; }
            set { MeasureName.Text = value; }
        }

        public string Code
        {
            get { return CodeTxt.Text; }
            set { CodeTxt.Text = value; }
        }

        public AddMeasurement()
        {
            InitializeComponent();
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            Categorie();
            showdata();
        }

        public void Categorie()
        {
            addBtn.Click += delegate { Measure?.Invoke(this, EventArgs.Empty); };
            showdata();
        }
        public event EventHandler Measure;

        public void SetBindingMeasureSource(BindingSource login)
        {
            throw new NotImplementedException();
        }

        public void showdata()
        {
            try
            {
                // Open the connection
                connection.Open();
                adapter = new SqlDataAdapter("SELECT MeasurementName as [Measurement Name],Code" +
                     " FROM [dbo].[IV_Measurement] " +
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
        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        public void ChangePanelColor11(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMeasurement_Load(object sender, EventArgs e)
        {

        }
    }
}
