using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private string email;
        private string tel;
        private string idNumber;

        protected string FirstName { get => firstName; set => firstName = value; }
        protected string LastName { get => lastName; set => lastName = value; }
        protected string Email { get => email; set => email = value; }
        protected string Tel { get => tel; set => tel = value; }
        public string IdNumber { get => idNumber; set => idNumber = value; }

        protected Person(string firstName, string lastName, string email, string tel, string idNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.tel = tel;
            this.idNumber = idNumber;
        }
    }
}
