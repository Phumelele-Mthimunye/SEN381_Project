using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0
{
    class Problem
    {
        private Message message;
        private Equipment equipment;

        public Problem(Message message, Equipment equipment)
        {
            this.message = message;
            this.equipment = equipment;
        }

        internal Message Message { get => message; }
        internal Equipment Equipment { get => equipment;  }

        internal Equipment Consists
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Problem problem &&
                   EqualityComparer<Message>.Default.Equals(message, problem.message) &&
                   EqualityComparer<Equipment>.Default.Equals(equipment, problem.equipment);
        }

        public override int GetHashCode()
        {
            int hashCode = -35829381;
            hashCode = hashCode * -1521134295 + EqualityComparer<Message>.Default.GetHashCode(message);
            hashCode = hashCode * -1521134295 + EqualityComparer<Equipment>.Default.GetHashCode(equipment);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
