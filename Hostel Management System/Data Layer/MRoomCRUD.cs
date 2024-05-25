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
using System.Xml.Linq;

namespace Hostel_Management_System.Data_Layer
{
    internal class MRoomCRUD
    {
        static string connection = "Data Source=DESKTOP-0L4773Q\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;Encrypt=False;";

        public RoomForm Composition
        {
            get => default;
            set
            {
            }
        }

        public static void AddRoom(Guna2TextBox roomNo,Guna2HtmlLabel Errorlb) {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string checkRoom = $"Select Count(*) from Rooms where room_no ='{roomNo.Text}'";
            SqlCommand check = new SqlCommand(checkRoom,con);
            int count = (int)check.ExecuteScalar();
            if (count == 0)
            {
                string query = $"INSERT INTO Rooms (room_no,status,booking_id) VALUES('{roomNo.Text}','Free',{0})";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Room Already Exists");
                Errorlb.Text = "Already Exists";
                Errorlb.ForeColor = Color.Red;
            }
        
            //close connection

            con.Close();

        }

        public static void ViewAllRoom(Guna2DataGridView RoomGrid)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "select * from RoomsView;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("RoomNo", typeof(int)); // Assuming room_no is of integer type
            table.Columns.Add("RoomStatus", typeof(string)); // Assuming status is of string type

            while (reader.Read())
            {
                table.Rows.Add(reader["RoomNo"], reader["RoomStatus"]);
            }

            RoomGrid.ColumnHeadersDefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            RoomGrid.ColumnHeadersDefaultCellStyle.BackColor =Color.FromArgb(0, 120, 215);
            RoomGrid.DataSource = table;

            // Close connection
            con.Close();
        }
        public static void ViewRoomBySearch(Guna2DataGridView RoomGrid,Guna2TextBox roomNo)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = $"SELECT room_no AS RoomNo, status AS RoomStatus FROM Rooms where room_no={roomNo.Text}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("RoomNo", typeof(int)); // Assuming room_no is of integer type
            table.Columns.Add("RoomStatus", typeof(string)); // Assuming status is of string type

            while (reader.Read())
            {
                table.Rows.Add(reader["RoomNo"], reader["RoomStatus"]);
            }

            RoomGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RoomGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            RoomGrid.DataSource = table;

            // Close connection
            con.Close();
        }
        public static void DeleteRoom(Guna2TextBox roomNo)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = $"Delete  FROM Rooms where room_no={roomNo.Text}";
            SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                   con.Close();
        }

        public static int FindKey(Guna2TextBox roomNo)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string id = $"select room_id from Rooms where room_no ={roomNo.Text}";
            SqlCommand checkId = new SqlCommand(id, con);
            int key = (int)checkId.ExecuteScalar();
            con.Close();
            return key;
        }

        public static void EditRoom(Guna2TextBox roomNo ,int key)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
           
            string query = $"update Rooms set room_no ={roomNo.Text} FROM Rooms where room_id={key}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
