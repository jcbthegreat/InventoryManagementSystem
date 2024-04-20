using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace InventoryManagementSystem.Forms
{
    public partial class DashBoardUserControl : UserControl
    {
        public DashBoardUserControl()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
