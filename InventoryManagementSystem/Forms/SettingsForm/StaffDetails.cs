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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class StaffDetails : Form, IStaffView
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public ComboBox RoleComboBox { get; set; }
        public Panel PanelBg { get; set; }
        private string imagePath;
        public static StaffDetails Instance { get; private set; }

        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

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

        public StaffDetails()
        {
            InitializeComponent();
            PanelBg = panelBg;
            connection = new SqlConnection(connectionString);
            RoleComboBox = comboBox2;
            Categorie();
            panelBg.BackColor = Color.DimGray;
            Instance = this;
            LoadRoleFromDatabase();
            // Initialize the SqlConnection

            connection = new SqlConnection(connectionString);

            showdata();
        }
        public void Categorie()
        {
            addBtn.Click += delegate
            {
                string contactNumber = txtcontact.Text;
                string email = txtemail.Text;
                // Subukan i-convert ang input sa integer
                if (!Regex.IsMatch(contactNumber, @"^(09|\+639)\d{9}$"))
                {
                    MessageBox.Show("Invalid contact number format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcontact.Focus();
                    return;
                }

                    // Subukan ding tiyakin na ang contact number ay may eksaktong 11 digits
                    if (contactNumber.Length != 11)
                {
                    MessageBox.Show("Invalid contact number format. Please enter a 11-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcontact.Focus();
                    return;
                }

                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Invalid email address format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Focus();
                    return;
                }

                // Kung walang error sa validation, maaari mo nang iproseso ang pag-add ng staff o anumang iba pang kaukulang aksyon
                Staff?.Invoke(this, EventArgs.Empty);
            };


        }

        public event EventHandler Staff;

        public void SetBindingStaffSource(BindingSource login)
        {
            throw new NotImplementedException();
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
        public void LoadRoleFromDatabase()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT ID, RoleType,RoleDescription FROM [IV].[Roles]", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    RoleComboBox.DataSource = dataTable;
                    RoleComboBox.DisplayMember = "RoleDescription";
                    RoleComboBox.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading role: " + ex.Message);
                }
            }
        }
        public void showdata()
        {
            try
            {
                // Open the connection
                connection.Open();
                adapter = new SqlDataAdapter("SELECT StaffNo as [Staff No],RoleType as [Role],Position,FirstName as [First Name],MiddleName as [Middle Name] " +
                     ", LastName as [Last Name], Email, ContactNo as [Contact No], UserName as Username FROM IV.StaffAssignment  " +
                    " order by StaffNo asc", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Resize the columns based on the content
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                dataGridView1.AutoResizeColumns();

                // Remove padding from the cells
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.DefaultCellStyle.Padding = new Padding(0);
                }

                // Resize the column headers
                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Ensure all rows are visible
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Optionally, adjust the last column to fill the remaining space
                //dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void RefreshDataGridView()
        {
            showdata();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGeneratepass_Click(object sender, EventArgs e)
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

        private void browseBtn_Click(object sender, EventArgs e)
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

        private void deleteBtn_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
