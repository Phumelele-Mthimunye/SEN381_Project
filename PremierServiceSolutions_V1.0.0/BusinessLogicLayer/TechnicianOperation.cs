using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    class TechnicianOperation : Operation
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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
