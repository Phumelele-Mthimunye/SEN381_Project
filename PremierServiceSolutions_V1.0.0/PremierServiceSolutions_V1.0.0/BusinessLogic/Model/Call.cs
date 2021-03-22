using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0.BusinessLogic
{
    class Call
    {
        private Person caller;
        private Person reciever;
        private DateTime startedAt;
        private DateTime endedAt;
        private List<Message> messages;

        public Call(Person caller, Person reciever)
        {
            this.caller = caller;
            this.reciever = reciever;
        }

        public DateTime StartedAt { get => startedAt;}
        public DateTime EndedAt { get => endedAt; set => endedAt = value; }
        public List<Message> Messages { get => messages; set => messages = value; }
        internal Person Caller { get => caller;  }
        internal Person Reciever { get => reciever;}

        internal Person Consists
        {
            get => default;
            set
            {
            }
        }

        internal Message contains
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Call call &&
                   EqualityComparer<Person>.Default.Equals(caller, call.caller) &&
                   EqualityComparer<Person>.Default.Equals(reciever, call.reciever) &&
                   startedAt == call.startedAt &&
                   endedAt == call.endedAt &&
                   EqualityComparer<List<Message>>.Default.Equals(messages, call.messages);
        }

        public override int GetHashCode()
        {
            int hashCode = -1891505016;
            hashCode = hashCode * -1521134295 + EqualityComparer<Person>.Default.GetHashCode(caller);
            hashCode = hashCode * -1521134295 + EqualityComparer<Person>.Default.GetHashCode(reciever);
            hashCode = hashCode * -1521134295 + startedAt.GetHashCode();
            hashCode = hashCode * -1521134295 + endedAt.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Message>>.Default.GetHashCode(messages);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
