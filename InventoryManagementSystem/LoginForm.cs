using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Forms.SettingsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(inputUsername.Text =="admin" &&  inputPassword.Text == "123456")
            // {
            MainForm main = new MainForm();
            main.ShowDialog();
            this.Hide();
            // }
            // else
            // {
            //     MessageBox.Show("The Username or Password you entered is incorrect, please try again");
            //     inputUsername.Clear();
            //     inputPassword.Clear();
            //     inputUsername.Focus();
            // }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
