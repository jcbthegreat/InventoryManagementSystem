namespace InventoryManagementSystem.Forms
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            groupBox1 = new GroupBox();
            txtnewpass = new TextBox();
            npassword = new Label();
            txtuser = new TextBox();
            username = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            browseImageBtn = new Button();
            deleteImageBtn = new Button();
            btn_save = new Button();
            btn_close = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtnewpass);
            groupBox1.Controls.Add(npassword);
            groupBox1.Controls.Add(txtuser);
            groupBox1.Controls.Add(username);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Profile";
            // 
            // txtnewpass
            // 
            txtnewpass.Location = new Point(17, 148);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.PasswordChar = '*';
            txtnewpass.Size = new Size(208, 25);
            txtnewpass.TabIndex = 3;
            // 
            // npassword
            // 
            npassword.AutoSize = true;
            npassword.Location = new Point(17, 128);
            npassword.Name = "npassword";
            npassword.Size = new Size(97, 17);
            npassword.TabIndex = 2;
            npassword.Text = "New Password";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(17, 83);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(208, 25);
            txtuser.TabIndex = 1;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(17, 63);
            username.Name = "username";
            username.Size = new Size(69, 17);
            username.TabIndex = 0;
            username.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(browseImageBtn);
            groupBox2.Controls.Add(deleteImageBtn);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(285, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(48, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 161);
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
            browseImageBtn.Location = new Point(88, 198);
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
            deleteImageBtn.Location = new Point(124, 198);
            deleteImageBtn.Name = "deleteImageBtn";
            deleteImageBtn.Size = new Size(32, 30);
            deleteImageBtn.TabIndex = 23;
            deleteImageBtn.UseVisualStyleBackColor = false;
            deleteImageBtn.Click += deleteImageBtn_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(92, 184, 92);
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(316, 277);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(100, 37);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.FromArgb(217, 83, 79);
            btn_close.Cursor = Cursors.Hand;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(425, 277);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(100, 37);
            btn_close.TabIndex = 3;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 327);
            Controls.Add(btn_close);
            Controls.Add(btn_save);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            Load += EditProfile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Button browseImageBtn;
        private Button deleteImageBtn;
        private TextBox txtnewpass;
        private Label npassword;
        private TextBox txtuser;
        private Label username;
        private Button btn_save;
        private Button btn_close;
    }
}