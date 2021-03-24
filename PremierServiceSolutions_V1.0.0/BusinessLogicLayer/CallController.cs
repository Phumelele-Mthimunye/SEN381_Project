using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CallController
    {
        private bool isTracked;
        private Call call;
        /// <summary>
        /// returns current managed call object
        /// </summary>
        public Call Call { get => call; set => call = value; }

        public CallController(Call call)
        {
            this.call = call;
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
