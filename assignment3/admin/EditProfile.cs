using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
using System.Diagnostics.Contracts;

namespace assignment3
{

    public partial class frmEditProfile : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmEditProfile()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmEditProfile_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select userID from Users where role = 'admin'", con);
            string adminID = cmd.ExecuteScalar()?.ToString();
            label3.Text = adminID;
            con.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill Up New Password!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                con.Open();
                string newPassword = txtPassword.Text;
                SqlCommand cmd = new SqlCommand("update Users SET password = '" + newPassword + "'", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            txtPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Show")
            {
                txtPassword.PasswordChar = '\0';
                button2.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                button2.Text = "Show";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminHome am = new frmAdminHome();
            am.ShowDialog();
            this.Close();

        }
    }
}
