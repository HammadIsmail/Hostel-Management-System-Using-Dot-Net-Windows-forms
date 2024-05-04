using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Data_Layer
{
    internal class DashboardCRUD
    {
        static string connection = "Data Source=DESKTOP-0L4773Q\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;Encrypt=False;";
        public static int GetAdmin()
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"select Count(*) from credentials where role='Admin';";
            SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }

        public static int GetEmployee()
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"select Count(*) from credentials where role='Employee';";
            SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }

        public static int GetCustomer()
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"select Count(*) from credentials where role='Customer';";
            SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }

        public static int GetRooms()
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"select Count(*) from Rooms;";
            SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }
        public static int GetBookedRooms()
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"select Count(*) from Rooms where status='Booked';";
            SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }

        public static int GetFreeRooms()
        {

            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = $"select Count(*) from Rooms where status='Free';";
            SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }

       

            public static long GetRent()
            {
                SqlConnection con = new SqlConnection(connection);
                // open connection
                con.Open();
                string query = "select sum(payment) from Bookings;";
                SqlCommand cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar();
                con.Close();

                // Use null-coalescing operator to handle null result
                long count = (result != DBNull.Value) ? (long)result : 0;

                return count;
            }

        
        public static long GetFoodSale()
        {

        
            SqlConnection con = new SqlConnection(connection);
            // open connection
            con.Open();
            string query = "select sum(sale_amount) from Foodsales;";
            SqlCommand cmd = new SqlCommand(query, con);
            object result = cmd.ExecuteScalar();
            con.Close();

            // Use null-coalescing operator to handle null result
            long count = (result != DBNull.Value) ? (long)result : 0;

            return count;
         
        }

        public static long GetTotalProfit()
        {
            long Rent = GetRent();
            long FoodSale= GetFoodSale();
            long Total=Rent+FoodSale;
            return Total;
        }
    }
}
