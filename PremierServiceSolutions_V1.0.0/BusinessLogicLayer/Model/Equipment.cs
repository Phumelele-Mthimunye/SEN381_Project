using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    enum EquipmentType { 
        Laptop,
        Printer,
        Router,
        Switch
    }
    class Equipment:IComparable
    {
        private string model;
        private string type;
        private string name;
        private string year;

        public Equipment(string model, string type, string name, string year)
        {
            this.model = model;
            this.type = type;
            this.name = name;
            this.year = year;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Equipment equipment &&
                   model == equipment.model &&
                   type == equipment.type &&
                   name == equipment.name &&
                   year == equipment.year;
        }

        public override int GetHashCode()
        {
            int hashCode = -1893571687;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(model);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(year);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
