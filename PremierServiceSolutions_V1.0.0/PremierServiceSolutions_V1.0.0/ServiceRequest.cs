using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0
{
    class ServiceRequest
    {
        private string serviceRequestID;
        private List<Problem> issues;
        private List<Call> calls;
        private bool isClosed;
        private Employee technacian;

        public string ServiceRequestID { get => serviceRequestID; set => serviceRequestID = value; }
        public bool IsClosed { get => isClosed; set => isClosed = value; }
        internal List<Problem> Issues { get => issues; set => issues = value; }
        internal List<Call> Calls { get => calls; set => calls = value; }
        internal Employee Technacian { get => technacian; set => technacian = value; }

        internal Call consists
        {
            get => default;
            set
            {
            }
        }

        internal Problem Consists
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is ServiceRequest request &&
                   serviceRequestID == request.serviceRequestID &&
                   isClosed == request.isClosed &&
                   EqualityComparer<Employee>.Default.Equals(technacian, request.technacian);
        }

        public override int GetHashCode()
        {
            int hashCode = 2084139560;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(serviceRequestID);
            hashCode = hashCode * -1521134295 + isClosed.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Employee>.Default.GetHashCode(technacian);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
