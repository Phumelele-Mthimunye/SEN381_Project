using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions_V1._0._0
{
    class CallController
    {
        private bool isTracked;
        private Call call;

        public CallController(Call call)
        {
            this.call = call;
        }

        internal Call contains
        {
            get => default;
            set
            {
            }
        }

        private void trackingCall()
        { }
        public void startCall()
        { }
        public void endCall()
        { }
        private void submitServiceRequest()
        { }
        private void addToServiceRequest()
        { }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
