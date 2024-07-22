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
    public partial class ChooseRole : Form
    {
        public Panel PanelBg { get; set; }
        public static ChooseRole Instance { get; private set; }
        public ChooseRole()
        {
            InitializeComponent();
            PanelBg = panelBg;
            //panelBg.BackColor = Color.DimGray;
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoleAccess role1 = new RoleAccess();
            role1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoleAssignment role2 = new RoleAssignment();
            role2.ShowDialog();
        }

        private void ChooseRole_Load(object sender, EventArgs e)
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
