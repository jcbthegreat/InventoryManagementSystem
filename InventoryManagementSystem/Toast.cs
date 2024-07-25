using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Toast : Form
    {
        int toastX, toastY;
        public Toast(string type,string message)
        {
            InitializeComponent();

            switch (type)
            {
                case "SUCCESS":
                    lblType.Text = type;
                    lblMessage.Text = message;
                    toastBorder.BackColor = Color.FromArgb(57, 155, 53);
                    picIcon.Image = Properties.Resources.check__1_;
                    break;

                case "ERROR":
                    lblType.Text = type;
                    lblMessage.Text = message;
                    toastBorder.BackColor = Color.FromArgb(227, 50, 45);
                    picIcon.Image = Properties.Resources.mark__1_;
                    break;
                case "INFO":
                    lblType.Text = type;
                    lblMessage.Text = message;
                    toastBorder.BackColor = Color.FromArgb(18, 136, 191);
                    picIcon.Image = Properties.Resources.info__1_;
                    break;
                case "WARNING":
                    lblType.Text = type;
                    lblMessage.Text = message;
                    toastBorder.BackColor = Color.FromArgb(245, 171, 35);
                    picIcon.Image = Properties.Resources.caution__1_;
                    break;

            }
        }

        private void Toast_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width;
            toastY = ScreenHeight - this.Height;
            this.Location = new Point(toastX, toastY);
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);

            if (toastY <= 1000)
            {
                toastTimer.Stop();
                toastHide.Start();
            }
        }
        int y = 100;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y < 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if(toastY > 800)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }
    }
}
