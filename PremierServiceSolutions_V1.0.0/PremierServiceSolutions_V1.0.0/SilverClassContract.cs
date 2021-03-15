using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0
{
    class SilverClassContract : ServiceContract
    {
        public SilverClassContract(string contractID, string contractType, DateTime startON, DateTime elabaseON) : base(contractID, contractType, startON, elabaseON)
        {
        }
    }
}
