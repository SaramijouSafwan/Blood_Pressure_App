using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using Blood_Pressure_Tracker_Service.Classes;
using System.Threading;
namespace Blood_Pressure_Tracker_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BLOOD_PRESSURE" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BLOOD_PRESSURE.svc or BLOOD_PRESSURE.svc.cs at the Solution Explorer and start debugging.
    public class BLOOD_PRESSURE : IBLOOD_PRESSURE
    {
        bool notifyProp = false;

        public List<string> getDietPlan(string _bloodPressureStatus)
        {
            List<string> dietPlan = new List<string>();

            SqlConnection connection = SQLConnection.createConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [DIET_PLAN] WHERE status = @status", connection);

                cmd.Parameters.Add(new SqlParameter("@status", _bloodPressureStatus));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dietPlan.Add(reader["dietPlan"].ToString());
                }

                connection.Close();

            }
            catch
            {
                connection.Close();
            }

            return dietPlan;
        }

        public string measureBloodPressure(string _ssn, float _upper, float _lower)
        {
            string bloodPressureState = "";

            if (_upper < 80 || _lower < 60)
                bloodPressureState = "Low Blood Pressure - Hypotension";
            else if ((_upper >= 80 && _upper < 120) && (_lower >= 60 && _lower < 80))
                bloodPressureState = "Normal Blood Pressure -";
            else if ((_upper >= 120 && _upper < 140) || (_lower >= 80 && _lower < 90))
                bloodPressureState = "Prehypertension -";
            else if ((_upper >= 140 && _upper < 160) || (_lower >= 90 && _lower < 100))
                bloodPressureState = "High Blood Pressure - Hypertension Stage 1";
            else if ((_upper >= 160 && _upper < 180) || (_lower >= 100 && _lower < 110))
                bloodPressureState = "High Blood Pressure - Hypertension Stage 2";
            else
                bloodPressureState = "High Blood Pressure - Hypertension Stage 3";

            SqlConnection connection = SQLConnection.createConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [BLOOD_PRESSURE](userSSN, date, upper, lower, status) VALUES(@userSSN, @date, @upper, @lower, @status)", connection);

                cmd.Parameters.Add(new SqlParameter("@userSSN", _ssn));
                cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now.ToString()));
                cmd.Parameters.Add(new SqlParameter("@upper", _upper));
                cmd.Parameters.Add(new SqlParameter("@lower", _lower));
                cmd.Parameters.Add(new SqlParameter("@status", bloodPressureState));

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }

            return bloodPressureState;
        }

        public List<string> trackBloodPressure(string _ssn)
        {
            List<string> userBloodPressure = new List<string>();

            SqlConnection connection = SQLConnection.createConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [BLOOD_PRESSURE] WHERE userSSN = @ssn", connection);

                cmd.Parameters.Add(new SqlParameter("@ssn", _ssn));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string index = reader["date"] + " " + reader["upper"] + " " + reader["lower"] + " " + reader["status"];
                   
                    userBloodPressure.Add(index);
                }

                connection.Close();

            }
            catch
            {
                connection.Close();
            }

            return userBloodPressure;
        }

        public void notifyUser(bool notify, int timeSecound)
        {
            if (notify == true)
            {
                Thread.Sleep(timeSecound * 1000);
                notifyProp = true;
            }
        }

        public string cheakMail()
        {
            if (notifyProp == true)
            {
                notifyProp = false;
                return "Its time to measure the blood pressure.";
            }
            return null;
        }

    }
}
