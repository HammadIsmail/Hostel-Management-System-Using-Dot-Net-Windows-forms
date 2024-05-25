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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Hostel_Management_System
{
    public partial class SettingForm : Form
    {
        int key;
        public SettingForm()
        {
            InitializeComponent();
        }

      

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            StatusErrorlb.Text = "";
        }

    



        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox,SearchErrorlb);
            if (success)
            {
                MUserCRUD.VeiwBySearch(UserGridView,SearchBox);
            }
            SearchBox.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bool success = Validations.User(NameBox,NameError,PasswordBox,PasswordError);
            if (success)
            {
                MUserCRUD.EditUser(NameBox,PasswordBox,StatusBox, Role,key);
                MUserCRUD.VeiwAll(UserGridView);
            }
            StatusBox.Text = "";
            NameBox.Text = "";
            PasswordBox.Text = "";
            StatusPlaceHolder.Text = "Status";
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MUserCRUD.VeiwAll(UserGridView);
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            MUserCRUD.VeiwAll(UserGridView);

        }

        private void UserGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = UserGridView.SelectedRows[0].Cells[0].Value.ToString();
            string password = UserGridView.SelectedRows[0].Cells[1].Value.ToString();
            string role = UserGridView.SelectedRows[0].Cells[2].Value.ToString();
            int status = (int)UserGridView.SelectedRows[0].Cells[3].Value;
            NameBox.Text = name;
            PasswordBox.Text = password;
            StatusBox.Text=status.ToString();
            StatusPlaceHolder.Text = "";
            Role.Text = role;
            key = MUserCRUD.FindKey(name,password,role,status);
            StatusBox.Focus();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MUserCRUD.DeleteUser(key);
            MUserCRUD.VeiwAll(UserGridView);
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            PasswordError.Text = "";
        }

        private void StatusBox_DropDown(object sender, EventArgs e)
        {
            StatusPlaceHolder.Text = "";
        }

        private void NameBox_TextChanged_1(object sender, EventArgs e)
        {
            NameError.Text = "";
        }
    }
}
