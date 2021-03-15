using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0
{
    class Message:IComparable
    {
        private string timeStamp;
        private string owner;
        private string text;

        public Message(string timeStamp, string owner, string text)
        {
            this.timeStamp = timeStamp;
            this.owner = owner;
            this.text = text;
        }

        public string TimeStamp { get => timeStamp;  }
        public string Owner { get => owner;  }
        public string Text { get => text; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Message message &&
                   timeStamp == message.timeStamp &&
                   owner == message.owner &&
                   text == message.text;
        }

        public override int GetHashCode()
        {
            int hashCode = 274931045;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(timeStamp);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(owner);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(text);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
