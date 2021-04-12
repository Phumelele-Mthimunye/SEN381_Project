using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ClientDataAccess
    {
        private SqlConnectionStringBuilder conString;

        public ClientDataAccess()
        {
            conString = new SqlConnectionStringBuilder();
            conString.DataSource = "(local)";
            conString.InitialCatalog = "PremierServiceSolutions";
            conString.IntegratedSecurity = true;
        }
        /// <summary>
        /// Inserts client data to the database
        /// </summary>
        /// <param name="data"> is an arrray of employee data</param>
        public bool InsertClient(params string[] data)
        {
            bool isAdded = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString.ConnectionString))
                {
                    string query = String.Format("INSERT INTO [dbo].[Client]([ClientID],[AddressID],[IDnumber],[LastName],[FirstName],[Email],[Tel]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", data[0], data[1], data[2], data[3], data[4], data[5], data[6]);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        isAdded = (cmd.ExecuteNonQuery() > 0) ? true : false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return isAdded;
        }
        /// <summary>
        /// Inserts client Login data to the database
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool InsertExternalUser(params string[] data)
        {
            bool isAdded = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString.ConnectionString))
                {
                    string query = String.Format("INSERT INTO [dbo].[ExternalUser]([Username],[ClientID],[Password]) VALUES('{0}','{1}','{2}')", data[0], data[1], data[2]);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        isAdded = (cmd.ExecuteNonQuery() > 0) ? true : false;
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return isAdded;

        }
        
        /// <summary>
        /// Inserts Client Address data into database
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool InsertAddress(params string[] data)
        {
            bool isAdded = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString.ConnectionString))
                {
                    string query = String.Format("INSERT INTO [dbo].[Address]([AddressID],[UnitNo],[Street],[City],[Province],[Code]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", data[0], data[1], data[2], data[3], data[4], data[5]);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        isAdded = (cmd.ExecuteNonQuery() > 0) ? true : false;
                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("failed");
            }
            return isAdded;
        }

        /// <summary>
        /// Reads client login data from database
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool ReadLoginClient(params string[] data)
        {
            bool exists = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString.ConnectionString))
                {
                    string query = String.Format("Select * FROM ExternalUser Where Username = '{0}' AND Password = '{1}'", data[0], data[1]);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        exists = reader.HasRows ? true : false;

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("failed");
            }
            return exists;
        }
    }
}
