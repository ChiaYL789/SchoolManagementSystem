using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT
{
    public partial class frmTT : Form
    {
        public static string studID;

        public frmTT(string id)
        {
            InitializeComponent();
            studID = id;
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private void btnBackTT_Click(object sender, EventArgs e)
        {
            frmStudentHome F1 = new frmStudentHome(studID);// Create an instance of the frmStudentHome form, passing the student ID here
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }

        private void frmTT_Load(object sender, EventArgs e)
        {
            // Create an instance of the Student class, passing the student ID here
            Student module1 = new Student(studID);

            con.Open();//use sql select query to retrieve timetable
            SqlCommand cmd = new SqlCommand("SELECT Name,schedule " + "FROM CoachingClass " +
                            "WHERE ClassID IN (SELECT ClassID FROM Module WHERE StudentID = @studentID AND Module.status = 'completed') " +
                            "ORDER BY (CASE schedule " +
                                       "WHEN 'monday' THEN 1 " +
                                       "WHEN 'tuesday' THEN 2 " +
                                       "WHEN 'wednesday' THEN 3 " +
                                       "WHEN 'thursday' THEN 4 " +
                                       "WHEN 'friday' THEN 5 " +
                                       "END)", con);

            cmd.Parameters.AddWithValue("@studentID", studID);// Set the student ID parameter for the SQL query

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                // Create a new DataTable to store the timetable data
                DataTable timetable = new DataTable();
                // Load the data from the SqlDataReader into the timetable DataTable
                timetable.Load(reader);

                dgvTimetable.AutoGenerateColumns = true;// Optionally set this property to automatically generate columns
                // Set the timetable DataTable as the data source for the dgvTimetable DataGridView
                dgvTimetable.DataSource = timetable;

                dgvTimetable.Refresh();
            }
            con.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
