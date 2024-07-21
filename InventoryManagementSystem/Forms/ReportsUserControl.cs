using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using PdfSharpPdf = PdfSharp.Pdf;
using PdfSharpCorePdf = PdfSharpCore.Pdf;
using PdfSharpCoreDrawing = PdfSharpCore.Drawing;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace InventoryManagementSystem.Forms
{
    public partial class ReportsUserControl : UserControl
    {
        private string connectionString = "Server=desktop-eqrn1iv.taile2b728.ts.net;Database=INVENTORY-SYSTEM;User Id=sa;Password=sasa;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private int currentPageIndex = 0;
        private int pageSize = 20;
       
        public ReportsUserControl()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            comboBox1.Items.Add("Choose Report");
            comboBox1.Items.Add("Product");
            //comboBox1.Items.Add("Warehouse");
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Customers");
            btnGenerate.Enabled = false; // Disable Generate button by default
            ExportToExcel.Enabled = false; // Disable ExportToExcel button by default
            ExportToPDF.Enabled = false; // Disable ExportToExcel button by default

            // Set default selection to "Choose Report"
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdatePaginationControls();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();

            if (selectedOption == "Choose Report")
            {
                btnGenerate.Enabled = false; // Disable Generate button if "Choose Report" is selected
            }
            else
            {
                btnGenerate.Enabled = true; // Enable Generate button if a report is selected
            }
        }

        private async Task GenerateReport(string selectedOption)
        {
            try
            {
                string query = "";

                switch (selectedOption)
                {
                    case "Product":
                        query = "SELECT  p.product_code as [Product Code], p.product_name as [Product Name], " +
                                "b.BrandName as [Brand Name], c.CategoryName as [Category Name], s.subcategoryname as [Sub Category Name], " +
                                "t.typename as [Type Name], v.variantname as [Variant Name], m.measurementname as [Unit], " +
                                "p.unit_count as [Count], w.current_stock as [Cur Stock], w.min_stock as [Min Stock], " +
                                "w.max_stock as [Max Stock], w.original_price as [Orig Price], w.retail_price as [Retail Price] " +
                                "FROM [IV].[Product] p " +
                                "LEFT JOIN [IV].[brand] b ON p.brand_id = b.id " +
                                "LEFT JOIN [IV].[Categories] c on p.category_id = c.id " +
                                "LEFT JOIN [IV].[SubCategories] s on p.subcategory_id = s.ID " +
                                "LEFT JOIN [IV].[Types] t on p.[type_id] = t.id " +
                                "LEFT JOIN [IV].[Variant] v on p.variant_id = v.id " +
                                "LEFT JOIN [IV].[Measurement] m on p.unit_id = m.id " +
                                "LEFT JOIN [IV].[WarehouseItems] w on p.id = w.product_id " +
                                "ORDER BY p.ID ASC";
                        break;
                    //case "Warehouse":
                    //    query = "SELECT * FROM [IV].[Warehouse]";
                    //    break;
                    case "Staff":
                        query = "SELECT  s.StaffNo as [Staff No], RoleType as [Role], Position, CONCAT(FirstName, ' ', MiddleName, ' ', Lastname) AS [Full Name], " +
                                "Email, ContactNo as [Contact], Username " +
                                "FROM [IV].[StaffAssignment] s " +
                                "ORDER BY ID ASC";
                        break;
                    case "Customers":
                        query = "SELECT  c.[Name] as [Full Name], email as [Email Address], [Address], Contact as [Contact No] ,Discount, s.[Name] as [Is Supplier?] " +
                            " FROM [IV].[Customer] c " +
                            " INNER JOIN[IV].[Supplier] s on c.is_supplier = s.Id " +
                            " order by c.Id asc";
                        break;
                    default:
                        // Handle default case
                        break;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            // Enable ExportToExcel button
                            ExportToExcel.Enabled = true;
                            ExportToPDF.Enabled = true;
                            dataGridView1.DataSource = dt; // Bind DataGridView
                            UpdatePaginationControls(); // Update pagination controls if needed
                        }
                        else
                        {
                            // No data found case
                            MessageBox.Show("No data found or DataTable is empty.");
                            dataGridView1.DataSource = null;
                            ExportToExcel.Enabled = false; // Disable ExportToExcel button when no data is shown
                            ExportToPDF.Enabled = false; // Disable ExportToExcel button when no data is shown
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataGridView(int pageIndex)
        {
            try
            {
                int startIndex = pageIndex * pageSize;
                DataRow[] rows = dt.AsEnumerable().Skip(startIndex).Take(pageSize).ToArray();
                DataTable pageDataTable = dt.Clone(); // Clone structure (columns)

                foreach (DataRow row in rows)
                {
                    pageDataTable.ImportRow(row);
                }

                dataGridView1.DataSource = pageDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading DataGridView: {ex.Message}");
            }
        }

        private void UpdatePaginationControls()
        {
            try
            {
                int currentPageNumber = currentPageIndex + 1;
                int totalPages = (int)Math.Ceiling((double)dt.Rows.Count / pageSize);
                lblPage.Text = $"Page {currentPageNumber} of {totalPages}";
                btnPrevious.Enabled = currentPageIndex > 0;
                btnNext.Enabled = (currentPageIndex + 1) * pageSize < dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating pagination: {ex.Message}");
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();

            if (selectedOption != "Choose Report")
            {
                await GenerateReport(selectedOption);
                
            }
            else
            {
                MessageBox.Show("Please select a report.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((currentPageIndex + 1) * pageSize < dt.Rows.Count)
            {
                currentPageIndex++;
                LoadDataGridView(currentPageIndex);
                UpdatePaginationControls();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                LoadDataGridView(currentPageIndex);
                UpdatePaginationControls();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell content click if needed
        }

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "export.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Data");

                            // Loop through each column in DataTable
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                string columnName = dt.Columns[i].ColumnName;

                                // Check if the column name exists in DataGridView columns
                                if (dataGridView1.Columns.Cast<DataGridViewColumn>().Any(col => col.HeaderText == columnName))
                                {
                                    // Add header with color and white font
                                    var headerCell = worksheet.Cell(1, i + 1);
                                    headerCell.Value = columnName;
                                    headerCell.Style.Fill.BackgroundColor = XLColor.RoyalBlue; // Set header background color
                                    headerCell.Style.Font.Bold = true; // Make header text bold
                                    headerCell.Style.Font.FontColor = XLColor.White; // Set header font color to white
                                }
                                else
                                {
                                    // Add header without color (default)
                                    worksheet.Cell(1, i + 1).Value = columnName;
                                }
                            }

                            // Add data rows
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dt.Rows[i][j]?.ToString();
                                }
                            }

                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ExportToPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "export.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dt = (DataTable)dataGridView1.DataSource;
                        if (dt == null || dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        PdfSharpCorePdf.PdfDocument pdfDocument = new PdfSharpCorePdf.PdfDocument();
                        PdfSharpCorePdf.PdfPage pdfPage = pdfDocument.AddPage();
                        PdfSharpCoreDrawing.XGraphics gfx = PdfSharpCoreDrawing.XGraphics.FromPdfPage(pdfPage);

                        PdfSharpCoreDrawing.XFont font = new PdfSharpCoreDrawing.XFont("Arial", 5);
                        double marginLeft = 40;
                        double marginTop = 80; // Increased margin to accommodate header
                        double marginBottom = 40;
                        double cellPadding = 5;

                        double pageWidth = pdfPage.Width.Point;
                        double pageHeight = pdfPage.Height.Point;
                        double usableWidth = pageWidth - 2 * marginLeft;
                        double usableHeight = pageHeight - marginTop - marginBottom;

                        double cellWidth = usableWidth / dt.Columns.Count;
                        double cellHeight = font.Height + 2 * cellPadding;

                        bool isLandscape = dt.Columns.Count > 6;
                        if (isLandscape)
                        {
                            pdfPage.Orientation = PdfSharpCore.PageOrientation.Landscape;
                            pageWidth = pdfPage.Width.Point;
                            pageHeight = pdfPage.Height.Point;
                            usableWidth = pageWidth - 2 * marginLeft;
                            usableHeight = pageHeight - marginTop - marginBottom;
                            cellWidth = usableWidth / dt.Columns.Count;
                            cellHeight = font.Height + 2 * cellPadding;
                        }

                        // Add company name and other header details
                        PdfSharpCoreDrawing.XFont titleFont = new PdfSharpCoreDrawing.XFont("Arial", 14, PdfSharpCoreDrawing.XFontStyle.Bold);
                        PdfSharpCoreDrawing.XFont headerFont = new PdfSharpCoreDrawing.XFont("Arial", 10, PdfSharpCoreDrawing.XFontStyle.Regular);

                        string companyName = "Inventory Management System";
                        string reportTitle = "Extracted Data Report";
                        string reportDate = DateTime.Now.ToString("MMMM dd, yyyy");

                        gfx.DrawString(companyName, titleFont, PdfSharpCoreDrawing.XBrushes.Black, new PdfSharpCoreDrawing.XRect(0, 20, pageWidth, 0), PdfSharpCoreDrawing.XStringFormats.TopCenter);
                        gfx.DrawString(reportTitle, headerFont, PdfSharpCoreDrawing.XBrushes.Black, new PdfSharpCoreDrawing.XRect(0, 40, pageWidth, 0), PdfSharpCoreDrawing.XStringFormats.TopCenter);
                        gfx.DrawString(reportDate, headerFont, PdfSharpCoreDrawing.XBrushes.Black, new PdfSharpCoreDrawing.XRect(0, 60, pageWidth, 0), PdfSharpCoreDrawing.XStringFormats.TopCenter);

                        // Load image from the Resources folder
                        string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "living-room.png");
                       

                        if (File.Exists(imagePath))
                        {
                            using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                            {
                                var logo = PdfSharpCoreDrawing.XImage.FromStream(() => stream);
                                double originalWidth = logo.PixelWidth;
                                double originalHeight = logo.PixelHeight;

                                double maxWidth = 100;
                                double maxHeight = 40;
                                double scale = Math.Min(maxWidth / originalWidth, maxHeight / originalHeight);

                                double width = originalWidth * scale;
                                double height = originalHeight * scale;

                                gfx.DrawImage(logo, marginLeft, marginTop - height - 10, width, height); // Adjust position and size as needed
                            }
                        }
                        else
                        {
                            MessageBox.Show("Logo image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        double startY = marginTop;
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            string columnName = dt.Columns[i].ColumnName;
                            PdfSharpCoreDrawing.XRect headerRect = new PdfSharpCoreDrawing.XRect(marginLeft + i * cellWidth, startY, cellWidth, cellHeight);
                            gfx.DrawRectangle(PdfSharpCoreDrawing.XBrushes.LightGray, headerRect);
                            gfx.DrawString(columnName, font, PdfSharpCoreDrawing.XBrushes.Black, headerRect, PdfSharpCoreDrawing.XStringFormats.Center);
                        }

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                string cellValue = dt.Rows[i][j]?.ToString();
                                PdfSharpCoreDrawing.XRect cellRect = new PdfSharpCoreDrawing.XRect(marginLeft + j * cellWidth, startY + (i + 1) * cellHeight, cellWidth, cellHeight);
                                gfx.DrawRectangle(PdfSharpCoreDrawing.XBrushes.White, cellRect);
                                gfx.DrawString(cellValue, font, PdfSharpCoreDrawing.XBrushes.Black, cellRect, PdfSharpCoreDrawing.XStringFormats.Center);
                            }
                        }

                        pdfDocument.Save(sfd.FileName);
                        MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}