using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    functions Con;
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
            Con = new functions();
            ShowEmp();
            GetDepartment();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void ShowEmp()
        {
            string Query = "select * from EmployeeTbl";
            EmployeeList.DataSource = Con.GetDate(Query);
        }  
        private void GetDepatment()
        {
            string Query = "select * from DepartmentTbl";
            DepCb.DisplayMember = Con.GetTypeCode(Query).columns["DepName"].tostring();
            DepCb.ValueMember = Con.GetData(Query).columns["DepId"].Tostring(); 
            DepCb.DataSource = Con.GetDate(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalaryTb.Texrv == "") ;
                {
                    MessageBox.Show("Missing Data")
                }
                else
                {
                    string Name =EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.Tostring();
                    string Dep = GenCb.SelectedValue.Tostring();
                    string DOB = EmpNameTb.Text;
                    string Name = EmpNameTb.Text;
                    string Name = EmpNameTb.Text;

                }
            }
        }
    }
}
