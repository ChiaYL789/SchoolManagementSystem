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
    public partial class LecturerStudentList : Form
    {
        SqlDataReader rd;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public LecturerStudentList()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string module = selectModule_listbox.Text;
            con.Open();
            SqlCommand cmdSelectData = new SqlCommand("SELECT Student.studentName, CoachingClass.Name, CoachingClass.level, CoachingClass.schedule " +
                                          "FROM Student " +
                                          "JOIN Module ON Student.studentID = Module.StudentID " +
                                          "JOIN CoachingClass ON Module.ClassID = CoachingClass.ClassID " +
                                          "WHERE CoachingClass.Name = @ClassID AND Module.status = 'completed'", con);

            cmdSelectData.Parameters.AddWithValue("@ClassID", module);
            SqlDataReader rd = cmdSelectData.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(rd);

            studentlist_dgv.DataSource = table;

            con.Close();

        }

        private void LecturerStudentList_Load(object sender, EventArgs e)
        {

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
