namespace InventoryManagementSystem.Forms
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUserControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            paymentMethodBtn = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button6 = new Button();
            panel5 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 41);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 24);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(81, 25);
            label9.TabIndex = 2;
            label9.Text = "Settings";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1172, 617);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(paymentMethodBtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 126);
            panel2.TabIndex = 0;
            // 
            // paymentMethodBtn
            // 
            paymentMethodBtn.BackColor = SystemColors.Control;
            paymentMethodBtn.Cursor = Cursors.Hand;
            paymentMethodBtn.Dock = DockStyle.Fill;
            paymentMethodBtn.FlatAppearance.BorderSize = 0;
            paymentMethodBtn.FlatStyle = FlatStyle.Flat;
            paymentMethodBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            paymentMethodBtn.Image = Properties.Resources.add_payment;
            paymentMethodBtn.Location = new Point(0, 0);
            paymentMethodBtn.Name = "paymentMethodBtn";
            paymentMethodBtn.Padding = new Padding(0, 0, 0, 10);
            paymentMethodBtn.Size = new Size(200, 126);
            paymentMethodBtn.TabIndex = 3;
            paymentMethodBtn.Text = "Payment Method";
            paymentMethodBtn.TextAlign = ContentAlignment.BottomCenter;
            paymentMethodBtn.UseVisualStyleBackColor = false;
            paymentMethodBtn.Click += paymentMethodBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(209, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 126);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.product_management1;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 0, 10);
            button1.Size = new Size(200, 126);
            button1.TabIndex = 3;
            button1.Text = "Manage Category";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button6);
            panel4.Location = new Point(415, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 126);
            panel4.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Padding = new Padding(0, 0, 0, 10);
            button6.Size = new Size(200, 126);
            button6.TabIndex = 3;
            button6.Text = "Sub Category";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button7);
            panel5.Location = new Point(621, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 126);
            panel5.TabIndex = 3;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Padding = new Padding(0, 0, 0, 10);
            button7.Size = new Size(200, 126);
            button7.TabIndex = 3;
            button7.Text = "Type";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(827, 3);
            button8.Name = "button8";
            button8.Padding = new Padding(0, 0, 0, 10);
            button8.Size = new Size(200, 126);
            button8.TabIndex = 3;
            button8.Text = "Variant";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(3, 135);
            button5.Name = "button5";
            button5.Padding = new Padding(0, 0, 0, 10);
            button5.Size = new Size(200, 126);
            button5.TabIndex = 3;
            button5.Text = "Measurement";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(209, 135);
            button3.Name = "button3";
            button3.Padding = new Padding(0, 0, 0, 10);
            button3.Size = new Size(200, 126);
            button3.TabIndex = 4;
            button3.Text = "Brand Name";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = Properties.Resources.add_location__1_;
            button4.Location = new Point(415, 135);
            button4.Name = "button4";
            button4.Padding = new Padding(0, 0, 0, 10);
            button4.Size = new Size(200, 126);
            button4.TabIndex = 5;
            button4.Text = "Add Location";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.management;
            button2.Location = new Point(621, 135);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 0, 10);
            button2.Size = new Size(200, 126);
            button2.TabIndex = 6;
            button2.Text = "Manage User";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(827, 135);
            button9.Name = "button9";
            button9.Padding = new Padding(0, 0, 0, 10);
            button9.Size = new Size(200, 126);
            button9.TabIndex = 7;
            button9.Text = "Manage Staff";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Hand;
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(3, 267);
            button10.Name = "button10";
            button10.Padding = new Padding(0, 0, 0, 10);
            button10.Size = new Size(200, 126);
            button10.TabIndex = 8;
            button10.Text = "Role Access";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "SettingsUserControl";
            Size = new Size(1172, 658);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button paymentMethodBtn;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Button button6;
        private Panel panel5;
        private Button button7;
        private Label label9;
        private Button button8;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button9;
        private PictureBox pictureBox1;
        private Button button10;
    }
}
