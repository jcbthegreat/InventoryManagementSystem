using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class AddStaff : Form
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private string imagePath;
        public Panel PanelBg { get; set; }
        
        public static AddStaff Instance { get; private set; }
        private readonly SqlConnection connection;
       
        public string StaffNo
        {
            get { return txtstaffno.Text; }
            set { txtstaffno.Text = value; }
        }

        public string RoleType
        {
            get { return comboBox2.SelectedValue?.ToString(); }
            set { comboBox2.SelectedValue = value; }
        }
        public string Position
        {
            get { return txtposition.Text; }
            set { txtposition.Text = value; }
        }
        public string FirstName
        {
            get { return txtfirstname.Text; }
            set { txtfirstname.Text = value; }
        }
        public string MiddleName
        {
            get { return txtmiddlename.Text; }
            set { txtmiddlename.Text = value; }
        }
        public string Lastname
        {
            get { return txtlastname.Text; }
            set { txtlastname.Text = value; }
        }
        public string Email
        {
            get { return txtemail.Text; }
            set { txtemail.Text = value; }
        }
        public string ContactNo
        {
            get { return txtcontact.Text; }
            set { txtcontact.Text = value; }
        }
        public string Username
        {
            get { return txtusername.Text; }
            set { txtusername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string ImgPath
        {
            get { return pictureBox2.Text; }
            set { pictureBox2.Text = value; }
        }
    
        public AddStaff()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            Categorie();
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
            
        }
        public void Categorie()
        {
            addBtn.Click += delegate { Staff?.Invoke(this, EventArgs.Empty); };
           
        }

        public event EventHandler Staff;

        public void SetBindingStaffSource(BindingSource login)
        {
            throw new NotImplementedException();
        }
        private void browseImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    addimage.Image = new System.Drawing.Bitmap(imagePath);
                }
            }
        }

        private void deleteImageBtn_Click(object sender, EventArgs e)
        {
            if (addimage.Image != null)
            {
                addimage.Image = null;
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
