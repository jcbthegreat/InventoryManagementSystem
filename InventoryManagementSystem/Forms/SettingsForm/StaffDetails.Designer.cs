namespace InventoryManagementSystem.Forms.SettingsForm
{
    partial class StaffDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDetails));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            panelBg = new Panel();
            pictureBox2 = new PictureBox();
            closeBtn = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 100);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(943, 37);
            button1.Name = "button1";
            button1.Size = new Size(98, 44);
            button1.TabIndex = 23;
            button1.Text = "Add Staff";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(18, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.WindowText;
            textBox3.Location = new Point(47, 48);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Search Staff";
            textBox3.Size = new Size(212, 25);
            textBox3.TabIndex = 21;
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.DimGray;
            panelBg.Controls.Add(pictureBox2);
            panelBg.Controls.Add(closeBtn);
            panelBg.Controls.Add(label1);
            panelBg.Dock = DockStyle.Top;
            panelBg.Location = new Point(0, 0);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(1055, 36);
            panelBg.TabIndex = 5;
            panelBg.Paint += panelBg_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = Properties.Resources.close__1_;
            closeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(1023, 0);
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
            label1.Location = new Point(41, 11);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Staff List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column7, Column1, Column8, Column9, Column3, Column2, Column4, Column10, Column5, Column6 });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(18, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1023, 438);
            dataGridView1.TabIndex = 7;
            // 
            // Column7
            // 
            Column7.HeaderText = "Staff No";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "First name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Middle name";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Last name";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Email";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Contact Number";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Address";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column10
            // 
            Column10.HeaderText = "Username";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            Column5.DefaultCellStyle = dataGridViewCellStyle2;
            Column5.Description = "Edit";
            Column5.HeaderText = "";
            Column5.Image = Properties.Resources.pencil__1_;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.ToolTipText = "Edit";
            Column5.Width = 5;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "";
            Column6.Image = Properties.Resources.pencil__1_;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.ToolTipText = "Delete";
            Column6.Width = 5;
            // 
            // StaffDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 592);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffDetails";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDetails";
            Load += StaffDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Panel panelBg;
        private PictureBox pictureBox2;
        private Button closeBtn;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
    }
}