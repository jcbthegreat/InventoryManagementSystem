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

namespace InventoryManagementSystem.Forms
{
    public partial class AddProductForm : Form, IProductView
    {
        private const string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public Panel PanelBg { get; set; }
        public ComboBox BrandComboBox { get; set; }
        public static AddProductForm Instance { get; private set; }
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public string Brand_Id
        {
            get { return comboBox1.SelectedValue?.ToString(); }
            set { comboBox1.SelectedValue = value; }
        }

        public string Product_Code
        {
            get { return txtprodcode.Text; }
            set { txtprodcode.Text = value; }
        }
        public string Product_Name
        {
            get { return txtprodname.Text; }
            set { txtprodname.Text = value; }
        }
        public string Category_Id
        {
            get { return comboBox2.SelectedValue?.ToString(); }
            set { comboBox2.SelectedValue = value; }
        }
        public string Subcategory_Id
        {
            get { return comboBox3.SelectedValue?.ToString(); }
            set { comboBox3.SelectedValue = value; }
        }

        public string Type_Id
        {
            get { return comboBox4.SelectedValue?.ToString(); }
            set { comboBox4.SelectedValue = value; }
        }
        public string Variant_Id
        {
            get { return comboBox5.SelectedValue?.ToString(); }
            set { comboBox5.SelectedValue = value; }
        }

        public string Unit_Id
        {
            get { return comboBox5.SelectedValue?.ToString(); }
            set { comboBox5.SelectedValue = value; }
        }

        public string Unit_Count
        {
            get { return unit_count.Text; }
            set { unit_count.Text = value; }
        }

        public AddProductForm()
        {

            InitializeComponent();
            BrandComboBox = comboBox1;
            PanelBg = panelBg;
            //panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            LoadComboBoxData();

            Categories();


        }
        public void RefreshDataGridView()
        {

        }
        public void SetBindingProductSource(BindingSource login)
        {
            throw new NotImplementedException();
        }
        #region FormShadow

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        #endregion
        public void Categories()
        {
            saveProductBtn.Click += delegate { Products?.Invoke(this, EventArgs.Empty); };

        }
        public event EventHandler Products;

        private void LoadComboBoxData()
        {
            try
            {
                // Load Brand ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandBrand = new SqlCommand("SELECT ID, BrandName FROM [IV].[brand]", con);
                    SqlDataAdapter adapterBrand = new SqlDataAdapter(commandBrand);
                    DataTable dataTableBrand = new DataTable();
                    adapterBrand.Fill(dataTableBrand);
                    comboBox1.DataSource = dataTableBrand;
                    comboBox1.DisplayMember = "BrandName";
                    comboBox1.ValueMember = "ID";
                }

                // Load Category ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandCategory = new SqlCommand("SELECT ID, CategoryName FROM [IV].[Categories]", con);
                    SqlDataAdapter adapterCategory = new SqlDataAdapter(commandCategory);
                    DataTable dataTableCategory = new DataTable();
                    adapterCategory.Fill(dataTableCategory);
                    comboBox2.DataSource = dataTableCategory;
                    comboBox2.DisplayMember = "CategoryName";
                    comboBox2.ValueMember = "ID";
                }

                // Load Subcategory ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandSubcategory = new SqlCommand("SELECT ID, SubCategoryName FROM [IV].[SubCategories]", con);
                    SqlDataAdapter adapterSubcategory = new SqlDataAdapter(commandSubcategory);
                    DataTable dataTableSubcategory = new DataTable();
                    adapterSubcategory.Fill(dataTableSubcategory);
                    comboBox3.DataSource = dataTableSubcategory;
                    comboBox3.DisplayMember = "SubCategoryName";
                    comboBox3.ValueMember = "ID";
                }

                // Load Type ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandType = new SqlCommand("SELECT ID, TypeName FROM [IV].[Types]", con);
                    SqlDataAdapter adapterType = new SqlDataAdapter(commandType);
                    DataTable dataType = new DataTable();
                    adapterType.Fill(dataType);
                    comboBox4.DataSource = dataType;
                    comboBox4.DisplayMember = "TypeName";
                    comboBox4.ValueMember = "ID";
                }

                // Load Variant ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandVariant = new SqlCommand("SELECT ID, VariantName FROM [IV].[Variant]", con);
                    SqlDataAdapter adapterVariant = new SqlDataAdapter(commandVariant);
                    DataTable dataVariant = new DataTable();
                    adapterVariant.Fill(dataVariant);
                    comboBox5.DataSource = dataVariant;
                    comboBox5.DisplayMember = "VariantName";
                    comboBox5.ValueMember = "ID";
                }

                // Load Unit ComboBox
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand commandUnit = new SqlCommand("SELECT ID, MeasurementCode FROM [IV].[Measurement]", con);
                    SqlDataAdapter adapterUnit = new SqlDataAdapter(commandUnit);
                    DataTable dataUnit = new DataTable();
                    adapterUnit.Fill(dataUnit);
                    comboBox6.DataSource = dataUnit;
                    comboBox6.DisplayMember = "MeasurementCode";
                    comboBox6.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
        public void ChangePanelColor3(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
