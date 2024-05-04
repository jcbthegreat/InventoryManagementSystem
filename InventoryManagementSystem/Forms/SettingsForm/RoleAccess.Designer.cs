namespace InventoryManagementSystem.Forms.SettingsForm
{
    partial class RoleAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleAccess));
            panelBg = new Panel();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            pictureBox3 = new PictureBox();
            checkBox3 = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            addBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            panelBg.Size = new Size(1026, 36);
            panelBg.TabIndex = 28;
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
            closeBtn.Location = new Point(994, 0);
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
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Role Access";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(46, 171);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Purchase Order";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(279, 171);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 19);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Products";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(213, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 143);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Cursor = Cursors.Hand;
            checkBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(487, 171);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(66, 19);
            checkBox3.TabIndex = 34;
            checkBox3.Text = "Reports";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(419, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 143);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(6, 24);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 143);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 35;
            pictureBox5.TabStop = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Control;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Cursor = Cursors.Hand;
            checkedListBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Payment Method", "Manage Category", "Sub Category", "Type", "Variant", "Measurement", "Brand Name", "Add Location", "Manage User" });
            checkedListBox1.Location = new Point(212, 24);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(118, 162);
            checkedListBox1.TabIndex = 37;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(92, 184, 92);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.WhiteSmoke;
            addBtn.Location = new Point(898, 382);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(116, 30);
            addBtn.TabIndex = 39;
            addBtn.Text = "Save";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 255);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "MainForm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(checkedListBox1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(660, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 202);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Role Name";
            textBox1.Size = new Size(297, 23);
            textBox1.TabIndex = 42;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(12, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(309, 61);
            groupBox3.TabIndex = 43;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Role ";
            // 
            // RoleAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 424);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(addBtn);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoleAccess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoleAccess";
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBg;
        private PictureBox pictureBox1;
        private Button closeBtn;
        private Label label1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PictureBox pictureBox3;
        private CheckBox checkBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private CheckedListBox checkedListBox1;
        private Button addBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private GroupBox groupBox3;
    }
}