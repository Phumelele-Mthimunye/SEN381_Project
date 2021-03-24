using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeDataAccess
    {
        private SqlConnectionStringBuilder conString;

        public EmployeeDataAccess()
        {
            conString = new SqlConnectionStringBuilder();
            conString.DataSource = "(local)";
            conString.InitialCatalog = "PremierServiceSolutions";
            conString.IntegratedSecurity = true;
        }
        /// <summary>
        /// this method inserts employee  data to the database Thipe
        /// </summary>
        /// <param name="data"> is an arrray of employee data</param>
        public bool insertEmp(string [] data)
        {
            bool isAdded = false;
            try
            {
                using (SqlConnection connection = new SqlConnection( conString.ConnectionString) )
                {
                    string query = String.Format("INSERT INTO [dbo].[Employee]([EmpID],[DepID],[IDnumber],[LastName],[FirstName],[Email],[Tel]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", data[0], data[1], data[2], data[3], data[4], data[5], data[6]);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        isAdded = (cmd.ExecuteNonQuery() > 0) ? true : false;                   
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return isAdded;

        }


    }
}
