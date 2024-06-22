﻿namespace InventoryManagementSystem.Forms
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            panelBg = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            browseImageBtn = new Button();
            deleteImageBtn = new Button();
            saveProductBtn = new Button();
            cancelBtn = new Button();
            groupBox1 = new GroupBox();
            label13 = new Label();
            comboBox6 = new ComboBox();
            label12 = new Label();
            comboBox5 = new ComboBox();
            label10 = new Label();
            comboBox4 = new ComboBox();
            textBox3 = new TextBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox7 = new TextBox();
            groupBox2 = new GroupBox();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.DimGray;
            panelBg.Controls.Add(pictureBox2);
            panelBg.Controls.Add(label9);
            panelBg.Dock = DockStyle.Top;
            panelBg.Location = new Point(0, 0);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(970, 37);
            panelBg.TabIndex = 1;
            panelBg.Paint += panelBg_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(38, 9);
            label9.Name = "label9";
            label9.Size = new Size(116, 17);
            label9.TabIndex = 0;
            label9.Text = "Add New Product";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 127);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(193, 28);
            comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(441, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 27);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(441, 46);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 8;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 293);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 9;
            label2.Text = "Purchase Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(228, 293);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 10;
            label3.Text = "Sales Price / Rate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 109);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 11;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 46);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 12;
            label5.Text = "Brand";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 227);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "Min Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(228, 227);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 15;
            label7.Text = "Max Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(228, 46);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 17;
            label8.Text = "Product Code";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(42, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
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
            browseImageBtn.Location = new Point(82, 182);
            browseImageBtn.Name = "browseImageBtn";
            browseImageBtn.Size = new Size(30, 30);
            browseImageBtn.TabIndex = 19;
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
            deleteImageBtn.Location = new Point(118, 182);
            deleteImageBtn.Name = "deleteImageBtn";
            deleteImageBtn.Size = new Size(32, 30);
            deleteImageBtn.TabIndex = 20;
            deleteImageBtn.UseVisualStyleBackColor = false;
            deleteImageBtn.Click += deleteImageBtn_Click;
            // 
            // saveProductBtn
            // 
            saveProductBtn.BackColor = Color.FromArgb(92, 184, 92);
            saveProductBtn.Cursor = Cursors.Hand;
            saveProductBtn.FlatAppearance.BorderSize = 0;
            saveProductBtn.FlatStyle = FlatStyle.Flat;
            saveProductBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveProductBtn.ForeColor = Color.WhiteSmoke;
            saveProductBtn.Location = new Point(383, 378);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(123, 31);
            saveProductBtn.TabIndex = 22;
            saveProductBtn.Text = "Save";
            saveProductBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(217, 83, 79);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(512, 378);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(123, 31);
            cancelBtn.TabIndex = 23;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(cancelBtn);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(saveProductBtn);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 439);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(15, 169);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 35;
            label13.Text = "Variant";
            // 
            // comboBox6
            // 
            comboBox6.Cursor = Cursors.Hand;
            comboBox6.FlatStyle = FlatStyle.Flat;
            comboBox6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(15, 187);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(195, 28);
            comboBox6.TabIndex = 34;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(441, 109);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 33;
            label12.Text = "Type";
            // 
            // comboBox5
            // 
            comboBox5.Cursor = Cursors.Hand;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(441, 127);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(195, 28);
            comboBox5.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(228, 109);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 31;
            label10.Text = "Sub Category";
            // 
            // comboBox4
            // 
            comboBox4.Cursor = Cursors.Hand;
            comboBox4.FlatStyle = FlatStyle.Flat;
            comboBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(228, 127);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(195, 28);
            comboBox4.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(441, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 27);
            textBox3.TabIndex = 29;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(228, 169);
            label11.Name = "label11";
            label11.Size = new Size(119, 15);
            label11.TabIndex = 28;
            label11.Text = "Unit of Measurement";
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(228, 187);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(195, 28);
            comboBox3.TabIndex = 26;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(228, 247);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(195, 27);
            textBox9.TabIndex = 25;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(228, 313);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(195, 27);
            textBox8.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(15, 247);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(195, 27);
            textBox6.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(228, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(15, 313);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(195, 27);
            textBox7.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(browseImageBtn);
            groupBox2.Controls.Add(deleteImageBtn);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(702, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 235);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Product Image";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 589);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "a";
            Load += AddProductForm_Load;
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBg;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private Button browseImageBtn;
        private Button deleteImageBtn;
        private Button saveProductBtn;
        private Button cancelBtn;
        private GroupBox groupBox1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox6;
        private TextBox textBox2;
        private TextBox textBox7;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private Label label11;
        private Label label12;
        private ComboBox comboBox5;
        private Label label10;
        private ComboBox comboBox4;
        private Label label13;
        private ComboBox comboBox6;
    }
}