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

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class AddWarehouseItem : Form, IWarehouseItemView
    {
        private const string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public Panel PanelBg { get; set; }
        public System.Windows.Forms.ComboBox WarehouseComboBox { get; set; }
        public static AddWarehouseItem Instance { get; private set; }
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;
        private string _currentStock;

        // Define the property with get and set accessors


        public string Warehouse_Id
        {
            get { return comboBox1.SelectedValue?.ToString(); }
            set { comboBox1.SelectedValue = value; }
        }

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

        public AddWarehouseItem()
        {
            InitializeComponent();
            PanelBg = panelBg;
            WarehouseComboBox = comboBox1;
            //panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            LoadComboBoxData();
            Categories();
        }


        public void RefreshDataGridView()
        {

        }
        public void SetBindingItemSource(BindingSource login)
        {
            throw new NotImplementedException();
        }
        public void Categories()
        {
            saveItemBtn.Click += (sender, e) =>
            {
                // Save item logic here

                // Notify subscribers that an item has been saved
                Items?.Invoke(this, EventArgs.Empty);
                this.Close(); // Close the form after saving
            };

        }
        public event EventHandler Items;

        private void LoadComboBoxData()
        {
            try
            {
                // Load Warehouse ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandBrand = new SqlCommand("SELECT ID, [Name] FROM [IV].[Warehouse]", con);
                    SqlDataAdapter adapterBrand = new SqlDataAdapter(commandBrand);
                    DataTable dataTableBrand = new DataTable();
                    adapterBrand.Fill(dataTableBrand);
                    comboBox1.DataSource = dataTableBrand;
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "ID";
                }

                // Load Product ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandCategory = new SqlCommand("SELECT ID, Product_Code FROM [IV].[Product] WHERE NOT EXISTS (SELECT 1 FROM [IV].[WarehouseItems] WHERE Product_ID = [IV].[Product].ID) and (isdeleted is null or isdeleted = 0)", con);
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

        private void AddWarehouseItem_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        public void ChangePanelColor3(Color color)
        {
            PanelBg.BackColor = color;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
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
    }
}
