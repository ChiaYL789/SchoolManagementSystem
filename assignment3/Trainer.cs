using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace assignment3
{
    internal class Trainer
    {
        string trainerName;
        string gender;
        string email;
        int contactNumber;
        string address;
        string trainerID;
        string password;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Email { get => email; set => email = value; }
        public int ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Address { get => address; set => address = value; }
        public string TrainerID { get => trainerID; set => trainerID = value; }
        public string Password { get => password; set => password = value; }
        public string TrainerName { get => trainerName; set => trainerName = value; }
        public string Gender { get => gender; set => gender = value; }

        public Trainer(string n, string g, string em, int cn, string ad, string id, string pw)
        {
            trainerName = n;
            gender = g;
            email = em;
            contactNumber = cn;
            address = ad;
            trainerID = id;
            password = pw;
        }
        public Trainer(string id)
        {
            trainerID = id;
        }

        public Trainer()
        {

        }

        public void EditProfile()
        {
            con.Open();
            string sql = "UPDATE Trainer SET email = @Email, password = @Password, address = @Address, contactNumber = @ContactNumber WHERE trainerID = @TrainerID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
            cmd.Parameters.AddWithValue("@TrainerID", trainerID);
            cmd.ExecuteNonQuery();

            string sql2 = "UPDATE Users SET password = @Password WHERE userID = @TrainerID";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.Parameters.AddWithValue("@Password", password);
            cmd2.Parameters.AddWithValue("@TrainerID", trainerID);
            cmd2.ExecuteNonQuery();

            con.Close();
        }

        public static void viewProfile(Trainer t1)
        {
            con.Open();
            string sql = "SELECT * FROM Trainer WHERE trainerID = '"+t1.trainerID+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                t1.TrainerName = rd.GetString(3);
                t1.Gender = rd.GetString(7);
                t1.Email = rd.GetString(5);
                t1.ContactNumber = rd.GetInt32(4);
                t1.Address = rd.GetString(6);
                t1.Password = rd.GetString(2);
            }
            rd.Close();
            con.Close();
        }
    }
}
