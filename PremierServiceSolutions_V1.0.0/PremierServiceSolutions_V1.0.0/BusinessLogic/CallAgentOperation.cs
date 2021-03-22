using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0.BusinessLogic
{
    class CallAgentOperation : Operation
    {
        internal Operation implements
        {
            get => default;
            set
            {
            }
        }

        public void doWork()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is CallAgentOperation operation &&
                   EqualityComparer<Operation>.Default.Equals(implements, operation.implements);
        }

        public override int GetHashCode()
        {
            return 2097922551 + EqualityComparer<Operation>.Default.GetHashCode(implements);
        }
    }
}
