using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class AddCustomers : Form, ICustomerView
    {
    

        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public Panel PanelBg { get; set; }
        public static AddCustomers Instance { get; private set; }
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public string Name
        {
            get { return txtname.Text; }
            set { txtname.Text = value; }
        }
        public string Email
        {
            get { return txtemail.Text; }
            set { txtemail.Text = value; }
        }
        public string Address
        {
            get { return txtaddress.Text; }
            set { txtaddress.Text = value; }
        }
        public string Discount
        {
            get { return txtdiscount.Text; }
            set { txtdiscount.Text = value; }
        }
        public string Is_Supplier
        {
            get { return comboBox1.SelectedValue?.ToString(); }
            set { comboBox1.SelectedValue = value; }
        }

        public AddCustomers()
        {
            InitializeComponent();
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            Categorie();
            showdata();
            LoadCategoriesFromDatabase();

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

        public void Categorie()
        {
            addBtn.Click += delegate { Customer?.Invoke(this, EventArgs.Empty); };
            showdata();
        }
        public event EventHandler Customer;

        public void SetBindingCustomerSource(BindingSource login)
        {
            throw new NotImplementedException();
        }

        public void LoadCategoriesFromDatabase()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                using (SqlCommand command = new SqlCommand("SELECT [Name],ID FROM [IV].[Supplier]", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);


                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);


                    comboBox1.DataSource = dataTable;


                    comboBox1.DisplayMember = "[Name]";


                    comboBox1.ValueMember = "ID";
                }
            }
        }


        public void showdata()
        {
            try
            {
                // Open the connection
                connection.Open();
                adapter = new SqlDataAdapter("select c.[name] as [Full name], c.Email, c.[Address],c.Discount,s.[name] as [Is Supplier?] " +
                     " from [IV].[Customer] c inner join [IV].[Supplier] s on c.is_supplier = s.id " +
                    " order by c.ID asc", connection);
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomers_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ChangePanelColor5(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
