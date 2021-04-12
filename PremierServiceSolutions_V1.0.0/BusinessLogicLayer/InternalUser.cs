using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    class InternalUser
    {
        private string empID;
        private string username;
        private string password;

        public InternalUser(string empID, string username, string password)
        {
            this.empID = empID;
            this.username = username;
            this.password = password;
        }
        public InternalUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public override bool Equals(object obj)
        {
            return obj is InternalUser user &&
                   empID == user.empID &&
                   username == user.username &&
                   password == user.password;
        }

        public override int GetHashCode()
        {
            int hashCode = 2081138649;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(empID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(password);
            return hashCode;
        }
        /// <summary>
        /// Saves Employee Login data to the database
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            EmployeeDataAccess dataAccess = new EmployeeDataAccess();
            return dataAccess.InsertInternalUser(empID, username, password);
        }
        /// <summary>
        /// Reads Employee Login data to the database
        /// </summary>
        /// <returns></returns>
        public bool Login()
        {
            EmployeeDataAccess dataAccess = new EmployeeDataAccess();
            return dataAccess.ReadLoginEmployee(username, password);
        }
    }
}
