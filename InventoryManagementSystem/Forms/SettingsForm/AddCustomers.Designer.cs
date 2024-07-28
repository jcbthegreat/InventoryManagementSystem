namespace InventoryManagementSystem.Forms.SettingsForm
{
    partial class AddCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelBg = new Panel();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            label1 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            addBtn = new Button();
            pictureBox2 = new PictureBox();
            txtFilter = new TextBox();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            btnUpdate = new Button();
            label21 = new Label();
            comboBox1 = new ComboBox();
            label20 = new Label();
            label16 = new Label();
            label13 = new Label();
            label12 = new Label();
            label22 = new Label();
            label23 = new Label();
            txtemail = new TextBox();
            label26 = new Label();
            txtcontact = new TextBox();
            label27 = new Label();
            txtdiscount = new TextBox();
            label28 = new Label();
            txtaddress = new TextBox();
            label31 = new Label();
            textfullname = new TextBox();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.DimGray;
            panelBg.Controls.Add(pictureBox1);
            panelBg.Controls.Add(closeBtn);
            panelBg.Controls.Add(label1);
            panelBg.Dock = DockStyle.Top;
            panelBg.Location = new Point(0, 0);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(806, 36);
            panelBg.TabIndex = 4;
            panelBg.Paint += panelBg_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = Properties.Resources.close__1_;
            closeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(774, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(32, 36);
            closeBtn.TabIndex = 1;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(85, 359);
            label10.Name = "label10";
            label10.Size = new Size(52, 13);
            label10.TabIndex = 27;
            label10.Text = "(optional)";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(240, 85);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(554, 275);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer List";
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
            dataGridView1.Location = new Point(3, 18);
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
            dataGridView1.Size = new Size(548, 254);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(92, 184, 92);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.WhiteSmoke;
            addBtn.Location = new Point(9, 478);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(79, 27);
            addBtn.TabIndex = 6;
            addBtn.Text = "Register";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(553, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilter.ForeColor = SystemColors.WindowText;
            txtFilter.Location = new Point(582, 54);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Search";
            txtFilter.Size = new Size(212, 25);
            txtFilter.TabIndex = 31;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(txtcontact);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(txtdiscount);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Controls.Add(label31);
            groupBox1.Controls.Add(textfullname);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 511);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register Customer";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(9, 437);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 25);
            comboBox2.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(58, 419);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 42;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 419);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 40;
            label3.Text = "IsActive";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(91, 192, 222);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(102, 478);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 27);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(8, 79);
            label21.Name = "label21";
            label21.Size = new Size(30, 15);
            label21.TabIndex = 38;
            label21.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(7, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 25);
            comboBox1.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(36, 79);
            label20.Name = "label20";
            label20.Size = new Size(13, 15);
            label20.TabIndex = 36;
            label20.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(55, 250);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 31;
            label16.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(101, 193);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 28;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(41, 136);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 27;
            label12.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(95, 25);
            label22.Name = "label22";
            label22.Size = new Size(13, 15);
            label22.TabIndex = 26;
            label22.Text = "*";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(8, 136);
            label23.Name = "label23";
            label23.Size = new Size(36, 15);
            label23.TabIndex = 19;
            label23.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(8, 156);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(203, 25);
            txtemail.TabIndex = 2;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(8, 358);
            label26.Name = "label26";
            label26.Size = new Size(80, 15);
            label26.TabIndex = 11;
            label26.Text = "Add Discount";
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(7, 213);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(203, 25);
            txtcontact.TabIndex = 4;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(8, 193);
            label27.Name = "label27";
            label27.Size = new Size(93, 15);
            label27.TabIndex = 9;
            label27.Text = "Contact number";
            // 
            // txtdiscount
            // 
            txtdiscount.Location = new Point(9, 381);
            txtdiscount.MaxLength = 11;
            txtdiscount.Name = "txtdiscount";
            txtdiscount.Size = new Size(203, 25);
            txtdiscount.TabIndex = 5;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(8, 250);
            label28.Name = "label28";
            label28.Size = new Size(49, 15);
            label28.TabIndex = 7;
            label28.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(8, 270);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(203, 83);
            txtaddress.TabIndex = 3;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label31.Location = new Point(8, 25);
            label31.Name = "label31";
            label31.Size = new Size(91, 15);
            label31.TabIndex = 1;
            label31.Text = "Customer name";
            // 
            // textfullname
            // 
            textfullname.Location = new Point(8, 45);
            textfullname.Name = "textfullname";
            textfullname.Size = new Size(203, 25);
            textfullname.TabIndex = 0;
            // 
            // AddCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 578);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(panelBg);
            Controls.Add(txtFilter);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomers";
            Load += AddCustomers_Load;
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBg;
        private Button closeBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label10;
        private GroupBox groupBox3;
        private Button addBtn;
        private PictureBox pictureBox2;
        private TextBox txtFilter;
        private GroupBox groupBox1;
        private Label label21;
        private ComboBox comboBox1;
        private Label label20;
        private Label label16;
        private Label label13;
        private Label label12;
        private Label label22;
        private Label label23;
        private TextBox txtemail;
        private Label label26;
        private TextBox txtcontact;
        private Label label27;
        private TextBox txtdiscount;
        private Label label28;
        private TextBox txtaddress;
        private Label label31;
        private TextBox textfullname;
        private Button btnUpdate;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
    }
}