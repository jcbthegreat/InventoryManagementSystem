﻿using System;
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
    public partial class CustomerDetails : Form
    {
        public Panel PanelBg { get; set; }
        public static CustomerDetails Instance { get; private set; }

        public CustomerDetails()
        {
            InitializeComponent();
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomers addCustomers = new AddCustomers();
            addCustomers.ShowDialog();
        }

        private void InitializeDataGridView()
        {
            try
            {

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

                dataGridView1.Rows.Add(new object[] { "Joyce Maton", "09xxxxxxxx", "joyce.maton@gmail.com", "address can be blank (prefer to put some inputs here)", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Guiller Carpio", "09xxxxxxxx", "guiller.dikomaintindihan_09@gmail.com", "address can be blank (prefer to put some inputs here)", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Jayson Galawgaw", "09xxxxxxxx", "jaysondancer@yahoo.com", "address can be blank (prefer to put some inputs here)", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Silverio Cabrales", "09xxxxxxxx", "sila.hes@gmail.com", "address can be blank (prefer to put some inputs here)", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Nicole Trasadas", "09xxxxxxxx", "nicole_beryo@gmail.com", "address can be blank (prefer to put some inputs here)", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Jessica Cristobal", "09xxxxxxxx", "jessica_moto@gmail.com", "address can be blank (prefer to put some inputs here)", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Ana Baguilat", "09xxxxxxxx", "ana_lagot123@gmail.com", "address can be blank (prefer to put some inputs here)", Properties.Resources.pencil, Properties.Resources.bin });
                dataGridView1.Rows.Add(new object[] { "Gerald Cantunderstand", "09xxxxxxxx", "ako_geraldbudoy@gmail.com", "address can be blank (prefer to put some inputs here)", Properties.Resources.pencil, Properties.Resources.bin });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
            InitializeDataGridView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ChangePanelColor6(Color color)
        {
            PanelBg.BackColor = color;
        }
    }
}
