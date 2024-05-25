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
using System.Xml.Linq;

namespace Hostel_Management_System.Data_Layer
{
    internal class MBookingCRUD
    {
        static string connection = "Data Source=DESKTOP-0L4773Q\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;Encrypt=False;";

        public DeleteBookingForm Composition
        {
            get => default;
            set
            {
            }
        }

        public AddBookingForm CompositioN
        {
            get => default;
            set
            {
            }
        }

        public ViewBookingForm ComosiTion
        {
            get => default;
            set
            {
            }
        }

        public EditBookingForm CoMposition
        {
            get => default;
            set
            {
            }
        }

        public static void getRoomNo(Guna2ComboBox RoomNo)
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"SELECT room_no from Rooms where status='Free'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RoomNo.Items.Add(reader["room_no"].ToString());
            }

            con.Close();
        }

        public static void AddBooking(Guna2TextBox Name, Guna2TextBox CNIC, Guna2TextBox Contact, Guna2TextBox Payment,Guna2ComboBox Gender, Guna2ComboBox RoomType, Guna2ComboBox Facility, Guna2ComboBox RoomNo, Guna2DateTimePicker Date)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string Empquery = $"INSERT INTO Bookings  VALUES ('{Name.Text}', {CNIC.Text}, {Contact.Text}, {Payment.Text}, '{Gender.Text}', '{RoomType.Text}',' {Facility.Text}',{RoomNo.Text},'{Date.Value}')";
            SqlCommand EmpTable = new SqlCommand(Empquery, con);
            EmpTable.ExecuteNonQuery();

            string getKeyQuery = $"Select booking_id from Bookings where name='{Name.Text}' AND cnic='{CNIC.Text}' And contact={Contact.Text}";
            SqlCommand getKey = new SqlCommand(getKeyQuery, con);
            int key = (int)getKey.ExecuteScalar();

            string RoomQuery = $"Update Rooms Set booking_id={key},status='Booked' where room_no={RoomNo.Text}";
            SqlCommand RoomTable = new SqlCommand(RoomQuery, con);
            RoomTable.ExecuteNonQuery();

            con.Close();
        }


        public static void VeiwAll(Guna2DataGridView UserGrid)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "";
            con.Open();

            query = $"select * from BookingView;";



            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CNIC", typeof(long));
            table.Columns.Add("Contact", typeof(long));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Payment", typeof(long));
            table.Columns.Add("RoomNo", typeof(int));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("BookedDate", typeof(DateTime));

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Name"] = reader["Name"].ToString();
                row["CNIC"] = Convert.ToInt64(reader["CNIC"]);
                row["Contact"] = Convert.ToInt64(reader["Contact"]);
                row["Gender"] = reader["Gender"].ToString();
                row["Payment"] = Convert.ToInt64(reader["Payment"]);
                row["RoomNo"] = Convert.ToInt64(reader["RoomNo"]);
                row["Status"] = reader["Status"].ToString();
                row["BookedDate"] = Convert.ToDateTime(reader["BookedDate"]);

                table.Rows.Add(row);
            }

            UserGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            UserGrid.DataSource = table;

            // Close connection
            con.Close();
        }




        public static void VeiwbySearch(Guna2DataGridView UserGrid,Guna2TextBox Name)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "";
            con.Open();
            if (!long.TryParse(Name.Text, out long intName))
            {
                query = $"SELECT name as Name,cnic as CNIC,contact as Contact,gender as Gender,payment as Payment,booking_date as BookedDate,Rooms.room_no as RoomNo,Rooms.status as Status FROM Bookings inner join Rooms on Bookings.booking_id=Rooms.booking_id where name='{Name.Text}' AND Rooms.status='Booked';";
            }
            else
            {
                query = $"SELECT name as Name,cnic as CNIC,contact as Contact,gender as Gender,payment as Payment,booking_date as BookedDate,Rooms.room_no as RoomNo,Rooms.status as Status FROM Bookings inner join Rooms on Bookings.booking_id=Rooms.booking_id where cnic={long.Parse(Name.Text)} AND Rooms.status='Booked';";
            }



            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CNIC", typeof(long));
            table.Columns.Add("Contact", typeof(long));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Payment", typeof(long));
            table.Columns.Add("RoomNo", typeof(int));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("BookedDate", typeof(DateTime));

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Name"] = reader["Name"].ToString();
                row["CNIC"] = Convert.ToInt64(reader["CNIC"]);
                row["Contact"] = Convert.ToInt64(reader["Contact"]);
                row["Gender"] = reader["Gender"].ToString();
                row["Payment"] = Convert.ToInt64(reader["Payment"]);
                row["RoomNo"] = Convert.ToInt64(reader["RoomNo"]);
                row["Status"] = reader["Status"].ToString();
                row["BookedDate"] = Convert.ToDateTime(reader["BookedDate"]);

                table.Rows.Add(row);
            }

            UserGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            UserGrid.DataSource = table;

            // Close connection
            con.Close();
        }

        public static int FindKey(string name, long cnic, long contact)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string id = $"execute FindKeyForBooking '{name}',{ cnic},{ contact}";
            ;
            SqlCommand checkId = new SqlCommand(id, con);
            int key = (int)checkId.ExecuteScalar();
            con.Close();
            return key;
        }
        public static int FindRoomNo(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string room = $"select room_no from Rooms where booking_id={id}";
            SqlCommand getRoom = new SqlCommand(room, con);
            int roomNo = (int)getRoom.ExecuteScalar();
            con.Close();
            return roomNo;
        }
        public static void DeleteBooking(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = $"update Rooms set status='Free' where booking_id={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            string Salaryquery = $"Delete from Bookings where booking_id={id}";
            SqlCommand SalaryTable = new SqlCommand(Salaryquery, con);
            SalaryTable.ExecuteNonQuery();
       

            con.Close();
        }
        public static void EditBooking(Guna2TextBox Name, Guna2TextBox CNIC, Guna2TextBox Contact, Guna2TextBox Payment, Guna2ComboBox Gender, Guna2ComboBox RoomType, Guna2ComboBox Facility, Guna2ComboBox RoomNo, Guna2DateTimePicker Date, int key,int PrevRoom)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = $"update Bookings set name ='{Name.Text}',cnic={long.Parse(CNIC.Text)},contact={long.Parse(Contact.Text)},payment={long.Parse(Payment.Text)},gender='{Gender.Text}',RoomType='{RoomType.Text}',facility='{Facility.Text}',room_no={int.Parse(RoomNo.Text)},booking_date='{Date.Value}' where booking_id={key}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            string RoomQuery = $"update Rooms set status='Booked',room_no={int.Parse(RoomNo.Text)},booking_id={key} where booking_id={key}";
            SqlCommand RoomTable = new SqlCommand(RoomQuery, con);
            RoomTable.ExecuteNonQuery();
            string DelFreeQuery = $"Delete  from Rooms where room_no={RoomNo.Text} AND status='Free'";
            SqlCommand DelFree = new SqlCommand(DelFreeQuery, con);
            DelFree.ExecuteNonQuery();
            string unBookQuery = $"Insert into Rooms values({PrevRoom},'Free',{0})";
            SqlCommand unBook = new SqlCommand(unBookQuery, con);
            unBook.ExecuteNonQuery();

            con.Close();
        }

    }
}
