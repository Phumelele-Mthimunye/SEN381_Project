using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    class ServiceController
    {
        private List<ServiceRequest> serviceRequests;
        private List<Employee> technacians;

        internal ServiceRequest consists
        {
            get => default;
            set
            {
            }
        }

        internal CallController communicates
        {
            get => default;
            set
            {
            }
        }

        public void closeRequest()
        { }
        public void reAssignRequest()
        { }
        public void escalateRequest()
        { }
        public void assignRequest()
        { 
        }
        
    }
}
