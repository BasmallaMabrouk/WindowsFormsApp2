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
            EmployeeList.DataSource = Convert.GetDate(Query);
        }  
        private void GetDepatment()
        {
            string Query = "select * from DepartmentTbl";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
