using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class AddBrandName : Form
    {
        public Panel PanelBg { get; set; }
        public static AddBrandName Instance { get; private set; }

        public AddBrandName()
        {
            InitializeComponent();
            PanelBg = panelBg;
            PanelBg.BackColor = Color.DimGray;
            Instance = this;
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeDataGridView()
        {
            try
            {

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

                dataGridView1.Rows.Add(new object[] { "Category1", "BrandName1", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category1", "BrandName2", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category1", "BrandName3", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category2", "BrandName4", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category2", "BrandName5", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category3", "BrandName1", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category1", "BrandName1", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category4", "BrandName5", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category5", "BrandName3", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category5", "BrandName3", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category4", "BrandName5", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category4", "BrandName5", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category2", "BrandName2", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category3", "BrandName2", "Description can be blank", Properties.Resources.pencil, Properties.Resources.bin });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddBrandName_Load(object sender, EventArgs e)
        {

            PanelBg.BackColor = Properties.Settings.Default.MyColor;
            InitializeDataGridView();
            //PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            comboBox1.Items.Clear(); // Clear existing items

            AddCategory categoryForm = new AddCategory();



            int columnIndex = 0;


            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in categoryForm.dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[columnIndex].Value != null)
                {
                    string cellValue = row.Cells[columnIndex].Value.ToString();
                    if (!uniqueValues.Contains(cellValue))
                    {
                        comboBox1.Items.Add(cellValue);
                        uniqueValues.Add(cellValue);
                    }
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string columnData1 = comboBox1.Text;
            string columnData2 = textBox2.Text;
            string columnData3 = textBox1.Text;

            dataGridView1.Rows.Add(columnData1, columnData2, columnData3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ChangePanelColor2(Color color)
        {
            PanelBg.BackColor = color;
        }
    }
}
