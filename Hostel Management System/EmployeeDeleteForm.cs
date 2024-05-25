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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class EmployeeDeleteForm : Form
    {
        int key;
        string name;
        public EmployeeDeleteForm()
        {
            InitializeComponent();
        }

        private void EmployeeDeleteForm_Load(object sender, EventArgs e)
        {
            MEmployeeCRUD.VeiwAll(EmpGridView);
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MEmployeeCRUD.VeiwAll(EmpGridView);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox,Errorlb); 
            if (success)
            {
                MEmployeeCRUD.VeiwBySearch(EmpGridView, SearchBox);
            }
            SearchBox.Clear();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Errorlb.Text = "";
        }

        private void EmpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             name = EmpGridView.SelectedRows[0].Cells[0].Value.ToString();
            long cnic = (long)EmpGridView.SelectedRows[0].Cells[1].Value;
            long contact =(long)EmpGridView.SelectedRows[0].Cells[2].Value;
            key = MEmployeeCRUD.FindKey(name,cnic,contact);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MEmployeeCRUD.DeleteEmp(key,name);
            MEmployeeCRUD.VeiwAll(EmpGridView);

        }
    }
}
