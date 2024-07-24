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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem.Forms
{
    public partial class UpdateProduct : Form, IUpdateWarehouseProduct
    {
        private const string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public Panel PanelBg { get; set; }
        public System.Windows.Forms.ComboBox WarehouseComboBox { get; set; }
        public static UpdateProduct Instance { get; private set; }
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public string Product_Id
        {
            get { return comboBox2.SelectedValue?.ToString(); }
            set { comboBox2.SelectedValue = value; }
        }
        public string Min_Stock
        {
            get { return txtminstock.Text; }
            set { txtminstock.Text = value; }
        }
        public string Max_Stock
        {
            get { return txtmaxstock.Text; }
            set { txtmaxstock.Text = value; }
        }
        public string Current_Stock
        {
            get { return txtcurstock.Text; }
            set { txtcurstock.Text = value; }
        }

        public string Original_Price
        {
            get { return txtorigprice.Text; }
            set { txtorigprice.Text = value; }
        }
        public string Retail_Price
        {
            get { return txtretprice.Text; }
            set { txtretprice.Text = value; }
        }

        public UpdateProduct()
        {
            InitializeComponent();
            PanelBg = panelBg;
            //WarehouseComboBox = comboBox1;
            //panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            LoadComboBoxData();
            LoadTextBoxData();
            Categories();
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTextBoxData();
        }
        private void LoadTextBoxData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT Min_Stock, Max_Stock, Current_Stock, Original_Price, Retail_Price FROM [IV].[WarehouseItems] WHERE Product_Id = @ProductId", con);
                    command.Parameters.AddWithValue("@ProductId", comboBox2.SelectedValue); // Assuming comboBox2 is your product selection

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Min_Stock = reader["Min_Stock"].ToString();
                        Max_Stock = reader["Max_Stock"].ToString();
                        Current_Stock = reader["Current_Stock"].ToString();
                        Original_Price = reader["Original_Price"].ToString();
                        Retail_Price = reader["Retail_Price"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }
        }
        public void Categories()
        {
            saveItemBtn.Click += delegate { UpdateItems?.Invoke(this, EventArgs.Empty); };

        }
        public event EventHandler UpdateItems;

        private void LoadComboBoxData()
        {
            try
            {
                // Load Product ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandCategory = new SqlCommand("SELECT ID, Product_Code FROM [IV].[Product] where (isdeleted is null or isdeleted = 0)", con);
                    SqlDataAdapter adapterCategory = new SqlDataAdapter(commandCategory);
                    DataTable dataTableCategory = new DataTable();
                    adapterCategory.Fill(dataTableCategory);
                    comboBox2.DataSource = dataTableCategory;
                    comboBox2.DisplayMember = "Product_Code";
                    comboBox2.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }
        }

        public void RefreshDataGridView()
        {

        }
        public void SetBindingItemsSource(BindingSource login)
        {
            throw new NotImplementedException();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        public void ChangePanelColor3(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
