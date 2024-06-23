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
    public partial class AddWarehouseItem : Form
    {
        public Panel PanelBg { get; set; }
        public static AddWarehouseItem Instance { get; private set; }
        public AddWarehouseItem()
        {
            InitializeComponent();
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
        }

        private void AddWarehouseItem_Load(object sender, EventArgs e)
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
    }
}
