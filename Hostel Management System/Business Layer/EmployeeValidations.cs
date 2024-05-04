using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Business_Layer
{
    internal class EmployeeValidations
    {
        public static bool Emp(Guna2TextBox Name, Guna2TextBox CNIC, Guna2TextBox Contact, Guna2TextBox Salary, Guna2TextBox Address, Guna2TextBox Password, Guna2HtmlLabel NameErrorlb, Guna2HtmlLabel CNICErrorlb, Guna2HtmlLabel ContactErrorlb, Guna2HtmlLabel SalaryErrorlb, Guna2HtmlLabel AddressErrorlb, Guna2HtmlLabel PasswordErrorlb)
        {
            if (string.IsNullOrEmpty(Name.Text.Trim()))
            {
                NameErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(CNIC.Text.Trim()))
            {
               CNICErrorlb.Text = "Please fill this out !";
                return false;
            }
      

            if (string.IsNullOrEmpty(Contact.Text.Trim()))
            {
                ContactErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(Salary.Text.Trim()))
            {
                SalaryErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(Address.Text.Trim()))
            {
                AddressErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(Password.Text.Trim()))
            {
                PasswordErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (!long.TryParse(CNIC.Text, out long intValue))
            {
                CNICErrorlb.Text = "Please Add Integer Value!";
                return false;
            }
            if (!long.TryParse(Contact.Text, out long intContact))
            {
                ContactErrorlb.Text = "Please Add Integer Value!";
                return false;
            }
            if (!long.TryParse(Salary.Text, out long intAddress))
            {
                SalaryErrorlb.Text = "Please Add Integer Value!";
                return false;
            }
        

            return true;
        }

        public static bool Emp(Guna2TextBox Name, Guna2TextBox CNIC, Guna2TextBox Contact, Guna2TextBox Salary, Guna2TextBox Address, Guna2HtmlLabel NameErrorlb, Guna2HtmlLabel CNICErrorlb, Guna2HtmlLabel ContactErrorlb, Guna2HtmlLabel SalaryErrorlb, Guna2HtmlLabel AddressErrorlb)
        {
            if (string.IsNullOrEmpty(Name.Text.Trim()))
            {
                NameErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(CNIC.Text.Trim()))
            {
                CNICErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(Contact.Text.Trim()))
            {
                ContactErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(Salary.Text.Trim()))
            {
                SalaryErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(Address.Text.Trim()))
            {
                AddressErrorlb.Text = "Please fill this out !";
                return false;
            }
         
            if (!long.TryParse(CNIC.Text, out long intValue))
            {
                CNICErrorlb.Text = "Please Add Integer Value!";
                return false;
            }
            if (!long.TryParse(Contact.Text, out long intContact))
            {
                ContactErrorlb.Text = "Please Add Integer Value!";
                return false;
            }
            if (!long.TryParse(Salary.Text, out long intAddress))
            {
                SalaryErrorlb.Text = "Please Add Integer Value!";
                return false;
            }

            return true;
        }
    }
}
