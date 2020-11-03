using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COE182P_Project.Classes
{
    class SQLConnection
    {
        public static SqlConnection SQLConnect()
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["OutbreakMonitor"]?.ConnectionString;
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL was not able to connect to the database. Error: " + ex.ToString(), "SQL Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
        public static void CloseSQLConnect(SqlConnection SQLconn)
        {
            if (SQLconn != null)
            {
                SQLconn.Close();
            }
        }
    }
}
