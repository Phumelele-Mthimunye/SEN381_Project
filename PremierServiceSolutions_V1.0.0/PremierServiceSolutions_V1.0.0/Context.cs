using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0
{
    class Context
    {
        Operation operations;

        public Context(Operation operations)
        {
            this.operations = operations;
        }

        internal Operation Contains
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Context context &&
                   EqualityComparer<Operation>.Default.Equals(operations, context.operations);
        }

        public override int GetHashCode()
        {
            return 509552007 + EqualityComparer<Operation>.Default.GetHashCode(operations);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        private void doOperation()
        {
            operations.doWork();
        }
    }
}
