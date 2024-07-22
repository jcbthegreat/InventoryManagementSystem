using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms.SettingsForm
{
    public partial class RoleAssignment : Form
    {
        private string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private string selectedStaffNo = null; // Store the selected staff number
        private Dictionary<string, int> roleDictionary = new Dictionary<string, int>(); // Store RoleType and Role ID
        public Panel PanelBg { get; set; }
        public static RoleAssignment Instance { get; private set; }

        public RoleAssignment()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            PanelBg = panelBg;
            panelBg.BackColor = Color.DimGray;
            Instance = this;
            LoadStaffList();
            LoadRoleComboBox();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            addBtn.Click += addBtn_Click; // Attach the click event here
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedFullName = listBox1.SelectedItem.ToString();
                FetchStaffNo(selectedFullName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No action needed here
        }

        private void LoadStaffList()
        {
            try
            {
                connection.Open();
                string query = "SELECT StaffNo, FirstName, MiddleName, LastName FROM IV.StaffAssignment ORDER BY ID ASC";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string fullName = $"{reader["FirstName"]} {reader["MiddleName"]} {reader["LastName"]}";
                    listBox1.Items.Add(fullName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff list: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadRoleComboBox()
        {
            try
            {
                connection.Open();
                string query = "SELECT ID, RoleDescription FROM [IV].[Roles]";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int roleId = (int)reader["ID"];
                    string roleType = reader["RoleDescription"].ToString();
                    roleDictionary[roleType] = roleId;
                    comboBox1.Items.Add(roleType);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FetchStaffNo(string fullName)
        {
            try
            {
                connection.Open();
                string query = "SELECT StaffNo FROM IV.StaffAssignment WHERE CONCAT(FirstName, ' ', MiddleName, ' ', LastName) = @FullName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", fullName);
                var result = command.ExecuteScalar();

                if (result != null)
                {
                    selectedStaffNo = result.ToString();
                    // MessageBox.Show($"Selected Staff No: {selectedStaffNo}"); // Debug message
                }
                else
                {
                    selectedStaffNo = null; // Reset if no match is found
                    MessageBox.Show("Staff No not found."); // Debug message
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching staff number: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateStaffRole(int roleId)
        {
            try
            {
                connection.Open();
                string query = "UPDATE IV.StaffAssignment SET RoleType = @RoleId WHERE StaffNo = @StaffNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoleId", roleId);
                command.Parameters.AddWithValue("@StaffNo", selectedStaffNo);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Staff role updated successfully.");
                }
                else
                {
                    MessageBox.Show("No rows affected. Please check if the staff number and role ID are correct.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff role: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (selectedStaffNo != null && comboBox1.SelectedItem != null)
            {
                string selectedRoleType = comboBox1.SelectedItem.ToString();
                if (roleDictionary.TryGetValue(selectedRoleType, out int roleId))
                {
                    // MessageBox.Show($"Selected Role ID: {roleId}"); // Debug message
                    UpdateStaffRole(roleId);
                }
                else
                {
                    MessageBox.Show("Selected role type not found.");
                }
            }
           
        }
    }
}