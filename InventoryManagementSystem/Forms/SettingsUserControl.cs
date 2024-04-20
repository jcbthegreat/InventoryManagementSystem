using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Forms.SettingsForm;

namespace InventoryManagementSystem.Forms
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void paymentMethodBtn_Click(object sender, EventArgs e)
        {
            AddPaymentMethodForm addPaymentMethodForm = new AddPaymentMethodForm();
            addPaymentMethodForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddLocation addlocation = new AddLocation();
            addlocation.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddBrandName addBrandName = new AddBrandName();
            addBrandName.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            StaffDetails staff = new StaffDetails();
            staff.ShowDialog();
        }
    }
}
