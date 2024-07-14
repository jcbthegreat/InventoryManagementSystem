namespace InventoryManagementSystem.Forms
{
    partial class UploadProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadProduct));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            WAREHOUSENAME = new DataGridViewTextBoxColumn();
            PRODUCTCODE = new DataGridViewTextBoxColumn();
            PRODUCTNAME = new DataGridViewTextBoxColumn();
            BRANDNAME = new DataGridViewTextBoxColumn();
            CATEGORYNAME = new DataGridViewTextBoxColumn();
            SUBCATEGORYNAME = new DataGridViewTextBoxColumn();
            TYPENAME = new DataGridViewTextBoxColumn();
            VARIANTNAME = new DataGridViewTextBoxColumn();
            MEASUREMENT = new DataGridViewTextBoxColumn();
            MEASUREMENTCOUNT = new DataGridViewTextBoxColumn();
            CURRENTSTOCK = new DataGridViewTextBoxColumn();
            MINIMUMSTOCK = new DataGridViewTextBoxColumn();
            MAXIMUMSTOCK = new DataGridViewTextBoxColumn();
            ORIGINALPRICE = new DataGridViewTextBoxColumn();
            RETAILPRICE = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnSaveExcel = new Button();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            panel1 = new Panel();
            closeBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, WAREHOUSENAME, PRODUCTCODE, PRODUCTNAME, BRANDNAME, CATEGORYNAME, SUBCATEGORYNAME, TYPENAME, VARIANTNAME, MEASUREMENT, MEASUREMENTCOUNT, CURRENTSTOCK, MINIMUMSTOCK, MAXIMUMSTOCK, ORIGINALPRICE, RETAILPRICE });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(12, 99);
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
            dataGridView1.Size = new Size(1078, 430);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 41;
            // 
            // WAREHOUSENAME
            // 
            WAREHOUSENAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WAREHOUSENAME.HeaderText = "WAREHOUSENAME";
            WAREHOUSENAME.Name = "WAREHOUSENAME";
            WAREHOUSENAME.ReadOnly = true;
            WAREHOUSENAME.Width = 151;
            // 
            // PRODUCTCODE
            // 
            PRODUCTCODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PRODUCTCODE.HeaderText = "PRODUCTCODE";
            PRODUCTCODE.Name = "PRODUCTCODE";
            PRODUCTCODE.ReadOnly = true;
            PRODUCTCODE.Width = 125;
            // 
            // PRODUCTNAME
            // 
            PRODUCTNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PRODUCTNAME.HeaderText = "PRODUCTNAME";
            PRODUCTNAME.Name = "PRODUCTNAME";
            PRODUCTNAME.ReadOnly = true;
            PRODUCTNAME.Width = 130;
            // 
            // BRANDNAME
            // 
            BRANDNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BRANDNAME.HeaderText = "BRANDNAME";
            BRANDNAME.Name = "BRANDNAME";
            BRANDNAME.ReadOnly = true;
            BRANDNAME.Width = 115;
            // 
            // CATEGORYNAME
            // 
            CATEGORYNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CATEGORYNAME.HeaderText = "CATEGORYNAME";
            CATEGORYNAME.Name = "CATEGORYNAME";
            CATEGORYNAME.ReadOnly = true;
            CATEGORYNAME.Width = 136;
            // 
            // SUBCATEGORYNAME
            // 
            SUBCATEGORYNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SUBCATEGORYNAME.HeaderText = "SUBCATEGORYNAME";
            SUBCATEGORYNAME.Name = "SUBCATEGORYNAME";
            SUBCATEGORYNAME.ReadOnly = true;
            SUBCATEGORYNAME.Width = 160;
            // 
            // TYPENAME
            // 
            TYPENAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TYPENAME.HeaderText = "TYPENAME";
            TYPENAME.Name = "TYPENAME";
            TYPENAME.ReadOnly = true;
            TYPENAME.Width = 101;
            // 
            // VARIANTNAME
            // 
            VARIANTNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            VARIANTNAME.HeaderText = "VARIANTNAME";
            VARIANTNAME.Name = "VARIANTNAME";
            VARIANTNAME.ReadOnly = true;
            VARIANTNAME.Width = 125;
            // 
            // MEASUREMENT
            // 
            MEASUREMENT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MEASUREMENT.HeaderText = "MEASUREMENT";
            MEASUREMENT.Name = "MEASUREMENT";
            MEASUREMENT.ReadOnly = true;
            MEASUREMENT.Width = 128;
            // 
            // MEASUREMENTCOUNT
            // 
            MEASUREMENTCOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MEASUREMENTCOUNT.HeaderText = "MEASUREMENTCOUNT";
            MEASUREMENTCOUNT.Name = "MEASUREMENTCOUNT";
            MEASUREMENTCOUNT.ReadOnly = true;
            MEASUREMENTCOUNT.Width = 171;
            // 
            // CURRENTSTOCK
            // 
            CURRENTSTOCK.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CURRENTSTOCK.HeaderText = "CURRENTSTOCK";
            CURRENTSTOCK.Name = "CURRENTSTOCK";
            CURRENTSTOCK.ReadOnly = true;
            CURRENTSTOCK.Width = 129;
            // 
            // MINIMUMSTOCK
            // 
            MINIMUMSTOCK.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MINIMUMSTOCK.HeaderText = "MINIMUMSTOCK";
            MINIMUMSTOCK.Name = "MINIMUMSTOCK";
            MINIMUMSTOCK.ReadOnly = true;
            MINIMUMSTOCK.Width = 135;
            // 
            // MAXIMUMSTOCK
            // 
            MAXIMUMSTOCK.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MAXIMUMSTOCK.HeaderText = "MAXIMUMSTOCK";
            MAXIMUMSTOCK.Name = "MAXIMUMSTOCK";
            MAXIMUMSTOCK.ReadOnly = true;
            MAXIMUMSTOCK.Width = 138;
            // 
            // ORIGINALPRICE
            // 
            ORIGINALPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ORIGINALPRICE.HeaderText = "ORIGINALPRICE";
            ORIGINALPRICE.Name = "ORIGINALPRICE";
            ORIGINALPRICE.ReadOnly = true;
            ORIGINALPRICE.Width = 128;
            // 
            // RETAILPRICE
            // 
            RETAILPRICE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RETAILPRICE.HeaderText = "RETAILPRICE";
            RETAILPRICE.Name = "RETAILPRICE";
            RETAILPRICE.ReadOnly = true;
            RETAILPRICE.Width = 108;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(933, 58);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 4;
            button1.Text = "Import";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSaveExcel
            // 
            btnSaveExcel.Cursor = Cursors.Hand;
            btnSaveExcel.FlatAppearance.BorderSize = 0;
            btnSaveExcel.FlatStyle = FlatStyle.Flat;
            btnSaveExcel.Image = (Image)resources.GetObject("btnSaveExcel.Image");
            btnSaveExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveExcel.Location = new Point(1014, 58);
            btnSaveExcel.Name = "btnSaveExcel";
            btnSaveExcel.Size = new Size(75, 35);
            btnSaveExcel.TabIndex = 5;
            btnSaveExcel.Text = "Upload";
            btnSaveExcel.TextAlign = ContentAlignment.MiddleRight;
            btnSaveExcel.UseVisualStyleBackColor = true;
            btnSaveExcel.Click += btnSaveExcel_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(839, 58);
            button2.Name = "button2";
            button2.Size = new Size(88, 35);
            button2.TabIndex = 6;
            button2.Text = "Template";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(closeBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 34);
            panel1.TabIndex = 7;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.BackgroundImage = Properties.Resources.close__1_;
            closeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(1072, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 34);
            closeBtn.TabIndex = 5;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 6;
            label1.Text = "Upload Product";
            // 
            // UploadProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 541);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(btnSaveExcel);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UploadProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button btnSaveExcel;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn WAREHOUSENAME;
        private DataGridViewTextBoxColumn PRODUCTCODE;
        private DataGridViewTextBoxColumn PRODUCTNAME;
        private DataGridViewTextBoxColumn BRANDNAME;
        private DataGridViewTextBoxColumn CATEGORYNAME;
        private DataGridViewTextBoxColumn SUBCATEGORYNAME;
        private DataGridViewTextBoxColumn TYPENAME;
        private DataGridViewTextBoxColumn VARIANTNAME;
        private DataGridViewTextBoxColumn MEASUREMENT;
        private DataGridViewTextBoxColumn MEASUREMENTCOUNT;
        private DataGridViewTextBoxColumn CURRENTSTOCK;
        private DataGridViewTextBoxColumn MINIMUMSTOCK;
        private DataGridViewTextBoxColumn MAXIMUMSTOCK;
        private DataGridViewTextBoxColumn ORIGINALPRICE;
        private DataGridViewTextBoxColumn RETAILPRICE;
        private Button button2;
        private Panel panel1;
        private Button closeBtn;
        private Label label1;
    }
}