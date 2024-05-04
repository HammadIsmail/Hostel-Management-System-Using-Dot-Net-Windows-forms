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
    public partial class CustomerBookingForm : Form
    {
        string Name;
        public CustomerBookingForm(string name)
        {
            InitializeComponent();
           this.Name = name;
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

            }
            CNICBox.Clear();
            ContactBox.Clear();
            PaymentBox.Clear();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
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

        private void CustomerBookingForm_Load(object sender, EventArgs e)
        {
            MBookingCRUD.getRoomNo(RoomNoBox);
            RoomNoBox.StartIndex = 0;
            NameBox.Text =this. Name;
        }
    }
    }
