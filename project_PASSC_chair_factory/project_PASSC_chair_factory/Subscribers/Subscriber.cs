using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class Subscriber
    {
        private Worker worker;
        public Subscriber(Worker _worker, PublishEvent pub)
        {
            worker = _worker;
            // Subscribe to the event
            pub.RaiseChairEvent += HandleCustomEvent;
        }

        // Define what actions to take when the event is raised.
        void HandleCustomEvent(object sender, ChairEventBusMessage e)
        {
            worker.operateBus(e.Message, e.Chair);
        }
    }
}
