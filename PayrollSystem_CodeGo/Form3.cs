using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;

namespace PayrollSystem_CodeGo
{
    public partial class Form3 : Form
    {
        string connection = "server=localhost;user=root;database=payrollSystem;password=;";
        
        public Form3()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }
        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please search an Employee first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
            }
            else
            {
                string employeeID = txtSearch.Text;
                string lastname = lblLnameResult.Text;
                string firstname = lblFnameResult.Text;
                string middlename = lblMnameResult.Text;
                string jobTitle = lblJtitleResult.Text;
                string salary = lblJobSalaryResult.Text;


                this.Hide();
                Form4 form4 = new Form4(employeeID, lastname, firstname, middlename, jobTitle, salary);
                form4.ShowDialog();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();

            string pastSalary = "SELECT totalSalary, month, year FROM salary WHERE employeeID = @empID ORDER BY salaryID DESC";
            MySqlCommand cmd = new MySqlCommand(pastSalary, con);
            cmd.Parameters.AddWithValue("@empID", txtSearch.Text);
            MySqlDataReader pastSalaryRead =cmd.ExecuteReader();


            if (pastSalaryRead.Read())

            {
                string totalSalary = pastSalaryRead["totalSalary"].ToString();
                string month = pastSalaryRead["month"].ToString();
                string year = pastSalaryRead["year"].ToString();

                lblPastSalaryResult.Text = totalSalary + " " + month + " " + year;
            }
            pastSalaryRead.Close();

            string searchQuery = ("SELECT * FROM registeremployee WHERE employeeID = @employeeID");
            MySqlCommand command = new MySqlCommand(searchQuery, con);
            command.Parameters.AddWithValue("@employeeID", txtSearch.Text);
            MySqlDataReader searchReader = command.ExecuteReader(); 
            
            if (searchReader.Read())
            {
                lblLnameResult.Text = searchReader["lastname"].ToString();
                lblFnameResult.Text = searchReader["firstname"].ToString();
                lblMnameResult.Text = searchReader["middlename"].ToString();
                lblContactResult.Text = searchReader["contact"].ToString();
                lblJtitleResult.Text = searchReader["jobtitle"].ToString();
                lblJobSalaryResult.Text = searchReader["salary"].ToString();
                lblEmailResult.Text = searchReader["email"].ToString();
                lblAddressResult.Text = searchReader["address"].ToString();
            }
            else
            {
                MessageBox.Show("Employee not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnManageDeductions_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please search an Employee first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
            }
            else
            {
                this.Hide();
                string employeeID = txtSearch.Text;
                string employeeName = lblLnameResult.Text + "," + " " + lblFnameResult.Text + " " + lblMnameResult.Text;
                ManageDeduction manageDeduction = new ManageDeduction(employeeID, employeeName);
                manageDeduction.ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
               DialogResult result =  MessageBox.Show("Are you sure you want Logout?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
            }
            else
            {

            }
        }
    }
}
