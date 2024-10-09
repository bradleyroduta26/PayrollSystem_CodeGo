using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PayrollSystem_CodeGo
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            String Username, Password;
            Username = txtUser.Text;
            Password = txtPass.Text;

            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please input username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(Username == "Admin" && Password == "12345")
            {
                MessageBox.Show("Welcome Admin", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
