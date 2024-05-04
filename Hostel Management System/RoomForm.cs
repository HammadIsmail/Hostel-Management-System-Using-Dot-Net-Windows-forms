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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class RoomForm : Form
    {
        int key;
        public RoomForm()
        {
            InitializeComponent();
            RoomTextBox.Focus();
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.Room(RoomTextBox, RoomErrorlb);
            if (success)
            {
                MRoomCRUD.AddRoom(RoomTextBox, RoomErrorlb);
                MRoomCRUD.ViewAllRoom(RoomGridView);
            }
            RoomTextBox.Text = "";
        }

        private void RoomErrorlb_Click(object sender, EventArgs e)
        {

        }

        private void RoomTextBox_TextChanged(object sender, EventArgs e)
        {
            RoomErrorlb.Text = "";
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            MRoomCRUD.ViewAllRoom(RoomGridView);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.Room(RoomTextBox, RoomErrorlb);
            if (success)
            {
                MRoomCRUD.ViewRoomBySearch(RoomGridView, RoomTextBox);
            }
            RoomTextBox.Text = "";

        }

        private void RoomGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomTextBox.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            key = MRoomCRUD.FindKey(RoomTextBox);

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.Room(RoomTextBox, RoomErrorlb);
            if (success)
            {
                MRoomCRUD.DeleteRoom(RoomTextBox);
                MRoomCRUD.ViewAllRoom(RoomGridView);
            }
            RoomTextBox.Text="";

        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MRoomCRUD.ViewAllRoom(RoomGridView);
            
        }

        private void RoomEditBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.Room(RoomTextBox, RoomErrorlb);
            if (success)
            {
                MRoomCRUD.EditRoom(RoomTextBox, key);
                MRoomCRUD.ViewAllRoom(RoomGridView);
            }
            RoomTextBox.Text = "";

        }
    }
}
