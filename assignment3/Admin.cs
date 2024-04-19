using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;

namespace assignment3
{
    internal class Admin
    {
        private string Name;
        private string Gender;
        private string Email;
        private string ContactNumber;
        private string Address;
        private string TrainerID;
        private string Password;
        private string Module;
        private string Level;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Admin(string name, string gen, string em, string num, string add, string id, string pw)
        {
            Name = name;
            Gender = gen;
            Email = em;
            ContactNumber = num;
            Address = add;
            TrainerID = id;
            Password = pw;
        }
        
        public Admin(string id, string md, string lv)
        {
            TrainerID = id;
            Module = md;
            Level = lv;
        }
        public Admin(string id)
        {
            TrainerID = id;
        }


        public Admin()
        {

        }


        public void registerTrainer()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from Trainer where trainerID = '" + TrainerID + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                MessageBox.Show("Username Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("insert into Trainer(trainerID,password,trainerName,gender,contactNumber,email,address)values(@id,@pw,@name,@gen,@num,@em,@add)", con);
                cmd1.Parameters.AddWithValue("@id", TrainerID);
                cmd1.Parameters.AddWithValue("@pw", Password);
                cmd1.Parameters.AddWithValue("@name", Name);
                cmd1.Parameters.AddWithValue("@gen", Gender);
                cmd1.Parameters.AddWithValue("@em", Email);
                cmd1.Parameters.AddWithValue("@num", ContactNumber);
                cmd1.Parameters.AddWithValue("@add", Address);


                SqlCommand cmd2 = new SqlCommand("insert into Users(userID,password,role)values(@id,@pw,'trainer')", con);
                cmd2.Parameters.AddWithValue("@id", TrainerID);
                cmd2.Parameters.AddWithValue("@pw", Password);

                cmd2.ExecuteNonQuery();
                int i = cmd1.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Unable To Register!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public void assignTrainerModule()
        {
            con.Open();;

            SqlCommand cmd = new SqlCommand("select count(*) from AssignModule where trainerID = '" + TrainerID + "' and module = '" + Module + "' and level = '" + Level + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                MessageBox.Show("module Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("insert into AssignModule(trainerID, module, level)values(@id,@md,@lv)", con);
                cmd1.Parameters.AddWithValue("@id", TrainerID);
                cmd1.Parameters.AddWithValue("@md", Module);
                cmd1.Parameters.AddWithValue("@lv", Level);

                cmd1.ExecuteNonQuery();

                MessageBox.Show("Assign Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();

        }

        public void deleteTrainerModule()
        {
            con.Open(); ;

            SqlCommand cmd = new SqlCommand("select count(*) from AssignModule where trainerID = '" + TrainerID + "' and module = '" + Module + "' and level = '" + Level + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count == 0)
            {
                MessageBox.Show("Module not Available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("delete from AssignModule where trainerID = @id and module = @md and level = @lv", con);
                cmd1.Parameters.AddWithValue("@id", TrainerID);
                cmd1.Parameters.AddWithValue("@md", Module);
                cmd1.Parameters.AddWithValue("@lv", Level);

                cmd1.ExecuteNonQuery();

                MessageBox.Show("Delete Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();

        }

        public void deleteTrainer()
        {
            con.Open(); ;

            SqlCommand cmd = new SqlCommand("select count(*) from Trainer where trainerID = '" + TrainerID +"'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count == 0)
            {
                MessageBox.Show("Trainer not Available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("delete from Trainer where trainerID = @id", con);
                cmd1.Parameters.AddWithValue("@id", TrainerID);

                SqlCommand cmd2 = new SqlCommand("delete from Users where userID = @id", con);
                cmd2.Parameters.AddWithValue("@id", TrainerID);

                SqlCommand cmd3 = new SqlCommand("delete from AssignModule where trainerID = @id", con);
                cmd3.Parameters.AddWithValue("@id", TrainerID);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Delete Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();

        }
        public void ComboTrainerID(ComboBox comboBox)
        {
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT trainerID FROM Trainer", con);
            da.Fill(dt);

            con.Close();

            comboBox.DataSource = dt;
            comboBox.DisplayMember = "trainerID";
            comboBox.ValueMember = "trainerID";
        }

        public void FComboTrainerID(ComboBox comboBox)
        {
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT trainerID FROM Feedback", con);
            da.Fill(dt);

            con.Close();

            comboBox.DataSource = dt;
            comboBox.DisplayMember = "trainerID";
            comboBox.ValueMember = "trainerID";
        }



    }
}



      

