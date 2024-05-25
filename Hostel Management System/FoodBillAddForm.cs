using Hostel_Management_System.Business_Layer;
using Hostel_Management_System.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Hostel_Management_System
{
    public partial class FoodBillAddForm : Form
    {
        string name,category;
        int key;
        public FoodBillAddForm()
        {
            InitializeComponent();
        }

        public PrintFoodDataForm CompostIon
        {
            get => default;
            set
            {
            }
        }

        private void AddFoodItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void FoodBillAddForm_Load(object sender, EventArgs e)
        {
            FoodBillCRUD.ViewAllFoodItem(BillGridView);
            FoodBillCRUD.getFoodItemName(FoodItemNameBox);
            FoodItemNameBox.StartIndex = 0;
            FoodBillCRUD.getFoodItemCategory(FoodItemCategoryBox);
            FoodItemCategoryBox.StartIndex = 0;


        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void PrintBillBtn_Click(object sender, EventArgs e)
        {
            bool suceess = FoodBillValidations.FoodBill(CustomerNameBox, QuantityBox, CustomerNameErrorlb, QuantityErrorlb);
            if (suceess)
            {
                string CustomerName = CustomerNameBox.Text;
                int Quantity = int.Parse(QuantityBox.Text);
                int price = int.Parse(PriceBox.Text);
                int preQuantity = FoodBillCRUD.checkQuantity(name,category);
                if (preQuantity<Quantity)
                {
                    MessageBox.Show($"We have {preQuantity} of this Item");
                }
                else
                {
                    FoodBillCRUD.AddFoodItem(CustomerName, name, category, price, Quantity);
                    FoodBillCRUD.changeQuantity(name, category, Quantity,price);
                    FoodBillCRUD.ViewAllFoodItem(BillGridView);
                    long total=int.Parse(PriceBox.Text)*int.Parse(QuantityBox.Text);
                    PrintFoodDataForm printFoodDataForm = new PrintFoodDataForm(CustomerNameBox,FoodItemNameBox,FoodItemCategoryBox,int.Parse(PriceBox.Text),QuantityBox,total);
                    printFoodDataForm.ShowDialog();

                }
            }
            CustomerNameBox.Text = "";
            QuantityBox.Text = "";
        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {
            QuantityErrorlb.Text = "";
        }

        private void CustomerNameBox_TextChanged(object sender, EventArgs e)
        {
            CustomerNameErrorlb.Text = "";
        }

        private void FoodItemCategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = FoodItemCategoryBox.Text;
            PriceBox.Text=FoodBillCRUD.getFoodItemPrice(name,category).ToString();
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            FoodBillCRUD.ViewAllFoodItem(BillGridView);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox, SearchErrorlb);
            if (success)
            {
                FoodBillCRUD.ViewFoodItemBySearch(BillGridView, SearchBox);
            }
            SearchBox.Text = "";
        }

        private void BillGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string customer = BillGridView.SelectedRows[0].Cells[0].Value.ToString();
            string Item = BillGridView.SelectedRows[0].Cells[1].Value.ToString();
            int price = (int)BillGridView.SelectedRows[0].Cells[3].Value;
            int quantity = (int)BillGridView.SelectedRows[0].Cells[4].Value;
            key = FoodBillCRUD.FindKey(customer,Item,price,quantity);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            FoodBillCRUD.DeleteFoodBill(key);
            FoodBillCRUD.ViewAllFoodItem(BillGridView);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bool suceess = FoodBillValidations.FoodBill(CustomerNameBox, QuantityBox, CustomerNameErrorlb, QuantityErrorlb);
            if (suceess)
            {
                string CustomerName = CustomerNameBox.Text;
                int Quantity = int.Parse(QuantityBox.Text);
                int price = int.Parse(PriceBox.Text);
                int preQuantity = FoodBillCRUD.checkQuantity(name, category);
                if (preQuantity < Quantity)
                {
                    MessageBox.Show($"We have {preQuantity} of this Item");
                }
                else
                {
                    FoodBillCRUD.AddFoodItem(CustomerName, name, category, price, Quantity);
                    FoodBillCRUD.changeQuantity(name, category, Quantity, price);
                    FoodBillCRUD.ViewAllFoodItem(BillGridView);
             

                }
            }
            CustomerNameBox.Text = "";
            QuantityBox.Text = "";
        }

        private void FoodItemNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            name=FoodItemNameBox.Text;
        }
    }
}
