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
        public byte[] ImgPath { get; set; }
        public string isactive
        {
            get { return comboBox1.SelectedItem?.ToString(); }
            set { comboBox1.SelectedItem = value; }
        }

        public StaffDetails()
        {
            InitializeComponent();
            PanelBg = panelBg;
            connection = new SqlConnection(connectionString);
            RoleComboBox = comboBox2;
            Categorie();
            //panelBg.BackColor = Color.DimGray;
            Instance = this;
            LoadRoleFromDatabase();
            // Initialize the SqlConnection

            connection = new SqlConnection(connectionString);

            showdata();

            comboBox1.Items.Add("Active");
            comboBox1.Items.Add("Inactive");
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
                connection.Open();
                adapter = new SqlDataAdapter("SELECT StaffNo as [Staff No], RoleType as [Role], Position, FirstName as [First Name], MiddleName as [Middle Name], LastName as [Last Name], Email, ContactNo as [Contact No], " +
                    " UserName as Username, CASE WHEN isactive = 1 THEN 'Active' ELSE 'Inactive' END AS IsActive FROM IV.StaffAssignment order by StaffNo asc", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Create a ComboBox column for IsActive
                DataGridViewComboBoxColumn isActiveColumn = new DataGridViewComboBoxColumn();
                isActiveColumn.HeaderText = "IsActive";
                isActiveColumn.Name = "IsActive";
                isActiveColumn.DataPropertyName = "IsActive";
                isActiveColumn.Items.AddRange("Active", "Inactive");

                dataGridView1.Columns.Remove("IsActive"); // Remove the existing IsActive column
                dataGridView1.Columns.Add(isActiveColumn); // Add the ComboBox column

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AllowUserToOrderColumns = true;
                dataGridView1.AllowUserToResizeColumns = true;
                dataGridView1.AllowUserToResizeRows = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
                dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 210, 210);

                dataGridView1.CellFormatting += dataGridView1_CellFormatting;
                dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "IsActive")
            {
                string status = e.Value as string;
                if (status == "Active")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "Inactive")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "IsActive")
            {
                string staffNo = dataGridView1.Rows[e.RowIndex].Cells["Staff No"].Value.ToString();
                string newStatus = dataGridView1.Rows[e.RowIndex].Cells["IsActive"].Value.ToString();
                int isActive = (newStatus == "Active") ? 1 : 0;

                UpdateStaffIsActiveStatus(staffNo, isActive);
            }
        }

        private void UpdateStaffIsActiveStatus(string staffNo, int isActive)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE IV.StaffAssignment SET isactive = @IsActive WHERE StaffNo = @StaffNo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@StaffNo", staffNo);
                        command.ExecuteNonQuery();
                    }
                }

                ShowToast("SUCCESS", "Update Status Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RefreshDataGridView()
        {
            showdata();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ShowToast(string type, string message)
        {
            // Assuming you have a method to show toast messages
            // This could be implemented as a static method or a service
            Toast toast = new Toast(type, message);
            toast.Show();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
