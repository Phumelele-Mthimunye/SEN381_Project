using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Client: Person
    {
        private string clientNo;
        private string address;
        private List<ServiceContract> serviceContracts;

        public Client(string firstName, string lastName, string email, string tel, string idNumber) : base(firstName, lastName, email, tel, idNumber)
        {
        }
        public Client()
        {
            FirstName = "T";
            LastName = "Cleint ";
            IdNumber = "ClientTest";

        }

        public Client(string clientNo, string address)
        {
            this.clientNo = clientNo;
            this.address = address;
        }

        internal ServiceContract Consist
        {
            get => default;
            set
            {
            }
        }

        public string ClientNo { get => clientNo; set => clientNo = value; }
        public string Address { get => address; set => address = value; }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   FirstName == client.FirstName &&
                   LastName == client.LastName &&
                   IdNumber == client.IdNumber;
        }

        public override int GetHashCode()
        {
            int hashCode = -2111806963;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IdNumber);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// this saves Client data to the database
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            ClientDataAccess dataAccess = new ClientDataAccess();
            return dataAccess.InsertClient(clientNo, address, IdNumber, LastName, FirstName, Email, Tel);
        }
    }
}
