using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace project_PASSC_chair_factory
{
    class WorkersSubscribe
    {
        private Worker worker;
        public WorkersSubscribe(Worker _worker, PublishEventWorker pub)
        {
            worker = _worker;
            // Subscribe to the event
            pub.RaiseWorkerEvent += HandlerWorkersEvent;
        }

        // Define what actions to take when the event is raised.
        void HandlerWorkersEvent(object sender, WorkerEventBusMessage e)
        {
            if (!e.Message.Contains(worker.workerName))
                Console.WriteLine(worker.workerName + " observed that " + e.Message);

        }
    }
}
