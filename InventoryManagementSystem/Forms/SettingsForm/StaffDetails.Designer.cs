﻿namespace InventoryManagementSystem.Forms.SettingsForm
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
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            panelBg = new Panel();
            pictureBox2 = new PictureBox();
            closeBtn = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label21 = new Label();
            comboBox2 = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtposition = new TextBox();
            btnGeneratepass = new PictureBox();
            label8 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            txtusername = new TextBox();
            label7 = new Label();
            txtfirstname = new TextBox();
            label6 = new Label();
            txtcontact = new TextBox();
            label5 = new Label();
            txtemail = new TextBox();
            label4 = new Label();
            txtlastname = new TextBox();
            label3 = new Label();
            txtmiddlename = new TextBox();
            label2 = new Label();
            txtstaffno = new TextBox();
            addBtn = new Button();
            groupBox2 = new GroupBox();
            addimage = new PictureBox();
            browseBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnGeneratepass).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addimage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(12, 414);
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
            textBox3.Location = new Point(41, 414);
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
            panelBg.Size = new Size(827, 36);
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
            closeBtn.Location = new Point(795, 0);
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
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(12, 469);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(792, 251);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtposition);
            groupBox1.Controls.Add(btnGeneratepass);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtusername);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtfirstname);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtcontact);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtlastname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtmiddlename);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtstaffno);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 354);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register Staff";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(235, 49);
            label21.Name = "label21";
            label21.Size = new Size(30, 15);
            label21.TabIndex = 38;
            label21.Text = "Role";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Administrator", "Users" });
            comboBox2.Location = new Point(234, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 25);
            comboBox2.TabIndex = 37;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(263, 49);
            label20.Name = "label20";
            label20.Size = new Size(13, 15);
            label20.TabIndex = 36;
            label20.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(289, 280);
            label19.Name = "label19";
            label19.Size = new Size(13, 15);
            label19.TabIndex = 34;
            label19.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(293, 222);
            label18.Name = "label18";
            label18.Size = new Size(13, 15);
            label18.TabIndex = 33;
            label18.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(325, 166);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 32;
            label17.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(268, 103);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 31;
            label16.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(67, 280);
            label15.Name = "label15";
            label15.Size = new Size(13, 15);
            label15.TabIndex = 30;
            label15.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(83, 221);
            label14.Name = "label14";
            label14.Size = new Size(13, 15);
            label14.TabIndex = 29;
            label14.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(69, 163);
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
            label12.Location = new Point(57, 103);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 27;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(83, 49);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 26;
            label11.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(9, 103);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 19;
            label10.Text = "Position";
            // 
            // txtposition
            // 
            txtposition.Location = new Point(9, 123);
            txtposition.Name = "txtposition";
            txtposition.Size = new Size(203, 25);
            txtposition.TabIndex = 18;
            // 
            // btnGeneratepass
            // 
            btnGeneratepass.Cursor = Cursors.Hand;
            btnGeneratepass.Image = (Image)resources.GetObject("btnGeneratepass.Image");
            btnGeneratepass.Location = new Point(444, 301);
            btnGeneratepass.Name = "btnGeneratepass";
            btnGeneratepass.Size = new Size(24, 24);
            btnGeneratepass.SizeMode = PictureBoxSizeMode.AutoSize;
            btnGeneratepass.TabIndex = 17;
            btnGeneratepass.TabStop = false;
            btnGeneratepass.Click += btnGeneratepass_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(235, 281);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 15;
            label8.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(235, 301);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(203, 25);
            txtPassword.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(235, 222);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 13;
            label9.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(235, 242);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(203, 25);
            txtusername.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 161);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 11;
            label7.Text = "First name";
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(8, 181);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(203, 25);
            txtfirstname.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(235, 164);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 9;
            label6.Text = "Contact number";
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(235, 184);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(203, 25);
            txtcontact.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(235, 103);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(235, 123);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(203, 25);
            txtemail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 278);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Last name";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(9, 298);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(203, 25);
            txtlastname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 219);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 3;
            label3.Text = "Middle name";
            // 
            // txtmiddlename
            // 
            txtmiddlename.Location = new Point(9, 239);
            txtmiddlename.Name = "txtmiddlename";
            txtmiddlename.Size = new Size(203, 25);
            txtmiddlename.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 49);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Staff number";
            // 
            // txtstaffno
            // 
            txtstaffno.Location = new Point(8, 69);
            txtstaffno.Name = "txtstaffno";
            txtstaffno.Size = new Size(203, 25);
            txtstaffno.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(92, 184, 92);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.WhiteSmoke;
            addBtn.Location = new Point(725, 343);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(79, 27);
            addBtn.TabIndex = 16;
            addBtn.Text = "Register";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(addimage);
            groupBox2.Controls.Add(browseBtn);
            groupBox2.Controls.Add(deleteBtn);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(540, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 259);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Profile Picture";
            // 
            // addimage
            // 
            addimage.BackColor = SystemColors.ControlLight;
            addimage.Location = new Point(49, 36);
            addimage.Name = "addimage";
            addimage.Size = new Size(170, 170);
            addimage.SizeMode = PictureBoxSizeMode.Zoom;
            addimage.TabIndex = 21;
            addimage.TabStop = false;
            // 
            // browseBtn
            // 
            browseBtn.BackColor = Color.Transparent;
            browseBtn.Cursor = Cursors.Hand;
            browseBtn.FlatAppearance.BorderSize = 0;
            browseBtn.FlatStyle = FlatStyle.Flat;
            browseBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            browseBtn.ForeColor = Color.WhiteSmoke;
            browseBtn.Image = (Image)resources.GetObject("browseBtn.Image");
            browseBtn.Location = new Point(106, 212);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(30, 30);
            browseBtn.TabIndex = 22;
            browseBtn.UseVisualStyleBackColor = false;
            browseBtn.Click += browseBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Transparent;
            deleteBtn.BackgroundImage = (Image)resources.GetObject("deleteBtn.BackgroundImage");
            deleteBtn.BackgroundImageLayout = ImageLayout.Center;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.WhiteSmoke;
            deleteBtn.Location = new Point(142, 212);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(32, 30);
            deleteBtn.TabIndex = 23;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // StaffDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 732);
            Controls.Add(addBtn);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffDetails";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDetails";
            Load += StaffDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnGeneratepass).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Panel panelBg;
        private PictureBox pictureBox2;
        private Button closeBtn;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox1;
        private Label label21;
        private ComboBox comboBox2;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtposition;
        private PictureBox btnGeneratepass;
        private Label label8;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtusername;
        private Label label7;
        private TextBox txtfirstname;
        private Label label6;
        private TextBox txtcontact;
        private Label label5;
        private TextBox txtemail;
        private Label label4;
        private TextBox txtlastname;
        private Label label3;
        private TextBox txtmiddlename;
        private Label label2;
        private TextBox txtstaffno;
        private Button addBtn;
        private GroupBox groupBox2;
        private PictureBox addimage;
        private Button browseBtn;
        private Button deleteBtn;
    }
}