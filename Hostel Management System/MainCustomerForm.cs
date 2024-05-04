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
    public partial class MainCustomerForm : Form
    {
        bool MenuBar=true;
        string Name;
        public MainCustomerForm(string Name)
        {
            InitializeComponent();
            this.Name= Name;
        }
        //211
        private void Form1_Load(object sender, EventArgs e)
        {
            CLoseBtn.Location = new System.Drawing.Point(1340, 6);


            UserNamelb.Text = "WElcome! " + this.Name;

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
            MainBoxPanel.Controls.Clear();
            CustomerBookingForm customerBookingForm  = new CustomerBookingForm(this.Name);
            customerBookingForm.TopLevel = false;
            customerBookingForm.FormBorderStyle = FormBorderStyle.None;
            customerBookingForm.Dock = DockStyle.Fill;
            MainBoxPanel.Controls.Add(customerBookingForm);
            customerBookingForm.Show();
        }

        private void MainBoxPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddUserBtn_MouseHover(object sender, EventArgs e)
        {
            
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
          

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
          
        }

     

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodAddForm_Click(object sender, EventArgs e)
        {
         
        }

        private void FoodViewForm_Click(object sender, EventArgs e)
        {
            
        }

        private void FoodEditForm_Click(object sender, EventArgs e)
        {
        
        }

        private void FoodDeleteForm_Click(object sender, EventArgs e)
        {
      
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}

