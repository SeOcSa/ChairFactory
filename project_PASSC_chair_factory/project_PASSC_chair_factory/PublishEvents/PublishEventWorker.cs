using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PASSC_chair_factory
{
    class PublishEventWorker
    {
        public event EventHandler<WorkerEventBusMessage> RaiseWorkerEvent;
        public void publishWorker(Worker worker,Chair chair)
        {
            worker.operate(chair);
            OnRaiseCustomEvent(new WorkerEventBusMessage(worker.workerName + ": " + worker.eventMessage));
        }
        protected virtual void OnRaiseCustomEvent(WorkerEventBusMessage e)
        {
            EventHandler<WorkerEventBusMessage> handler = RaiseWorkerEvent;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
