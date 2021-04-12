using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class Employee : Person
    {
        private string empNo;
        private string postion;
        private string department;
        private Context operations;
        private bool isAvailable;

        public Employee()
        {
            FirstName = "T";
            LastName = "Employee";
            IdNumber = "EmployeeTest";
        }

        public Employee(string firstName, string lastName, string email, string tel, string idNumber) : base(firstName, lastName, email, tel, idNumber)
        {
        }

        public string EmpNo { get => empNo; set => empNo = value; }
        public string Postion { get => postion; set => postion = value; }
        public string Department { get => department; set => department = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
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
                   postion == employee.postion &&
                   isAvailable == employee.isAvailable;
        }


        public override string ToString()
        {
            return base.ToString();
        }
        

        public override int GetHashCode()
        {
            int hashCode = -447241237;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(empNo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(postion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(department);
            hashCode = hashCode * -1521134295 + EqualityComparer<Context>.Default.GetHashCode(operations);
            hashCode = hashCode * -1521134295 + isAvailable.GetHashCode();
            return hashCode;
        }
        EmployeeDataAccess dataAccess = new EmployeeDataAccess();
        /// <summary>
        /// Saves employee data to the database
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            return dataAccess.InsertEmployee(empNo, department, IdNumber, LastName, FirstName, Email, Tel, Convert.ToString(isAvailable));
        }
        
    }
}
