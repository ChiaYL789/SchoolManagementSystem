using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class AdminFeedback
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string subject;
        private string feedback;

        public AdminFeedback(string s, string f)
        {
            subject = s;
            feedback = f;
        }

        public void SendFeedback()
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "INSERT INTO Feedback(trainerID, subject, feedback) values ( 'var','" + subject + "','" + feedback + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
        }
    }
}
