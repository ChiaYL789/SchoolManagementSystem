using ASSIGNMENT;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmt5._0
{
    internal class Lecturer
    {
        private string TpNum;
        private string Password;
        private string StudentName;
        private string Gender;
        private string ContactNumber;
        private string Email;
        private string Address;
        private string RequestModule;
        private string RequestLevel;
        private string EnrollMonth;

        private string LecturerID;
        private string LecturerEmail;
        private string LecturerContactNo;
        private string LecturerAddress;
        private string LecturerPassword;
        private string LecturerName;



        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string LecturerEmail1 { get => LecturerEmail; set => LecturerEmail = value; }
        public string LecturerContactNo1 { get => LecturerContactNo; set => LecturerContactNo = value; }
        public string LecturerAddress1 { get => LecturerAddress; set => LecturerAddress = value; }
        public string LecturerPassword1 { get => LecturerPassword; set => LecturerPassword = value; }
        public string LecturerName1 { get => LecturerName; set => LecturerName = value; }

        public Lecturer()
        {

        }
        public Lecturer(string id, string m)
        {
            TpNum = id;
            RequestModule = m;
        }

        public Lecturer(string id, string m, string l)
        {
            TpNum = id;
            RequestModule = m;
            RequestLevel = l;
        }
        public Lecturer(string lid)
        {
            LecturerID = lid;
        }

        //register constructor
        public Lecturer(string tp, string password, string studentName, string gender, string contactNumber, string email, string address, string month)
        {
            TpNum = tp;
            Password = password;
            StudentName = studentName;
            Gender = gender;
            ContactNumber = contactNumber;
            Email = email;
            Address = address;
            EnrollMonth = month;
        }


        public void Register()
        {
            con.Open();
            SqlCommand cmd_DuplicateStudent = new SqlCommand("SELECT COUNT(*) FROM Student WHERE studentID ='" + TpNum + "'", con);
            int count = Convert.ToInt32(cmd_DuplicateStudent.ExecuteScalar().ToString());

            if (count > 0)
            {
                MessageBox.Show("Username Already Exist!", "Error");
            }
            else
            {
                SqlCommand cmdInsertStudent = new SqlCommand("INSERT INTO Student(studentID,password,studentName, gender, contactNumber, email, address,enrollMonth) VALUES(@tp, @password, @studentName, @gender, @contactNumber, @email, @address,@month)", con);

                cmdInsertStudent.Parameters.AddWithValue("@tp", TpNum);
                cmdInsertStudent.Parameters.AddWithValue("@password", Password);
                cmdInsertStudent.Parameters.AddWithValue("@studentName", StudentName);
                cmdInsertStudent.Parameters.AddWithValue("@gender", Gender);
                cmdInsertStudent.Parameters.AddWithValue("@contactNumber", ContactNumber);
                cmdInsertStudent.Parameters.AddWithValue("@email", Email);
                cmdInsertStudent.Parameters.AddWithValue("@address", Address);
                cmdInsertStudent.Parameters.AddWithValue("@month", EnrollMonth);

                int i = cmdInsertStudent.ExecuteNonQuery();

                SqlCommand cmdInsertRole = new SqlCommand("INSERT INTO Users(userID,password,role) VALUES(@ID, @password, 'student')", con);

                cmdInsertRole.Parameters.AddWithValue("@ID", TpNum);
                cmdInsertRole.Parameters.AddWithValue("@password", Password);
                cmdInsertRole.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Registration Successful!");
                }

                else
                {
                    MessageBox.Show("Unable To Register!");
                }
            }

            con.Close();
        }

        public void PopulateStudentID(ComboBox comboBox)
        {
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT studentID FROM Student", con);
            da.Fill(dt);

            con.Close();

            comboBox.DataSource = dt;
            comboBox.DisplayMember = "studentID";
            comboBox.ValueMember = "studentID";
        }

        public void Enroll()
        {
            con.Open();

            SqlCommand cmdEnroll = new SqlCommand("UPDATE Module SET status = 'completed' WHERE studentID = @id AND ClassID = @module", con);
            cmdEnroll.Parameters.AddWithValue("@id", TpNum);
            cmdEnroll.Parameters.AddWithValue("@module", RequestModule);
            cmdEnroll.ExecuteNonQuery();

            MessageBox.Show("Enroll Successful");
            con.Close();
        }
        public static void viewProfile(Lecturer l1)
        {
            con.Open();

            string sql = "SELECT * FROM Lecturer WHERE username = '"+l1.LecturerID+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                l1.LecturerID = rd.GetString(1);
                l1.LecturerName1 = rd.GetString(3);
                l1.LecturerPassword1 = rd.GetString(2);
                l1.LecturerContactNo1 = rd.GetInt32(4).ToString();
                l1.LecturerEmail1 = rd.GetString(5);
                l1.LecturerAddress1 = rd.GetString(6);

            }
            rd.Close();
            con.Close();
        }
    }
}