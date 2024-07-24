namespace InventoryManagementSystem.Forms
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            panelBg = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            txtcurstock = new TextBox();
            label4 = new Label();
            txtretprice = new TextBox();
            label6 = new Label();
            txtorigprice = new TextBox();
            label3 = new Label();
            txtmaxstock = new TextBox();
            label2 = new Label();
            txtminstock = new TextBox();
            label1 = new Label();
            cancelBtn = new Button();
            saveItemBtn = new Button();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
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
            panelBg.Size = new Size(471, 37);
            panelBg.TabIndex = 2;
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
            label9.Size = new Size(104, 17);
            label9.TabIndex = 0;
            label9.Text = "Update Product";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtcurstock);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtretprice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtorigprice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtmaxstock);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtminstock);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cancelBtn);
            groupBox1.Controls.Add(saveItemBtn);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 351);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Product Item";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(195, 23);
            comboBox2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(15, 166);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 33;
            label8.Text = "Current Stock";
            // 
            // txtcurstock
            // 
            txtcurstock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtcurstock.Location = new Point(15, 184);
            txtcurstock.Name = "txtcurstock";
            txtcurstock.Size = new Size(195, 23);
            txtcurstock.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 226);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 31;
            label4.Text = "Retail Price";
            // 
            // txtretprice
            // 
            txtretprice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtretprice.Location = new Point(15, 244);
            txtretprice.Name = "txtretprice";
            txtretprice.Size = new Size(195, 23);
            txtretprice.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(228, 166);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 29;
            label6.Text = "Original Price";
            // 
            // txtorigprice
            // 
            txtorigprice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtorigprice.Location = new Point(228, 184);
            txtorigprice.Name = "txtorigprice";
            txtorigprice.Size = new Size(195, 23);
            txtorigprice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(228, 107);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 27;
            label3.Text = "Maximum Stock";
            // 
            // txtmaxstock
            // 
            txtmaxstock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtmaxstock.Location = new Point(228, 125);
            txtmaxstock.Name = "txtmaxstock";
            txtmaxstock.Size = new Size(195, 23);
            txtmaxstock.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 107);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 25;
            label2.Text = "Minimum Stock";
            // 
            // txtminstock
            // 
            txtminstock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtminstock.Location = new Point(15, 125);
            txtminstock.Name = "txtminstock";
            txtminstock.Size = new Size(195, 23);
            txtminstock.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Product Code";
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(217, 83, 79);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(144, 295);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(123, 31);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveItemBtn
            // 
            saveItemBtn.BackColor = Color.FromArgb(92, 184, 92);
            saveItemBtn.Cursor = Cursors.Hand;
            saveItemBtn.FlatAppearance.BorderSize = 0;
            saveItemBtn.FlatStyle = FlatStyle.Flat;
            saveItemBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveItemBtn.ForeColor = Color.WhiteSmoke;
            saveItemBtn.Location = new Point(15, 295);
            saveItemBtn.Name = "saveItemBtn";
            saveItemBtn.Size = new Size(123, 31);
            saveItemBtn.TabIndex = 7;
            saveItemBtn.Text = "Update";
            saveItemBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 421);
            Controls.Add(groupBox1);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBg;
        private PictureBox pictureBox2;
        private Label label9;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox txtcurstock;
        private Label label4;
        private TextBox txtretprice;
        private Label label6;
        private TextBox txtorigprice;
        private Label label3;
        private TextBox txtmaxstock;
        private Label label2;
        private TextBox txtminstock;
        private Label label1;
        private Button cancelBtn;
        private Button saveItemBtn;
    }
}