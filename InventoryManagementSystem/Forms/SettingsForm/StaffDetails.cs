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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class StaffDetails : Form
    {
        public Panel PanelBg { get; set; }
        public static StaffDetails Instance { get; private set; }

        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public StaffDetails()
        {
            InitializeComponent();
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;

            // Initialize the SqlConnection
            string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
            connection = new SqlConnection(connectionString);

            showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff details = new AddStaff();
            details.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ChangePanelColor9(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        public void showdata()
        {
            try
            {
                // Open the connection
                connection.Open();
                adapter = new SqlDataAdapter("SELECT StaffNo as [Staff No],RoleType as [Role],Position,FirstName as [First Name],MiddleName as [Middle Name] "+
                     ", LastName as [Last Name], Email, ContactNo as [Contact No], UserName as Username FROM IV.StaffAssignment  " +
                    " order by StaffNo asc", connection);
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
    }
}
