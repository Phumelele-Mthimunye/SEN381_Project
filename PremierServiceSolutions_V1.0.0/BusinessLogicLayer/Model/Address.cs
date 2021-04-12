using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Address
    {
        private string addressID;
        private int unitNo;
        private string state;
        private string code;
        private string city;
        private string street;

        public Address(string addressID, int unitNo, string street, string city, string state, string code)
        {
            this.addressID = addressID;
            this.unitNo = unitNo;
            this.state = state;
            this.code = code;
            this.city = city;
            this.street = street;
        }
        public string AddressID { get => addressID; set => addressID = value; }
        public int UnitNo { get => unitNo; set => unitNo = value; }
        public string State { get => state; set => state = value; }
        public string Code { get => code; set => code = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }

        internal Client contains
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   addressID == address.addressID &&
                   unitNo == address.unitNo &&
                   state == address.state &&
                   code == address.code &&
                   city == address.city &&
                   street == address.street;
        }

        public override int GetHashCode()
        {
            int hashCode = -1444019420;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(addressID);
            hashCode = hashCode * -1521134295 + unitNo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(state);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(city);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(street);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// this saves Address data to the database
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            ClientDataAccess dataAccess = new ClientDataAccess();
            return dataAccess.InsertAddress(addressID, Convert.ToString(unitNo), street, city, state, code);
        }
    }
}
