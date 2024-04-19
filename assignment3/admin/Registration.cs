using assignment3.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment3
{
    public partial class frmRegistration : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMonthlyReport f4 = new frmMonthlyReport();
            f4.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminHome am = new frmAdminHome();
            am.ShowDialog();
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0 || txtContactN.Text.Trim().Length == 0 || txtAddress.Text.Trim().Length == 0 || txtUsername.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length <= 8 || txtAddress.Text.Trim().Length == 0 || cbGender.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill Up All The Required Fields!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string patternEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                string patternID = "^TA[0-9]{3}$";

                bool isEmailValid = Regex.IsMatch(txtEmail.Text, patternEmail);
                bool isUsernameValid = Regex.IsMatch(txtUsername.Text, patternID);

                if (isEmailValid && isUsernameValid)
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();

                    Admin tra = new Admin(txtName.Text.Trim(), cbGender.Text.Trim(), txtEmail.Text.Trim(), txtContactN.Text.Trim(), txtAddress.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
                    tra.registerTrainer(); 
                }
                else
                {
                    MessageBox.Show("Please Insert Valid Input!", "Error", MessageBoxButtons.OK);

                    if (!isEmailValid)
                    {
                        errorProvider1.SetError(this.txtEmail, "Please provide a valid Email Address");
                    }
                
                    else
                    {
                        errorProvider1.Clear();
                    }

                    if (!isUsernameValid)
                    {
                        errorProvider2.SetError(this.txtUsername, "Please provide a valid ID");
                    }
                    else
                    {
                        errorProvider2.Clear();
                    }

                    txtEmail.Focus(); // Set focus to the first invalid field
                }
            }
                
        }
    


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContactN.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cbGender.SelectedIndex = 0;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbModule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (btnShow.Text == "Show")
            {
                txtPassword.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShow.Text = "Show";
            }
        }
    }
}
