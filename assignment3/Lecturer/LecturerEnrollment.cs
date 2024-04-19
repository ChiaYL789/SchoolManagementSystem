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
    public partial class LecturerEnrollment : Form
    {
        SqlDataReader rd;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public LecturerEnrollment()
        {
            InitializeComponent();
        }

        private void clear()
        {
            module_cb.Items.Clear();
            level_cb.Items.Clear();
            schedule_cb.Items.Clear();
            student_cb.SelectedItem= null;
        }

        private void LecturerRequest_Load(object sender, EventArgs e)
        {
            student_cb.SelectedItem = null;
            Lecturer objShowStudentID = new Lecturer();
            objShowStudentID.PopulateStudentID(student_cb);
        }

        private void student_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string student = student_cb.Text;
            module_cb.Items.Clear();
            con.Open();
            SqlCommand cmdSelectStudent = new SqlCommand("SELECT DISTINCT ClassID FROM Module WHERE StudentID = @student AND [status] = 'pending'", con);
            cmdSelectStudent.Parameters.AddWithValue("@student", student);
            SqlDataReader da1 = cmdSelectStudent.ExecuteReader();
            while (da1.Read())
            {
                module_cb.Items.Add(da1["ClassID"].ToString());
            }
            da1.Close();
            con.Close();
        }

        private void enroll_btn_Click(object sender, EventArgs e)
        {
            string id = student_cb.Text;
            string module = module_cb.Text;
            Lecturer objEnroll = new Lecturer(student_cb.Text, module_cb.Text);
            objEnroll.Enroll();
            clear();
            Lecturer objShowStudentID = new Lecturer();
            objShowStudentID.PopulateStudentID(student_cb);
        }

        private void module_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string student = student_cb.Text;
            string module = module_cb.Text;
            con.Open();
            SqlCommand cmdSelectModule = new SqlCommand("SELECT DISTINCT [level] FROM CoachingClass WHERE ClassID = @module", con);
            cmdSelectModule.Parameters.AddWithValue("@module", module);
            SqlDataReader da2 = cmdSelectModule.ExecuteReader();

            level_cb.Items.Clear();
            while (da2.Read())
            {
                level_cb.Items.Add(da2["level"].ToString());
            }

            da2.Close();
            con.Close();
        }

        private void level_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string student = student_cb.Text;
            string module = module_cb.Text;
            string level = level_cb.Text;

            con.Open();
            SqlCommand cmdSelectSchedule = new SqlCommand("SELECT Schedule FROM CoachingClass WHERE ClassID = @module AND level = @level", con);
            cmdSelectSchedule.Parameters.AddWithValue("@module", module);
            cmdSelectSchedule.Parameters.AddWithValue("@level", level);
            SqlDataReader da3 = cmdSelectSchedule.ExecuteReader();

            //clear schdule label
            schedule_cb.Items.Clear();

            while (da3.Read())
            {
                string scheduleName = da3[0].ToString();
                schedule_cb.Items.Add(scheduleName);
            }

            da3.Close();
            con.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerHome home = new frmLecturerHome();
            home.ShowDialog();
            this.Close();
        }
    }
}
