using asmt5._0;
using ASSIGNMENT;
using assignment3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    internal class Users
    {
        private string userID;
        private string password;


        public Users(string id, string p)
        {
            userID = id;
            password = p;
        }

        public string login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from Users where userID='" + userID + "' and password='" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from Users where userID='" + userID + "' and password='" + password + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    frmAdminHome a = new frmAdminHome(un);
                    a.ShowDialog();
                }
                if (userRole == "trainer")
                {
                    frmTrainerHome b = new frmTrainerHome(un);
                    b.ShowDialog();
                }
                if(userRole == "lecturer")
                {
                    frmLecturerHome c = new frmLecturerHome(un);
                    c.ShowDialog();
                }
                
                if (userRole == "student")
                {
                    frmStudentHome d = new frmStudentHome(un);
                    d.ShowDialog();
                }


            }
            else
                status = "Invalid Login Credentials!";

            con.Close();
            return status;
        }
    }
}
