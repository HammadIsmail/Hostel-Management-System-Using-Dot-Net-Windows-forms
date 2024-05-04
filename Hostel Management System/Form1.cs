using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Hostel_Management_System.Business_Layer;
using Hostel_Management_System.Data_Layer;

namespace Hostel_Management_System
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
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
            if (UserName.Text == "UserName")
            {
                UserName.Text = "";
                UserName.ForeColor = Color.Black;

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
            this.Hide();
            SignUpForm registerForm = new SignUpForm();
            registerForm.ShowDialog();
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
          bool success=Validations.InputField(usernameErrorLb, passwordErrorLb, UserName, Password);


            if (success)
            {
                string name = UserName.Text;
                string password = Password.Text;
                SignInResult result = MUserCRUD.SignIn(name, password);
                if (result.Count > 0 && result.IsAdmin=="Admin")
                {
                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    string Name = UserName.Text;

                    MainForm mainForm = new MainForm(Name);
                    mainForm.ShowDialog();
                    this.Close();
                }
                else if(result.Count > 0 && result.IsAdmin == "Employee")
                {
                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    string Name = UserName.Text;

                    MainEmployeeForm MainEmployeeForm = new MainEmployeeForm(Name);
                    MainEmployeeForm.ShowDialog();
                    this.Close();

                }
                else if(result.Count>0 && result.IsAdmin=="Customer")
                {
                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    string Name=UserName.Text;
                    MainCustomerForm MainCustomerForm = new MainCustomerForm(Name);
                    MainCustomerForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UserName.Text = "";
                Password.Text = "";
            }
        }

        private void PasswordCheckCombo_CheckedChanged(object sender, EventArgs e)
        {
            Validations.TogglePassword(Password);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
