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
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class EmployeeViewForm : Form
    {
        public EmployeeViewForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool success = Validations.SettingSearch(SearchBox, SearchErrorlb);
            if (success)
            {
                MEmployeeCRUD.VeiwBySearch(EmpGridView, SearchBox);
            }
            SearchBox.Clear();
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            MEmployeeCRUD.VeiwAll(EmpGridView);
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            MEmployeeCRUD.VeiwAll(EmpGridView);

        }


    }
}
