using assignment3.admin;
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
    public partial class frmAdminHome : Form
    {
        public static string username;

        public frmAdminHome()
        {
            InitializeComponent();
        }

        public frmAdminHome(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            this.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblName.Text = "Hello " + username + " !";
            lblDNum.Text = "admin";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAssign ss = new frmAssign();
            ss.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmViewTrainerList tl = new frmViewTrainerList();
            tl.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration rg = new frmRegistration();
            rg.ShowDialog();
            this.Close();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeedback fb = new frmFeedback();
            fb.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditProfile ep = new frmEditProfile();
            ep.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMonthlyReport mr = new frmMonthlyReport();
            mr.ShowDialog();
            this.Close();
        }
    }
}
