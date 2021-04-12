using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ExternalUser
    {
        private string clientID;
        private string username;
        private string password;

        public ExternalUser(string clientID, string username, string password)
        {
            this.clientID = clientID;
            this.username = username;
            this.password = password;
        }
        public ExternalUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public ExternalUser()
        {
        }
        public string ClientID { get => clientID; set => clientID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public override bool Equals(object obj)
        {
            return obj is ExternalUser user &&
                   clientID == user.clientID &&
                   username == user.username &&
                   password == user.password;
        }

        public override int GetHashCode()
        {
            int hashCode = -1912263412;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(password);
            return hashCode;
        }
        /// <summary>
        /// Saves Client Login Data into Database
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            ClientDataAccess dataAccess = new ClientDataAccess();
            return dataAccess.InsertExternalUser(username, clientID, password);
        }
        /// <summary>
        /// Reads Client login details from database
        /// </summary>
        /// <returns></returns>
        public bool Login()
        {
            ClientDataAccess dataAccess = new ClientDataAccess();
            return dataAccess.ReadLoginClient(username, password);
        }
    }
}
