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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            AdminNolb.Text = DashboardCRUD.GetAdmin().ToString();
            EmployeeNolb.Text = DashboardCRUD.GetEmployee().ToString();
            CustomerNolb.Text = DashboardCRUD.GetCustomer().ToString();
            TotalRoomNolb.Text=DashboardCRUD.GetRooms().ToString();
            BookedRoomNolb.Text=DashboardCRUD.GetBookedRooms().ToString();
            FreeRoomNolb.Text=DashboardCRUD.GetFreeRooms().ToString();
            RentNolb.Text=DashboardCRUD.GetRent().ToString();
            FoodSalesNolb.Text=DashboardCRUD.GetFoodSale().ToString();
            TotalProfitlb.Text=DashboardCRUD.GetTotalProfit().ToString();

        }
    }
}
