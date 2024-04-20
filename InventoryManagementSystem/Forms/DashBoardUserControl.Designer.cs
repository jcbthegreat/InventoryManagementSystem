namespace InventoryManagementSystem.Forms
{
    partial class DashBoardUserControl
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel7 = new Panel();
            Time = new Label();
            Date = new Label();
            label9 = new Label();
            panel6 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel5, 3, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(52, 77);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1054, 187);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(792, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 181);
            panel5.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 109);
            label7.Name = "label7";
            label7.Size = new Size(45, 18);
            label7.TabIndex = 5;
            label7.Text = "Users";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 38);
            label8.Name = "label8";
            label8.Size = new Size(38, 41);
            label8.TabIndex = 4;
            label8.Text = "2";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.group;
            pictureBox4.Location = new Point(127, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(112, 108);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Orange;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(529, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 181);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Orange;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 109);
            label5.Name = "label5";
            label5.Size = new Size(82, 18);
            label5.TabIndex = 4;
            label5.Text = "Low Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Orange;
            label6.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 38);
            label6.Name = "label6";
            label6.Size = new Size(38, 41);
            label6.TabIndex = 3;
            label6.Text = "2";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.arrow;
            pictureBox3.Location = new Point(127, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(266, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 181);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 4;
            label3.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 38);
            label4.Name = "label4";
            label4.Size = new Size(78, 41);
            label4.TabIndex = 3;
            label4.Text = "100";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.box__1_;
            pictureBox2.Location = new Point(127, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 181);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 2;
            label2.Text = "Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(38, 41);
            label1.TabIndex = 1;
            label1.Text = "5";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.menu1;
            pictureBox1.Location = new Point(127, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 48);
            panel1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(Time);
            panel7.Controls.Add(Date);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(789, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(383, 48);
            panel7.TabIndex = 1;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Time.Location = new Point(213, 21);
            Time.Name = "Time";
            Time.Size = new Size(37, 17);
            Time.TabIndex = 2;
            Time.Text = "Time";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Date.Location = new Point(18, 21);
            Date.Name = "Date";
            Date.Size = new Size(36, 17);
            Date.TabIndex = 1;
            Date.Text = "Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 13);
            label9.Name = "label9";
            label9.Size = new Size(105, 25);
            label9.TabIndex = 0;
            label9.Text = "Dashboard";
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1172, 658);
            panel6.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // DashBoardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel6);
            Name = "DashBoardUserControl";
            Size = new Size(1172, 658);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label9;
        private Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private Label Time;
        private Label Date;
        private Panel panel7;
    }
}
