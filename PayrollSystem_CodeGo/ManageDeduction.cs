using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PayrollSystem_CodeGo
{
    public partial class ManageDeduction : Form
    {
        private bool isComputeDeductionClicked = false;

        string connection = "server=localhost;user=root;database=payrollSystem;password=;";

        public ManageDeduction(string empID, string empName)
        {
            InitializeComponent();
            lblEmployeeIDResult.Text = empID;
            lblEmployeeNameResult.Text = empName;

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

        private void btnAddToDeductions_Click(object sender, EventArgs e)
        {
            

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();

            
            if (isComputeDeductionClicked)
            {
                string addDeduction = "INSERT INTO deductions (employeeID, month, year, philhealth, sss, pagibig, absences, philhealthAmount, sssAmount, pagibigAmount, absencesAmount) VALUES (@employeeID, @month, @year, @philhealth, @sss, @pagibig, @absences, @philhealthAmount, @sssAmount, @pagibigAmount, @absencesAmount)";
                MySqlCommand command = new MySqlCommand(addDeduction, con);
                command.Parameters.AddWithValue("@employeeID", lblEmployeeIDResult.Text);
                command.Parameters.AddWithValue("@month", cbMonth.Text);
                command.Parameters.AddWithValue("@year", cbYear.Text);
                command.Parameters.AddWithValue("@philhealth", txtPhil.Text);
                command.Parameters.AddWithValue("@sss", txtSSS.Text);
                command.Parameters.AddWithValue("@pagibig", txtPagibig.Text);
                command.Parameters.AddWithValue("@absences", txtAbseences.Text);
                command.Parameters.AddWithValue("@philhealthAmount", lblPhilhealthAmount.Text);
                command.Parameters.AddWithValue("@sssAmount", lblSSSAmount.Text);
                command.Parameters.AddWithValue("@pagibigAmount", lblPagibigAmount.Text);
                command.Parameters.AddWithValue("@absencesAmount", lblAbsencesAmount.Text);

                int result = command.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Successfully added Deductions.", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to add deductions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please compute deduction first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnComputeDeductions_Click(object sender, EventArgs e)
        {
            isComputeDeductionClicked = true;
            string month = cbMonth.SelectedItem?.ToString();
            string year = cbYear.SelectedItem?.ToString();

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();

            string checkDeduction = "SELECT COUNT(*) FROM deductions WHERE employeeID = @empID && month = @month && year = @year ";
            MySqlCommand cmd = new MySqlCommand(checkDeduction, con);
            cmd.Parameters.AddWithValue("@empID", lblEmployeeIDResult.Text);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);

            int result = Convert.ToInt32(cmd.ExecuteScalar());

            if (result > 0)
            {
                MessageBox.Show($"This employee already had a record for {month} {year}.");
                txtPhil.Clear();
                txtSSS.Clear();
                txtPagibig.Clear();
                txtAbseences.Clear();
                cbMonth.Focus();
            }
            else
            {
                string selectSalary = "SELECT salary FROM registeremployee WHERE employeeID = @empID";
                MySqlCommand command = new MySqlCommand(selectSalary, con);

                command.Parameters.AddWithValue("@empID", lblEmployeeIDResult.Text);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    if (string.IsNullOrEmpty(cbMonth.Text) || string.IsNullOrEmpty(cbYear.Text) || string.IsNullOrEmpty(txtPhil.Text) || string.IsNullOrEmpty(txtSSS.Text) || string.IsNullOrEmpty(txtPagibig.Text) || string.IsNullOrEmpty(txtAbseences.Text))
                    {
                        MessageBox.Show("Please Input All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        int salary = Convert.ToInt32(reader["salary"]);

                        string philhealthString = txtPhil.Text;
                        string sssString = txtSSS.Text;
                        string pagibigString = txtPagibig.Text;

                        philhealthString = philhealthString.Replace("%", "");
                        sssString = sssString.Replace("%", "");
                        pagibigString = pagibigString.Replace("%", "");

                        double philhealthValue = Convert.ToDouble(philhealthString);
                        double sssValue = Convert.ToDouble(sssString);
                        double pagibigValue = Convert.ToDouble(pagibigString);
                        double absences = Convert.ToDouble(txtAbseences.Text);

                        double philhealthValueDec = philhealthValue / 100;
                        double sssValueDec = sssValue / 100;
                        double pagibigValueDec = pagibigValue / 100;

                        double philhealthAmount = philhealthValueDec * salary;
                        double sssAmount = sssValueDec * salary;
                        double pagibigAmount = pagibigValueDec * salary;
                        double dailyRate = salary / 26;
                        double absencesAmount = absences * dailyRate;

                        lblPhilhealthAmount.Text = philhealthAmount.ToString();
                        lblSSSAmount.Text = sssAmount.ToString();
                        lblPagibigAmount.Text = pagibigAmount.ToString();
                        lblAbsencesAmount.Text = absencesAmount.ToString();
                        
                    }
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
