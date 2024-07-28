using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.View;
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
    public partial class LoginForm : Form, ILoginView
    {

        private int id;
        private string staffno;
        private string lastname, firstname;
        private string position;
        private string roletype;
 
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string StaffNo
        {
            get { return staffno; }
            set { staffno = value; }
        }
        public string RoleType
        {
            get { return roletype; }
            set { roletype = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string UserName
        {
            get { return inputUsername.Text; }
            set { inputUsername.Text = value; }
        }
        public string PassWord
        {
            get { return inputPassword.Text; }
            set { inputPassword.Text = value; }
        }
        public string isactive { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            LoginUser();

        }
        public void showToast(string type, string message)
        {
            Toast toast = new Toast(type, message);
            toast.Show();
        }
        public void LoginUser()
        {
            loginBtn.Click += (s, e) => Login?.Invoke(this, EventArgs.Empty);

            // Add event handlers for Enter key on both TextBoxes
            inputUsername.KeyDown += TextBox_KeyDown;
            inputPassword.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger Login event when Enter key is pressed
                Login?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler Login;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void ResetFields()
        {
            inputUsername.Text = string.Empty;
            inputPassword.Text = string.Empty;
        }


        public void SetBindingLoginSource(BindingSource login)
        {
            throw new NotImplementedException();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
