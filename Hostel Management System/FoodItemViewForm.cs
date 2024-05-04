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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class FoodItemViewForm : Form
    {
        public FoodItemViewForm()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void FoodItemViewForm_Load(object sender, EventArgs e)
        {
            MFoodItemCRUD.ViewAllFoodItem(FoodGridView);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox,SearchErrorlb);
            if (success)
            {
                MFoodItemCRUD.ViewFoodItemBySearch(FoodGridView, SearchBox);
            }
            SearchBox.Text = "";

        }
    }
}
