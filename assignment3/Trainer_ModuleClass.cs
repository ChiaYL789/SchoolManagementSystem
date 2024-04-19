using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.AccessControl;

namespace assignment3
{
    internal class Trainer_ModuleClass
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string moduleName;
        private int moduleCharge;
        private string moduleLevel;
        private string schedule;
        private string trainerID;
        private string classID;

        public Trainer_ModuleClass(string n, int c, string l, string s, string id,string cid) 
        {
            moduleName = n;
            moduleCharge = c;
            moduleLevel = l;
            schedule = s;
            trainerID = id;
            classID = cid;
        }

        public Trainer_ModuleClass(int c, string s)
        {
            moduleCharge = c;
            schedule = s;
        }

        public Trainer_ModuleClass()
        {

        }

        public void AddCC()
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "INSERT INTO CoachingClass(Name, amount, level, schedule, trainerID, ClassID) values ('" + moduleName + "'," + moduleCharge.ToString() + ",'" + moduleLevel + "','" + schedule + "','" + trainerID + "','" + classID + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);


            con.Close();
        }

        public void EditCharge(string selectedID)
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "UPDATE CoachingClass set amount = '" + moduleCharge + "' where ClassID = '" + selectedID+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();
        }

        public void EditSchedule (string selectedID)
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "UPDATE CoachingClass set schedule = '" +schedule + "' where ClassID = '" + selectedID+"'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();
        }

        public void DeleteCC(string selectedID) 
        { 
            con.Open();

            DataTable dt = new DataTable();
            string sql = "DELETE from CoachingClass where ClassID ='" + selectedID+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();

        }

        public DataTable RetrieveData(string trainerID)
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "SELECT Name, amount, level, schedule, ClassID from CoachingClass where trainerID='" + trainerID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
