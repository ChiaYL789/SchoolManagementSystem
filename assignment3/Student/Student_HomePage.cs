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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace ASSIGNMENT
{
    public partial class frmStudentHome : Form
    {

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public static string studID;

        public frmStudentHome(string id)
        {
            InitializeComponent();
            studID = id;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Student obj1 = new Student(studID);// Create a Student object with the passed student ID
            Student.viewProfile(obj1);// Call the viewProfile method on the Student object



            lblHomeshow.Text = obj1.studentID;// display studentid on the label on homepage



            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT studentName FROM Student WHERE studentID = '" + studID + "'", con);
            // Retrieve the student's name from the database based on their student ID



            string studentName = cmd.ExecuteScalar()?.ToString();
            lblStudname.Text = "Student: " + studentName;//display student name on label on homepage
            con.Close();

        }
    
        private void btnTimeTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTT F1 = new frmTT(studID);// Create an instance of the frmTT form, passing the student ID
            F1.ShowDialog();
            this.Close();
        }




        private void btnPayTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPay F1 = new frmPay(studID);// Create an instance of the form and pass the student ID
            F1.ShowDialog();
            this.Close();
        }




        private void btnEnrollTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnroll F1 = new frmEnroll(studID);//pass student id to other form
            F1.ShowDialog();
            this.Close();



        }




        private void btnProfileTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProfile F1 = new frmProfile(studID);//pass student id to other form
            F1.ShowDialog();
            this.Close();
        }




        private void btnLoutHP_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin h = new frmLogin();
            h.ShowDialog();
            this.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {



        }
    }
}