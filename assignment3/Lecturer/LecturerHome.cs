using assignment3;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmt5._0
{
    public partial class frmLecturerHome : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public static string username;
        public frmLecturerHome()
        {
            InitializeComponent();
        }
        public frmLecturerHome(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerRegistration register = new LecturerRegistration();
            register.ShowDialog();
            this.Close();

        }

        private void request_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerEnrollment request = new LecturerEnrollment();
            request.ShowDialog();
            this.Close();
        }

        private void list_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerStudentList list = new LecturerStudentList();
            list.ShowDialog();
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerUpdateStudent updateStudent = new LecturerUpdateStudent();
            updateStudent.ShowDialog();
            this.Close();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerProfile profile = new LecturerProfile(username);
            profile.ShowDialog();
            this.Close();
        }

        private void LecturerHome_Load(object sender, EventArgs e)
        {
            role_lb.Text = username;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT lecturerName FROM Lecturer WHERE username = '" + username + "'", con);

            string lecturerName = cmd.ExecuteScalar()?.ToString();
            name_lb.Text = lecturerName;//display student name on label on homepage
            con.Close();
        }

        private void name_lb_Click(object sender, EventArgs e)
        {

        }

        private void role_lb_Click(object sender, EventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
