namespace InventoryManagementSystem.Forms.SettingsForm
{
    partial class AddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaff));
            panelBg = new Panel();
            pictureBox2 = new PictureBox();
            closeBtn = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnGenerate = new PictureBox();
            label8 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            browseImageBtn = new Button();
            deleteImageBtn = new Button();
            addBtn = new Button();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnGenerate).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panelBg.Size = new Size(975, 36);
            panelBg.TabIndex = 6;
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
            closeBtn.Location = new Point(943, 0);
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
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Staff";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 323);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register Staff";
            // 
            // btnGenerate
            // 
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Image = (Image)resources.GetObject("btnGenerate.Image");
            btnGenerate.Location = new Point(433, 262);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(24, 24);
            btnGenerate.SizeMode = PictureBoxSizeMode.AutoSize;
            btnGenerate.TabIndex = 17;
            btnGenerate.TabStop = false;
            btnGenerate.Click += btnGenerate_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(225, 242);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 15;
            label8.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(225, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(203, 25);
            txtPassword.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 242);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 13;
            label9.Text = "Username";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(8, 262);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(203, 25);
            textBox8.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 110);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 11;
            label7.Text = "First name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(8, 130);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(203, 25);
            textBox6.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(225, 172);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 9;
            label6.Text = "Contact number";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(225, 192);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(203, 25);
            textBox5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 172);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(8, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 25);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(444, 110);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Last name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(444, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 25);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(225, 110);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 3;
            label3.Text = "Middle name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 25);
            textBox2.TabIndex = 2;
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
            // textBox1
            // 
            textBox1.Location = new Point(8, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 25);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(browseImageBtn);
            groupBox2.Controls.Add(deleteImageBtn);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(699, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 259);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Profile Picture";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(49, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // browseImageBtn
            // 
            browseImageBtn.BackColor = Color.Transparent;
            browseImageBtn.Cursor = Cursors.Hand;
            browseImageBtn.FlatAppearance.BorderSize = 0;
            browseImageBtn.FlatStyle = FlatStyle.Flat;
            browseImageBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            browseImageBtn.ForeColor = Color.WhiteSmoke;
            browseImageBtn.Image = (Image)resources.GetObject("browseImageBtn.Image");
            browseImageBtn.Location = new Point(106, 212);
            browseImageBtn.Name = "browseImageBtn";
            browseImageBtn.Size = new Size(30, 30);
            browseImageBtn.TabIndex = 22;
            browseImageBtn.UseVisualStyleBackColor = false;
            browseImageBtn.Click += browseImageBtn_Click;
            // 
            // deleteImageBtn
            // 
            deleteImageBtn.BackColor = Color.Transparent;
            deleteImageBtn.BackgroundImage = (Image)resources.GetObject("deleteImageBtn.BackgroundImage");
            deleteImageBtn.BackgroundImageLayout = ImageLayout.Center;
            deleteImageBtn.Cursor = Cursors.Hand;
            deleteImageBtn.FlatAppearance.BorderSize = 0;
            deleteImageBtn.FlatStyle = FlatStyle.Flat;
            deleteImageBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteImageBtn.ForeColor = Color.WhiteSmoke;
            deleteImageBtn.Location = new Point(142, 212);
            deleteImageBtn.Name = "deleteImageBtn";
            deleteImageBtn.Size = new Size(32, 30);
            deleteImageBtn.TabIndex = 23;
            deleteImageBtn.UseVisualStyleBackColor = false;
            deleteImageBtn.Click += deleteImageBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(92, 184, 92);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.WhiteSmoke;
            addBtn.Location = new Point(884, 370);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(79, 27);
            addBtn.TabIndex = 14;
            addBtn.Text = "Register";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 475);
            Controls.Add(addBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStaff";
            Load += AddStaff_Load;
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnGenerate).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBg;
        private PictureBox pictureBox2;
        private Button closeBtn;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label8;
        private TextBox txtPassword;
        private Label label9;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Button addBtn;
        private PictureBox pictureBox1;
        private Button browseImageBtn;
        private Button deleteImageBtn;
        private PictureBox btnGenerate;
    }
}