using Guna.UI2.WinForms;
using System;
using System.CodeDom.Compiler;
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
    internal class MFoodItemCRUD
    {
        static string connection = "Data Source=DESKTOP-0L4773Q\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;Encrypt=False;";

        public AddFoodItemForm composition
        {
            get => default;
            set
            {
            }
        }

        public FoodItemEditForm Compostion
        {
            get => default;
            set
            {
            }
        }

        public FoodItemViewForm ComPosition
        {
            get => default;
            set
            {
            }
        }

        public FoodItemDeleteForm comPostion
        {
            get => default;
            set
            {
            }
        }

        public static int CheckFoodItem(Guna2TextBox Name)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string checkQuery = $"Select count(*) from FoodItems where name='{Name.Text}'";
            SqlCommand checkTable = new SqlCommand(checkQuery, con);
            int count = (int)checkTable.ExecuteScalar();

            con.Close();

            return count;
        }

        public static void AddFoodItem(Guna2TextBox Name, Guna2TextBox Category, Guna2TextBox Price, Guna2TextBox Quantity)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            long totalPrice=int.Parse(Price.Text)*int.Parse(Quantity.Text);
         
       
                string FoodItemsQuery = $"INSERT INTO FoodItems  VALUES ('{Name.Text}','{Category.Text}',{int.Parse(Price.Text)},{int.Parse(Quantity.Text)},{totalPrice})";
                SqlCommand FoodTable = new SqlCommand(FoodItemsQuery, con);
                FoodTable.ExecuteNonQuery();

            con.Close();
        }

        public static void ViewAllFoodItem(Guna2DataGridView Grid )
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "select * from FoodItemView;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Category", typeof(string)); 
            table.Columns.Add("Price", typeof(int)); 
            table.Columns.Add("Quantity", typeof(int)); 
            table.Columns.Add("TotalPrice", typeof(long));

            while (reader.Read())
            {
                table.Rows.Add(reader["Name"],
                    reader["Category"],
                     reader["Price"],
                      reader["Quantity"],
                       reader["TotalPrice"]

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


            string query =$"SELECT name AS Name, category AS Category,price as Price,quatity as Quantity,total_price as TotalPrice FROM FoodItems where name='{Name.Text}' OR category='{Name.Text}'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("TotalPrice", typeof(long));

            while (reader.Read())
            {
                table.Rows.Add(reader["Name"],
                    reader["Category"],
                     reader["Price"],
                      reader["Quantity"],
                       reader["TotalPrice"]

                    );
            }

            Grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            Grid.DataSource = table;

            // Close connection
            con.Close();
        }

        public static void DeleteFoodItem(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string Salaryquery = $"Delete from FoodItems where food_id={id}";
            SqlCommand SalaryTable = new SqlCommand(Salaryquery, con);
            SalaryTable.ExecuteNonQuery();
         

            con.Close();
        }
        public static int FindKey(string name, string category)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string id = $"execute FindKeyForFoodItem '{name}','{category}';";
            SqlCommand checkId = new SqlCommand(id, con);
            int key = (int)checkId.ExecuteScalar();
            con.Close();
            return key;
        }
        public static void EditFoodItem(Guna2TextBox Name, Guna2TextBox Category, Guna2TextBox Price, Guna2TextBox Quantity, int key)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            int totalPrice=int.Parse(Price.Text)*int.Parse(Quantity.Text);
            string query = $"update FoodItems set name ='{Name.Text}',category='{Category.Text}',price={int.Parse(Price.Text)},quatity={int.Parse(Quantity.Text)},total_price={totalPrice} where food_id={key}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
