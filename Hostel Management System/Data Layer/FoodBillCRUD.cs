using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Data_Layer
{
    internal class FoodBillCRUD
    {
        static string connection = "Data Source=DESKTOP-0L4773Q\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;Encrypt=False;";

        public static void getFoodItemName(Guna2ComboBox Name)
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT name from FoodItems";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name.Items.Add(reader["name"].ToString());
            }

            con.Close();
        }

        public static void getFoodItemCategory(Guna2ComboBox Category)
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT category from FoodItems";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category.Items.Add(reader["category"].ToString());
            }

            con.Close();
        }

        public static int getFoodItemPrice(string name,string category)
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT price from FoodItems where name='{name}' AND category='{category}';";
            SqlCommand cmd = new SqlCommand(query, con);
            int price = (int)cmd.ExecuteScalar();

            con.Close();
            return price;
        }

        public static void AddFoodItem(string Customer,string name, string category,int price,int quantity)
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT food_id from FoodItems where name='{name}' AND category='{category}';";
            SqlCommand cmd = new SqlCommand(query, con);
            int foodId = (int)cmd.ExecuteScalar();
            long totalSale = price * quantity;
            string Salesquery = $"insert into FoodSales values({foodId},'{Customer}','{name}','{category}',{price},{quantity},{totalSale});";
            SqlCommand salesTable = new SqlCommand(Salesquery, con);
            salesTable.ExecuteNonQuery();

          
            con.Close();
        }
        public static void changeQuantity( string name, string category, int quantity,int price)
        {
            
            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT quatity from FoodItems where name='{name}' AND category='{category}';";
            SqlCommand cmd = new SqlCommand(query, con);
            int prevQuantity = (int)cmd.ExecuteScalar();
            int newQuantity = prevQuantity-quantity;
            long totalPrice=price * newQuantity;
            string changeQuantity = $"update FoodItems set quatity={newQuantity},total_price={totalPrice} where  name='{name}' AND category='{category}';";
            SqlCommand changeQuantityTable = new SqlCommand(changeQuantity, con);
            changeQuantityTable.ExecuteNonQuery();
            con.Close();
        }

        public static int checkQuantity(string name, string category)
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT quatity from FoodItems where name='{name}' AND category='{category}';";
            SqlCommand cmd = new SqlCommand(query, con);
            int prevQuantity = (int)cmd.ExecuteScalar();
            con.Close();
            return prevQuantity;

        }

        public static void ViewAllFoodItem(Guna2DataGridView Grid)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "SELECT customer_name AS CustomerName,item_name as ItemName,item_category AS Category,item_price as Price,sale_quantity as Quantity,sale_amount as TotalBill FROM FoodSales";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("CustomerName", typeof(string));
            table.Columns.Add("ItemName", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("TotalBill", typeof(long));

            while (reader.Read())
            {
                table.Rows.Add(
                    reader["CustomerName"],
                    reader["ItemName"],
                    reader["Category"],
                     reader["Price"],
                      reader["Quantity"],
                       reader["TotalBill"]

                    );
            }

            Grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            Grid.DataSource = table;

            // Close connection
            con.Close();
        }
        public static void ViewFoodItemBySearch(Guna2DataGridView Grid,Guna2TextBox Name)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = $"SELECT customer_name AS CustomerName,item_name as ItemName,item_category AS Category,item_price as Price,sale_quantity as Quantity,sale_amount as TotalBill FROM FoodSales where customer_name='{Name.Text}'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("CustomerName", typeof(string));
            table.Columns.Add("ItemName", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("TotalBill", typeof(long));

            while (reader.Read())
            {
                table.Rows.Add(
                    reader["CustomerName"],
                    reader["ItemName"],
                    reader["Category"],
                     reader["Price"],
                      reader["Quantity"],
                       reader["TotalBill"]

                    );
            }

            Grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            Grid.DataSource = table;

            // Close connection
            con.Close();
        }
        public static void DeleteFoodBill(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string Salaryquery = $"Delete from FoodSales where sale_id={id}";
            SqlCommand SalaryTable = new SqlCommand(Salaryquery, con);
            SalaryTable.ExecuteNonQuery();
            con.Close();
        }
        public static int FindKey(string customer,string item, int price,int quantity)
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT sale_id from FoodSales where customer_name='{customer}' AND item_name='{item}' AND item_price='{price}' And sale_quantity='{quantity}';";
            SqlCommand cmd = new SqlCommand(query, con);
            int key = (int)cmd.ExecuteScalar();

            con.Close();
            return key;
        }
    }
}
