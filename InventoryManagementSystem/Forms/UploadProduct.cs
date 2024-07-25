using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using InventoryManagementSystem.Model;
namespace InventoryManagementSystem.Forms
{
    public partial class UploadProduct : Form
    {
        string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private readonly SqlConnection connection;
        SqlDataAdapter adapter;
        //DataTable dt;

        public UploadProduct()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            InitializeDataGridView();
            this.Load += new System.EventHandler(this.UploadProduct_Load);
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnDLTemplate, "Download Template");
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(button1, "Import Template");
            ToolTip toolTip3 = new ToolTip();
            toolTip3.SetToolTip(btnSaveExcel, "Upload Template");

        }


        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("WAREHOUSENAME", "Warehouse Name");
            dataGridView1.Columns.Add("PRODUCTCODE", "Product Code");
            dataGridView1.Columns.Add("PRODUCTNAME", "Product Name");
            dataGridView1.Columns.Add("BRANDNAME", "Brand Name");
            dataGridView1.Columns.Add("CATEGORYNAME", "Category Name");
            dataGridView1.Columns.Add("SUBCATEGORYNAME", "Sub Category Name");
            dataGridView1.Columns.Add("TYPENAME", "Type Name");
            dataGridView1.Columns.Add("VARIANTNAME", "Variant Name");
            dataGridView1.Columns.Add("MEASUREMENTNAME", "Measurement Name");
            dataGridView1.Columns.Add("MEASUREMENTCOUNT", "Measurement Count");
            dataGridView1.Columns.Add("CURRENTSTOCK", "Current Stock");
            dataGridView1.Columns.Add("MINIMUMSTOCK", "Minimum Stock");
            dataGridView1.Columns.Add("MAXIMUMSTOCK", "Maximum Stock");
            dataGridView1.Columns.Add("ORIGINALPRICE", "Original Price");
            dataGridView1.Columns.Add("RETAILPRICE", "Retail Price");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure that this is called from the main STA thread
            // The OpenFileDialog and Excel operations need STA
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(openFileDialog.FileName);

                    try
                    {
                        using (var package = new ExcelPackage(fileInfo))
                        {
                            var worksheet = package.Workbook.Worksheets[0];
                            var rowCount = worksheet.Dimension.Rows;
                            var colCount = worksheet.Dimension.Columns;

                            // Ensure columns are set up correctly before adding rows
                            InitializeDataGridView();

                            dataGridView1.Rows.Clear();

                            // Add rows from Excel to DataGridView
                            for (int row = 2; row <= rowCount; row++)
                            {
                                var dataGridViewRow = new DataGridViewRow();
                                dataGridViewRow.CreateCells(dataGridView1);

                                for (int col = 1; col <= colCount; col++)
                                {
                                    dataGridViewRow.Cells[col - 1].Value = worksheet.Cells[row, col].Text;
                                }

                                dataGridView1.Invoke(new System.Action(() => dataGridView1.Rows.Add(dataGridViewRow)));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                //MessageBox.Show("No data found.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowToast("WARNING", "No data found.");
                return;
            }

            bool dataSavedSuccessfully = false;
            bool hasErrors = false;
            string staffNo = MainForm.Instance.StaffNo;

            try
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    // Define SQL queries with isdeleted check
                    string checkProductExistsQuery = "SELECT COUNT(*) FROM [IV].[Product] WHERE product_code = @ProductCode AND (isdeleted IS NULL OR isdeleted = 0)";
                    string insertProductQuery = "INSERT INTO [IV].[Product] (product_code, product_name, brand_id, category_id, subcategory_id, type_id, variant_id, unit_id, unit_count, AddedDate, addedby, isdeleted) " +
                                                "VALUES (@ProductCode, @ProductName, @BrandId, @CategoryId, @SubCategoryId, @TypeId, @VariantId, @UnitId, @UnitCount, GETDATE(), @AddedBy, 0); SELECT SCOPE_IDENTITY();";
                    string getProductIdQuery = "SELECT ID FROM [IV].[Product] WHERE product_code = @ProductCode AND isdeleted IS NULL";

                    string checkWarehouseExistsQuery = "SELECT COUNT(*) FROM [IV].[Warehouse] WHERE Name = @WarehouseName ";
                    string getWarehouseIdQuery = "SELECT ID FROM [IV].[Warehouse] WHERE Name = @WarehouseName ";
                    string checkWarehouseItemExistsQuery = "SELECT COUNT(*) FROM [IV].[WarehouseItems] WHERE product_id = @ProductId AND warehouse_id = @WarehouseId AND (isdeleted IS NULL OR isdeleted = 0)";
                    string insertWarehouseItemQuery = "INSERT INTO [IV].[WarehouseItems] (product_id, warehouse_id, current_stock, min_stock, max_stock, original_price, retail_price, AddedDate, addedby, isdeleted) " +
                                                      "VALUES (@ProductId, @WarehouseId, @CurrentStock, @MinStock, @MaxStock, @OriginalPrice, @RetailPrice, GETDATE(), @AddedBy, 0);";

                    // Prepare commands
                    using (var checkProductCommand = new SqlCommand(checkProductExistsQuery, connection, transaction))
                    using (var insertProductCommand = new SqlCommand(insertProductQuery, connection, transaction))
                    using (var getProductIdCommand = new SqlCommand(getProductIdQuery, connection, transaction))
                    using (var checkWarehouseCommand = new SqlCommand(checkWarehouseExistsQuery, connection, transaction))
                    using (var getWarehouseIdCommand = new SqlCommand(getWarehouseIdQuery, connection, transaction))
                    using (var checkWarehouseItemCommand = new SqlCommand(checkWarehouseItemExistsQuery, connection, transaction))
                    using (var insertWarehouseItemCommand = new SqlCommand(insertWarehouseItemQuery, connection, transaction))
                    using (var brandLookupCommand = new SqlCommand("IF EXISTS (SELECT 1 FROM [IV].[Brand] WHERE BrandName = @Name) SELECT ID FROM [IV].[Brand] WHERE BrandName = @Name ELSE BEGIN INSERT INTO [IV].[Brand] (BrandName) VALUES (@Name); SELECT SCOPE_IDENTITY(); END", connection, transaction))
                    using (var categoryLookupCommand = new SqlCommand("IF EXISTS (SELECT 1 FROM [IV].[Categories] WHERE CategoryName = @Name) SELECT ID FROM [IV].[Categories] WHERE CategoryName = @Name ELSE BEGIN INSERT INTO [IV].[Categories] (CategoryName) VALUES (@Name); SELECT SCOPE_IDENTITY(); END", connection, transaction))
                    using (var subCategoryLookupCommand = new SqlCommand("IF EXISTS (SELECT 1 FROM [IV].[SubCategories] WHERE SubCategoryName = @Name) SELECT ID FROM [IV].[SubCategories] WHERE SubCategoryName = @Name ELSE BEGIN INSERT INTO [IV].[SubCategories] (SubCategoryName) VALUES (@Name); SELECT SCOPE_IDENTITY(); END", connection, transaction))
                    using (var typeLookupCommand = new SqlCommand("IF EXISTS (SELECT 1 FROM [IV].[Types] WHERE TypeName = @Name) SELECT ID FROM [IV].[Types] WHERE TypeName = @Name ELSE BEGIN INSERT INTO [IV].[Types] (TypeName) VALUES (@Name); SELECT SCOPE_IDENTITY(); END", connection, transaction))
                    using (var variantLookupCommand = new SqlCommand("IF EXISTS (SELECT 1 FROM [IV].[Variant] WHERE VariantName = @Name) SELECT ID FROM [IV].[Variant] WHERE VariantName = @Name ELSE BEGIN INSERT INTO [IV].[Variant] (VariantName) VALUES (@Name); SELECT SCOPE_IDENTITY(); END", connection, transaction))
                    using (var measurementLookupCommand = new SqlCommand("IF EXISTS (SELECT 1 FROM [IV].[Measurement] WHERE MeasurementName = @Name) SELECT ID FROM [IV].[Measurement] WHERE MeasurementName = @Name ELSE BEGIN INSERT INTO [IV].[Measurement] (MeasurementName) VALUES (@Name); SELECT SCOPE_IDENTITY(); END", connection, transaction))
                    {
                        // Add parameters for lookup commands
                        foreach (var cmd in new[] { brandLookupCommand, categoryLookupCommand, subCategoryLookupCommand, typeLookupCommand, variantLookupCommand, measurementLookupCommand })
                        {
                            cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                        }

                        // Add parameters for product commands
                        checkProductCommand.Parameters.Add("@ProductCode", SqlDbType.VarChar);
                        insertProductCommand.Parameters.Add("@ProductCode", SqlDbType.VarChar);
                        insertProductCommand.Parameters.Add("@ProductName", SqlDbType.VarChar);
                        insertProductCommand.Parameters.Add("@BrandId", SqlDbType.Int);
                        insertProductCommand.Parameters.Add("@CategoryId", SqlDbType.Int);
                        insertProductCommand.Parameters.Add("@SubCategoryId", SqlDbType.Int);
                        insertProductCommand.Parameters.Add("@TypeId", SqlDbType.Int);
                        insertProductCommand.Parameters.Add("@VariantId", SqlDbType.Int);
                        insertProductCommand.Parameters.Add("@UnitId", SqlDbType.Int);
                        insertProductCommand.Parameters.Add("@UnitCount", SqlDbType.Int);
                        insertProductCommand.Parameters.Add("@AddedBy", SqlDbType.VarChar);
                        getProductIdCommand.Parameters.Add("@ProductCode", SqlDbType.VarChar);

                        // Add parameters for warehouse commands
                        checkWarehouseCommand.Parameters.Add("@WarehouseName", SqlDbType.VarChar);
                        getWarehouseIdCommand.Parameters.Add("@WarehouseName", SqlDbType.VarChar);
                        checkWarehouseItemCommand.Parameters.Add("@ProductId", SqlDbType.Int);
                        checkWarehouseItemCommand.Parameters.Add("@WarehouseId", SqlDbType.Int);
                        insertWarehouseItemCommand.Parameters.Add("@ProductId", SqlDbType.Int);
                        insertWarehouseItemCommand.Parameters.Add("@WarehouseId", SqlDbType.Int);
                        insertWarehouseItemCommand.Parameters.Add("@CurrentStock", SqlDbType.Int);
                        insertWarehouseItemCommand.Parameters.Add("@MinStock", SqlDbType.Int);
                        insertWarehouseItemCommand.Parameters.Add("@MaxStock", SqlDbType.Int);
                        insertWarehouseItemCommand.Parameters.Add("@OriginalPrice", SqlDbType.Decimal);
                        insertWarehouseItemCommand.Parameters.Add("@RetailPrice", SqlDbType.Decimal);
                        insertWarehouseItemCommand.Parameters.Add("@AddedBy", SqlDbType.VarChar);

                        bool hasDataToSave = false;

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            try
                            {
                                // Extract data from DataGridView
                                string productCode = GetCellValue(row, "PRODUCTCODE");
                                string productName = GetCellValue(row, "PRODUCTNAME");
                                string warehouseName = GetCellValue(row, "WAREHOUSENAME");
                                int currentStock = int.TryParse(GetCellValue(row, "CURRENTSTOCK"), out int stock) ? stock : 0;
                                int minStock = int.TryParse(GetCellValue(row, "MINIMUMSTOCK"), out int min) ? min : 0;
                                int maxStock = int.TryParse(GetCellValue(row, "MAXIMUMSTOCK"), out int max) ? max : 0;
                                decimal originalPrice = decimal.TryParse(GetCellValue(row, "ORIGINALPRICE"), out decimal oPrice) ? oPrice : 0m;
                                decimal retailPrice = decimal.TryParse(GetCellValue(row, "RETAILPRICE"), out decimal rPrice) ? rPrice : 0m;
                                string measurementName = GetCellValue(row, "MEASUREMENTNAME");

                                // Check if the product exists
                                checkProductCommand.Parameters["@ProductCode"].Value = productCode;
                                int productExists = (int)checkProductCommand.ExecuteScalar();

                                int productId;
                                if (productExists == 0)
                                {
                                    // Insert into Product table and get the new Product ID
                                    insertProductCommand.Parameters["@ProductCode"].Value = productCode;
                                    insertProductCommand.Parameters["@ProductName"].Value = productName;

                                    // Lookup IDs for other fields
                                    insertProductCommand.Parameters["@BrandId"].Value = GetOrInsertId(brandLookupCommand, GetCellValue(row, "BRANDNAME"));
                                    insertProductCommand.Parameters["@CategoryId"].Value = GetOrInsertId(categoryLookupCommand, GetCellValue(row, "CATEGORYNAME"));
                                    insertProductCommand.Parameters["@SubCategoryId"].Value = GetOrInsertId(subCategoryLookupCommand, GetCellValue(row, "SUBCATEGORYNAME"));
                                    insertProductCommand.Parameters["@TypeId"].Value = GetOrInsertId(typeLookupCommand, GetCellValue(row, "TYPENAME"));
                                    insertProductCommand.Parameters["@VariantId"].Value = GetOrInsertId(variantLookupCommand, GetCellValue(row, "VARIANTNAME"));
                                    insertProductCommand.Parameters["@UnitId"].Value = GetOrInsertId(measurementLookupCommand, measurementName);
                                    insertProductCommand.Parameters["@UnitCount"].Value = GetUnitCount(measurementName);
                                    insertProductCommand.Parameters["@AddedBy"].Value = staffNo;

                                    productId = Convert.ToInt32(insertProductCommand.ExecuteScalar());
                                }
                                else
                                {
                                    // Get the existing Product ID
                                    getProductIdCommand.Parameters["@ProductCode"].Value = productCode;
                                    productId = Convert.ToInt32(getProductIdCommand.ExecuteScalar());
                                }

                                // Check if the warehouse exists
                                checkWarehouseCommand.Parameters["@WarehouseName"].Value = warehouseName;
                                int warehouseExists = (int)checkWarehouseCommand.ExecuteScalar();

                                int warehouseId;
                                if (warehouseExists == 0)
                                {
                                    // If warehouse doesn't exist, handle the case
                                    hasErrors = true;
                                    MessageBox.Show($"Warehouse '{warehouseName}' does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                                else
                                {
                                    // Get the existing Warehouse ID
                                    getWarehouseIdCommand.Parameters["@WarehouseName"].Value = warehouseName;
                                    warehouseId = Convert.ToInt32(getWarehouseIdCommand.ExecuteScalar());
                                }

                                // Check if the product already exists in the warehouse
                                checkWarehouseItemCommand.Parameters["@ProductId"].Value = productId;
                                checkWarehouseItemCommand.Parameters["@WarehouseId"].Value = warehouseId;
                                int warehouseItemExists = (int)checkWarehouseItemCommand.ExecuteScalar();

                                // Debugging information
                                Console.WriteLine($"Product ID: {productId}, Warehouse ID: {warehouseId}, Warehouse Item Exists: {warehouseItemExists}");

                                if (warehouseItemExists == 0)
                                {
                                    // Insert into WarehouseItems table
                                    insertWarehouseItemCommand.Parameters["@ProductId"].Value = productId;
                                    insertWarehouseItemCommand.Parameters["@WarehouseId"].Value = warehouseId;
                                    insertWarehouseItemCommand.Parameters["@CurrentStock"].Value = currentStock;
                                    insertWarehouseItemCommand.Parameters["@MinStock"].Value = minStock;
                                    insertWarehouseItemCommand.Parameters["@MaxStock"].Value = maxStock;
                                    insertWarehouseItemCommand.Parameters["@OriginalPrice"].Value = originalPrice;
                                    insertWarehouseItemCommand.Parameters["@RetailPrice"].Value = retailPrice;
                                    insertWarehouseItemCommand.Parameters["@AddedBy"].Value = staffNo;

                                    insertWarehouseItemCommand.ExecuteNonQuery();
                                    hasDataToSave = true;
                                }
                                else
                                {
                                    //MessageBox.Show($"Product '{productCode}' already exists in warehouse '{warehouseName}'.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ShowToast("WARNING", $"Product Code '{productCode}' already exists.");
                                    hasErrors = true;
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                hasErrors = true;
                                MessageBox.Show($"An error occurred while processing the row: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }

                        if (!hasErrors)
                        {
                            // Commit transaction if no errors occurred and if data was saved
                            if (hasDataToSave)
                            {
                                transaction.Commit();
                                dataSavedSuccessfully = true;
                            }
                            else
                            {
                                //MessageBox.Show("No new data was saved.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ShowToast("ERROR", "No new data was saved.");
                            }
                        }
                        else
                        {
                            // Rollback transaction if there were errors
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                if (dataSavedSuccessfully)
                {
                    ShowToast("SUCCESS", "Uploading successful!");
                }
            }
        }
        private int GetOrInsertId(SqlCommand command, string name)
        {
            command.Parameters["@Name"].Value = name;
            object result = command.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName].Value?.ToString() ?? string.Empty;
        }

        private int GetUnitCount(string measurementName)
        {
            // Implement your logic to get the unit count based on the measurementName
            return 1; // Example value
        }
        private void UploadProduct_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UploadProduct_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Template");

                    // Define headers
                    worksheet.Cells[1, 1].Value = "Warehouse Name";
                    worksheet.Cells[1, 2].Value = "Product Code";
                    worksheet.Cells[1, 3].Value = "Product Name";
                    worksheet.Cells[1, 4].Value = "Brand Name";
                    worksheet.Cells[1, 5].Value = "Category Name";
                    worksheet.Cells[1, 6].Value = "Sub Category Name";
                    worksheet.Cells[1, 7].Value = "Type Name";
                    worksheet.Cells[1, 8].Value = "Variant Name";
                    worksheet.Cells[1, 9].Value = "Measurement Name";
                    worksheet.Cells[1, 10].Value = "Measurement Count";
                    worksheet.Cells[1, 11].Value = "Current Stock";
                    worksheet.Cells[1, 12].Value = "Minimum Stock";
                    worksheet.Cells[1, 13].Value = "Maximum Stock";
                    worksheet.Cells[1, 14].Value = "Original Price";
                    worksheet.Cells[1, 15].Value = "Retail Price";

                    // Auto-fit columns
                    worksheet.Cells.AutoFitColumns();

                    // Save the file
                    using (var saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Save Template";
                        saveFileDialog.FileName = "ProductTemplate.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fi = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fi);
                            ShowToast("SUCCESS", "Successfully Download the Template!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the template: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowToast(string type, string message)
        {
            // Assuming you have a method to show toast messages
            // This could be implemented as a static method or a service
            Toast toast = new Toast(type, message);
            toast.Show();
        }
    }
}
