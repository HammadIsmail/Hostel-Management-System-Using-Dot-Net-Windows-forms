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
    public partial class EditBookingForm : Form
    {
        int key,PrevRoom;
        public EditBookingForm()
        {
            InitializeComponent();
        }

        private void EditBookingForm_Load(object sender, EventArgs e)
        {
            MBookingCRUD.VeiwAll(BookingGridView);
            MBookingCRUD.getRoomNo(RoomNoBox);
            RoomNoBox.StartIndex = 0;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox, SearchErrorlb);
            if (success)
            {
                MBookingCRUD.VeiwbySearch(BookingGridView, SearchBox);
            }
            SearchBox.Clear();
        }

        private void BookingGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = BookingGridView.SelectedRows[0].Cells[0].Value.ToString();
            long cnic = (long)BookingGridView.SelectedRows[0].Cells[1].Value;
            long contact = (long)BookingGridView.SelectedRows[0].Cells[2].Value;
            long payment = (long)BookingGridView.SelectedRows[0].Cells[4].Value;
            NameBox.Text = name;
            CNICBox.Text=cnic.ToString();
            ContactBox.Text=contact.ToString();
            PaymentBox.Text=payment.ToString();

            key = MBookingCRUD.FindKey(name, cnic, contact);
            PrevRoom = MBookingCRUD.FindRoomNo(key);
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

        private void PaymentBox_TextChanged(object sender, EventArgs e)
        {
            PaymentErrorlb.Text = "";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            bool success = BookingValidations.book(NameBox,CNICBox,ContactBox,PaymentBox,NameErrorlb,CNICErrorlb,ContactErrorlb,PaymentErrorlb);
            if (success)
            {
                MBookingCRUD.EditBooking(NameBox,CNICBox,ContactBox,PaymentBox,GenderBox,RoomTypeBox,FacilityBox,RoomNoBox,DateBox,key,PrevRoom);
                MBookingCRUD.VeiwAll(BookingGridView);
                MBookingCRUD.getRoomNo(RoomNoBox);
                RoomNoBox.StartIndex = 0;
                PrintBookingDataForm print = new PrintBookingDataForm(NameBox, CNICBox, ContactBox, GenderBox, RoomTypeBox, FacilityBox, PaymentBox, RoomNoBox);
                print.ShowDialog();
            }
            NameBox.Clear();
            CNICBox.Clear();
            ContactBox.Clear();
            PaymentBox.Clear();
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {

            bool success = BookingValidations.book(NameBox, CNICBox, ContactBox, PaymentBox, NameErrorlb, CNICErrorlb, ContactErrorlb, PaymentErrorlb);
            if (success)
            {
                MBookingCRUD.EditBooking(NameBox, CNICBox, ContactBox, PaymentBox, GenderBox, RoomTypeBox, FacilityBox, RoomNoBox, DateBox, key, PrevRoom);
                MBookingCRUD.VeiwAll(BookingGridView);
                MBookingCRUD.getRoomNo(RoomNoBox);
                RoomNoBox.StartIndex = 0;
           
            }
            NameBox.Clear();
            CNICBox.Clear();
            ContactBox.Clear();
            PaymentBox.Clear();
        }

        private void RoomNoBox_DropDown(object sender, EventArgs e)
        {
          
        }
    }
}
