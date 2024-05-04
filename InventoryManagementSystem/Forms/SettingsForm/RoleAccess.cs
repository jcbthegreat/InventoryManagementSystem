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
    public partial class RoleAccess : Form
    {
        public Panel PanelBg { get; set; }
        public static RoleAccess Instance { get; private set; }

        public RoleAccess()
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

        public void ChangePanelColor12(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
