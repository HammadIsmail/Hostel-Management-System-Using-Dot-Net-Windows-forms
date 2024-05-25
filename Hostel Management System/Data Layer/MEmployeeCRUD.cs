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
    internal class MEmployeeCRUD
    {
        static string connection = "Data Source=DESKTOP-0L4773Q\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;Encrypt=False;";

        public EmployeeDeleteForm Composition
        {
            get => default;
            set
            {
            }
        }

        public AddEmployeeForm ComPosition
        {
            get => default;
            set
            {
            }
        }

        public EmployeeEditForm Compostion
        {
            get => default;
            set
            {
            }
        }

        public EmployeeViewForm Compostiom
        {
            get => default;
            set
            {
            }
        }

        public SalaryForm CompostioN
        {
            get => default;
            set
            {
            }
        }

        public static void AddEmployee(Guna2TextBox Name, Guna2TextBox CNIC, Guna2TextBox Contact, Guna2TextBox Salary, Guna2TextBox Address, Guna2TextBox Password,Guna2ComboBox Gender, Guna2ComboBox Rank,Guna2DateTimePicker Date)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string Empquery = $"INSERT INTO Employee  VALUES ('{Name.Text}', {CNIC.Text}, {Contact.Text}, {Salary.Text}, '{Address.Text}', '{Gender.Text}',' {Rank.Text}','{Date.Value}')";
            SqlCommand EmpTable = new SqlCommand(Empquery, con);
            EmpTable.ExecuteNonQuery();

            string UserQuery = $"INSERT INTO Credentials Values('{Name.Text}','{Password.Text}','Employee','{1}')";
            SqlCommand UserTable = new SqlCommand(UserQuery, con);
            UserTable.ExecuteNonQuery();

            string getForeignKeyQuery = $"Select emp_id from Employee where name='{Name.Text}' And cnic={CNIC.Text}";
            SqlCommand getgetForeignKey=new SqlCommand(getForeignKeyQuery, con);
            int id = (int)getgetForeignKey.ExecuteScalar();

            string SalaryQuery = $"INSERT INTO EmployeeSalary Values({id},{0},'UnPaid')";
            SqlCommand SalaryTable = new SqlCommand (SalaryQuery, con);
            SalaryTable.ExecuteNonQuery();
            //close connection

            con.Close();
        }

        public static void VeiwBySearch(Guna2DataGridView UserGrid, Guna2TextBox Name)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "";
            con.Open();
            if (!long.TryParse(Name.Text, out long intName))
            {
                 query = $"SELECT name as Name,cnic as CNIC,contact as Contact,gender as Gender,salary as Salary,address as Address,position as Position,emp_date as DateOfJoining FROM Employee where name='{Name.Text}';";
            }
           else 
            {
                query = $"SELECT name as Name,cnic as CNIC,contact as Contact,gender as Gender,salary as Salary,address as Address,position as Position,emp_date as DateOfJoining FROM Employee where cnic={long.Parse(Name.Text)};";
            }
          
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader =cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CNIC", typeof(long));
            table.Columns.Add("Contact", typeof(long));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Salary", typeof(long));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Position", typeof(string));
            table.Columns.Add("DateOfJoining", typeof(DateTime));

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Name"] = reader["Name"].ToString();
                row["CNIC"] = Convert.ToInt64(reader["CNIC"]);
                row["Contact"] = Convert.ToInt64(reader["Contact"]);
                row["Gender"] = reader["Gender"].ToString();
                row["Salary"] = Convert.ToInt64(reader["Salary"]);
                row["Address"] = reader["Address"].ToString();
                row["Position"] = reader["Position"].ToString();
                row["DateOfJoining"] = Convert.ToDateTime(reader["DateOfJoining"]);

                table.Rows.Add(row);
            }

            UserGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            UserGrid.DataSource = table;

            // Close connection
            con.Close();
        }

        public static void VeiwAll(Guna2DataGridView UserGrid)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "";
            con.Open();
           
                query = $"select * from EmployeeView;";
            
         

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CNIC", typeof(long));
            table.Columns.Add("Contact", typeof(long));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Salary", typeof(long));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Position", typeof(string));
            table.Columns.Add("DateOfJoining", typeof(DateTime));

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Name"] = reader["Name"].ToString();
                row["CNIC"] = Convert.ToInt64(reader["CNIC"]);
                row["Contact"] = Convert.ToInt64(reader["Contact"]);
                row["Gender"] = reader["Gender"].ToString();
                row["Salary"] = Convert.ToInt64(reader["Salary"]);
                row["Address"] = reader["Address"].ToString();
                row["Position"] = reader["Position"].ToString();
                row["DateOfJoining"] = Convert.ToDateTime(reader["DateOfJoining"]);

                table.Rows.Add(row);
            }

            UserGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            UserGrid.DataSource = table;

            // Close connection
            con.Close();
        }

        public static void DeleteEmp(int id,string name)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string Salaryquery = $"Delete from EmployeeSalary where emp_id={id}";
            SqlCommand SalaryTable = new SqlCommand(Salaryquery, con);
            SalaryTable.ExecuteNonQuery();
            string query = $"Delete from Employee where emp_id={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
          
            string queryUser = $"Delete from Credentials where username='{name}'";
            SqlCommand cmdUser = new SqlCommand(queryUser, con);
            cmdUser.ExecuteNonQuery();

            con.Close();
        }
        public static int FindKey(string name, long cnic, long contact)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string id = $"execute FindKeyForEmployee '{name}',{ cnic},{contact}";
            SqlCommand checkId = new SqlCommand(id, con);
            int key = (int)checkId.ExecuteScalar();
            con.Close();
            return key;
        }

        public static void EditEmp(Guna2TextBox Name, Guna2TextBox CNIC, Guna2TextBox Contact, Guna2TextBox Salary, Guna2TextBox Address, Guna2ComboBox Gender, Guna2ComboBox Rank, Guna2DateTimePicker Date,int key)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = $"update Employee set name ='{Name.Text}',cnic={long.Parse(CNIC.Text)},contact={long.Parse(Contact.Text)},salary={long.Parse(Salary.Text)},address='{Address.Text}',gender='{Gender.Text}',position='{Rank.Text}',emp_date='{Date.Value}' where emp_id={key}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public static void SalaryVeiwAll(Guna2DataGridView UserGrid)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "";
            con.Open();

            query = $"SELECT Employee.name as Name,Employee.cnic as CNIC,Employee.contact as Contact,Employee.position as Position,EmployeeSalary.salary as Salary,EmployeeSalary.status as Status FROM Employee inner join EmployeeSalary on Employee.emp_id=EmployeeSalary.emp_id where EmployeeSalary.status='UnPaid';";



            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CNIC", typeof(long));
            table.Columns.Add("Contact", typeof(long));
            table.Columns.Add("Position", typeof(string));
            table.Columns.Add("Salary", typeof(long));
            table.Columns.Add("Status", typeof(string));

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Name"] = reader["Name"].ToString();
                row["CNIC"] = Convert.ToInt64(reader["CNIC"]);
                row["Contact"] = Convert.ToInt64(reader["Contact"]);
                row["Position"] = reader["Position"].ToString();
                row["Salary"] = Convert.ToInt64(reader["Salary"]);
                row["Status"] = (reader["Status"]).ToString();

                table.Rows.Add(row);
            }

            UserGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            UserGrid.DataSource = table;

            // Close connection
            con.Close();
        }

        public static void SalaryVeiwBySearch(Guna2DataGridView UserGrid,Guna2TextBox Name)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "";
            con.Open();

            if (!long.TryParse(Name.Text, out long intName))
            {
                query = $"SELECT Employee.name as Name,Employee.cnic as CNIC,Employee.contact as Contact,Employee.position as Position,EmployeeSalary.salary as Salary,EmployeeSalary.status as Status FROM Employee inner join EmployeeSalary on Employee.emp_id=EmployeeSalary.emp_id where Employee.name='{Name.Text}' And EmployeeSalary.status='UnPaid'";
            }
            else
            {
                query = $"SELECT Employee.name as Name,Employee.cnic as CNIC,Employee.contact as Contact,Employee.position as Position,EmployeeSalary.salary as Salary,EmployeeSalary.status as Status FROM Employee inner join EmployeeSalary on Employee.emp_id=EmployeeSalary.emp_id where Employee.cnic={long.Parse(Name.Text)} And EmployeeSalary.status='UnPaid'";
            }



            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CNIC", typeof(long));
            table.Columns.Add("Contact", typeof(long));
            table.Columns.Add("Position", typeof(string));
            table.Columns.Add("Salary", typeof(long));
            table.Columns.Add("Status", typeof(string));

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Name"] = reader["Name"].ToString();
                row["CNIC"] = Convert.ToInt64(reader["CNIC"]);
                row["Contact"] = Convert.ToInt64(reader["Contact"]);
                row["Position"] = reader["Position"].ToString();
                row["Salary"] = Convert.ToInt64(reader["Salary"]);
                row["Status"] = (reader["Status"]).ToString();

                table.Rows.Add(row);
            }

            UserGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            UserGrid.DataSource = table;

            // Close connection
            con.Close();
        }

        public static void PaySalary(Guna2TextBox Salary,Guna2ComboBox Status, int key)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = $"update EmployeeSalary set salary ={long.Parse(Salary.Text)},status='{Status.Text}' where emp_id={key}";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
