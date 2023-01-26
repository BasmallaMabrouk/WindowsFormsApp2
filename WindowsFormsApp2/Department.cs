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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
            Con = new functions();
            ShowDepartments();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void ShowDepartments()
        {
            string Query = "select * from DeprartmentTl";
            DepList.DataSource = Con.GetData(Query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Dep = DepNameTb.Text; 
                    string Query ="insert into DepartmentTbl Values('{0}'); 
                        Query = string.Format(Query,DepNameTb.Text);
                    Con .SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added");
                    DepNameTb.Text = " ";
                }
            } 
            catch(Exception Ex) {
                MessageBox.Show(Ex.Message);
            }   
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
