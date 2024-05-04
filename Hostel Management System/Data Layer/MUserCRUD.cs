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
    public class SignInResult
    {
        public int Count;
        public string IsAdmin;
    }
    internal class MUserCRUD
    {
        static string connection = "Data Source=DESKTOP-0L4773Q\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;Encrypt=False;";

        public static SignInResult SignIn(string name, string password)
        {
            SignInResult result = new SignInResult();
          
            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT COUNT(*) FROM Credentials WHERE username = '{name}' AND password ='{password}' AND status = {1}";
            string queryAdmin = $"SELECT role FROM Credentials WHERE username = '{name}' AND password ='{password}' AND status = {1}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(queryAdmin, con);

            result.Count = (int)cmd.ExecuteScalar();
            result.IsAdmin = (string)cmd1.ExecuteScalar();
       
            con.Close();
            return result;
        }

        public static void SignUp(string name, string password)
        {
            SqlConnection con = new SqlConnection(connection);

            con.Open();

            string query = $"INSERT INTO Credentials (username, password,role,status) VALUES('{name}','{password}','Customer',{0})";

            //execute query
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            //close connection

            con.Close();
        }
     

        public static void VeiwAll(Guna2DataGridView UserGrid)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = $"SELECT username AS UserName, password AS Password,role as Role,status as Status FROM Credentials";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("UserName", typeof(string)); 
            table.Columns.Add("Password", typeof(string)); 
            table.Columns.Add("Role", typeof(string)); 
            table.Columns.Add("Status", typeof(int));

            while (reader.Read())
            {
                table.Rows.Add(reader["UserName"], reader["Password"], reader["Role"], reader["Status"]);
            }

            UserGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            UserGrid.DataSource = table;

            // Close connection
            con.Close();
        }
        public static int FindKey(string name,string password,string role,int status)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string id = $"select user_id from Credentials where username ='{name}' AND password='{password}' AND role='{role}' AND status={status}";
            SqlCommand checkId = new SqlCommand(id, con);
            int key = (int)checkId.ExecuteScalar();
            con.Close();
            return key;
        }
        public static void VeiwBySearch(Guna2DataGridView UserGrid,Guna2TextBox Name)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = $"SELECT username AS UserName, password AS Password,role as Role,status as Status FROM Credentials where username='{Name.Text}' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("UserName", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Role", typeof(string));
            table.Columns.Add("Status", typeof(int));

            while (reader.Read())
            {
                table.Rows.Add(reader["UserName"], reader["Password"], reader["Role"], reader["Status"]);
            }

            UserGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            UserGrid.DataSource = table;

            // Close connection
            con.Close();
        }

        public static void DeleteUser(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = $"Delete from Credentials where user_id={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void EditUser(Guna2TextBox status, Guna2ComboBox Role,int id)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = $"Update Credentials set role='{Role.Text}',status={int.Parse(status.Text)} where user_id={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
