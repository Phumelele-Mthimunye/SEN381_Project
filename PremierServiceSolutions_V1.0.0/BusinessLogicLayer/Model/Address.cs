using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    class Address
    {
        private string state;
        private string code;
        private string city;
        private string street;

        public Address(string state, string code, string city, string street)
        {
            this.state = state;
            this.code = code;
            this.city = city;
            this.street = street;
        }

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
                   state == address.state &&
                   code == address.code &&
                   city == address.city &&
                   street == address.street;
        }

        public override int GetHashCode()
        {
            int hashCode = 1363663050;
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
    }
}
