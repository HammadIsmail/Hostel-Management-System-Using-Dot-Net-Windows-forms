using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Business_Layer
{
    internal class BookingValidations
    {
        internal Data_Layer.MBookingCRUD Association
        {
            get => default;
            set
            {
            }
        }

        public static bool book(Guna2TextBox Name, Guna2TextBox CNIC, Guna2TextBox Contact, Guna2TextBox Payment, Guna2HtmlLabel NameErrorlb, Guna2HtmlLabel CNICErrorlb, Guna2HtmlLabel ContactErrorlb, Guna2HtmlLabel PaymentErrorlb)
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
            if (CNIC.Text.Length != 13)
            {
                CNICErrorlb.Text = "Incomplete Digits!";
                return false;
            }
            if (Contact.Text.Length !=11)
            {
                ContactErrorlb.Text = "Incomplete Digits!";
                return false;
            }
            if (!long.TryParse(CNIC.Text, out long intValue))
            {
                CNICErrorlb.Text = "Please Add Integer Value!";
                return false;
            }
            if (string.IsNullOrEmpty(Contact.Text.Trim()))
            {
                ContactErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (!long.TryParse(Contact.Text, out long intContact))
            {
                ContactErrorlb.Text = "Please Add Integer Value!";
                return false;
            }

            if (string.IsNullOrEmpty(Payment.Text.Trim()))
            {
                PaymentErrorlb.Text = "Please fill this out !";
                return false;
            }

         


            if (!long.TryParse(Payment.Text, out long intAddress))
            {
                PaymentErrorlb.Text = "Please Add Integer Value!";
                return false;
            }


            return true;
        }
    }
}
