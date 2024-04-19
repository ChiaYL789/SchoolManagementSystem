using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string stat;
            Users obj1 = new Users(txtUsername.Text, txtPassword.Text);
            stat = obj1.login(txtUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
            }
            else
            {
                this.Close();
            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
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
