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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUserControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label9 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            additem = new Button();
            button1 = new Button();
            addBtnFrm = new Button();
            deleteProdBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 51);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(790, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(829, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Quick Search";
            textBox1.Size = new Size(325, 18);
            textBox1.TabIndex = 2;
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
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 607);
            panel2.TabIndex = 1;
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
            dataGridView1.Size = new Size(1172, 530);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 530);
            panel3.Name = "panel3";
            panel3.Size = new Size(1172, 77);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(additem);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(addBtnFrm);
            panel4.Controls.Add(deleteProdBtn);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(658, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(514, 77);
            panel4.TabIndex = 2;
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
            additem.Location = new Point(141, 21);
            additem.Name = "additem";
            additem.Size = new Size(116, 33);
            additem.TabIndex = 3;
            additem.Text = "    Add Item";
            additem.UseVisualStyleBackColor = false;
            additem.Click += additem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(91, 192, 222);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(263, 21);
            button1.Name = "button1";
            button1.Size = new Size(115, 33);
            button1.TabIndex = 2;
            button1.Text = "  Update Product";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
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
            addBtnFrm.Location = new Point(19, 21);
            addBtnFrm.Name = "addBtnFrm";
            addBtnFrm.Size = new Size(116, 33);
            addBtnFrm.TabIndex = 0;
            addBtnFrm.Text = "    Add Product";
            addBtnFrm.UseVisualStyleBackColor = false;
            addBtnFrm.Click += addBtnFrm_Click;
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
            deleteProdBtn.Location = new Point(384, 21);
            deleteProdBtn.Name = "deleteProdBtn";
            deleteProdBtn.Size = new Size(112, 33);
            deleteProdBtn.TabIndex = 1;
            deleteProdBtn.Text = "Delete Product";
            deleteProdBtn.TextAlign = ContentAlignment.MiddleRight;
            deleteProdBtn.UseVisualStyleBackColor = false;
            deleteProdBtn.Click += deleteProdBtn_Click;
            // 
            // ProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductUserControl";
            Size = new Size(1172, 658);
            Load += ProductUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label9;
        private Panel panel3;
        private Button deleteProdBtn;
        private Button addBtnFrm;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button button1;
        private Button additem;
    }
}
