using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierServiceSolutions_V1._0._0.DataLayer;

namespace PremierServiceSolutions_V1._0._0.BusinessLogic
{
    class Demo
    {
        public string getData()
        {
            DemoDataHandler handler = new DemoDataHandler();
            //business logic 
            return handler.getData();
        }
    }
}
