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
    public partial class AddVariant : Form
    {
        public Panel PanelBg { get; set; }
        public static AddVariant Instance { get; private set; }
        public AddVariant()
        {
            InitializeComponent();
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }


        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChangePanelColor13(Color color)
        {
            PanelBg.BackColor = color;
        }
    }
}
