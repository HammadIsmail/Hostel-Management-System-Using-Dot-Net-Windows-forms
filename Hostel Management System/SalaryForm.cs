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
    public partial class SalaryForm : Form
    {
        int key;
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            MEmployeeCRUD.SalaryVeiwAll(EmpGridView);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox, SearchErrorlb);
            if (success)
            {
                MEmployeeCRUD.SalaryVeiwBySearch(EmpGridView, SearchBox);
                SearchBox.Text = "";
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchErrorlb.Text = "";
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MEmployeeCRUD.SalaryVeiwAll(EmpGridView);

        }

        private void EmpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = EmpGridView.SelectedRows[0].Cells[0].Value.ToString();
            long cnic = (long)EmpGridView.SelectedRows[0].Cells[1].Value;
            long contact = (long)EmpGridView.SelectedRows[0].Cells[2].Value;
            key = MEmployeeCRUD.FindKey(name, cnic, contact);
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            MEmployeeCRUD.PaySalary(SalaryBox, StatusBox, key);
            MEmployeeCRUD.SalaryVeiwAll(EmpGridView);
        }
    }
}
