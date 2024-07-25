namespace InventoryManagementSystem.Forms
{
    partial class ProductUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            textBox1 = new TextBox();
            button3 = new Button();
            label9 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            additem = new Button();
            addBtnFrm = new Button();
            updateProd = new Button();
            deleteProdBtn = new Button();
            panel7 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 51);
            panel1.TabIndex = 38;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(128, 15);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 35;
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(textBox1);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(682, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(431, 51);
            panel6.TabIndex = 34;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.search;
            pictureBox5.Location = new Point(31, 15);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(70, 21);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Quick Search";
            textBox1.Size = new Size(325, 18);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(89, 15);
            button3.Name = "button3";
            button3.Size = new Size(33, 29);
            button3.TabIndex = 33;
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(4, 15);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 1;
            label9.Text = "Product";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 547);
            panel2.Name = "panel2";
            panel2.Size = new Size(1113, 53);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.Controls.Add(additem);
            panel3.Controls.Add(addBtnFrm);
            panel3.Controls.Add(updateProd);
            panel3.Controls.Add(deleteProdBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(588, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(525, 53);
            panel3.TabIndex = 3;
            // 
            // additem
            // 
            additem.BackColor = Color.FromArgb(92, 184, 92);
            additem.BackgroundImageLayout = ImageLayout.Center;
            additem.Cursor = Cursors.Hand;
            additem.FlatAppearance.BorderSize = 0;
            additem.FlatStyle = FlatStyle.Flat;
            additem.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            additem.ForeColor = Color.WhiteSmoke;
            additem.Image = (Image)resources.GetObject("additem.Image");
            additem.ImageAlign = ContentAlignment.MiddleLeft;
            additem.Location = new Point(144, 11);
            additem.Name = "additem";
            additem.Size = new Size(128, 33);
            additem.TabIndex = 40;
            additem.Text = "    Add Item";
            additem.UseVisualStyleBackColor = false;
            // 
            // addBtnFrm
            // 
            addBtnFrm.BackColor = Color.FromArgb(92, 184, 92);
            addBtnFrm.Cursor = Cursors.Hand;
            addBtnFrm.FlatAppearance.BorderSize = 0;
            addBtnFrm.FlatStyle = FlatStyle.Flat;
            addBtnFrm.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBtnFrm.ForeColor = Color.WhiteSmoke;
            addBtnFrm.Image = (Image)resources.GetObject("addBtnFrm.Image");
            addBtnFrm.ImageAlign = ContentAlignment.MiddleLeft;
            addBtnFrm.Location = new Point(8, 11);
            addBtnFrm.Name = "addBtnFrm";
            addBtnFrm.Size = new Size(130, 33);
            addBtnFrm.TabIndex = 37;
            addBtnFrm.Text = "    Add Product";
            addBtnFrm.UseVisualStyleBackColor = false;
            // 
            // updateProd
            // 
            updateProd.BackColor = Color.FromArgb(0, 133, 216);
            updateProd.Cursor = Cursors.Hand;
            updateProd.FlatAppearance.BorderSize = 0;
            updateProd.FlatStyle = FlatStyle.Flat;
            updateProd.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            updateProd.ForeColor = Color.WhiteSmoke;
            updateProd.Image = (Image)resources.GetObject("updateProd.Image");
            updateProd.ImageAlign = ContentAlignment.MiddleLeft;
            updateProd.Location = new Point(278, 11);
            updateProd.Name = "updateProd";
            updateProd.Size = new Size(120, 33);
            updateProd.TabIndex = 39;
            updateProd.Text = "    Update Product";
            updateProd.TextAlign = ContentAlignment.MiddleRight;
            updateProd.UseVisualStyleBackColor = false;
            // 
            // deleteProdBtn
            // 
            deleteProdBtn.BackColor = Color.FromArgb(217, 83, 79);
            deleteProdBtn.Cursor = Cursors.Hand;
            deleteProdBtn.FlatAppearance.BorderSize = 0;
            deleteProdBtn.FlatStyle = FlatStyle.Flat;
            deleteProdBtn.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteProdBtn.ForeColor = Color.WhiteSmoke;
            deleteProdBtn.Image = (Image)resources.GetObject("deleteProdBtn.Image");
            deleteProdBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteProdBtn.Location = new Point(404, 11);
            deleteProdBtn.Name = "deleteProdBtn";
            deleteProdBtn.Size = new Size(114, 33);
            deleteProdBtn.TabIndex = 38;
            deleteProdBtn.Text = "Delete Product";
            deleteProdBtn.TextAlign = ContentAlignment.MiddleRight;
            deleteProdBtn.UseVisualStyleBackColor = false;
            deleteProdBtn.Click += deleteProdBtn_Click;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel7.Controls.Add(dataGridView1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 51);
            panel7.Name = "panel7";
            panel7.Size = new Size(1113, 496);
            panel7.TabIndex = 40;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1113, 496);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // ProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductUserControl";
            Size = new Size(1113, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private Label label9;
        private Panel panel2;
        private Panel panel3;
        private Panel panel7;
        private DataGridView dataGridView1;
        private Button additem;
        private Button updateProd;
        private Button addBtnFrm;
        private Button deleteProdBtn;
        private Button button3;
        private Panel panel6;
        private Button button1;
    }
}
