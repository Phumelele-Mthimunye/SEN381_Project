using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0.BusinessLogic
{
    abstract class ServiceContract
    {
        protected string contractID;
        protected string contractType;
        protected double price;
        protected DateTime startON;
        protected DateTime elabaseON;

        protected ServiceContract(string contractID, string contractType, DateTime startON, DateTime elabaseON)
        {
            this.contractID = contractID;
            this.contractType = contractType;
            this.startON = startON;
            this.elabaseON = elabaseON;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
