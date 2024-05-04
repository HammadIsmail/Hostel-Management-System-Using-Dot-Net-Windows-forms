using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Business_Layer
{
    internal class FoodBillValidations
    {
        public static bool FoodBill(Guna2TextBox CustomerName, Guna2TextBox Quantity, Guna2HtmlLabel CustomerNameErrorlb,Guna2HtmlLabel QuantityErrorlb)
        {
            if (string.IsNullOrEmpty(CustomerName.Text.Trim()))
            {
                CustomerNameErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(Quantity.Text.Trim()))
            {
                QuantityErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (!int.TryParse(Quantity.Text, out int intValue))
            {
                QuantityErrorlb.Text = "Please Add Integer Value !";
                return false;
            }
            return true;
        }
    }
}
