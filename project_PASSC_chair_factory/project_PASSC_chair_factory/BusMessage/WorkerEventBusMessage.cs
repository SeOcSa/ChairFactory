using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class WorkerEventBusMessage
    {
        public WorkerEventBusMessage(String s)
        {
            message = s;

        }
        private String message;

        public String Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
