using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using Blood_Pressure_Tracker_Service.Classes;
namespace Blood_Pressure_Tracker_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "USER" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select USER.svc or USER.svc.cs at the Solution Explorer and start debugging.
    public class USER : IUSER
    {
        
        public string signIn(string _name, string _password)
        {
            SqlConnection connection = SQLConnection.createConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [USER] WHERE name = @name and password = @password", connection);

                cmd.Parameters.Add(new SqlParameter("@name", _name));
                cmd.Parameters.Add(new SqlParameter("@password", _password));
                SqlDataReader reader = cmd.ExecuteReader();

                int rowCount = 0;
                string ssn = "";
                while (reader.Read())
                {
                    rowCount++;
                    ssn = reader["ssn"].ToString();
                }
                    
                if (rowCount > 0)
                    return ssn;

                connection.Close();
            }
            catch
            {
                connection.Close();
            }

            return null;
        }

        public void signUp(string _ssn, string _name, string _password, string _age, string _gender, string _weight)
        {
            SqlConnection connection = SQLConnection.createConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [USER](ssn, name, age, gender, weight, password) VALUES(@ssn, @name, @age, @gender, @weight, @password)", connection);

                cmd.Parameters.Add (new SqlParameter("@ssn", _ssn));
                cmd.Parameters.Add(new SqlParameter("@name", _name));
                cmd.Parameters.Add(new SqlParameter("@age", int.Parse(_age)));
                cmd.Parameters.Add(new SqlParameter("@gender", _gender));
                cmd.Parameters.Add(new SqlParameter("@weight", float.Parse(_weight)));
                cmd.Parameters.Add(new SqlParameter("@password", _password));

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }

            return;
        }

        public void updateUser(string _ssn, string _name, string _password, string _age, string _gender, string _weight)
        {
            SqlConnection connection = SQLConnection.createConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE [USER] SET name=@name, password=@password, age=@age, gender=@gender, weight=@weight WHERE ssn = @ssn", connection);

                cmd.Parameters.Add(new SqlParameter("@ssn", _ssn));
                cmd.Parameters.Add(new SqlParameter("@name", _name));
                cmd.Parameters.Add(new SqlParameter("@password", _password));
                cmd.Parameters.Add(new SqlParameter("@age", int.Parse(_age)));
                cmd.Parameters.Add(new SqlParameter("@gender", _gender));
                cmd.Parameters.Add(new SqlParameter("@weight", float.Parse(_weight)));

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }

            return;
        }

        public List<string> findUser(string _ssn)
        {
            List<string> userInfo = new List<string>();

            SqlConnection connection = SQLConnection.createConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [USER] WHERE ssn = @ssn", connection);

                cmd.Parameters.Add(new SqlParameter("@ssn", _ssn));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userInfo.Add(reader["ssn"].ToString());
                    userInfo.Add(reader["name"].ToString());
                    userInfo.Add(reader["password"].ToString());
                    userInfo.Add(reader["age"].ToString());
                    userInfo.Add(reader["gender"].ToString());
                    userInfo.Add(reader["weight"].ToString());
                }
                connection.Close();

            }
            catch
            {
                connection.Close();
            }

            return userInfo;
        }

    }
}
