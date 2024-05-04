﻿using Hostel_Management_System.Business_Layer;
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
    public partial class ViewBookingForm : Form
    {
        public ViewBookingForm()
        {
            InitializeComponent();
        }
        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MBookingCRUD.VeiwAll(BookingGridView);

        }

        private void ViewBookingForm_Load(object sender, EventArgs e)
        {
            MBookingCRUD.VeiwAll(BookingGridView);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox,SearchErrorlb);
            if (success)
            {
                MBookingCRUD.VeiwbySearch(BookingGridView,SearchBox);
            }
            SearchBox.Clear();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }
    }
}
