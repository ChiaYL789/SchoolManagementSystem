using assignment3;
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
using System.Xml.Linq;

namespace ASSIGNMENT
{
    public partial class frmProfile : Form
    {
        public static string studID;

        public frmProfile(string id)
        {
            InitializeComponent();
            studID = id;
        }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        private void frmProfile_Load(object sender, EventArgs e)
        {
            Student student = new Student(studID);//retrieve student id

            Student.viewProfile(student);//call the view profile method to here

            // Update the UI labels with the retrieved student data
            lblStudID.Text = student.studentID;
            lblNamePro.Text = student.StudName;
            lblGenderPro.Text = student.Gender;
            txtEmailPro.Text = student.Email;
            txtNewpassPro.Text = student.StudPassword;
            txtPhonePro.Text = student.PhoneNum;
            txtNewaddress.Text = student.StudAddress;

        }


        private void btnShow_Click(object sender, EventArgs e)//show or hide password character when clicked
        {
            if (btnShow.Text == "Show")
            {
                txtNewpassPro.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtNewpassPro.PasswordChar = '*';
                btnShow.Text = "Show";
            }
        }


        private void btnBackPro_Click(object sender, EventArgs e)//return to homepage button
        {
            frmStudentHome F1 = new frmStudentHome(studID);
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }

        private void btnEditP_Click_1(object sender, EventArgs e)//call edit profile when button clicked
        {
            Student obj1 = new Student(studID);
            obj1.editProfile(txtEmailPro.Text, txtPhonePro.Text, txtNewpassPro.Text, txtNewaddress.Text);

            txtEmailPro.Clear();
            txtPhonePro.Clear();
            txtNewpassPro.Clear();
            txtNewaddress.Clear();

        }

        private void btnExitProfile_Click_1(object sender, EventArgs e)//button clear, clear user input in profile form
        {
            txtEmailPro.Clear();
            txtPhonePro.Clear();
            txtNewpassPro.Clear();
            txtNewaddress.Clear();

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void txtNewpassPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNamePro_Click(object sender, EventArgs e)
        {

        }
    }
}
