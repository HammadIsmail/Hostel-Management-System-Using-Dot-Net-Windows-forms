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
    public partial class MainForm : Form
    {
        bool MenuBar=true;
        string Name;
        public MainForm(string name)
        {
            InitializeComponent();
            Name = name;
        }
        //211
        private void Form1_Load(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            DashBoard DashBoard = new DashBoard();
            DashBoard.TopLevel = false;
            DashBoard.FormBorderStyle = FormBorderStyle.None;
            DashBoard.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(DashBoard);
            DashBoard.Show();
            UserNamelb.Text = "Welcome! " + Name;

            BookingCrudPanel.Height = 40;
            EmployeeCrudPanel.Height = 40;
            FoodItemPanel.Height = 40;

            RoomBtn.Location = new System.Drawing.Point(20, 295);
            EmployeeCrudPanel.Location = new System.Drawing.Point(17, 351);
            FoodItemPanel.Location = new System.Drawing.Point(19, 411);

            CLoseBtn.Location = new System.Drawing.Point(1340, 6);
            LogOutBtn.Location = new System.Drawing.Point(19, 670);
            UserSettingBtn.Location = new System.Drawing.Point(19, 620);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          //  MenuBar = !MenuBar;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuBar_Tick(object sender, EventArgs e)
        {
         

            //if (MenuBar)
            //{
            //    if (MenuPanel.Width<=208)
            //    {
            //        MenuPanel.Width += 10;
            //    }
            //    if (DashBoardBtn.Width<=170)
            //    {
            //        DashBoardBtn.Width += 10;
            //        BookingBtn.Width += 10;

            //    }
            //    if (DashBoardBtn.Width == 170)
            //    {
            //        BookingBtn.Left += 5;
            //        BookingBtn.Text = "Add Users   ";

            //        DashBoardBtn.Text = "Dashboard";
            //        DashBoardBtn.Left += 5;

            //    }
            //}
            //else
            //{

            //    if (MenuPanel.Width >= 78)
            //    {
            //        MenuPanel.Width -= 10;
            //    }
            //    if (DashBoardBtn.Width >= 60)
            //    {
            //        DashBoardBtn.Width -= 10;
            //        BookingBtn.Width -= 10;

            //    }
            //    if (DashBoardBtn.Width ==140)
            //    {
            //        DashBoardBtn.Text = "";
            //        DashBoardBtn.Left -= 5;
            //        BookingBtn.Left -= 5;
            //        BookingBtn.Text = "";
            //    }

              
            //}
        }

        private void CheckMaximumAndMinimum_Tick(object sender, EventArgs e)
        {
           
        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            DashBoard DashBoard = new DashBoard();
            DashBoard.TopLevel = false;
            DashBoard.FormBorderStyle = FormBorderStyle.None;
            DashBoard.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(DashBoard);
            DashBoard.Show();
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
            RoomBtn.Location = new System.Drawing.Point(19, 460);
            EmployeeCrudPanel.Location = new System.Drawing.Point(19, 457);
            FoodItemPanel.Location = new System.Drawing.Point(19, 525);

        }

        private void AddUserBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void UserCrudPanel_MouseLeave(object sender, EventArgs e)
        {
        }
        private void EmployeeBtn_MouseHover(object sender, EventArgs e)
        {
            EmployeeCrudPanel.Height = 249;
            FoodItemPanel.Location = new System.Drawing.Point(19, 620);

        }
        private void FoodItemBtn_MouseHover(object sender, EventArgs e)
        {
            FoodItemPanel.Height = 210;

        }
        private void MenuPanel_MouseLeave(object sender, EventArgs e)
        {
            BookingCrudPanel.Height = 40;
            EmployeeCrudPanel.Height = 40;
            FoodItemPanel.Height = 40;
            RoomBtn.Location = new System.Drawing.Point(20, 295);
            EmployeeCrudPanel.Location = new System.Drawing.Point(17, 351);
            FoodItemPanel.Location = new System.Drawing.Point(19, 411);

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
            EmployeeEditForm EmployeeEditForm = new EmployeeEditForm();
            EmployeeEditForm.TopLevel = false;
            EmployeeEditForm.FormBorderStyle = FormBorderStyle.None;
            EmployeeEditForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(EmployeeEditForm);
            EmployeeEditForm.Show();
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

        private void FoodAddForm_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            AddFoodItemForm AddFoodItemForm = new AddFoodItemForm();
            AddFoodItemForm.TopLevel = false;
            AddFoodItemForm.FormBorderStyle = FormBorderStyle.None;
            AddFoodItemForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(AddFoodItemForm);
            AddFoodItemForm.Show();
        }

        private void FoodViewForm_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            FoodItemViewForm FoodItemViewForm = new FoodItemViewForm();
            FoodItemViewForm.TopLevel = false;
            FoodItemViewForm.FormBorderStyle = FormBorderStyle.None;
            FoodItemViewForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(FoodItemViewForm);
            FoodItemViewForm.Show();
        }

        private void FoodEditForm_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            FoodItemEditForm FoodItemEditForm = new FoodItemEditForm();
            FoodItemEditForm.TopLevel = false;
            FoodItemEditForm.FormBorderStyle = FormBorderStyle.None;
            FoodItemEditForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(FoodItemEditForm);
            FoodItemEditForm.Show();
        }

        private void FoodDeleteForm_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            FoodItemDeleteForm FoodItemDeleteForm = new FoodItemDeleteForm();
            FoodItemDeleteForm.TopLevel = false;
            FoodItemDeleteForm.FormBorderStyle = FormBorderStyle.None;
            FoodItemDeleteForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(FoodItemDeleteForm);
            FoodItemDeleteForm.Show();
        }

        private void UserSettingBtn_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            SettingForm SettingForm = new SettingForm();
            SettingForm.TopLevel = false;
            SettingForm.FormBorderStyle = FormBorderStyle.None;
            SettingForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(SettingForm);
            SettingForm.Show();
        }

        private void EmployeeSalaryForm_Click(object sender, EventArgs e)
        {
            MainBoxPanel.Controls.Clear();
            SalaryForm SalaryForm = new SalaryForm();
            SalaryForm.TopLevel = false;
            SalaryForm.FormBorderStyle = FormBorderStyle.None;
            SalaryForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(SalaryForm);
            SalaryForm.Show();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
           
        }
    }
}

