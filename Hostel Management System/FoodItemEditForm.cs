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
using System.Windows.Input;

namespace Hostel_Management_System
{
    public partial class FoodItemEditForm : Form
    {
        int key;
        public FoodItemEditForm()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void FoodItemEditForm_Load(object sender, EventArgs e)
        {
            MFoodItemCRUD.ViewAllFoodItem(FoodGridView);
        }

        private void FoodGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = FoodGridView.SelectedRows[0].Cells[0].Value.ToString();
            string category = FoodGridView.SelectedRows[0].Cells[1].Value.ToString();
            int  Price = (int)FoodGridView.SelectedRows[0].Cells[2].Value;
            int  Quantity =(int)FoodGridView.SelectedRows[0].Cells[3].Value;
            key = MFoodItemCRUD.FindKey(name, category);
            NameBox.Text = name;
            CategoryBox.Text = category;
            PriceBox.Text=Price.ToString();
            QuantityBox.Text=Quantity.ToString();
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MFoodItemCRUD.ViewAllFoodItem(FoodGridView);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox, SearchErrorlb);
            if (success)
            {
                MFoodItemCRUD.ViewFoodItemBySearch(FoodGridView, SearchBox);
            }
            SearchBox.Text = "";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            bool success = FoodValidations.Food(NameBox, CategoryBox, PriceBox, QuantityBox, NameErrorlb, CategoryErrorlb, PriceErrorlb, QuantityErrorlb);
            if (success)
            {
                MFoodItemCRUD.EditFoodItem(NameBox,CategoryBox,PriceBox,QuantityBox,key);
                MFoodItemCRUD.ViewAllFoodItem(FoodGridView);

            }
        }
    }
}
