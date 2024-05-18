using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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

        public MainForm(string firstname, string lastname, string postion)
        {
            InitializeComponent();
            settingsBtn.Click += delegate { ShowSettings?.Invoke(this, EventArgs.Empty); };
            PanelBg = panelBg;
            PanelBg.BackColor = Color.DimGray;
            Instance = this;
            _fullName = $"{firstname} {lastname}";
            _position = $"{postion}";

            if (txtUsername != null)
            {
                txtUsername.Text = _fullName;
                txtPosition.Text = _position;
            }
            else
            {
                MessageBox.Show("TextBox 'txtUsername' is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private UserControl currentControl = null;
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        public event EventHandler ShowSettings;

        private void MainForm_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
            button1.PerformClick();

        }

       public void ShowSettingsUserControl(ISettingsUserControl settingsUserControl)
        {
            panel5.Controls.Clear();
            panel5.Controls.Add((Control)settingsUserControl);
        }

        private void purchaseOrderBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new PurchaseOrderControl());
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
            LoadUserControl(new UserManageControl());
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SettingsUserControl());
        }

        private void LoadUserControl(UserControl control)
        {
            // Remove the currently displayed control (if any)
            if (currentControl != null)
            {
                this.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            // Set the new control
            currentControl = control;

            // Dock the control to fill the form
            currentControl.Dock = DockStyle.Fill;

            // Add the new control to the form
            panel5.Controls.Add(currentControl);
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
            EditProfile profile = new EditProfile();
            profile.ShowDialog();
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

    
    }
}
