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
    public partial class FoodItemDeleteForm : Form
    {
        int key;
        public FoodItemDeleteForm()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MFoodItemCRUD.ViewAllFoodItem(FoodGridView);
        }

        private void FoodGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = FoodGridView.SelectedRows[0].Cells[0].Value.ToString();
            string category = FoodGridView.SelectedRows[0].Cells[1].Value.ToString();
            key = MFoodItemCRUD.FindKey(name,category);
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MFoodItemCRUD.DeleteFoodItem(key);
            MFoodItemCRUD.ViewAllFoodItem(FoodGridView);
        }

        private void FoodItemDeleteForm_Load(object sender, EventArgs e)
        {
            MFoodItemCRUD.ViewAllFoodItem(FoodGridView);

        }
    }
}
