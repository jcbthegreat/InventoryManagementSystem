using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class PurchaseOrderUserControl : UserControl
    {
        private readonly string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private SqlConnection connection;

        public PurchaseOrderUserControl()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadCustomersAsync();
            LoadBanksAsync();
        }

        private async Task LoadCustomersAsync()
        {
            try
            {
                await connection.OpenAsync();

                string query = "SELECT ID, [Name] FROM [IV].[Customer] " +
                               "WHERE is_supplier = 1 " +
                               "AND isactive = 1 " + 
                               "ORDER BY ID ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    await Task.Run(() => adapter.Fill(dataTable)); 

                    comboBoxCus.DataSource = dataTable;
                    comboBoxCus.DisplayMember = "Name";
                    comboBoxCus.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private async Task LoadBanksAsync()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    string query = "SELECT ID, [Name] FROM [IV].[Bank] ORDER BY ID ASC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        await Task.Run(() => adapter.Fill(dataTable));

                        comboBoxBank.DataSource = dataTable;
                        comboBoxBank.DisplayMember = "Name";
                        comboBoxBank.ValueMember = "ID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading Bank: {ex.Message}");
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxCus.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlTransaction transaction = await BeginTransactionAsync())
            {
                try
                {
                    int purchaseOrderId = await SavePurchaseOrderAsync(transaction);

                    // Clear existing rows in DataGridView
                    dataGridView2.Rows.Clear();

                    // Add rows to DataGridView
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            await SavePurchaseOrderDetailAsync(purchaseOrderId, row, transaction);
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Purchase Order saved successfully!");

                    // Load the Purchase Order details into the DataGridView after saving
                    await LoadPurchaseOrderDetailsAsync(purchaseOrderId);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error saving purchase order: {ex.Message}");
                }
            }
        }

        private async Task<SqlTransaction> BeginTransactionAsync()
        {
            await connection.OpenAsync();
            return connection.BeginTransaction();
        }

        private async Task<int> SavePurchaseOrderAsync(SqlTransaction transaction)
        {
            string insertPOQuery = "INSERT INTO [IV].[PurchaseOrder] (PO_NUMBER, client_id, order_date, mode_payment_id, payment_status, BANK_ID, bank_date, check_number, paid_amount, balance, principal_amount) " +
                                   "VALUES (@PONumber, @ClientId, @OrderDate, @ModePaymentId, @PaymentStatus, @BankId, @BankDate, @CheckNumber, @PaidAmount, @Balance, @PrincipalAmount);" +
                                   "SELECT SCOPE_IDENTITY();";

            using (SqlCommand poCommand = new SqlCommand(insertPOQuery, connection, transaction))
            {
                poCommand.Parameters.AddWithValue("@PONumber", po_num.Text);
                poCommand.Parameters.AddWithValue("@ClientId", comboBoxCus.SelectedValue ?? DBNull.Value);
                poCommand.Parameters.AddWithValue("@OrderDate", dateTimePicOrderDate.Value);
                poCommand.Parameters.AddWithValue("@ModePaymentId", comboBoxModePay.SelectedValue ?? DBNull.Value);
                poCommand.Parameters.AddWithValue("@PaymentStatus", comboBoxStatus.SelectedValue ?? DBNull.Value);
                poCommand.Parameters.AddWithValue("@BankId", comboBoxBank.SelectedValue ?? DBNull.Value);
                poCommand.Parameters.AddWithValue("@BankDate", dateTimePickerBankDate.Value);
                poCommand.Parameters.AddWithValue("@CheckNumber", textCheckNum.Text);
                poCommand.Parameters.AddWithValue("@PaidAmount", 0); // Replace with actual value
                poCommand.Parameters.AddWithValue("@Balance", 0); // Replace with actual value
                poCommand.Parameters.AddWithValue("@PrincipalAmount", 0); // Replace with actual value

                return Convert.ToInt32(await poCommand.ExecuteScalarAsync());
            }
        }

        private async Task SavePurchaseOrderDetailAsync(int purchaseOrderId, DataGridViewRow row, SqlTransaction transaction)
        {
            string insertPODetailsQuery = "INSERT INTO [IV].[PurchaseOrderDetail] (purchase_order_id, warehouse_id, product_id, quantity, amount, discount, net_amount) " +
                                          "VALUES (@PurchaseOrderId, @WarehouseId, @ProductId, @Quantity, @Amount, @Discount, @NetAmount);";

            using (SqlCommand podCommand = new SqlCommand(insertPODetailsQuery, connection, transaction))
            {
                podCommand.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);
                podCommand.Parameters.AddWithValue("@WarehouseId", row.Cells["Warehouse ID"].Value ?? DBNull.Value);
                podCommand.Parameters.AddWithValue("@ProductId", row.Cells["Product ID"].Value ?? DBNull.Value);
                podCommand.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value ?? DBNull.Value);
                podCommand.Parameters.AddWithValue("@Amount", row.Cells["Amount"].Value ?? DBNull.Value);
                podCommand.Parameters.AddWithValue("@Discount", row.Cells["Discount"].Value ?? DBNull.Value);
                podCommand.Parameters.AddWithValue("@NetAmount", row.Cells["Net Amount"].Value ?? DBNull.Value);

                await podCommand.ExecuteNonQueryAsync();
            }
        }

        private async Task LoadPurchaseOrderDetailsAsync(int purchaseOrderId)
        {
            string query = "SELECT ID, purchase_order_id, warehouse_id, product_id, quantitty, amount, discount, net_amount " +
                           "FROM [IV].[PurchaseOrderDetail] " +
                           "WHERE purchase_order_id = @PurchaseOrderId " +
                           "ORDER BY ID ASC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable detailsTable = new DataTable();
                await Task.Run(() => adapter.Fill(detailsTable));

                // Bind the DataTable to the DataGridView
                dataGridView2.DataSource = detailsTable;

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AllowUserToOrderColumns = true;
                dataGridView2.AllowUserToResizeColumns = true;
                dataGridView2.AllowUserToResizeRows = true;
                dataGridView2.RowHeadersVisible = false;
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "ID" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Purchase Order ID", HeaderText = "Purchase Order ID", DataPropertyName = "purchase_order_id" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Warehouse ID", HeaderText = "Warehouse ID", DataPropertyName = "warehouse_id" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Product ID", HeaderText = "Product ID", DataPropertyName = "product_id" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Quantity", DataPropertyName = "quantity" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Amount", HeaderText = "Amount", DataPropertyName = "amount" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Discount", HeaderText = "Discount", DataPropertyName = "discount" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Net Amount", HeaderText = "Net Amount", DataPropertyName = "net_amount" });
        }
        // Event Handlers
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content clicks if needed
        }

        private void po_num_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event for Purchase Order Number
        }

        private void comboBoxCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxCus.SelectedValue != null)
            //{
            //    int customerId = Convert.ToInt32(comboBoxCus.SelectedValue);
            //    LoadCustomerDetails(customerId);
            //}
        }

        private void dateTimePicOrderDate_ValueChanged(object sender, EventArgs e)
        {
            // Handle changes to the order date
        }

        private void comboBoxpayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle payment method selection changes
        }

        private void comboBoxModePay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle mode of payment selection changes
        }

        private void comboBoxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle bank selection changes
        }

        private void dateTimePickerBankDate_ValueChanged(object sender, EventArgs e)
        {
            // Handle changes to the bank date
        }

        private void textCheckNum_TextChanged(object sender, EventArgs e)
        {
            // Handle changes to the check number
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle changes to the payment status
        }

        private void comboBoxCus_SelectedIndexChanged_2(object sender, EventArgs e)
        {
        }
    }
}