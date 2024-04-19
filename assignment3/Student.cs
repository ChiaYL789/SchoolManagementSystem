using assignment3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASSIGNMENT
{
    internal class Student
    {
        //declare all variables
        public string studName;
        public string studentID;
        private string studPassword;
        private string gender;
        private string email;
        private string phoneNum;
        private string studAddress;
        public string module;
        private string enrollmentStatus;
        private string level;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //get set method for some variables
        public string StudName { get => studName; set => studName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string StudPassword { get => studPassword; set => studPassword = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string StudAddress { get => studAddress; set => studAddress = value; }

        public Student(string n)
        {
            studentID = n;
        }

        public static void viewProfile(Student s1)//method for viewing/display profile
        {
            con.Open();

            //retrieve data from database using sql select query
            string sql = "SELECT * FROM Student WHERE studentID = '" + s1.studentID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())//assign retrieved data to object properties
            {
                s1.studentID = rd.GetString(1);
                s1.gender = rd.GetString(4);
                s1.StudName = rd.GetString(3);
                s1.studPassword = rd.GetString(2);
                s1.phoneNum = rd.GetInt32(5).ToString();
                s1.email = rd.GetString(6);
                s1.studAddress = rd.GetString(7);
            }
            rd.Close();
            con.Close();
        }

        public void editProfile(string em, string num, string ps, string ad)//method for editing profile
        {
            con.Open();

            // Assign the input values to the corresponding properties
            email = em;
            phoneNum = num;
            studAddress = ad;
            studPassword = ps;

            // Check if any of the required fields are empty
            if (em.Trim().Length == 0 || num.Trim().Length == 0 || ad.Trim().Length == 0 || ps.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if the password length is less than or equal to 8
                if (ps.Length <= 8)
                {
                    MessageBox.Show("Password length must be more than 8 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Construct the UPDATE query using parameterized query
                    SqlCommand cmd1 = new SqlCommand("UPDATE Student SET email = @Email, contactNumber = @PhoneNum, address = @Address, password = @Password WHERE StudentID = @StudentID", con);
                    cmd1.Parameters.AddWithValue("@Email", email);
                    cmd1.Parameters.AddWithValue("@PhoneNum", phoneNum);
                    cmd1.Parameters.AddWithValue("@Address", studAddress);
                    cmd1.Parameters.AddWithValue("@Password", studPassword);
                    cmd1.Parameters.AddWithValue("@StudentID", studentID);

                    // Execute the UPDATE query
                    int i = cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("UPDATE Users SET password = @Password WHERE userID = @StudentID", con);
                    cmd2.Parameters.AddWithValue("@Password", studPassword);
                    cmd2.Parameters.AddWithValue("@StudentID", studentID);

                    // Execute the UPDATE query
                    int o = cmd2.ExecuteNonQuery();

                    if (i > 0 && o > 0)
                    {
                        MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            con.Close();
        }


        public string allmodule()//method for retrieve all module for respective student
        {
            con.Close();
            con.Open();
            string module1 = null;
            string sqlone = "SELECT ClassID FROM Module WHERE studentID = @studentID";
            SqlCommand cmd = new SqlCommand(sqlone, con);
            cmd.Parameters.AddWithValue("@studentID", studentID);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                module1 = rd.GetString(0);
            }
            con.Close();
            return module1;
        }
    }
}

    
