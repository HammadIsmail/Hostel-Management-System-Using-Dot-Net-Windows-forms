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
using System.Windows.Input;

namespace Hostel_Management_System
{
    public partial class EmployeeEditForm : Form
    {
        int key;
        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            MEmployeeCRUD.VeiwAll(EmpGridView);
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MEmployeeCRUD.VeiwAll(EmpGridView);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox, SearchErrorlb);
            if (success)
            {
                MEmployeeCRUD.VeiwBySearch(EmpGridView, SearchBox);
            }
            SearchBox.Clear();
        }
        private void ClearTextBoxes()
        {
            NameBox.Text = "";
            CNICBox.Text = "";
            ContactBox.Text = "";
            SalaryBox.Text = "";
            AddressBox.Text = "";
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            bool success = EmployeeValidations.Emp(NameBox, CNICBox, ContactBox, SalaryBox, AddressBox,  NameErrorlb, CNICErrorlb, ContactErrorlb, SalaryErrorlb, AddressErrorlb);
            if (success)
            {
                MEmployeeCRUD.EditEmp(NameBox, CNICBox, ContactBox, SalaryBox, AddressBox, GenderBox, RankBox, DateBox,key);
                ClearTextBoxes();
                MEmployeeCRUD.VeiwAll(EmpGridView);
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

        private void EmpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = EmpGridView.SelectedRows[0].Cells[0].Value.ToString();
            long cnic = (long)EmpGridView.SelectedRows[0].Cells[1].Value;
            long contact = (long)EmpGridView.SelectedRows[0].Cells[2].Value;
            long salary = (long)EmpGridView.SelectedRows[0].Cells[4].Value;
            string address = EmpGridView.SelectedRows[0].Cells[5].Value.ToString();
            NameBox.Text = name;
            CNICBox.Text = cnic.ToString();
            ContactBox.Text = contact.ToString();
            SalaryBox.Text = salary.ToString();
            AddressBox.Text = address;
            key = MEmployeeCRUD.FindKey(name, cnic, contact);
        }
    }
}
