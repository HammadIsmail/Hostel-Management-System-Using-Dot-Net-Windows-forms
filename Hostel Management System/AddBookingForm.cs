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
    public partial class AddBookingForm : Form
    {
        public AddBookingForm()
        {
            InitializeComponent();
        }

        private void RoomNoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool success = BookingValidations.book(NameBox, CNICBox, ContactBox, PaymentBox, NameErrorlb, CNICErrorlb, ContactErrorlb, PaymentErrorlb);
            if (success)
            {
                MBookingCRUD.AddBooking(NameBox, CNICBox, ContactBox, PaymentBox, GenderBox, RoomTypeBox, FacilityTypeBox, RoomNoBox, DateBox);
                RoomNoBox.Items.Clear();
                MBookingCRUD.getRoomNo(RoomNoBox);
                RoomNoBox.StartIndex = 0;
                PrintBookingDataForm print = new PrintBookingDataForm(NameBox, CNICBox, ContactBox, GenderBox, RoomTypeBox, FacilityTypeBox, PaymentBox, RoomNoBox);
                print.ShowDialog();
            }
            NameBox.Clear();
            CNICBox.Clear();
            ContactBox.Clear();
            PaymentBox.Clear();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameErrorlb.Text ="";
        }

        private void CNICBox_TextChanged(object sender, EventArgs e)
        {
            CNICErrorlb.Text = "";

        }

        private void ContactBox_TextChanged(object sender, EventArgs e)
        {
            ContactErrorlb.Text = "";

        }

        private void PaymentBox_TextChanged(object sender, EventArgs e)
        {
            PaymentErrorlb.Text = "";

        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            MBookingCRUD.getRoomNo(RoomNoBox);
            RoomNoBox.StartIndex = 0;
        }

        private void RoomNoBox_DropDown(object sender, EventArgs e)
        {
         
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            bool success = BookingValidations.book(NameBox, CNICBox, ContactBox, PaymentBox, NameErrorlb, CNICErrorlb, ContactErrorlb, PaymentErrorlb);
            if (success)
            {
                MBookingCRUD.AddBooking(NameBox, CNICBox, ContactBox, PaymentBox, GenderBox, RoomTypeBox, FacilityTypeBox, RoomNoBox, DateBox);
                RoomNoBox.Items.Clear();
                MBookingCRUD.getRoomNo(RoomNoBox);
                RoomNoBox.StartIndex = 0;
             
            }
            NameBox.Clear();
            CNICBox.Clear();
            ContactBox.Clear();
            PaymentBox.Clear();
        }
    }
}
