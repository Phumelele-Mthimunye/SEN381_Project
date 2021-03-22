using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0.BusinessLogic
{
    class Employee : Person
    {
        private string empNo;
        private string postion;
        private string department;
        private Context operations;
        private bool isAvailable;

        public Employee(string firstName, string lastName, string email, string tel, string idNumber) : base(firstName, lastName, email, tel, idNumber)
        {
        }

        public string EmpNo { get => empNo; set => empNo = value; }
        public string Postion { get => postion; set => postion = value; }
        public string Department { get => department; set => department = value; }
        internal Context Operations { get => operations; set => operations = value; }

        internal Context Consist
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   FirstName == employee.FirstName &&
                   LastName == employee.LastName &&
                   IdNumber == employee.IdNumber &&
                   empNo == employee.empNo &&
                   postion == employee.postion;
        }

        public override int GetHashCode()
        {
            int hashCode = 1354008810;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IdNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(empNo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(postion);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
