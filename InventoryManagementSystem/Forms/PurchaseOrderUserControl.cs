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
        private int customerId;
        public PurchaseOrderUserControl()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadCustomersAsync();
            LoadBanksAsync();
            ConfigureDataGridView();
            LoadWarehousesAsync();
        }

        private async Task LoadCustomersAsync()
        {
            string query = "SELECT ID, [Name], Discount FROM [IV].[Customer] WHERE [Is_Supplier] = 1 AND isactive = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        await Task.Run(() => adapter.Fill(dataTable));

                        comboBoxCus.DisplayMember = "Name";
                        comboBoxCus.ValueMember = "ID";
                        comboBoxCus.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading customers: {ex.Message}");
                }
            }
        }

        private async Task LoadBanksAsync()
        {
            string query = "SELECT ID, [Name] FROM [IV].[Bank]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        await Task.Run(() => adapter.Fill(dataTable));

                        comboBoxBank.DisplayMember = "Name";
                        comboBoxBank.ValueMember = "ID";
                        comboBoxBank.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading banks: {ex.Message}");
                }
            }
        }

        private async Task<DataTable> LoadWarehousesAsync()
        {
            string query = "SELECT ID, [Name] FROM [IV].[Warehouse]";
            return await LoadDataAsync(query);
        }

        private async Task<DataTable> LoadProductsAsync(int? warehouseId = null)
        {
            string query = "SELECT p.ID, p.product_name FROM [IV].[Product] p " +
                           "LEFT JOIN [IV].[WarehouseItems] w ON p.ID = w.product_id " +
                           "WHERE (p.isdeleted IS NULL OR p.isdeleted = 0)";
            if (warehouseId.HasValue)
            {
                query += " AND w.warehouse_id = @WarehouseId";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        if (warehouseId.HasValue)
                        {
                            command.Parameters.AddWithValue("@WarehouseId", warehouseId.Value);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        await Task.Run(() => adapter.Fill(dataTable));
                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading products: {ex.Message}");
                    return null;
                }
            }
        }

        private async Task<DataTable> LoadDataAsync(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        await Task.Run(() => adapter.Fill(dataTable));
                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                    return null;
                }
            }
        }

        private async Task ConfigureDataGridView()
        {
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "ID" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Purchase Order ID", HeaderText = "Purchase Order ID", DataPropertyName = "purchase_order_id" });

            var warehouseColumn = new DataGridViewComboBoxColumn
            {
                Name = "Warehouse Name",
                HeaderText = "Warehouse",
                DataPropertyName = "warehouse_id",
                DisplayMember = "Name",
                ValueMember = "ID"
            };

            DataTable warehouseData = await LoadWarehousesAsync();
            if (warehouseData != null)
            {
                warehouseColumn.DataSource = warehouseData;
                warehouseColumn.DisplayMember = "Name";
                warehouseColumn.ValueMember = "ID";
            }
            dataGridView2.Columns.Add(warehouseColumn);

            var productColumn = new DataGridViewComboBoxColumn
            {
                Name = "Product Name",
                HeaderText = "Product",
                DataPropertyName = "product_id",
                DisplayMember = "product_name",
                ValueMember = "ID"
            };

            dataGridView2.Columns.Add(productColumn);

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Quantity", DataPropertyName = "quantity" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Retail Price", HeaderText = "Retail Price", DataPropertyName = "retail_price" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Amount", HeaderText = "Amount", DataPropertyName = "amount" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Discount", HeaderText = "Discount", DataPropertyName = "discount" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Net Amount", HeaderText = "Net Amount", DataPropertyName = "net_amount" });

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = true;
            dataGridView2.AllowUserToResizeRows = true;
            dataGridView2.RowHeadersVisible = false;

            dataGridView2.CellValueChanged += async (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridView2.Rows[e.RowIndex];

                    if (e.ColumnIndex == dataGridView2.Columns["Warehouse Name"].Index)
                    {
                        var selectedWarehouseId = row.Cells["Warehouse Name"].Value;
                        if (selectedWarehouseId != null)
                        {
                            var products = await LoadProductsAsync((int)selectedWarehouseId);
                            var productColumn = (DataGridViewComboBoxColumn)dataGridView2.Columns["Product Name"];
                            if (products != null)
                            {
                                productColumn.DataSource = products;
                                productColumn.DisplayMember = "product_name";
                                productColumn.ValueMember = "ID";
                            }
                        }
                    }
                    else if (e.ColumnIndex == dataGridView2.Columns["Product Name"].Index)
                    {
                        var selectedProductId = row.Cells["Product Name"].Value;
                        if (selectedProductId != null)
                        {
                            using (var conn = new SqlConnection(connectionString))
                            {
                                await conn.OpenAsync();

                                // Fetch retail price
                                string priceQuery = "SELECT retail_price FROM [IV].[WarehouseItems] WHERE product_id = @ProductId";
                                using (var priceCmd = new SqlCommand(priceQuery, conn))
                                {
                                    priceCmd.Parameters.AddWithValue("@ProductId", selectedProductId);
                                    var result = await priceCmd.ExecuteScalarAsync();
                                    var retailPrice = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                                    row.Cells["Retail Price"].Value = retailPrice;
                                }

                                // Fetch discount
                                string discountQuery = "SELECT discount FROM [IV].[Customer] WHERE ID = @ClientId";
                                using (var discountCmd = new SqlCommand(discountQuery, conn))
                                {
                                    discountCmd.Parameters.AddWithValue("@ClientId", customerId);
                                    var discountResult = await discountCmd.ExecuteScalarAsync();
                                    var discount = discountResult != DBNull.Value ? Convert.ToDecimal(discountResult) : 0;
                                    row.Cells["Discount"].Value = discount;
                                }
                            }
                        }
                    }
                    else if (e.ColumnIndex == dataGridView2.Columns["Quantity"].Index ||
                             e.ColumnIndex == dataGridView2.Columns["Retail Price"].Index ||
                             e.ColumnIndex == dataGridView2.Columns["Discount"].Index)
                    {
                        // Recalculate amount and net amount
                        var quantity = GetDecimalValue(row.Cells["Quantity"].Value);
                        var retailPrice = GetDecimalValue(row.Cells["Retail Price"].Value);
                        var discount = GetDecimalValue(row.Cells["Discount"].Value);

                        // Calculate total amount
                        var amount = quantity * retailPrice;
                        row.Cells["Amount"].Value = amount;

                        // Calculate net amount
                        var discountAmount = amount * (discount / 100);
                        var netAmount = amount - discountAmount;
                        row.Cells["Net Amount"].Value = netAmount;
                    }
                }
            };

            dataGridView2.EditingControlShowing += DataGridView2_EditingControlShowing;
        }

        private void DataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var comboBox = e.Control as ComboBox;
            if (comboBox != null)
            {
                // Set specific properties for the ComboBox if needed
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private decimal GetDecimalValue(object value)
        {
            return value != DBNull.Value && value != null ? Convert.ToDecimal(value) : 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxCus.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    // Retrieve customer discount
                    decimal customerDiscount = 0;
                    string discountQuery = "SELECT Discount FROM [IV].[Customer] WHERE ID = @ClientId";
                    using (var discountCommand = new SqlCommand(discountQuery, conn))
                    {
                        discountCommand.Parameters.AddWithValue("@ClientId", comboBoxCus.SelectedValue);
                        var discountResult = await discountCommand.ExecuteScalarAsync();
                        if (discountResult != DBNull.Value)
                        {
                            customerDiscount = Convert.ToDecimal(discountResult);
                        }
                    }

                    // Insert into PurchaseOrder
                    string insertPOQuery = "INSERT INTO [IV].[PurchaseOrder] (PO_NUMBER, client_id, order_date, mode_payment_id, payment_status, BANK_ID, bank_date, check_number, paid_amount, balance, principal_amount, is_deleted) " +
                        "VALUES (@PONumber, @ClientId, @OrderDate, @ModePaymentId, @PaymentStatus, @BankId, @BankDate, @CheckNumber, @PaidAmount, @Balance, @PrincipalAmount, @IsDeleted); " +
                        "SELECT SCOPE_IDENTITY()";

                    int purchaseOrderId;
                    using (var poCommand = new SqlCommand(insertPOQuery, conn))
                    {
                        poCommand.Parameters.AddWithValue("@PONumber", po_num.Text);
                        poCommand.Parameters.AddWithValue("@ClientId", comboBoxCus.SelectedValue ?? DBNull.Value);
                        poCommand.Parameters.AddWithValue("@OrderDate", dateTimePicOrderDate.Value);
                        poCommand.Parameters.AddWithValue("@ModePaymentId", comboBoxModePay.SelectedValue ?? DBNull.Value);
                        poCommand.Parameters.AddWithValue("@PaymentStatus", comboBoxStatus.SelectedValue ?? DBNull.Value);
                        poCommand.Parameters.AddWithValue("@BankId", comboBoxBank.SelectedValue ?? DBNull.Value);
                        poCommand.Parameters.AddWithValue("@BankDate", dateTimePickerBankDate.Value);
                        poCommand.Parameters.AddWithValue("@CheckNumber", textCheckNum.Text);
                        poCommand.Parameters.AddWithValue("@PaidAmount", DBNull.Value); // Adjust as needed
                        poCommand.Parameters.AddWithValue("@Balance", DBNull.Value); // Adjust as needed
                        poCommand.Parameters.AddWithValue("@PrincipalAmount", DBNull.Value);
                        poCommand.Parameters.AddWithValue("@IsDeleted", false);

                        purchaseOrderId = Convert.ToInt32(await poCommand.ExecuteScalarAsync());
                    }

                    // Check stock and insert into PurchaseOrderDetail
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var quantity = Convert.ToDecimal(row.Cells["Quantity"].Value ?? 0);
                        var productId = Convert.ToInt32(row.Cells["Product Name"].Value ?? 0);

                        // Check stock
                        decimal currentStock = 0;
                        string stockQuery = "SELECT Current_Stock FROM [IV].[WarehouseItems] WHERE Product_id = @ProductId";
                        using (var stockCommand = new SqlCommand(stockQuery, conn))
                        {
                            stockCommand.Parameters.AddWithValue("@ProductId", productId);
                            var stockResult = await stockCommand.ExecuteScalarAsync();
                            if (stockResult != DBNull.Value)
                            {
                                currentStock = Convert.ToDecimal(stockResult);
                            }
                        }

                        if (quantity > currentStock)
                        {
                            MessageBox.Show($"Insufficient stock for product ID {productId}. Available stock is {currentStock}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string insertPODetailQuery = "INSERT INTO [IV].[PurchaseOrderDetail] (purchase_order_id, warehouse_id, product_id, quantitty, amount, discount, net_amount) " +
                            "VALUES (@PurchaseOrderId, @WarehouseId, @ProductId, @Quantity, @Amount, @Discount, @NetAmount)";

                        using (var cmd = new SqlCommand(insertPODetailQuery, conn))
                        {
                            var amount = Convert.ToDecimal(row.Cells["Amount"].Value ?? 0);
                            var netAmount = amount - (amount * customerDiscount / 100);

                            cmd.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);
                            cmd.Parameters.AddWithValue("@WarehouseId", row.Cells["Warehouse Name"].Value ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@ProductId", productId);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@Discount", customerDiscount);
                            cmd.Parameters.AddWithValue("@NetAmount", netAmount);

                            await cmd.ExecuteNonQueryAsync();
                        }

                        // Update stock after inserting purchase order detail
                        string updateStockQuery = "UPDATE [IV].[WarehouseItems] SET Current_Stock = Current_Stock - @Quantity WHERE Product_id = @ProductId";
                        using (var updateStockCmd = new SqlCommand(updateStockQuery, conn))
                        {
                            updateStockCmd.Parameters.AddWithValue("@Quantity", quantity);
                            updateStockCmd.Parameters.AddWithValue("@ProductId", productId);

                            await updateStockCmd.ExecuteNonQueryAsync();
                        }
                    }

                    MessageBox.Show("Purchase order saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving purchase order: {ex.Message}");
                }
            }
        }
    }
}