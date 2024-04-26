using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class AddStaff : Form
    {
        private string imagePath;
        public Panel PanelBg { get; set; }
        public static AddStaff Instance { get; private set; }

        public AddStaff()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(browseImageBtn, "Choose Image");

            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(deleteImageBtn, "Delete Image");


            ToolTip toolTip3 = new ToolTip();
            toolTip3.SetToolTip(btnGenerate, "Generate Password");

            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
        }

        private void browseImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    pictureBox1.Image = new System.Drawing.Bitmap(imagePath);
                }
            }
        }

        private void deleteImageBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                imagePath = null;
                MessageBox.Show("Image removed successfully.");
            }
            else
            {
                MessageBox.Show("No image to remove.");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            int length = 12; // Change the length of the password here
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_=+";

            using (var rng = new RNGCryptoServiceProvider())
            {
                char[] chars = validChars.ToCharArray();
                byte[] data = new byte[length];
                rng.GetBytes(data);

                string password = "";
                foreach (byte b in data)
                {
                    password += chars[b % (chars.Length)];
                }

                txtPassword.Text = password;
            }
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ChangePanelColor9(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
