using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace PayrollSystem_CodeGo
{
   
    public partial class Form4 : Form
    {
        private bool isComputeButtonClicked = false;
        string connection = "server=localhost;user=root;database=payrollSystem;password=;";
        
        public Form4(string empID, string lname, string fname, string midname, string jTitle, string salary)
        {
            InitializeComponent();
            lblEmployeeID.Text = empID;
            lblEmployeeName.Text = lname + "," + " " + fname + " " + midname;
            lblJtitle.Text = jTitle;
            lblSalary.Text = salary;

            cbMonth.Items.Add("January");
            cbMonth.Items.Add("February");
            cbMonth.Items.Add("March");
            cbMonth.Items.Add("April");
            cbMonth.Items.Add("May");
            cbMonth.Items.Add("June");
            cbMonth.Items.Add("July");
            cbMonth.Items.Add("August");
            cbMonth.Items.Add("September");
            cbMonth.Items.Add("October");
            cbMonth.Items.Add("November");
            cbMonth.Items.Add("December");

            cbYear.Items.Add("2024");
            cbYear.Items.Add("2025");
            cbYear.Items.Add("2026");
            cbYear.Items.Add("2027");
            cbYear.Items.Add("2028");


        }
        
        /*private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Logout canceled.");
            }
        }*/

     
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            isComputeButtonClicked = true;
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();

            string month = cbMonth.SelectedItem?.ToString();
            string year = cbYear.SelectedItem?.ToString();

            string checkSalary = "SELECT COUNT(*) FROM salary WHERE employeeID = @empID && month = @month && year = @year ";
            MySqlCommand cmd = new MySqlCommand(checkSalary, con);
            cmd.Parameters.AddWithValue("@empID", lblEmployeeID.Text);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);

            int result = Convert.ToInt32(cmd.ExecuteScalar());

            if (result > 0)
            {
                MessageBox.Show($"This employee already had a record for {month} {year}.");
                cbMonth.Focus();
                return;
            }
            if (month is object && year is object)
            {
              

                
                string deductionsQuery = "SELECT philhealthAmount, sssAmount, pagibigAmount, absences, absencesAmount FROM deductions WHERE month = @month && year = @year  && employeeID = @empID";
                
                MySqlCommand command2 = new MySqlCommand(deductionsQuery, con);
               
                command2.Parameters.AddWithValue("@month", month);
                command2.Parameters.AddWithValue("@year", year);
                command2.Parameters.AddWithValue("@empID", lblEmployeeID.Text);


                MySqlDataReader read2 = command2.ExecuteReader();

                if (read2.Read())
                {
                    lblPhilhealth.Text = read2["philhealthAmount"].ToString();
                    lblSSS.Text = read2["sssAmount"].ToString();
                    lblPAGIBIG.Text = read2["pagibigAmount"].ToString();
                    lblAbsencesResult.Text = read2["absences"].ToString();
                    lblAbsencesAmountResult.Text = read2["absencesAmount"].ToString();

                    double philhealth = Convert.ToDouble(read2["philhealthAmount"]);
                    double sss = Convert.ToDouble(read2["sssAmount"]);
                    double pagibig = Convert.ToDouble(read2["pagibigAmount"]);
                    double absencesAmount = Convert.ToDouble(read2["absencesAmount"]);

                    double totalDeduction = philhealth + sss + pagibig + absencesAmount;
                    lblTotalDeduction.Text = totalDeduction.ToString();

                    double salary;
                    if (double.TryParse(lblSalary.Text, out salary))
                    {
                        double totalSalary = salary - totalDeduction;
                        lblTotalSalaryResult.Text = totalSalary.ToString();
                    }
                    

                }
                else
                {
                    MessageBox.Show($"No record found for employee {lblEmployeeName.Text} for the month of {month} {year}. Please set deduction for this employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    string employeeID = lblEmployeeID.Text;
                    string employeeName = lblEmployeeName.Text;
                    ManageDeduction manage = new ManageDeduction(employeeID, employeeName);
                    manage.ShowDialog();

                }
                read2.Close();

                con.Close();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            string month = cbMonth.SelectedItem?.ToString();
            string year = cbYear.SelectedItem?.ToString();

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();

            if (isComputeButtonClicked)
                { 
                string addToSalary = "INSERT INTO salary (employeeID, month, year, totalDeduction, totalSalary) VALUES (@employeeID, @month, @year, @totalDeduction, @totalSalary)";
                MySqlCommand command = new MySqlCommand(addToSalary, con);
                command.Parameters.AddWithValue("@employeeID", lblEmployeeID.Text);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@totalDeduction", lblTotalDeduction.Text);
                command.Parameters.AddWithValue("@totalSalary", lblTotalSalaryResult.Text);

                int result = command.ExecuteNonQuery();

                if (result > 0 )
                {
                    MessageBox.Show($"Successfully Paid Employee {lblEmployeeName.Text}", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please compute salary first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
