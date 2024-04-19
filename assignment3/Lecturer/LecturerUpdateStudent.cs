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
using System.Web;
using System.Windows.Forms;

namespace asmt5._0
{
    public partial class LecturerUpdateStudent : Form
    {
        SqlDataReader rd;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public LecturerUpdateStudent()
        {
            InitializeComponent();
        }

        private void clear()
        {
            module_cb.SelectedItem = null;
            newmodule_cb.SelectedItem = null;
            newlevel_cb.SelectedItem = null;
            module_cb.Items.Clear();
            newschedule_cb.Items.Clear();
        }

        private void LecturerUpdateStudent_Load(object sender, EventArgs e)
        {
            DisplayStudent();
        }

        private void DisplayStudent()
        {
            con.Open();
            SqlCommand cmdSelectStudentTable = new SqlCommand("SELECT DISTINCT StudentID FROM Module", con);
            rd = cmdSelectStudentTable.ExecuteReader();
            while (rd.Read())
            {
                student_listbox.Items.Add(rd[0].ToString());
            }
            rd.Close();
            con.Close();
        }

        private void DisplayModule()
        {
            string student = student_listbox.Text;

            con.Open();
            SqlCommand cmdSelectStudent = new SqlCommand("SELECT DISTINCT ClassID FROM Module WHERE StudentID = @Student AND status = 'completed'", con);
            cmdSelectStudent.Parameters.AddWithValue("@Student", student);

            SqlDataReader da = cmdSelectStudent.ExecuteReader();
            while (da.Read())
            {
                module_cb.Items.Add(da[0].ToString());
            }
            con.Close();
        }

        private void DisplaySchedule()
        {
            string student = student_listbox.Text;

            con.Open();
            SqlCommand cmdSchedule = new SqlCommand("SELECT DISTINCT schedule from CoachingClass", con);
            SqlDataReader da2 = cmdSchedule.ExecuteReader();
            while (da2.Read())
            {
                newschedule_cb.Items.Add(da2[0].ToString());
            }
            con.Close();
        }

        private void DisplayTable()
        {
            string student = student_listbox.Text;

            con.Open();
            SqlCommand cmdViewStudent = new SqlCommand("SELECT ClassID, Name, level, schedule " +
                                                       "FROM CoachingClass " +
                                                       "WHERE ClassID IN (SELECT ClassID FROM Module WHERE StudentID = @student)", con);
            cmdViewStudent.Parameters.AddWithValue("@student", student);
            SqlDataReader rd = cmdViewStudent.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(rd);

            studentlist_dgv.DataSource = table;
            con.Close();
        }

        private void student_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            DisplayModule();
            DisplaySchedule();
            DisplayTable();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string student = student_listbox.Text;
            con.Open();
            SqlCommand cmdDeleteStudent = new SqlCommand("Delete FROM Student WHERE studentName = '" + student + "'", con);
            cmdDeleteStudent.ExecuteNonQuery();

            SqlCommand cmdDeleteModule = new SqlCommand("Delete FROM Module WHERE StudentID = '" + student + "'", con);
            cmdDeleteModule.ExecuteNonQuery();
            con.Close();
            student_listbox.Items.Clear();
            DisplayStudent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerHome home = new frmLecturerHome();
            home.ShowDialog();
            this.Close();
        }

        private void module_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayModule();
            DisplaySchedule();
            DisplayTable();
        }

        private void schedule_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newmodule_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newlevel_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newschedule_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string student = student_listbox.Text;
            string module = module_cb.Text;
            string newModule = newmodule_cb.Text;
            string newLevel = newlevel_cb.Text;
            string schedule = newschedule_cb.Text;

            con.Open();

            SqlCommand cmdUpdateSchedule = new SqlCommand("UPDATE CoachingClass SET Schedule = @schedule, Level = @level, Name = @newModule WHERE ClassID = @moduleID", con);
            cmdUpdateSchedule.Parameters.AddWithValue("@schedule", schedule);
            cmdUpdateSchedule.Parameters.AddWithValue("@level", newLevel);
            cmdUpdateSchedule.Parameters.AddWithValue("@newModule", newModule);
            cmdUpdateSchedule.Parameters.AddWithValue("@moduleName", module);
            cmdUpdateSchedule.Parameters.AddWithValue("@moduleID", module);
            cmdUpdateSchedule.ExecuteNonQuery();

            MessageBox.Show("Update Successful");
            con.Close();

            student_listbox.Items.Clear();
            studentlist_dgv.DataSource = null; // Clear the data source
            studentlist_dgv.Rows.Clear();
            DisplayStudent();
            DisplayModule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            student_listbox.Items.Clear();
            DisplayStudent();
        }
    }
}
