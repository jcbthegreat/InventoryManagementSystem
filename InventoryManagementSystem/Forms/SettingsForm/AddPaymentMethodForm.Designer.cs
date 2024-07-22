namespace InventoryManagementSystem.Forms.SettingsForm
{
    partial class AddPaymentMethodForm
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
            panel1 = new Panel();
            closeBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 37);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = Properties.Resources.close__1_;
            closeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(846, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(32, 37);
            closeBtn.TabIndex = 1;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Payment Method";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.work_in_progress;
            pictureBox1.Location = new Point(247, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 586);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 66);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(185, 21);
            label2.Name = "label2";
            label2.Size = new Size(448, 21);
            label2.TabIndex = 0;
            label2.Text = "This module is currently in progress, bear with us! Thank you";
            // 
            // AddPaymentMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 652);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPaymentMethodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPaymentMethodForm";
            Load += AddPaymentMethodForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button closeBtn;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
    }
}