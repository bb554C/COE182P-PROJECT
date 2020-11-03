using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COE182P_Project.Classes
{
    class PatientClass
    {
        public static void AddNewPatient
    (int IDGender,
    int IDPatientStatus,
    string FirstName,
    string LastName,
    string ContactNum,
    DateTime Birthdate,
    string Longitude,
    string Latitude,
    string MedNotes)
        {
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.AddNewPatient", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@IDGender", SqlDbType.Int).Value = IDGender;
                    command.Parameters.Add("@IDPatientStatus", SqlDbType.Int).Value = IDPatientStatus;
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = LastName;
                    command.Parameters.Add("@ContactNum", SqlDbType.NVarChar, 25).Value = ContactNum;
                    command.Parameters.Add("@Birthdate", SqlDbType.DateTime).Value = Birthdate;
                    command.Parameters.Add("@Longitude", SqlDbType.NVarChar, 200).Value = Longitude;
                    command.Parameters.Add("@Latitude", SqlDbType.NVarChar, 200).Value = Latitude;
                    command.Parameters.Add("@MedNotes", SqlDbType.VarChar, 200).Value = MedNotes;
                    SQLconn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
        }
        public static int CountUnderInvestigation()
        {
            int count = 0;
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.CountUnderInvestigation", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return count;
        }
        public static int CountActiveSerious()
        {
            int count = 0;
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.CountActiveSerious", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return count;
        }
        public static int CountActiveMild()
        {
            int count = 0;
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.CountActiveMild", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return count;
        }
        public static int CountRecovered()
        {
            int count = 0;
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.CountRecovered", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return count;
        }
        public static int CountDeceased()
        {
            int count = 0;
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.CountDeceased", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return count;
        }
        public static List<PatientList> GetPatientListCoords(int CaseInt)
        {
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            string procString = "";
            switch (CaseInt)
            {
                case 0:
                    procString = "dbo.GetUnderInvestigation";
                    break;
                case 1:
                    procString = "dbo.GetActiveSerious";
                    break;
                case 2:
                    procString = "dbo.GetActiveMild";
                    break;
                case 3:
                    procString = "dbo.GetRecovered";
                    break;
                case 4:
                    procString = "dbo.GetDeceased";
                    break;
            }
            List<PatientList> PL = new List<PatientList>();
            using (SqlCommand command = new SqlCommand(procString, SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SQLconn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PatientList tempPL = new PatientList();
                        tempPL.PatientID = reader.GetInt32(0);
                        tempPL.Latitude = double.Parse(reader.GetString(1));
                        tempPL.Longitude = double.Parse(reader.GetString(2));
                        PL.Add(tempPL);
                    }
                }
                SQLConnection.CloseSQLConnect(SQLconn);
            }
            return PL;
        }
        public static void UpdatePatient(int IDPatient, int IDPatientStatus, string MedNotes)
        {
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.UpdatePatientStatus", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@IDPatient", SqlDbType.Int).Value = IDPatient;
                    command.Parameters.Add("@IDPatientStatus", SqlDbType.Int).Value = IDPatientStatus;
                    command.Parameters.Add("@MedNotes", SqlDbType.VarChar, 200).Value = MedNotes;
                    SQLconn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
        }
        public static void DeletePatient(int IDPatient)
        {
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.DeletePatient", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@IDPatient", SqlDbType.Int).Value = IDPatient;
                    SQLconn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
        }
        public class PatientList
        {
            public int PatientID;
            public double Latitude;
            public double Longitude;
        }
    }
}
