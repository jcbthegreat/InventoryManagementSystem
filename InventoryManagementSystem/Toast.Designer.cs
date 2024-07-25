namespace InventoryManagementSystem
{
    partial class Toast
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toast));
            toastBorder = new Panel();
            picIcon = new PictureBox();
            lblType = new Label();
            lblMessage = new Label();
            toastTimer = new System.Windows.Forms.Timer(components);
            toastHide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // toastBorder
            // 
            toastBorder.BackColor = Color.FromArgb(57, 155, 53);
            toastBorder.ForeColor = Color.Coral;
            toastBorder.Location = new Point(-10, 0);
            toastBorder.Name = "toastBorder";
            toastBorder.Size = new Size(23, 61);
            toastBorder.TabIndex = 0;
            // 
            // picIcon
            // 
            picIcon.Image = (Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new Point(24, 12);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(20, 20);
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.TabIndex = 1;
            picIcon.TabStop = false;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(50, 9);
            lblType.Name = "lblType";
            lblType.Size = new Size(42, 20);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(50, 33);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(82, 13);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Toast Message";
            // 
            // toastTimer
            // 
            toastTimer.Enabled = true;
            toastTimer.Interval = 10;
            toastTimer.Tick += toastTimer_Tick;
            // 
            // toastHide
            // 
            toastHide.Enabled = true;
            toastHide.Interval = 10;
            toastHide.Tick += toastHide_Tick;
            // 
            // Toast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 59);
            Controls.Add(lblMessage);
            Controls.Add(lblType);
            Controls.Add(picIcon);
            Controls.Add(toastBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Toast";
            Text = "Toast";
            Load += Toast_Load;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel toastBorder;
        private PictureBox picIcon;
        private Label lblType;
        private Label lblMessage;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}