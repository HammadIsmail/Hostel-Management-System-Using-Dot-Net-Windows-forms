using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Business_Layer
{
    internal class Validations
    {

        public static bool InputField(KryptonLabel usernameErrorLb, KryptonLabel passwordErrorLb,KryptonTextBox UsernameTxt, KryptonTextBox PasswordTxt)
        {
            if (string.IsNullOrEmpty(UsernameTxt.Text.Trim()) || UsernameTxt.Text.Trim() == "UserName")
            {
                usernameErrorLb.Text = "Please fill this out !";

                return false;
            }
        

            if (string.IsNullOrEmpty(PasswordTxt.Text.Trim()) || PasswordTxt.Text.Trim() == "Password")
            {
                passwordErrorLb.Text = "Please fill this out !";
                return false;
            }
           



            return true;
        }

        public static void CheckPassword(KryptonCheckBox ShowPassword, KryptonTextBox PasswordTxt)
        {

            if (!ShowPassword.Checked)
            {
                PasswordTxt.UseSystemPasswordChar = true;
            }
        }

        public static void TogglePassword(KryptonTextBox PasswordTxt)
        {
            PasswordTxt.UseSystemPasswordChar = !PasswordTxt.UseSystemPasswordChar;

        }

        public static bool Room(Guna2TextBox Room,Guna2HtmlLabel roomErrorlb)
        {
            if (string.IsNullOrEmpty(Room.Text.Trim()))
            {
                roomErrorlb.Text = "Please fill this out !";
                roomErrorlb.ForeColor=Color.Red;
                return false;
            }
            if (!int.TryParse(Room.Text, out int intValue))
            {
                roomErrorlb.Text = "Please Add Integer Value !";
                roomErrorlb.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        public static bool Setting(Guna2TextBox Status, Guna2HtmlLabel StatusErrorlb)
        {
          
            if (string.IsNullOrEmpty(Status.Text.Trim()))
            {
                StatusErrorlb.Text = "Please fill this out !";
                return false;
            }
         
            if (!int.TryParse(Status.Text, out int intValue))
            {
                Status.Text = "Please Add Integer Value !";
                return false;
            }
        
            return true;
        }

        public static bool SettingSearch(Guna2TextBox search, Guna2HtmlLabel searchErrorlb)
        {
            if (string.IsNullOrEmpty(search.Text.Trim()))
            {
                searchErrorlb.Text = "Please fill this out !";
                return false;
            }
       
            return true;
        }

    }
}
