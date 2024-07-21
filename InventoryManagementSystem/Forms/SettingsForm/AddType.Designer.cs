namespace InventoryManagementSystem.Forms.SettingsForm
{
    partial class AddType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddType));
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtType = new TextBox();
            label8 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            addBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            DescTxt = new TextBox();
            panelBg = new Panel();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(445, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(474, 71);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(212, 25);
            textBox1.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(279, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 277);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "List Of Types";
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
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(6, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(395, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(DescTxt);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 321);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Type";
            // 
            // txtType
            // 
            txtType.Location = new Point(18, 150);
            txtType.Name = "txtType";
            txtType.Size = new Size(204, 23);
            txtType.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(47, 127);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 30;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 129);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 29;
            label9.Text = "Type";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(18, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 23);
            comboBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(113, 37);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 25;
            label4.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(85, 176);
            label7.Name = "label7";
            label7.Size = new Size(52, 13);
            label7.TabIndex = 22;
            label7.Text = "(optional)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 37);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 24;
            label6.Text = "Choose Category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 23);
            comboBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(130, 83);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 21;
            label5.Text = "*";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(92, 184, 92);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.WhiteSmoke;
            addBtn.Location = new Point(18, 271);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(90, 27);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 83);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 8;
            label2.Text = "Sub Category Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 175);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 10;
            label3.Text = "Description";
            // 
            // DescTxt
            // 
            DescTxt.BackColor = SystemColors.Window;
            DescTxt.Location = new Point(18, 193);
            DescTxt.Multiline = true;
            DescTxt.Name = "DescTxt";
            DescTxt.Size = new Size(204, 72);
            DescTxt.TabIndex = 3;
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
            panelBg.Size = new Size(697, 36);
            panelBg.TabIndex = 27;
            panelBg.Paint += panelBg_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
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
            closeBtn.Location = new Point(665, 0);
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
            label1.Location = new Point(42, 11);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Type Method";
            // 
            // AddType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 418);
            Controls.Add(panelBg);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddType";
            Load += AddType_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        public DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button addBtn;
        private Label label2;
        private Label label3;
        //private TextBox TypeName;
        private TextBox DescTxt;
        private Panel panelBg;
        private PictureBox pictureBox1;
        private Button closeBtn;
        private Label label1;
        private Label label8;
        private Label label9;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox txtType;
    }
}