using Guna.UI2.WinForms;
using Hostel_Management_System.Business_Layer;
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

    public partial class PrintFoodDataForm : Form
    {
        string name, item, category,quantity;
        int price;

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintBtnLogic.print(Panel);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        long totalPrice;

        public PrintFoodDataForm(Guna2TextBox name,Guna2ComboBox item, Guna2ComboBox category,int price, Guna2TextBox quantity,long totalPrice)
        {
            InitializeComponent();
            this.name = name.Text;
            this.item = item.Text;
            this.category = category.Text;
            this.price = price;
            this.quantity = quantity.Text;
            this.totalPrice = totalPrice;
        }

        private void PrintFoodDataForm_Load(object sender, EventArgs e)
        {
            Namelb.Text = this.name;
            Itemlb.Text = this.item;
            Categorylb.Text = this.category;
            Pricelb.Text = this.price.ToString();
            Quantitylb.Text = this.quantity;
            TotalPriceLb.Text = this.totalPrice.ToString();

            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("yyyy-MM-dd");
            Datelb.Text = "Date : " + date;
        }
    }
}
