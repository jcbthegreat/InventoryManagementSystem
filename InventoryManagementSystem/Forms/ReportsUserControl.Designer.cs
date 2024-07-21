namespace InventoryManagementSystem.Forms
{
    partial class ReportsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsUserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ExportToPDF = new Button();
            ExportToExcel = new Button();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btnGenerate = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblPage = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ExportToPDF);
            panel1.Controls.Add(ExportToExcel);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnGenerate);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 51);
            panel1.TabIndex = 22;
            // 
            // ExportToPDF
            // 
            ExportToPDF.Cursor = Cursors.Hand;
            ExportToPDF.FlatAppearance.BorderSize = 0;
            ExportToPDF.FlatStyle = FlatStyle.Flat;
            ExportToPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExportToPDF.Image = (Image)resources.GetObject("ExportToPDF.Image");
            ExportToPDF.Location = new Point(400, 11);
            ExportToPDF.Name = "ExportToPDF";
            ExportToPDF.Size = new Size(26, 28);
            ExportToPDF.TabIndex = 7;
            ExportToPDF.TextAlign = ContentAlignment.MiddleRight;
            ExportToPDF.UseVisualStyleBackColor = true;
            ExportToPDF.Click += ExportToPDF_Click;
            // 
            // ExportToExcel
            // 
            ExportToExcel.Cursor = Cursors.Hand;
            ExportToExcel.FlatAppearance.BorderSize = 0;
            ExportToExcel.FlatStyle = FlatStyle.Flat;
            ExportToExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExportToExcel.Image = (Image)resources.GetObject("ExportToExcel.Image");
            ExportToExcel.Location = new Point(369, 11);
            ExportToExcel.Name = "ExportToExcel";
            ExportToExcel.Size = new Size(26, 28);
            ExportToExcel.TabIndex = 5;
            ExportToExcel.TextAlign = ContentAlignment.MiddleRight;
            ExportToExcel.UseVisualStyleBackColor = true;
            ExportToExcel.Click += ExportToExcel_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(textBox1);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(757, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(415, 51);
            panel6.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(25, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(64, 17);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Quick Search";
            textBox1.Size = new Size(325, 18);
            textBox1.TabIndex = 4;
            // 
            // btnGenerate
            // 
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.Image = (Image)resources.GetObject("btnGenerate.Image");
            btnGenerate.Location = new Point(332, 11);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(34, 31);
            btnGenerate.TabIndex = 4;
            btnGenerate.TextAlign = ContentAlignment.MiddleRight;
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(97, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "Reports";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 585);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 53);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnPrevious);
            panel3.Controls.Add(btnNext);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(696, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 53);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblPage);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 53);
            panel4.TabIndex = 3;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(206, 19);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(46, 15);
            lblPage.TabIndex = 2;
            lblPage.Text = "lblPage";
            // 
            // btnPrevious
            // 
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.Location = new Point(289, 10);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(89, 32);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "Prev Page";
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(384, 10);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(89, 32);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next Page";
            btnNext.TextAlign = ContentAlignment.MiddleLeft;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 51);
            panel5.Name = "panel5";
            panel5.Size = new Size(1172, 534);
            panel5.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1172, 534);
            dataGridView1.TabIndex = 3;
            // 
            // ReportsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReportsUserControl";
            Size = new Size(1172, 638);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnGenerate;
        private ComboBox comboBox1;
        private Panel panel2;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblPage;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Button ExportToExcel;
        private Panel panel6;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button ExportToPDF;
    }
}
