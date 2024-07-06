namespace InventoryManagementSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelBg = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button6 = new Button();
            mainFormCloseBtn = new Button();
            panel2 = new Panel();
            panel12 = new Panel();
            settingsBtn = new Button();
            panel8 = new Panel();
            panel11 = new Panel();
            reportBtn = new Button();
            usersBtn = new Button();
            panel9 = new Panel();
            button2 = new Button();
            panel6 = new Panel();
            purchaseOrderBtn = new Button();
            panel10 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            txtPosition = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.DimGray;
            panelBg.Controls.Add(pictureBox2);
            panelBg.Controls.Add(label1);
            panelBg.Controls.Add(button6);
            panelBg.Controls.Add(mainFormCloseBtn);
            panelBg.Dock = DockStyle.Top;
            panelBg.Location = new Point(0, 0);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(1435, 36);
            panelBg.TabIndex = 0;
            panelBg.Paint += panelBg_Paint_1;
            panelBg.MouseDown += panel1_MouseDown;
            panelBg.MouseMove += panel1_MouseMove;
            panelBg.MouseUp += panel1_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 17);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management System";
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Right;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(1371, 0);
            button6.Name = "button6";
            button6.Size = new Size(32, 36);
            button6.TabIndex = 1;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // mainFormCloseBtn
            // 
            mainFormCloseBtn.BackgroundImage = (Image)resources.GetObject("mainFormCloseBtn.BackgroundImage");
            mainFormCloseBtn.BackgroundImageLayout = ImageLayout.Center;
            mainFormCloseBtn.Cursor = Cursors.Hand;
            mainFormCloseBtn.Dock = DockStyle.Right;
            mainFormCloseBtn.FlatAppearance.BorderSize = 0;
            mainFormCloseBtn.FlatStyle = FlatStyle.Flat;
            mainFormCloseBtn.Location = new Point(1403, 0);
            mainFormCloseBtn.Name = "mainFormCloseBtn";
            mainFormCloseBtn.Size = new Size(32, 36);
            mainFormCloseBtn.TabIndex = 0;
            mainFormCloseBtn.UseVisualStyleBackColor = true;
            mainFormCloseBtn.Click += mainFormCloseBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 709);
            panel2.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(settingsBtn);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 431);
            panel12.Name = "panel12";
            panel12.Size = new Size(263, 49);
            panel12.TabIndex = 6;
            // 
            // settingsBtn
            // 
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.Dock = DockStyle.Fill;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            settingsBtn.Image = (Image)resources.GetObject("settingsBtn.Image");
            settingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsBtn.Location = new Point(0, 0);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Padding = new Padding(30, 0, 0, 0);
            settingsBtn.Size = new Size(263, 49);
            settingsBtn.TabIndex = 0;
            settingsBtn.Text = "                Settings";
            settingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(usersBtn);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 382);
            panel8.Name = "panel8";
            panel8.Size = new Size(263, 49);
            panel8.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.Controls.Add(reportBtn);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(263, 49);
            panel11.TabIndex = 4;
            // 
            // reportBtn
            // 
            reportBtn.Cursor = Cursors.Hand;
            reportBtn.Dock = DockStyle.Fill;
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            reportBtn.Image = (Image)resources.GetObject("reportBtn.Image");
            reportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            reportBtn.Location = new Point(0, 0);
            reportBtn.Name = "reportBtn";
            reportBtn.Padding = new Padding(30, 0, 0, 0);
            reportBtn.Size = new Size(263, 49);
            reportBtn.TabIndex = 0;
            reportBtn.Text = "                Reports";
            reportBtn.TextAlign = ContentAlignment.MiddleLeft;
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += userBtn_Click;
            // 
            // usersBtn
            // 
            usersBtn.Dock = DockStyle.Fill;
            usersBtn.FlatAppearance.BorderSize = 0;
            usersBtn.FlatStyle = FlatStyle.Flat;
            usersBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usersBtn.Image = Properties.Resources.group__2_;
            usersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            usersBtn.Location = new Point(0, 0);
            usersBtn.Name = "usersBtn";
            usersBtn.Padding = new Padding(30, 0, 0, 0);
            usersBtn.Size = new Size(263, 49);
            usersBtn.TabIndex = 0;
            usersBtn.Text = "                Users";
            usersBtn.TextAlign = ContentAlignment.MiddleLeft;
            usersBtn.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(button2);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 333);
            panel9.Name = "panel9";
            panel9.Size = new Size(263, 49);
            panel9.TabIndex = 4;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(263, 49);
            button2.TabIndex = 0;
            button2.Text = "               Products";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(purchaseOrderBtn);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 284);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 49);
            panel6.TabIndex = 1;
            // 
            // purchaseOrderBtn
            // 
            purchaseOrderBtn.Cursor = Cursors.Hand;
            purchaseOrderBtn.Dock = DockStyle.Fill;
            purchaseOrderBtn.FlatAppearance.BorderSize = 0;
            purchaseOrderBtn.FlatStyle = FlatStyle.Flat;
            purchaseOrderBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseOrderBtn.Image = (Image)resources.GetObject("purchaseOrderBtn.Image");
            purchaseOrderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            purchaseOrderBtn.Location = new Point(0, 0);
            purchaseOrderBtn.Name = "purchaseOrderBtn";
            purchaseOrderBtn.Padding = new Padding(30, 0, 0, 0);
            purchaseOrderBtn.Size = new Size(263, 49);
            purchaseOrderBtn.TabIndex = 0;
            purchaseOrderBtn.Text = "               Purchase Order";
            purchaseOrderBtn.TextAlign = ContentAlignment.MiddleLeft;
            purchaseOrderBtn.UseVisualStyleBackColor = true;
            purchaseOrderBtn.Click += purchaseOrderBtn_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(button1);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 235);
            panel10.Name = "panel10";
            panel10.Size = new Size(263, 49);
            panel10.TabIndex = 5;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(263, 49);
            button1.TabIndex = 0;
            button1.Text = "               Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txtPosition);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 235);
            panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(233, 205);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtPosition
            // 
            txtPosition.BackColor = SystemColors.Control;
            txtPosition.BorderStyle = BorderStyle.None;
            txtPosition.Enabled = false;
            txtPosition.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPosition.ForeColor = Color.DimGray;
            txtPosition.Location = new Point(61, 192);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(145, 16);
            txtPosition.TabIndex = 2;
            txtPosition.Text = "System Administrator";
            txtPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(61, 168);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(145, 18);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "John Doe";
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(61, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(263, 700);
            panel4.Name = "panel4";
            panel4.Size = new Size(1172, 45);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(8, 13);
            label2.Name = "label2";
            label2.Size = new Size(156, 17);
            label2.TabIndex = 4;
            label2.Text = "System Version (1.1)(Test)";
            label2.Click += label2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(263, 36);
            panel5.Name = "panel5";
            panel5.Size = new Size(1172, 664);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 745);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBg;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtPosition;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
        private Panel panel9;
        private Button usersBtn;
        private Panel panel8;
        private Button purchaseOrderBtn;
        private Button button6;
        private Button mainFormCloseBtn;
        private Button button2;
        private Panel panel10;
        private Panel panel12;
        private Button settingsBtn;
        private Panel panel11;
        private Button reportBtn;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
    }
}