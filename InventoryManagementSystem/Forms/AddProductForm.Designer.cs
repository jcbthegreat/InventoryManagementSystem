namespace InventoryManagementSystem.Forms
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
            groupBox1 = new GroupBox();
            label13 = new Label();
            comboBox6 = new ComboBox();
            label12 = new Label();
            comboBox5 = new ComboBox();
            label10 = new Label();
            comboBox4 = new ComboBox();
            unit_count = new TextBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label1 = new Label();
            txtprodname = new TextBox();
            cancelBtn = new Button();
            saveProductBtn = new Button();
            txtprodcode = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
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
            panelBg.Size = new Size(686, 37);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(unit_count);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtprodname);
            groupBox1.Controls.Add(cancelBtn);
            groupBox1.Controls.Add(saveProductBtn);
            groupBox1.Controls.Add(txtprodcode);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 303);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            groupBox1.Enter += groupBox1_Enter_1;
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
            comboBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(228, 186);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(195, 23);
            comboBox6.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(446, 109);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 33;
            label12.Text = "Type";
            // 
            // comboBox5
            // 
            comboBox5.Cursor = Cursors.Hand;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(15, 187);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(195, 23);
            comboBox5.TabIndex = 6;
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
            comboBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(446, 127);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(195, 23);
            comboBox4.TabIndex = 5;
            // 
            // unit_count
            // 
            unit_count.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            unit_count.Location = new Point(446, 187);
            unit_count.Name = "unit_count";
            unit_count.Size = new Size(195, 23);
            unit_count.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(228, 169);
            label11.Name = "label11";
            label11.Size = new Size(29, 15);
            label11.TabIndex = 28;
            label11.Text = "Unit";
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(228, 127);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(195, 23);
            comboBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(446, 46);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 8;
            label1.Text = "Product Name";
            // 
            // txtprodname
            // 
            txtprodname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtprodname.Location = new Point(446, 64);
            txtprodname.Name = "txtprodname";
            txtprodname.Size = new Size(195, 23);
            txtprodname.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(217, 83, 79);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(144, 247);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(123, 31);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click_1;
            // 
            // saveProductBtn
            // 
            saveProductBtn.BackColor = Color.FromArgb(92, 184, 92);
            saveProductBtn.Cursor = Cursors.Hand;
            saveProductBtn.FlatAppearance.BorderSize = 0;
            saveProductBtn.FlatStyle = FlatStyle.Flat;
            saveProductBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveProductBtn.ForeColor = Color.WhiteSmoke;
            saveProductBtn.Location = new Point(15, 247);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(123, 31);
            saveProductBtn.TabIndex = 9;
            saveProductBtn.Text = "Save";
            saveProductBtn.UseVisualStyleBackColor = false;
            // 
            // txtprodcode
            // 
            txtprodcode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtprodcode.Location = new Point(228, 66);
            txtprodcode.Name = "txtprodcode";
            txtprodcode.Size = new Size(195, 23);
            txtprodcode.TabIndex = 1;
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
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 127);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(193, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(446, 169);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 36;
            label2.Text = "Qty.";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 419);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBg;
        private Label label9;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label13;
        private ComboBox comboBox6;
        private Label label12;
        private ComboBox comboBox5;
        private Label label10;
        private ComboBox comboBox4;
        private TextBox unit_count;
        private Label label11;
        private ComboBox comboBox3;
        private Label label1;
        private TextBox txtprodname;
        private Button cancelBtn;
        private Button saveProductBtn;
        private TextBox txtprodcode;
        private Label label5;
        private Label label4;
        private Label label8;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
    }
}