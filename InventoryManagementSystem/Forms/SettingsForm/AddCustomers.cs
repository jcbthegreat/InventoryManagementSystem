using InventoryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class AddCustomers : Form, ICustomerView
    {


        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        public Panel PanelBg { get; set; }
        public static AddCustomers Instance { get; private set; }
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public string ID;
        public string Name
        {
            get { return textfullname.Text; }
            set { textfullname.Text = value; }
        }
        public string Email
        {
            get { return txtemail.Text; }
            set { txtemail.Text = value; }
        }
        public string Contact
        {
            get { return txtcontact.Text; }
            set { txtcontact.Text = value; }
        }
        public string Address
        {
            get { return txtaddress.Text; }
            set { txtaddress.Text = value; }
        }
        public string Discount
        {
            get { return txtdiscount.Text; }
            set { txtdiscount.Text = value; }
        }
        public string Is_Supplier
        {
            get { return comboBox1.SelectedValue?.ToString(); }
            set { comboBox1.SelectedValue = value; }
        }

        public AddCustomers()
        {
            InitializeComponent();
            PanelBg = panelBg;
            //panelBg.BackColor = Color.DimGray;
            Instance = this;
            connection = new SqlConnection(connectionString);
            Categorie();
            showdata();
            textfullname.Text = "";
            LoadCategoriesFromDatabase();


        }


        public void Categorie()
        {
            addBtn.Click += delegate { Customer?.Invoke(this, EventArgs.Empty); };
            showdata();
        }
        public event EventHandler Customer;

        public void SetBindingCustomerSource(BindingSource login)
        {
            throw new NotImplementedException();
        }

        public void LoadCategoriesFromDatabase()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                using (SqlCommand command = new SqlCommand("SELECT ID,Name FROM [IV].[Supplier]", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);


                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);


                    comboBox1.DataSource = dataTable;


                    comboBox1.DisplayMember = "Name";


                    comboBox1.ValueMember = "ID";
                }
            }
        }


        public void showdata()
        {
            try
            {
                // Open the connection
                connection.Open();
                adapter = new SqlDataAdapter("select c.ID, c.[name] as [Full name], c.Email, c.Contact, c.[Address], c.Discount, s.[name] as [Is Supplier?] " +
                    " from [IV].[Customer] c inner join [IV].[Supplier] s on c.is_supplier = s.id " +
                    " order by c.ID asc", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Hide the ID column
                dataGridView1.Columns["ID"].Visible = false;

                // Resize the columns based on the content
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                // Resize the column headers
                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Ensure all rows are visible
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Adjust the last column to fill the remaining space
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Ensure horizontal scrolling
                dataGridView1.ScrollBars = ScrollBars.Both;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                connection.Close();
            }
        }
        public void RefreshDataGridView()
        {
            showdata();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomers_Load(object sender, EventArgs e)
        {
            PanelBg.BackColor = Properties.Settings.Default.MyColor;
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

        public void ChangePanelColor5(Color color)
        {
            PanelBg.BackColor = color;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ID = row.Cells["ID"].Value?.ToString();
                textfullname.Text = row.Cells["Full name"].Value?.ToString();
                comboBox1.Text = row.Cells["Is Supplier?"].Value?.ToString();
                txtemail.Text = row.Cells["Email"].Value?.ToString();
                txtcontact.Text = row.Cells["Contact"].Value?.ToString();
                txtaddress.Text = row.Cells["Address"].Value?.ToString();
                txtdiscount.Text = row.Cells["Discount"].Value?.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustomerDetails();
        }
        private void UpdateCustomerDetails()
        {
            // Confirm the update operation
            DialogResult result = MessageBox.Show("Are you sure you want to update the customer details?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                // User clicked No or closed the dialog, so abort the operation
                return;
            }

            // Validate input fields
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Contact) || string.IsNullOrWhiteSpace(Address) ||
                string.IsNullOrWhiteSpace(Discount))
            {
                MessageBox.Show("All fields are required. Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!IsValidEmail(Email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate contact number (you can customize the regex pattern as needed)
            if (!IsValidContactNumber(Contact))
            {
                MessageBox.Show("Please enter a valid contact number (only digits allowed).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int supplierId;
                    using (SqlCommand command = new SqlCommand("SELECT ID FROM [IV].[Supplier] WHERE Name = @Name", connection))
                    {
                        command.Parameters.AddWithValue("@Name", comboBox1.Text);
                        supplierId = (int)command.ExecuteScalar();
                    }

                    using (SqlCommand command = new SqlCommand("UPDATE [IV].[Customer] SET Name = @Name, Email = @Email, Contact = @Contact, " +
                        "Address = @Address, Discount = @Discount, is_supplier = @IsSupplier WHERE ID = @ID", connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Contact", Contact);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Discount", Discount);
                        command.Parameters.AddWithValue("@IsSupplier", supplierId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer details updated successfully.");
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the given ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the customer details: " + ex.Message);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidContactNumber(string contactNumber)
        {
            // This regex checks if the contact number contains only digits
            return System.Text.RegularExpressions.Regex.IsMatch(contactNumber, @"^\d+$");
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            // Call showdata with the filter text
            showdata(txtFilter.Text);
        }

        public void showdata(string filter = "")
        {
            try
            {
                // Open the connection
                connection.Open();

                // SQL query with a filter parameter
                string query = "SELECT c.ID, c.[name] AS [Full name], c.Email, c.Contact, c.[Address], c.Discount, s.[name] AS [Is Supplier?] " +
                               "FROM [IV].[Customer] c " +
                               "INNER JOIN [IV].[Supplier] s ON c.is_supplier = s.id " +
                               "WHERE c.[name] LIKE @Filter OR c.Email LIKE @Filter OR c.Contact LIKE @Filter " +
                               "ORDER BY c.ID ASC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Add filter parameter
                    adapter.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filter + "%");

                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Hide the ID column
                    dataGridView1.Columns["ID"].Visible = false;

                    // Resize the columns based on the content
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }

                    // Resize the column headers
                    dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                    // Ensure all rows are visible
                    dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Adjust the last column to fill the remaining space
                    dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Ensure horizontal scrolling
                    dataGridView1.ScrollBars = ScrollBars.Both;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                connection.Close();
            }
        }
    }
}