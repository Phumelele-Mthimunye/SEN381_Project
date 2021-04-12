﻿using System;
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
        /// Inserts employee data to the database Thipe
        /// </summary>
        /// <param name="data"> is an arrray of employee data</param>
        public bool InsertEmployee(params string [] data)
        {
            bool isAdded = false;
            try
            {
                using (SqlConnection connection = new SqlConnection( conString.ConnectionString) )
                {
                    string query = String.Format("INSERT INTO [dbo].[Employee]([EmpID],[DepID],[IDnumber],[LastName],[FirstName],[Email],[Tel],[isAvailable]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
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
        /// Inserts Employee data into the database
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool InsertInternalUser(params string[] data)
        {
            bool isAdded = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString.ConnectionString))
                {
                    string query = String.Format("INSERT INTO [dbo].[InternalUser]([Username],[EmpID],[Password]) VALUES('{0}','{1}','{2}')", data[0], data[1], data[2]);
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
        /// Reads employee login data from database
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool ReadLoginEmployee(params string[] data)
        {
            bool exists = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString.ConnectionString))
                {
                    string query = String.Format("Select * FROM InternalUser Where Username = '{0}' AND Password = '{1}'", data[0], data[1]);
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
