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
    public partial class StaffDetails : Form
    {
        public Panel PanelBg { get; set; }
        public static StaffDetails Instance { get; private set; }

        public StaffDetails()
        {
            InitializeComponent();
            PanelBg = panelBg;
            PanelBg.BackColor = Color.DimGray;
            Instance = this;
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
    }
}
