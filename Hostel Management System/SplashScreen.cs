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

namespace Hostel_Management_System
{
    public partial class SplashScreen : KryptonForm
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadingBar.Value = 0;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void Loading_Tick(object sender, EventArgs e)
        {
            if (LoadingBar.Value == 100)
            {
                Loading.Enabled = false;
                this.Hide();
                LoginForm LoginForm = new LoginForm();
                LoginForm.ShowDialog();
                this.Close();
            } 
            else
            {
                LoadingBar.Value += 10;
                LoadingBar.Text = LoadingBar.Value.ToString() + "%";
            }
             


            
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

