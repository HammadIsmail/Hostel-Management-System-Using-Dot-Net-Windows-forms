using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Hostel_Management_System.Business_Layer;
using Hostel_Management_System.Data_Layer;
using Guna.UI2.WinForms;
namespace Hostel_Management_System
{
    public partial class MainEmployeeForm : Form
    {
        bool MenuBar=true;
        string Name;
        public MainEmployeeForm(string name)
        {
            InitializeComponent();
            Name = name;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UserNamelb.Text ="Welcome! "+ Name;
            BookingCrudPanel.Height = 40;
            LogOutBtn.Location = new System.Drawing.Point(20,680);
            FoodItemBtn.Location = new System.Drawing.Point(25, 217);
            CLoseBtn.Location = new System.Drawing.Point(1340, 6);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuBar = !MenuBar;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuBar_Tick(object sender, EventArgs e)
        {
         

            if (MenuBar)
            {
                if (MenuPanel.Width<=208)
                {
                    MenuPanel.Width += 10;
                }
                if (BookingBtn.Width <= 170)
                {
                    BookingBtn.Width += 10;

                }
                if (BookingBtn.Width == 170)
                {
                    BookingBtn.Left += 5;
                    BookingBtn.Text = "Add Users   ";

               

                }
            }
            else
            {

                if (MenuPanel.Width >= 78)
                {
                    MenuPanel.Width -= 10;
                }
                if (BookingBtn.Width >= 60)
                {
                    BookingBtn.Width -= 10;

                }
                if (BookingBtn.Width ==140)
                {
           
                    BookingBtn.Left -= 5;
                    BookingBtn.Text = "";
                }

              
            }
        }

        private void CheckMaximumAndMinimum_Tick(object sender, EventArgs e)
        {
           
        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
          
        }


        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void MainBoxPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddUserBtn_MouseHover(object sender, EventArgs e)
        {
            BookingCrudPanel.Height = 210;
            FoodItemBtn.Location = new System.Drawing.Point(25, 369);

        }

        private void AddUserBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void UserCrudPanel_MouseLeave(object sender, EventArgs e)
        {
        }
    
        private void FoodItemBtn_MouseHover(object sender, EventArgs e)
        {

        }
        private void MenuPanel_MouseLeave(object sender, EventArgs e)
        {
            BookingCrudPanel.Height = 40;
            FoodItemBtn.Location = new System.Drawing.Point(25, 217);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            AddBookingForm userForm = new AddBookingForm();
            userForm.TopLevel = false;
            userForm.FormBorderStyle = FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(userForm);
            userForm.Show();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            ViewBookingForm ViewBookingForm = new ViewBookingForm();
            ViewBookingForm.TopLevel = false;
            ViewBookingForm.FormBorderStyle = FormBorderStyle.None;
            ViewBookingForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(ViewBookingForm);
            ViewBookingForm.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            EditBookingForm EditBookingForm = new EditBookingForm();
            EditBookingForm.TopLevel = false;
            EditBookingForm.FormBorderStyle = FormBorderStyle.None;
            EditBookingForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(EditBookingForm);
            EditBookingForm.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            DeleteBookingForm DeleteBookingForm = new DeleteBookingForm();
            DeleteBookingForm.TopLevel = false;
            DeleteBookingForm.FormBorderStyle = FormBorderStyle.None;
            DeleteBookingForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(DeleteBookingForm);
            DeleteBookingForm.Show();
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            RoomForm RoomForm = new RoomForm();
            RoomForm.TopLevel = false;
            RoomForm.FormBorderStyle = FormBorderStyle.None;
            RoomForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(RoomForm);
            RoomForm.Show();
        }

      

        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {

            MainBoxPanel.Controls.Clear();
            AddEmployeeForm AddEmployeeForm = new AddEmployeeForm();
            AddEmployeeForm.TopLevel = false;
            AddEmployeeForm.FormBorderStyle = FormBorderStyle.None;
            AddEmployeeForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(AddEmployeeForm);
            AddEmployeeForm.Show();
        }

        private void EmployeeViewBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            EmployeeViewForm EmployeeViewForm = new EmployeeViewForm();
            EmployeeViewForm.TopLevel = false;
            EmployeeViewForm.FormBorderStyle = FormBorderStyle.None;
            EmployeeViewForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(EmployeeViewForm);
            EmployeeViewForm.Show();
        }

        private void EmployeeEditBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            EditBookingForm EditBookingForm = new EditBookingForm();
            EditBookingForm.TopLevel = false;
            EditBookingForm.FormBorderStyle = FormBorderStyle.None;
            EditBookingForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(EditBookingForm);
            EditBookingForm.Show();
        }

        private void EmployeeDeleteBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            EmployeeDeleteForm EmployeeDeleteForm = new EmployeeDeleteForm();
            EmployeeDeleteForm.TopLevel = false;
            EmployeeDeleteForm.FormBorderStyle = FormBorderStyle.None;
            EmployeeDeleteForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(EmployeeDeleteForm);
            EmployeeDeleteForm.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoodItemBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            FoodBillAddForm FoodBillAddForm = new FoodBillAddForm();
            FoodBillAddForm.TopLevel = false;
            FoodBillAddForm.FormBorderStyle = FormBorderStyle.None;
            FoodBillAddForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(FoodBillAddForm);
            FoodBillAddForm.Show();
        }
    }
}

