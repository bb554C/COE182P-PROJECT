using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COE182P_Project.Classes
{
    class UserAccountClass
    {
        public static string GetUserName(string Username)
        {
            string newUsername = "";
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.GetUserName", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@userName", SqlDbType.VarChar, 100).Value = Username;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            newUsername = reader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return newUsername;
        }
        public static string GetUserPassword(string Username)
        {
            string temp = "";
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.GetUserPassword", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@userName", SqlDbType.VarChar, 100).Value = Username;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp = reader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return temp;
        }
        public static int GetUserTypeID(string Username)
        {
            int temp = 0;
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.GetUserTypeID", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@userName", SqlDbType.VarChar, 100).Value = Username;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return temp;
        }

        public static bool GetUserAccountStatus(string Username)
        {
            bool temp = true;
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.GetAccountStatus", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@userName", SqlDbType.VarChar, 100).Value = Username;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp = reader.GetBoolean(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return temp;
        }

        public static void AddNewUser
    (int IDGender,
    int IDUserType,
    string UserName,
    string FirstName,
    string LastName,
    string ContactNum,
    string Password,
    string Address,
    bool StatusAccount)
        {
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.CreateAccount", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@IDGender", SqlDbType.Int).Value = IDGender;
                    command.Parameters.Add("@IDUserType", SqlDbType.Int).Value = IDUserType;
                    command.Parameters.Add("@UserName", SqlDbType.VarChar, 100).Value = UserName;
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = LastName;
                    command.Parameters.Add("@ContactNum", SqlDbType.NVarChar, 25).Value = ContactNum;
                    command.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = Password;
                    command.Parameters.Add("@Address", SqlDbType.VarChar, 100).Value = Address;
                    command.Parameters.Add("@StatusAccount", SqlDbType.Bit).Value = StatusAccount;
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
        public static User GetUserInfo(string Username)
        {
            User temp = new User();
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.GetUserInfo", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@userName", SqlDbType.VarChar, 100).Value = Username;
                    SQLconn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp.Username = reader.GetString(0);
                            temp.FirstName = reader.GetString(1);
                            temp.LastName = reader.GetString(2);
                            temp.ContactNumber = reader.GetString(3);
                            temp.GenderID = reader.GetInt32(4);
                            temp.UserTypeID = reader.GetInt32(5);
                            temp.Address = reader.GetString(6);
                            temp.AccountStatus = reader.GetBoolean(7);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to execute the command. Error: " + ex.ToString(), "SQL Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SQLConnection.CloseSQLConnect(SQLconn);
            return temp;
        }
        public static void UpdateUser
    (int IDGender,
    int IDUserType,
    string UserName,
    string FirstName,
    string LastName,
    string ContactNum,
    string Password,
    string Address,
    bool StatusAccount)
        {
            SqlConnection SQLconn = SQLConnection.SQLConnect();
            try
            {
                using (SqlCommand command = new SqlCommand("dbo.UpdateAccount", SQLconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@IDGender", SqlDbType.Int).Value = IDGender;
                    command.Parameters.Add("@IDUserType", SqlDbType.Int).Value = IDUserType;
                    command.Parameters.Add("@UserName", SqlDbType.VarChar, 100).Value = UserName;
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = LastName;
                    command.Parameters.Add("@ContactNum", SqlDbType.NVarChar, 25).Value = ContactNum;
                    command.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = Password;
                    command.Parameters.Add("@Address", SqlDbType.VarChar, 100).Value = Address;
                    command.Parameters.Add("@StatusAccount", SqlDbType.Bit).Value = StatusAccount;
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
    }
    public class User
    {
        public string Username;
        public string FirstName;
        public string LastName;
        public string ContactNumber;
        public int GenderID;
        public int UserTypeID;
        public string Address;
        public bool AccountStatus;
    }
}
