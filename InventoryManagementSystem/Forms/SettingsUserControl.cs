using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Forms.SettingsForm;
using InventoryManagementSystem.Presenter;
using InventoryManagementSystem.View;

namespace InventoryManagementSystem.Forms
{
    public partial class SettingsUserControl : UserControl, ISettingsUserControl
    {



        private AddCategory addcategory;
        private MainForm mainForm;
        private AddBrandName addBrandName;
        private AddProductForm addproductForm;
        private ManageUser addmangeuser;
        private AddCustomers addcustomer;
        private AddLocation addLocation;
        private SupplierDetails supplierdetails;
        private AddSupplier addSupplier;
        private AddSubCategory subcategory;
        private AddMeasurement measurement;
        private AddType addtype;
        private RoleAccess roleaccess;
        private ChooseRole chooserole;
        private RoleAssignment roleassign;
        public SettingsUserControl()
        {
            InitializeComponent();
            button1.Click += delegate { ShowCategory?.Invoke(this, EventArgs.Empty); };
            button6.Click += delegate { ShowSubCategory?.Invoke(this, EventArgs.Empty); };
            button7.Click += delegate { ShowType?.Invoke(this, EventArgs.Empty); };
            button8.Click += delegate { ShowVariant?.Invoke(this, EventArgs.Empty); };
            button3.Click += delegate { ShowBrand?.Invoke(this, EventArgs.Empty); };
            button5.Click += delegate { ShowMeasure?.Invoke(this, EventArgs.Empty); };
            button9.Click += delegate { ShowStaff?.Invoke(this, EventArgs.Empty); };
            this.mainForm = mainForm;
            this.addcategory = addcategory;
            this.addBrandName = addBrandName;
            this.addproductForm = addproductForm;
            this.addmangeuser = addmangeuser;
            this.addcustomer = addcustomer;
            this.addLocation = addLocation;
            this.supplierdetails = supplierdetails;
            this.addSupplier = addSupplier;
            this.subcategory = subcategory;
            this.measurement = measurement;
            this.addtype = addtype;
            this.roleaccess = roleaccess;
            this.chooserole = chooserole;
            this.roleassign = roleassign;


          

        }

        public event EventHandler ShowCategory;

        public event EventHandler ShowSubCategory;

        public event EventHandler ShowType;
        public event EventHandler ShowVariant;
        public event EventHandler ShowBrand;
        public event EventHandler ShowMeasure;
        public event EventHandler ShowStaff;

        private void paymentMethodBtn_Click(object sender, EventArgs e)
        {
            AddPaymentMethodForm addPaymentMethodForm = new AddPaymentMethodForm();
            addPaymentMethodForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddCategory addCategory = new AddCategory();
            //addCategory.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddLocation addlocation = new AddLocation();
            addlocation.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AddBrandName addBrandName = new AddBrandName();
            //addBrandName.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //AddMeasurement measure = new AddMeasurement();
            //measure.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //StaffDetails staff = new StaffDetails();
            //staff.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //AddSubCategory subcategory = new AddSubCategory();
            //subcategory.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //AddType addtype = new AddType();
            //addtype.ShowDialog();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //AddVariant addvariant = new AddVariant();
            //addvariant.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (MainForm.Instance != null)
                {
                    MainForm.Instance.ChangePanelColor(dialog.Color);
                }

                if (AddCategory.Instance != null)
                {
                    AddCategory.Instance.ChangePanelColor1(dialog.Color);
                }

                if (AddBrandName.Instance != null)
                {
                    AddBrandName.Instance.ChangePanelColor2(dialog.Color);
                }

                if (AddProductForm.Instance != null)
                {
                    AddProductForm.Instance.ChangePanelColor3(dialog.Color);
                }

                if (ManageUser.Instance != null)
                {
                    ManageUser.Instance.ChangePanelColor4(dialog.Color);
                }

                if (AddCustomers.Instance != null)
                {
                    AddCustomers.Instance.ChangePanelColor5(dialog.Color);
                }

                if (CustomerDetails.Instance != null)
                {
                    CustomerDetails.Instance.ChangePanelColor6(dialog.Color);
                }
                if (AddLocation.Instance != null)
                {
                    AddLocation.Instance.ChangePanelColor7(dialog.Color);
                }
                if (SupplierDetails.Instance != null)
                {
                    SupplierDetails.Instance.ChangePanelColor8(dialog.Color);
                }
                if (AddSupplier.Instance != null)
                {
                    AddSupplier.Instance.ChangePanelColor8(dialog.Color);
                }
                if (StaffDetails.Instance != null)
                {
                    StaffDetails.Instance.ChangePanelColor9(dialog.Color);
                }
                if (AddStaff.Instance != null)
                {
                    AddStaff.Instance.ChangePanelColor9(dialog.Color);
                }
                if (AddSubCategory.Instance != null)
                {
                    AddSubCategory.Instance.ChangePanelColor10(dialog.Color);
                }
                if (AddMeasurement.Instance != null)
                {
                    AddMeasurement.Instance.ChangePanelColor11(dialog.Color);
                }
                if (AddType.Instance != null)
                {
                    AddType.Instance.ChangePanelColor12(dialog.Color);
                }
                if (AddVariant.Instance != null)
                {
                    AddVariant.Instance.ChangePanelColor13(dialog.Color);
                }
                if (RoleAccess.Instance != null)
                {
                    RoleAccess.Instance.ChangePanelColor12(dialog.Color);
                }
                if (ChooseRole.Instance != null)
                {
                    ChooseRole.Instance.ChangePanelColor12(dialog.Color);
                }
                if (RoleAssignment.Instance != null)
                {
                    RoleAssignment.Instance.ChangePanelColor12(dialog.Color);
                }

                Properties.Settings.Default.MyColor = dialog.Color;
                Properties.Settings.Default.Save();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChooseRole role = new ChooseRole();
            role.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
