using InventoryManagementSystem.Presenter;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem.Forms
{
    public partial class EditProfile : Form, IStaffView
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private string imagePath;
        private int id;
        private string staffno;
        private string lastname, firstname, middlename;
        private string position, email, contactno;
        private string roletype;
        private readonly EditProfilePresenter _presenter;
        public string StaffNo
        {
            get { return staffno; }
            set { staffno = value; }
        }

        public string RoleType
        {
            get { return roletype; }
            set { roletype = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string MiddleName
        {
            get { return middlename; }
            set { middlename = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ContactNo
        {
            get { return contactno; }
            set { contactno = value; }
        }

        public string Username
        {
            get { return txtuser.Text; }
            set { txtuser.Text = value; }
        }
        public string Password
        {
            get { return txtnewpass.Text; }
            set
            {
                txtnewpass.Text = value;

            }
        }
        public byte[] ImgPath { get; set; }
        public EditProfile()
        {
            InitializeComponent();

            Categorie();

        }


        public void Categorie()
        {
            btn_save.Click += delegate { Staff?.Invoke(this, EventArgs.Empty); };

        }
        public event EventHandler Staff;
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetBindingStaffSource(BindingSource login)
        {
            throw new NotImplementedException();
        }
        public void RefreshDataGridView()
        {

        }
        private void browseImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    pictureBox1.Image = new Bitmap(imagePath);

                    // Convert image to byte array and assign to ImgPath
                    ImgPath = ImageToByteArray(pictureBox1.Image);
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat); // Convert image to byte array
                return ms.ToArray();
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

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
