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
    public partial class DeleteBookingForm : Form
    {
        int key;
        public DeleteBookingForm()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MBookingCRUD.VeiwAll(BookingGridView);
        }

        private void DeleteBookingForm_Load(object sender, EventArgs e)
        {
            MBookingCRUD.VeiwAll(BookingGridView);
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
            key = MBookingCRUD.FindKey(name, cnic, contact);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MBookingCRUD.DeleteBooking(key);
            MBookingCRUD.VeiwAll(BookingGridView);

        }
    }
}
