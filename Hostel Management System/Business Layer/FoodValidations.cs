using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Business_Layer
{
    internal class FoodValidations
    {
        internal Data_Layer.MFoodItemCRUD Association
        {
            get => default;
            set
            {
            }
        }

        public static bool Food(Guna2TextBox Name, Guna2TextBox Category, Guna2TextBox Price, Guna2TextBox Quantity, Guna2HtmlLabel NameErrorlb, Guna2HtmlLabel CategoryErrorlb, Guna2HtmlLabel PriceErrorlb, Guna2HtmlLabel QuantityErrorlb)
        {
            if (string.IsNullOrEmpty(Name.Text.Trim()))
            {
                NameErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (string.IsNullOrEmpty(Category.Text.Trim()))
            {
                CategoryErrorlb.Text = "Please fill this out !";
                return false;
            }
           
            if (string.IsNullOrEmpty(Price.Text.Trim()))
            {
                PriceErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (!long.TryParse(Price.Text, out long intValue))
            {
                PriceErrorlb.Text = "Please Add Integer Value!";
                return false;
            }
         

            if (string.IsNullOrEmpty(Quantity.Text.Trim()))
            {
                QuantityErrorlb.Text = "Please fill this out !";
                return false;
            }
            if (!long.TryParse(Quantity.Text, out long intContact))
            {
                QuantityErrorlb.Text = "Please Add Integer Value!";
                return false;
            }


          

            return true;
        }
    }
}
