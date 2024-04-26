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
    public partial class AddCategory : Form
    {

        public Panel PanelBg { get; set; }
        public static AddCategory Instance { get; private set; }
        public AddCategory()
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

        private void InitializeDataGridView()
        {
            try
            {
                // Create columns


                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();


                //dataGridView1.Rows.Add("Category1", "Category description can be blank");
                //dataGridView1.Rows.Add("Category2", "Category description can be blank");
                //dataGridView1.Rows.Add("Category3", "Category description can be blank");
                //dataGridView1.Rows.Add("Category4", "Category description can be blank");
                //dataGridView1.Rows.Add("Category5", "Category description can be blank");

                // Add some data rows with images and text
                dataGridView1.Rows.Add(new object[] { "Category1", "Category description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category2", "Category description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category3", "Category description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category4", "Category description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category5", "Category description can be blank", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Category6", "Category description can be blank", Properties.Resources.pencil, Properties.Resources.bin });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        //private Image LoadImage(string imagePath)
        //{
        //    try
        //    {
        //        return Image.FromFile(InventoryManagementSystem.Properties.Resources.bin);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading image: " + ex.Message);
        //        return null;
        //    }
        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string columnData1 = CategName.Text;
            string columnData2 = DescTxt.Text;


            if (CategName.Text == "")
            {
                MessageBox.Show("Please input Category Name!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                dataGridView1.Rows.Add(columnData1, columnData2);

                CategName.Text = "";
                DescTxt.Text = "";
            }

        }

        private void AddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataStorage.DataGridViewData.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataStorage.DataGridViewData.Add(row.Cells[0].Value.ToString()); // Assuming you want data from the first column
                }
            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
            InitializeDataGridView();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ChangePanelColor1(Color color)
        {
            PanelBg.BackColor = color;
        }

    }
}
