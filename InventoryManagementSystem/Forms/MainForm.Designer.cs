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
            button3 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button6 = new Button();
            mainFormCloseBtn = new Button();
            panel2 = new Panel();
            panel12 = new Panel();
            settingsBtn = new Button();
            panel11 = new Panel();
            reportBtn = new Button();
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
            button4 = new Button();
            comboBox10 = new ComboBox();
            label28 = new Label();
            textBox4 = new TextBox();
            label27 = new Label();
            label26 = new Label();
            dateTimePicker4 = new DateTimePicker();
            comboBox9 = new ComboBox();
            label25 = new Label();
            comboBox8 = new ComboBox();
            label24 = new Label();
            comboBox7 = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            dateTimePicker3 = new DateTimePicker();
            comboBox6 = new ComboBox();
            label21 = new Label();
            textBox3 = new TextBox();
            label20 = new Label();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.DimGray;
            panelBg.Controls.Add(button3);
            panelBg.Controls.Add(pictureBox2);
            panelBg.Controls.Add(label1);
            panelBg.Controls.Add(button6);
            panelBg.Controls.Add(mainFormCloseBtn);
            panelBg.Dock = DockStyle.Top;
            panelBg.Location = new Point(0, 0);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(1435, 36);
            panelBg.TabIndex = 0;
            panelBg.Paint += panelBg_Paint_2;
            panelBg.MouseMove += OnMouseDown;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1339, 0);
            button3.Name = "button3";
            button3.Size = new Size(32, 36);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            mainFormCloseBtn.BackgroundImageLayout = ImageLayout.Zoom;
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
            panel2.Controls.Add(panel11);
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
            // panel11
            // 
            panel11.Controls.Add(reportBtn);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 382);
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
            reportBtn.Click += reportBtn_Click;
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
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(button4);
            panel5.Controls.Add(comboBox10);
            panel5.Controls.Add(label28);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label27);
            panel5.Controls.Add(label26);
            panel5.Controls.Add(dateTimePicker4);
            panel5.Controls.Add(comboBox9);
            panel5.Controls.Add(label25);
            panel5.Controls.Add(comboBox8);
            panel5.Controls.Add(label24);
            panel5.Controls.Add(comboBox7);
            panel5.Controls.Add(label23);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(dateTimePicker3);
            panel5.Controls.Add(comboBox6);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label20);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(263, 36);
            panel5.Name = "panel5";
            panel5.Size = new Size(1172, 664);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint_1;
            // 
            // button4
            // 
            button4.Location = new Point(975, 398);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 37;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(122, 370);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(193, 23);
            comboBox10.TabIndex = 36;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(122, 352);
            label28.Name = "label28";
            label28.Size = new Size(44, 15);
            label28.TabIndex = 35;
            label28.Text = "label28";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(752, 316);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(298, 23);
            textBox4.TabIndex = 34;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(752, 299);
            label27.Name = "label27";
            label27.Size = new Size(44, 15);
            label27.TabIndex = 33;
            label27.Text = "label27";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(542, 299);
            label26.Name = "label26";
            label26.Size = new Size(44, 15);
            label26.TabIndex = 32;
            label26.Text = "label26";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(542, 317);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(193, 23);
            dateTimePicker4.TabIndex = 31;
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(331, 317);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(193, 23);
            comboBox9.TabIndex = 30;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(331, 299);
            label25.Name = "label25";
            label25.Size = new Size(44, 15);
            label25.TabIndex = 29;
            label25.Text = "label25";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(122, 317);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(193, 23);
            comboBox8.TabIndex = 28;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(122, 299);
            label24.Name = "label24";
            label24.Size = new Size(44, 15);
            label24.TabIndex = 27;
            label24.Text = "label24";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(752, 262);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(193, 23);
            comboBox7.TabIndex = 26;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(752, 244);
            label23.Name = "label23";
            label23.Size = new Size(44, 15);
            label23.TabIndex = 25;
            label23.Text = "label23";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(542, 244);
            label22.Name = "label22";
            label22.Size = new Size(44, 15);
            label22.TabIndex = 24;
            label22.Text = "label22";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(542, 262);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(193, 23);
            dateTimePicker3.TabIndex = 23;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(331, 262);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(193, 23);
            comboBox6.TabIndex = 22;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(331, 244);
            label21.Name = "label21";
            label21.Size = new Size(44, 15);
            label21.TabIndex = 21;
            label21.Text = "label21";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(122, 245);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 19;
            label20.Text = "label20";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1435, 745);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MainForm";
            Load += MainForm_Load_1;
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel12.ResumeLayout(false);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel6;
        private Button button1;
        private Panel panel9;
        private Button purchaseOrderBtn;
        private Button button6;
        private Button mainFormCloseBtn;
        private Button button2;
        private Panel panel10;
        private Panel panel12;
        private Button settingsBtn;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;

        private Panel panel11;
        private Button reportBtn;

        private Panel panel5;
        private Button button3;
        private Button button4;
        private ComboBox comboBox10;
        private Label label28;
        private TextBox textBox4;
        private Label label27;
        private Label label26;
        private DateTimePicker dateTimePicker4;
        private ComboBox comboBox9;
        private Label label25;
        private ComboBox comboBox8;
        private Label label24;
        private ComboBox comboBox7;
        private Label label23;
        private Label label22;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox6;
        private Label label21;
        private TextBox textBox3;
        private Label label20;
    }
}