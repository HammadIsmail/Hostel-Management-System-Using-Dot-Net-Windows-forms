using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Hostel_Management_System.Business_Layer;
using Hostel_Management_System.Data_Layer;

namespace Hostel_Management_System
{
    public partial class SignUpForm : KryptonForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if (UserName.Text == "UserNam")
            {
                UserName.Text = "";
                UserName.ForeColor = Color.Black;

            }
            usernameErrorLb.Text = "";

        }




        private void OnClickUserName_click(object sender, EventArgs e)
        {
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            passwordErrorLb.Text = "";
            Validations.CheckPassword(PasswordCheckCombo, Password);


        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            if(Password.Text == "UserName")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;

            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;

            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
         
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            this.Hide();
            LoginForm.ShowDialog();
            this.Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            bool success=Validations.InputField(usernameErrorLb, passwordErrorLb, UserName, Password);
           
            if (success)
            {
                bool check = Validations.ValidUserName(UserName, usernameErrorLb);
                if (check)
                {
                    string name = UserName.Text;
                    string password = Password.Text;
                    MUserCRUD.SignUp(name, password);

                //    MessageBox.Show("SignUp Successful ", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm LoginForm = new LoginForm();
                    LoginForm.ShowDialog();
                    this.Close();
                }
           
            }
        }

        private void PasswordCheckCombo_CheckedChanged(object sender, EventArgs e)
        {
            Validations.TogglePassword(Password);

        }
    }
}
