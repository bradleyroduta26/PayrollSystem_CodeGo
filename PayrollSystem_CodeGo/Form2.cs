using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PayrollSystem_CodeGo
{
    public partial class Form2 : Form
    {
        string connection = "server=localhost;user=root;database=payrollSystem;password=;";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connection);
            

            if (string.IsNullOrEmpty(txtLname.Text) || string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtJtitle.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please input all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else 
            {
                string registerQuery = "INSERT INTO registeremployee (lastname, firstname, middlename, contact, jobtitle, salary, email, address) VALUES (@lastname, @firstname, @middlename, @contact, @jobtitle, @salary, @email, @address)";
                MySqlCommand command = new MySqlCommand(registerQuery, con);

                command.Parameters.AddWithValue("@lastname", txtLname.Text);
                command.Parameters.AddWithValue("@firstname", txtFname.Text);
                command.Parameters.AddWithValue("@middlename", txtMname.Text);
                command.Parameters.AddWithValue("@contact", txtCon.Text);
                command.Parameters.AddWithValue("@jobtitle", txtJtitle.Text);
                command.Parameters.AddWithValue("@salary", txtSalary.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@address", txtAddress.Text);

                con.Open();
                int result = command.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Registration Successful!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLname.Clear();
                    txtFname.Clear();
                    txtMname.Clear();
                    txtJtitle.Clear();
                    txtCon.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();
                    txtSalary.Clear();
                    txtLname.Focus();
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
