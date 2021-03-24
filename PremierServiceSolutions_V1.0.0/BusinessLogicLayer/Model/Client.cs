using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal ServiceContract Consist
        {
            get => default;
            set
            {
            }
        }

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
    }
}
