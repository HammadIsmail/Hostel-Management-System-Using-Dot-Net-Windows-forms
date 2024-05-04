using Guna.UI2.WinForms;
using Hostel_Management_System.Business_Layer;
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
    public partial class PrintBookingDataForm : Form
    {
        string name, cnic, contact, gender, roomtype, facility, payment, roomNo;
        public PrintBookingDataForm(Guna2TextBox name,Guna2TextBox cnic,Guna2TextBox contact,ComboBox gender,ComboBox roomtype,ComboBox facility,Guna2TextBox payment,ComboBox roomNo)
        {
            InitializeComponent();
            this.name = name.Text;
            this.cnic=cnic.Text;
            this.gender = gender.Text;
            this.contact = contact.Text;
            this.roomtype = roomtype.Text;
            this.facility = facility.Text;
            this.payment = payment.Text;
            this.roomNo = roomNo.Text;
        }

        private void PrintBtn_Click(object sender, EventArgs e)

        {
            PrintBtnLogic.print(Panel);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void PrintBookingDataForm_Load(object sender, EventArgs e)
        {
            Namelb.Text = this.name;
            CNIClb.Text = this.cnic;
            Contactlb.Text= this.contact;
            Genderlb.Text= this.gender;
            RoomTypelb.Text = this.roomtype;
            FacilityLb.Text = this.facility;
            Paymentlb.Text = this.payment;
            RoomNolb.Text = this.roomNo;

            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("yyyy-MM-dd");
            Datelb.Text = "Date : " + date;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2VSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator3_Click(object sender, EventArgs e)
        {

        }
    }
}
