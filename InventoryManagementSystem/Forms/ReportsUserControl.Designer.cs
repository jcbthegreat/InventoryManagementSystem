namespace InventoryManagementSystem.Forms
{
    partial class ReportsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsUserControl));
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            repProduct = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 41);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "Reports";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(repProduct);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1006, 597);
            flowLayoutPanel1.TabIndex = 23;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // repProduct
            // 
            repProduct.BackColor = SystemColors.Control;
            repProduct.Cursor = Cursors.Hand;
            repProduct.Dock = DockStyle.Top;
            repProduct.FlatAppearance.BorderSize = 0;
            repProduct.FlatStyle = FlatStyle.Flat;
            repProduct.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            repProduct.Image = (Image)resources.GetObject("repProduct.Image");
            repProduct.Location = new Point(3, 3);
            repProduct.Name = "repProduct";
            repProduct.Padding = new Padding(0, 0, 0, 10);
            repProduct.Size = new Size(200, 149);
            repProduct.TabIndex = 4;
            repProduct.Text = "Products";
            repProduct.TextAlign = ContentAlignment.BottomCenter;
            repProduct.UseVisualStyleBackColor = false;
            repProduct.Click += repProduct_Click;
            // 
            // ReportsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "ReportsUserControl";
            Size = new Size(1006, 638);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button repProduct;
    }
}
