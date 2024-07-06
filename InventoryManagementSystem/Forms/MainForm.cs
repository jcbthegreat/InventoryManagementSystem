using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem.Forms
{
    public partial class MainForm : Form, IMainView
    {
        public Panel PanelBg { get; set; }
        private string _fullName;
        private string _position;

        private string staffno, roletype, position, lastname, firstname;
        string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        public static MainForm Instance { get; private set; }
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
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public MainForm(string firstname, string lastname, string postion, string username)
        {
            InitializeComponent();
            settingsBtn.Click += delegate { ShowSettings?.Invoke(this, EventArgs.Empty); };
            pictureBox3.Click += delegate { ShowProfile?.Invoke(this, EventArgs.Empty); };
            button2.Click += delegate { ShowProduct?.Invoke(this, EventArgs.Empty); };
            PanelBg = panelBg;
            PanelBg.BackColor = Color.DimGray;
            Instance = this;
            _fullName = $"{firstname} {lastname}";
            _position = $"{postion}";
            LoadProfileImage(username);
            if (txtUsername != null)
            {
                txtUsername.Text = _fullName;
                txtPosition.Text = _position;
            }
            else
            {
                MessageBox.Show("TextBox 'txtUsername' is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Resize += MainForm_Resize;
            button1.PerformClick();
        }

        private void LoadProfileImage(string username)
        {
            byte[] imageData = GetImageByUsername(username);

            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox1.Image = Properties.Resources.user; // Set default image or handle error accordingly
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources.user; // Set default profile image if image data is null or empty
            }
        }

        private UserControl currentControl = null;
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        public event EventHandler ShowSettings;
        public event EventHandler ShowProfile;
        public event EventHandler ShowProduct;

        private void MainForm_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
            button1.PerformClick();
        }

        public void ShowSettingsUserControl(ISettingsUserControl settingsUserControl)
        {
            try
            {
                panel5.Controls.Clear(); // Clear existing controls in panel5
                if (settingsUserControl != null && settingsUserControl is Control control)
                {
                    // Set size and location manually
                    control.Size = panel5.ClientSize; // Match control size to panel5
                    control.Location = new Point(0, 0); // Position control at top-left corner

                    panel5.Controls.Add(control); // Add the new control
                }
                else
                {
                    MessageBox.Show("Failed to load product control: Control is null or does not implement Control interface.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product control: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowProductControl(IShowProductControl showProductControl)
        {
            try
            {
                panel5.Controls.Clear(); // Clear existing controls in panel5
                if (showProductControl != null && showProductControl is Control control)
                {
                    // Set size and location manually
                    control.Size = panel5.ClientSize; // Match control size to panel5
                    control.Location = new Point(0, 0); // Position control at top-left corner

                    panel5.Controls.Add(control); // Add the new control
                }
                else
                {
                    MessageBox.Show("Failed to load product control: Control is null or does not implement Control interface.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product control: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchaseOrderBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new PurchaseOrderUserControl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DashBoardUserControl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ProductUserControl());
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReportsUserControl());
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SettingsUserControl());
        }

        private void LoadUserControl(UserControl control)
        {
            try
            {
                // Remove the current control if it exists
                if (currentControl != null)
                {
                    panel5.Controls.Remove(currentControl);
                    currentControl.Dispose();
                }

                // Clear any remaining controls, just to be sure
                panel5.Controls.Clear();

                // Set the new control
                currentControl = control;

                // Dock the control to the form
                currentControl.Dock = DockStyle.Fill;

                // Add the new control to the form
                panel5.Controls.Add(currentControl);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel5.Hide(); // Itago ang panel5 bago isara ang form ng setting
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Adjust panel5 size when MainForm is resized
            AdjustPanelSize();
        }

        private void AdjustPanelSize()
        {
            // Compute the size of panel5 based on MainForm's size
            panel5.Size = new Size(this.ClientSize.Width - panel5.Location.X * 2, this.ClientSize.Height - panel5.Location.Y * 2);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Toggle maximize/restore button
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }



        private void mainFormCloseBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ChangePanelColor(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //EditProfile editProfileForm = new EditProfile(); // Instantiate ang EditProfile form
            //editProfileForm.ShowDialog();
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
            //PanelBg.BackColor = Properties.Settings.Default.MyColor;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked Yes
            if (result == DialogResult.Yes)
            {
                // Reset the FirstName and LastName properties
                MainForm.Instance.FirstName = string.Empty;
                MainForm.Instance.Lastname = string.Empty;

                // Close the main form
                MainForm.Instance.Close();

                // Show the login form
                LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
                loginForm?.Show(); // Show the login form if it is not null
            }
        }

        private byte[] GetImageByUsername(string username)
        {
            byte[] imageData = null;

            try
            {
                // Implement your database retrieval logic here
                using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                {
                    connection.Open();

                    string query = "SELECT ImgPath FROM IV.StaffAssignment WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            imageData = (byte[])result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return imageData;
        }

        private void panelBg_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}