using Hostel_Management_System.Business_Layer;
using Hostel_Management_System.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class AddFoodItemForm : Form
    {
        public AddFoodItemForm()
        {
            InitializeComponent();
        }

        private void AddFoodItemBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool success = FoodValidations.Food(NameBox,CategoryBox,PriceBox,QuantityBox,NameErrorlb,CategoryErrorlb,PriceErrorlb,QuantityErrorlb);
            if (success)
            {
                int count = MFoodItemCRUD.CheckFoodItem(NameBox);
                if (count == 1)
                {
                    MessageBox.Show("Already Exits");
                }
                else
                {
                    MFoodItemCRUD.AddFoodItem(NameBox, CategoryBox, PriceBox, QuantityBox);

                }
            }
            NameBox.Clear();
            CategoryBox.Clear();
            PriceBox.Clear();
            QuantityBox.Clear();

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameErrorlb.Text = "";
        }

        private void CategoryBox_TextChanged(object sender, EventArgs e)
        {
            CategoryErrorlb.Text = "";
        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            PriceErrorlb.Text = "";
        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {
            QuantityErrorlb.Text = "";
        }

        private void AddFoodItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
