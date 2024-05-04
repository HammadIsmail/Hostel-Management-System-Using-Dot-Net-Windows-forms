using Hostel_Management_System.Business_Layer;
using Hostel_Management_System.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            NameBox.Text = "";
            CNICBox.Text = "";
            ContactBox.Text = "";
            SalaryBox.Text = "";
            AddressBox.Text = "";
            Password.Text = "";
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            //string[] dateComponents = DateBox.Value.ToString().Split(' ');
            //MessageBox.Show(dateComponents[0]);

            bool success = EmployeeValidations.Emp(NameBox, CNICBox, ContactBox, SalaryBox, AddressBox,Password, NameErrorlb, CNICErrorlb, ContactErrorlb, SalaryErrorlb, AddressErrorlb,PasswordErrorlb);
            if (success)
            {
                MEmployeeCRUD.AddEmployee(NameBox, CNICBox, ContactBox, SalaryBox, AddressBox, Password,GenderBox,RankBox,DateBox);
                ClearTextBoxes();
                MessageBox.Show("SuccessFully Entered Data!");
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameErrorlb.Text = "";
        }

        private void CNICBox_TextChanged(object sender, EventArgs e)
        {
            CNICErrorlb.Text = "";

        }

        private void ContactBox_TextChanged(object sender, EventArgs e)
        {
            ContactErrorlb.Text = "";

        }

        private void SalaryBox_TextChanged(object sender, EventArgs e)
        {
            SalaryErrorlb.Text = "";

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            AddressErrorlb.Text = "";

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            PasswordErrorlb.Text = "";
        }
    }
}
