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
                    string Dep = Convert.ToInt32(GenCb.SelectedValue.Tostring());
                    string DOB = DOBTb.Value.Tostring();
                    string JDate = JDateTb.Value.Tostring();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "insert into EmployeeTbl Values('{0}','{1)','{2}','{3}','{4}',{5}";
                    Query = string(Query, Name,Gender,Dep,DOB,JDate,Salary);
                    Con.SetDate(Query,DepNameTb.Text);
                    ShowEmp();
                    MessageBox.Show("Emplyee Added");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = ""; 
                    GenCb.SelectedIndex= -1; 
                    DepCb.SelectedIndex= -1;
                }
            } 
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalaryTb.Texrv == "") ;
                {
                    MessageBox.Show("Missing Data")
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.Tostring();
                    string Dep = Convert.ToInt32(GenCb.SelectedValue.Tostring());
                    string DOB = DOBTb.Value.Tostring();
                    string JDate = JDateTb.Value.Tostring();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "Update EmployeeTbl set EmpName='{0}',EmpGen='{1)',EmpDep='{2}',EmpDOB='{3}',EmpJDate='{4}',EmpSal={5} where EmpId ={6}";
                    Query = string(Query, Name, Gender, Dep, DOB, JDate, Salary, key);
                    Con.SetDate(Query, DepNameTb.Text);
                    ShowEmp();
                    MessageBox.Show("Emplyee Added");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }
    }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalaryTb.Texrv == "") ;
                {
                    MessageBox.Show("Missing Data")
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.Tostring();
                    string Dep = Convert.ToInt32(GenCb.SelectedValue.Tostring());
                    string DOB = DOBTb.Value.Tostring();
                    string JDate = JDateTb.Value.Tostring();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "Update EmployeeTbl set EmpName='{0}',EmpGen='{1)',EmpDep='{2}',EmpDOB='{3}',EmpJDate='{4}',EmpSal={5} where EmpId ={6}";
                    Query = string(Query, Name, Gender, Dep, DOB, JDate, Salary,key);
                    Con.SetDate(Query, DepNameTb.Text);
                    ShowEmp();
                    MessageBox.Show("Emplyee Added");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }
        int key = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
}
